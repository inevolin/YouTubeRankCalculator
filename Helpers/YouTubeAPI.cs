using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YTR.Objects;

namespace YTR
{
    public static class YouTubeAPI
    {
        private static readonly string API_URL = "https://www.googleapis.com/youtube/v3/";
        private static readonly string API_KEY = "?key=AIzaSyCHvqng2rLoA8-Ne8W_e287luh-bsnaggs";

        public static SingleVideo.RootObject VideoDetails(Http http, string id)
        {
            string url =
                        API_URL + "videos" +
                        API_KEY +
                        "&part=snippet,contentDetails,statistics,status" +
                        "&id=" + id;

            string RS = http.GET(url, "", new CookieContainer(), null, null, Http.HttpAccept.ACCEPT_JSON);

            if (RS == "[[[ERROR]]]")
                return null;

            SingleVideo.RootObject rb = JsonConvert.DeserializeObject<SingleVideo.RootObject>(RS);
            return rb;
        }

        public static SingleChannel.RootObject ChannelDetails(Http http, string id)
        {
            string url =
                        API_URL + "channels" +
                        API_KEY +
                        "&part=statistics,contentDetails" +
                        "&id=" + id;

            string RS = http.GET(url, "", new CookieContainer(), null, null, Http.HttpAccept.ACCEPT_JSON);

            if (RS == "[[[ERROR]]]")
                return null;

            SingleChannel.RootObject rb = JsonConvert.DeserializeObject<SingleChannel.RootObject>(RS);
            return rb;
        }


        public static SearchVideos.RootObject SearchVideos(Http http, string q, int amountPages)
        {
            string url =
                       API_URL + "search" +
                       API_KEY +
                       "&part=snippet" +
                       "&type=video" +
                       "&q=" + q +
                       "&maxResults=" + (amountPages * 10);

            string RS = http.GET(url, "", new CookieContainer(), null, null, Http.HttpAccept.ACCEPT_ALL);

            if (RS == "[[[ERROR]]]")
                return null;

            SearchVideos.RootObject rb = JsonConvert.DeserializeObject<SearchVideos.RootObject>(RS);
            return rb;
        }


        public static VideoComments.RootObject VideoComments(Http http, string id)
        {
            string url =
                        API_URL + "commentThreads" +
                        API_KEY +
                        "&part=snippet" +
                        "&videoId=" + id;

            string RS = http.GET(url, "", new CookieContainer(), null, null, Http.HttpAccept.ACCEPT_JSON);

            if (RS == "[[[ERROR]]]")
                return null;

            VideoComments.RootObject rb = JsonConvert.DeserializeObject<VideoComments.RootObject>(RS);
            return rb;
        }
    }
}
