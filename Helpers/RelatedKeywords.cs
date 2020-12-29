using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace YTR.Helpers
{
    public class RelatedKeywords
    {
        private Http http;
        private IList<string> found;

        public RelatedKeywords(Http http)
        {
            this.http = http;
            found = new List<string>();
        }

        public IList<string> Search(string keyword, int level = 1)
        {
            string url = "http://clients1.google.com/complete/search?hl=en-usa&client=hp&q=" + HttpUtility.UrlEncode(keyword);
            //TODO pick proxy from http object
            var RS = http.GET(url, "", new System.Net.CookieContainer(), null, null, Http.HttpAccept.ACCEPT_ALL);
            Parse(RS, keyword);

            if (level == 2)
                ProcessMultiLevels(keyword);

            return found;
        }
        private void ProcessMultiLevels(string keyword)
        {
            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            foreach (var c1 in az)
            {
                Search(keyword + " " + c1);
            }
        }

        private void Parse(string S, string keyword)
        {
            string[] filter = { "\\u003csc\\u003e",
                                "\\u003cb\\u003e",
                                "\\u003c\\/sc\\u003e",
                                "\\u003c\\/b\\u003e",
                                "\\u003cse\\u003e",
                                "\\u003cse\\u003e",
                                "\\u003c\\/se\\u003e"
                              };

            foreach (string s in filter)
                S = S.Replace(s, "");

            string pattern = "\\[\"(.+?)\"";
            foreach (Match m in Regex.Matches(S, pattern))
            {
                var s = m.Groups[1].Value.ToString();
                if (!found.Contains(s) && !s.Equals(keyword))
                    found.Add(s);
            }


        }
    }
}
