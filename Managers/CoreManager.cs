using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using YTR.Helpers;
using YTR.Objects;

namespace YTR.Managers
{
    public class CoreManager
    {
        public IDifficulty Difficulty { get; set; }
        public int maxThreads { get; set; }
        private IList<Http> http;
        private bool TRIAL;

        public CoreManager(bool trial)
        {
            this.TRIAL = trial;
            http = new List<Http>();
            Difficulty = new Medium();
        }

        //extra relatedKeywords
        public KeywordFullSearch FullSearch(string keyword)
        {
            abort = false;
            var qs = QuickSearch(keyword);
            if (qs == null)
                return null;

            var o = new KeywordFullSearch();
            o.Details = qs.Details;

            if (!TRIAL)
            {
                var rk = new RelatedKeywords(http[0]);
                o.RelatedKeywords = rk.Search(keyword, 2);
            }
            else
                o.RelatedKeywords = null;

            return (KeywordFullSearch)o;
        }

        public KeywordQuickSearch QuickSearch(string keyword)
        {
            abort = false;
            http.Clear();
            return InternalQuickSearch(keyword);
        }
        private KeywordQuickSearch InternalQuickSearch(string keyword)
        {
            var _http = new Http();
            http.Add(_http);

            var r = YouTubeAPI.SearchVideos(_http, keyword, 1);
            if (r == null)
                return null;

            var o = new KeywordQuickSearch();
            if (r.items.Count > 0)
            {

                o.Details.Keyword = keyword;
                foreach (var item in r.items)
                {
                    var q = YouTubeAPI.VideoDetails(_http, item.id.videoId);
                    var c = YouTubeAPI.VideoComments(_http, item.id.videoId);
                    var h = YouTubeAPI.ChannelDetails(_http, item.snippet.channelId);
                    var i = FillVideoDetails(q, c, h);
                    if (i != null)
                        o.Details.Videos.Add(i);
                }
                FillKeywordDetails(ref o, r);
            }
            else {
                o.Details.Keyword = keyword;
            }

            return o;
        }
        public void QuickSearch(IList<string> keywords, ref BackgroundWorker bgWorker)
        {
            http.Clear();
            /* int i = 0;
             foreach (var s in keywords)
             {
                 var f = QuickSearch(s);
                 int p = (int)(100 * ((double)(++i) / (double)keywords.Count));
                 bgWorker.ReportProgress(p, f);
             }*/
            System.Net.ServicePointManager.DefaultConnectionLimit = int.MaxValue;
            abort = false;
            int t = 0, i = 0;
            List<Thread> workerThreads = new List<Thread>();
            List<KeywordQuickSearch> results = new List<KeywordQuickSearch>();

            foreach (string s in keywords)
            {
                while (t >= maxThreads && !abort)
                    Thread.Sleep(200);
                ++t;
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        Thread.Sleep(new Random().Next(50, 150));
                        var f = InternalQuickSearch(s);
                        if (f != null)
                            lock (results)
                                results.Add(f);
                    }
                    catch { }
                    finally
                    {
                        try
                        {
                            --t;
                            var ft = workerThreads.First(x => x.ManagedThreadId == Thread.CurrentThread.ManagedThreadId);
                            workerThreads.Remove(ft);
                        }
                        catch { }
                    }
                });
                workerThreads.Add(thread);
                if (abort)
                    return;
                else
                    thread.Start();

                lock (results)
                    while (results.Count > 0)
                    {
                        var f = results[0];
                        int p = (int)(100 * ((double)(++i) / (double)keywords.Count));
                        bgWorker.ReportProgress(p, f);
                        results.RemoveAt(0);
                    }
            }

            while (workerThreads.Count > 0)
                Thread.Sleep(200);
            lock (results)
                while (results.Count > 0)
                {
                    var f = results[0];
                    int p = (int)(100 * ((double)(++i) / (double)keywords.Count));
                    bgWorker.ReportProgress(p, f);
                    results.RemoveAt(0);
                }

            foreach (Thread thread in workerThreads)
                if (abort)
                    return;
                else
                    thread.Join();

        }
        private void FillKeywordDetails(ref KeywordQuickSearch C, SearchVideos.RootObject R)
        {
            C.Details.AvgViewCount = (int)C.Details.Videos.Average(x => x.ViewCount);
            C.Details.HighestViewCount = C.Details.Videos.Max(x => x.ViewCount);
            C.Details.LowestViewCount = C.Details.Videos.Min(x => x.ViewCount);

            int old = C.Details.Videos.Where(x => DateTime.Now.Year - x.UploadedDate.Year == 1).Count();
            C.Details.OldVideos = old;
            C.Details.NewVideos = C.Details.Videos.Count - old;

            DefaultAlgorithm algo = new DefaultAlgorithm();
            C.Details.Overall = algo.Calculate(C, Difficulty);
            C.Details.Results = R.pageInfo.totalResults;

        }
        private VideoDetails FillVideoDetails(SingleVideo.RootObject core, VideoComments.RootObject comments, SingleChannel.RootObject channel)
        {
            if (core == null || core.items.Count <= 0)
                return null;
            var C = core.items[0];

            var v = new VideoDetails();
            v.CommentCount = C.statistics.commentCount;
            v.Description = C.snippet.description;

            if (comments != null && comments.items.Count > 0)
                v.LastCommentDate =
                        DateTime.Parse(comments.items[0].snippet.topLevelComment.snippet.publishedAt);


            v.Likes = C.statistics.likeCount;
            v.Dislikes = C.statistics.dislikeCount;

            v.Title = C.snippet.title;
            v.UploadedDate = DateTime.Parse(C.snippet.publishedAt);
            v.VideoDuration = System.Xml.XmlConvert.ToTimeSpan(C.contentDetails.duration);
            v.VideoURL = "https://youtube.com/watch?v=" + C.id;
            v.ViewCount = C.statistics.viewCount;
            v.Subscribers = channel.items.Count > 0 ? int.Parse(channel.items[0].statistics.subscriberCount) : 0;

            v.ChannelURL = "https://www.youtube.com/channel/" + C.snippet.channelId + "/";
            v.NumLinks = Regex.Matches(v.Description, "http").Count;
            return v;
        }

        private bool abort;
        public void Abort()
        {
            abort = true;
            if (http != null && http.Count > 0)
                foreach (var h in http)
                    if (h != null)
                        h.Abort();
        }

    }
}
