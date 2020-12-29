using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTR.Objects
{
    public class VideoComments
    {
        public class PageInfo
        {
            public int resultsPerPage { get; set; }
        }

        public class AuthorChannelId
        {
            public string value { get; set; }
        }

        public class Snippet2
        {
            public string channelId { get; set; }
            public string videoId { get; set; }
            public string textDisplay { get; set; }
            public string authorDisplayName { get; set; }
            public string authorProfileImageUrl { get; set; }
            public string authorChannelUrl { get; set; }
            public AuthorChannelId authorChannelId { get; set; }
            public string authorGoogleplusProfileUrl { get; set; }
            public bool canRate { get; set; }
            public string viewerRating { get; set; }
            public int likeCount { get; set; }
            public string publishedAt { get; set; }
            public string updatedAt { get; set; }
        }

        public class TopLevelComment
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public Snippet2 snippet { get; set; }
        }

        public class Snippet
        {
            public string channelId { get; set; }
            public string videoId { get; set; }
            public TopLevelComment topLevelComment { get; set; }
            public bool canReply { get; set; }
            public int totalReplyCount { get; set; }
            public bool isPublic { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public Snippet snippet { get; set; }
        }

        public class RootObject
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string nextPageToken { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
