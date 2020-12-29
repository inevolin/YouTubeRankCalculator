using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace YTR
{
    public class Http
    {
        //public class AbortException : Exception { }
        public enum HttpAccept
        {
            [Description("application/json, text/javascript, */*; q=0.01")]
            ACCEPT_JSON,

            [Description("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8")]
            ACCEPT_HTML,

            [Description("*/*")]
            ACCEPT_ALL
        }

        private readonly string USERAGENT = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:38.0) Gecko/20100101 Firefox/38.0";

        HttpWebRequest req;
        public void Abort()
        {
            if (req != null)
                req.Abort();
            req = null;
        }

        public string POST(string url, string referer, string contentType, List<byte[]> data, List<string> headers, CookieContainer c, WebProxy proxy, HttpAccept accept, int timeOut = 100000)
        {
            try
            {
                req = (HttpWebRequest)WebRequest.Create(url);

                if (proxy != null)
                {
                    req.Proxy = proxy;
                    req.PreAuthenticate = true;
                    req.Timeout = timeOut;
                }

                //req.Timeout = 15000;
                req.ContentType = contentType;//"multipart/form-data; boundary=" + boundary;
                req.Method = "POST";
                req.KeepAlive = true;
                req.Referer = referer;
                req.AllowAutoRedirect = true;
                req.UserAgent = USERAGENT;
                req.Accept = accept.ToString();
                if (headers != null)
                {
                    foreach (string s in headers)
                    {
                        req.Headers.Add(s);
                    }
                }
                req.CookieContainer = c == null ? new CookieContainer() : c;
                req.ServicePoint.Expect100Continue = false;
                ServicePointManager.Expect100Continue = false;
                req.AutomaticDecompression = DecompressionMethods.GZip;

                Stream stream = req.GetRequestStream();
                foreach (byte[] b in data)
                {
                    stream.Write(b, 0, b.Length);
                }
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string RS = reader.ReadToEnd();

                reader.Close();
                req.Abort();
                stream.Close();

                return RS;
            }
            catch (Exception ex)
            {
                if (req == null)
                    throw ex;
                return "[[[ERROR]]]";
            }
        }
        public string GET(string url, string referer, CookieContainer c, List<string> headers, WebProxy proxy, HttpAccept accept, int timeOut = 60000)
        {
            try
            {
                req = (HttpWebRequest)WebRequest.Create(url);

                if (proxy != null)
                {
                    req.Proxy = proxy;
                    req.PreAuthenticate = true;
                    req.Timeout = timeOut;
                }

                req.Timeout = 10000;
                req.CookieContainer = c == null ? new CookieContainer() : c;
                req.Referer = referer;
                req.Accept = accept.ToString();
                req.UserAgent = USERAGENT;
                if (headers != null)
                {
                    foreach (string s in headers)
                        req.Headers.Add(s);
                }
                req.AllowAutoRedirect = true;
                req.KeepAlive = true;
                req.AutomaticDecompression = DecompressionMethods.GZip;
                ServicePointManager.Expect100Continue = false;
                req.ServicePoint.Expect100Continue = false;

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();

                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string RS = reader.ReadToEnd();
                response.Close();
                req.Abort();
                stream.Close();
                return RS;
            }
            catch (Exception ex)
            {
                if (req == null)
                    throw ex;
                return "[[[ERROR]]]";
            }
        }

        public bool TestProxy(WebProxy proxy)
        {
            string rs = GET("https://www.google.com", "", new CookieContainer(), null, proxy, HttpAccept.ACCEPT_HTML, 15000);

            if (rs == null || !rs.Contains("Google Inc"))
                return false;

            return true;
        }

        public static string getBoundary()
        {
            return "----------------------------" + System.DateTime.Now.Ticks.ToString("x");
        }
        public static void DownloadFile(string url, string file)
        {
            using (WebClient wc = new WebClient())
                wc.DownloadFile(url, file);
        }
        public static string DownloadFile(string url)
        {
            string ext = Path.GetExtension(url);
            string file = Path.GetTempFileName() + ext;
            string fullpath = Path.Combine(Path.GetTempPath(), file);
            DownloadFile(url, file);
            return fullpath;
        }

        public static string HttpEncode(string s)
        { return HttpUtility.UrlEncode(s); }

        public static bool ValidUrl(string u)
        {
            if (u == null || u.Length <= 1) return false;
            string p = @"(http://|https://)(www\.)?([a-zA-Z0-9\-]+?)(\.)([a-zA-Z]+?){1,6}(([a-z0-9A-Z\?\&\%\=_\-\./])+?)$";
            return Regex.IsMatch(u, p);
        }
        public static bool ValidProxy(string u)
        {
            if (u == null || u.Length <= 1) return false;
            string p = @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}):(\d{2,5})";
            return Regex.IsMatch(u, p);
        }

    }
}
