using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace YTR.Forms
{
    public partial class ProxyGUI : Form
    {
        public ProxyGUI()
        {
            InitializeComponent();

           // txtProxies.Text = string.Join(Environment.NewLine, proxies.ToArray());
        }

        private void btnClearProxies_Click(object sender, EventArgs e)
        {
            proxies = new List<string>();
            txtProxies.Text = "";
            //save to xml
        }

        List<string> proxies = new List<string>();
        private void btnTestProxies_Click(object sender, EventArgs e)
        {

        }



        private void btnSaveProxies_Click(object sender, EventArgs e)
        {
            proxies = new List<string>();

            string[] lines = txtProxies.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line.Contains(":"))
                {
                    proxies.Add(line);
                }
            }


        }

        

        private void chkProxies_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProxies.Checked)
            {
                txtProxies.Enabled = true;
                btnTestProxies.Enabled = true;
                btnSaveProxies.Enabled = true;
                btnClearProxies.Enabled = true;
                txtTimeoutProxies.Enabled = true;
            }
            else
            {
                btnTestProxies.Enabled = false;
                btnSaveProxies.Enabled = false;
                btnClearProxies.Enabled = false;
                txtTimeoutProxies.Enabled = false;
                txtProxies.Enabled = false;
            }
        }

        WebProxy getProxy(object sender = null)
        {
            if (sender.GetType() == typeof(BackgroundWorker) && ((BackgroundWorker)sender).CancellationPending == true) return null;
            WebProxy PROXY = new WebProxy();
            if (chkProxies.Checked)
            {
                try
                {
                    Random r = new Random();

                    string ip = null, port = null, user = null, pass = null;
                    string pr = proxies[r.Next(0, proxies.Count)];

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
                    if (sender.GetType() == typeof(BackgroundWorker) && ((BackgroundWorker)sender).CancellationPending == true) return null;

                }
                catch { }
            }

            return PROXY;
        }
    }
}
