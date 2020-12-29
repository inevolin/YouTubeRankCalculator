using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTR.Objects
{
    public class KeywordFullSearch
    {
        public KeywordFullSearch()
        {
            Details = new AbstractKeyword();
            RelatedKeywords = new List<string>();
        }
        public AbstractKeyword Details { get; set; }
        public IList<string> RelatedKeywords { get; set; }
    }

    public class KeywordQuickSearch
    {
        public KeywordQuickSearch()
        {
            Details = new AbstractKeyword();
        }
        public AbstractKeyword Details { get; set; }
    }

    public class AbstractKeyword
    {
        public AbstractKeyword()
        {
            Videos = new List<VideoDetails>();
        }
        public IList<VideoDetails> Videos { get; set; }
        public string Keyword { get; set; }
        public int Results { get; set; }
        public int AvgViewCount { get; set; }
        public int NewVideos { get; set; }
        public int OldVideos { get; set; }
        public int LowestViewCount { get; set; }
        public int HighestViewCount { get; set; }
        public string Overall { get; set; }
    }

    public class VideoDetails
    {
        public string Title { get; set; }
        public int ViewCount { get; set; }
        public int Subscribers { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime LastCommentDate { get; set; }
        public int CommentCount { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string VideoURL { get; set; }
        public TimeSpan VideoDuration { get; set; }
        public string Description { get; set; }
        public int NumLinks { get; set; }
        public string ChannelURL { get; set; }
    }
}
