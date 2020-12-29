using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTR.Objects
{
    public class SingleVideo
    {
        public class PageInfo
        {
            public int totalResults { get; set; }
            public int resultsPerPage { get; set; }
        }

        public class Default
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Medium
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class High
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Thumbnails
        {
            public Default @default { get; set; }
            public Medium medium { get; set; }
            public High high { get; set; }
        }

        public class Localized
        {
            public string title { get; set; }
            public string description { get; set; }
        }

        public class Snippet
        {
            public string publishedAt { get; set; } // 3
            public string channelId { get; set; }
            public string title { get; set; } // 1
            public string description { get; set; }
            public Thumbnails thumbnails { get; set; }
            public string channelTitle { get; set; }
            public string categoryId { get; set; }
            public string liveBroadcastContent { get; set; }
            public Localized localized { get; set; }
        }

        public class ContentDetails
        {
            public string duration { get; set; } // duration
            public string dimension { get; set; }
            public string definition { get; set; }
            public string caption { get; set; }
            public bool licensedContent { get; set; }
        }

        public class Status
        {
            public string uploadStatus { get; set; }
            public string privacyStatus { get; set; }
            public string license { get; set; }
            public bool embeddable { get; set; }
            public bool publicStatsViewable { get; set; }
        }

        public class Statistics
        {
            public int viewCount { get; set; } // 2
            public int likeCount { get; set; } // 7.1
            public int dislikeCount { get; set; } // 7.2
            public int favoriteCount { get; set; }
            public int commentCount { get; set; } // 6
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; } // 8 part of URL
            public Snippet snippet { get; set; }
            public ContentDetails contentDetails { get; set; }
            public Status status { get; set; }
            public Statistics statistics { get; set; }
        }

        public class RootObject
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
