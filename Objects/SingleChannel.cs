using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTR.Objects
{
    public class SingleChannel
    {
        public class PageInfo
        {
            public int totalResults { get; set; }
            public int resultsPerPage { get; set; }
        }

        public class RelatedPlaylists
        {
            public string likes { get; set; }
            public string uploads { get; set; }
        }

        public class ContentDetails
        {
            public RelatedPlaylists relatedPlaylists { get; set; }
            public string googlePlusUserId { get; set; }
        }

        public class Statistics
        {
            public string viewCount { get; set; }
            public string commentCount { get; set; }
            public string subscriberCount { get; set; }
            public bool hiddenSubscriberCount { get; set; }
            public string videoCount { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public ContentDetails contentDetails { get; set; }
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
