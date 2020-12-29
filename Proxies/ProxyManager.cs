using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YTR.Proxies
{
    class ProxyManager
    {
        int runningProxyThreads;
        List<string> good = new List<string>();
        List<string> proxies = new List<string>();

        public ProxyManager(List<string> proxies)
        {
            this.proxies = proxies;
        }

        void testingProxies(object sender, DoWorkEventArgs e)
        {
            proxies = new List<string>();
            good = new List<string>();
            runningProxyThreads = 0;
  
            if (proxies.Count > 0)
            {


                for (int i = 0; i <= proxies.Count - 1; i++)
                {
                    //+= testProxies;

                    runningProxyThreads++;

                   /* lblProxies.Invoke((MethodInvoker)delegate
                    {
                        //lblProxies.Text = i.ToString() + "/" + proxies.Count.ToString();
                        lblProxies.Text = good.Count.ToString() + "/" + proxies.Count.ToString() + "  please wait...";
                    });*/

                   /* while (runningProxyThreads >= threads)
                    { Thread.Sleep(1000); }*/
                }

                while (runningProxyThreads > 0)
                {
                    /*lblProxies.Invoke((MethodInvoker)delegate
                    {
                        lblProxies.Text = good.Count.ToString() + "/" + proxies.Count.ToString() + "  please wait...";
                    });
                    Thread.Sleep(1000);*/
                }

                if (good.Count <= 0)
                {
                    /*lblProxies.Invoke((MethodInvoker)delegate
                    {
                        lblProxies.Text = "No good proxies";
                    });*/
                }
                else
                {
                    //MessageBox.Show((proxies.Count - good.Count) + " : bad proxies removed");
                }
                proxies = good;


               /* txtProxies.Invoke((MethodInvoker)delegate
                {
                    writeCnf();
                    txtProxies.Text = string.Join(Environment.NewLine, proxies.ToArray());
                });*/

                /*tabYTR.Invoke((MethodInvoker)delegate
                {
                    //tabControl1.Enabled = true;
                    lblProxies.Text = "Done: " + good.Count + " working proxies";
                });*/

            }
            else
            {
              //no proxies err
            }

        }
        void testProxies(object sender, DoWorkEventArgs e)
        {
            try
            {

                int i = (int)e.Argument;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://m.youtube.com/");
                //request.Proxy = getProxy(sender);
                HttpWebResponse response = null;
                try
                {

                    //request.UserAgent = UserAgent;

                    WebProxy PROXY = new WebProxy();
                    string ip = null, port = null, user = null, pass = null;
                    string pr = proxies[i];

                    ip = pr.Substring(0, pr.IndexOf(":"));
                    pr = pr.Substring(pr.IndexOf(":") + 1, pr.Length - pr.IndexOf(":") - 1);
                    if (pr.Contains(":"))
                    {
                        port = pr.Substring(0, pr.IndexOf(":"));
                        pr = pr.Substring(pr.IndexOf(":") + 1, pr.Length - pr.IndexOf(":") - 1);
                        user = pr.Substring(0, pr.IndexOf(":"));
                        pr = pr.Substring(pr.IndexOf(":") + 1, pr.Length - pr.IndexOf(":") - 1);
                        pass = pr.Substring(0, pr.Length);
                    }
                    else
                    {
                        port = pr.Substring(0, pr.Length);
                    }

                    PROXY.Address = new Uri("http://" + ip + ":" + port);
                    if (user != null & pass != null)
                    {
                        NetworkCredential nc = new NetworkCredential(user, pass);
                        PROXY.Credentials = nc;
                    }
                    request.Proxy = PROXY;
                    //request.Timeout = proxyTimeout * 1000;
                    response = (HttpWebResponse)request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    StreamReader streamRead = new StreamReader(stream);
                    string RS = streamRead.ReadToEnd();


                    if (RS.Contains("<title>YouTube</title>"))
                    {
                        good.Add(proxies[i]);
                    }
                }
                catch
                { }
                finally
                {
                    request.Abort();
                }


            }
            catch { }
            finally { runningProxyThreads--; }

        }

    }
}
