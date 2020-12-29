using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Web;
using YTR.Helpers;
using System.Threading.Tasks;

namespace YTR
{
    public partial class loading : Form
    {
        bool DEBUG = false;

        //bool needsVerification = true; 
        bool validation = false;
        bool trial = false;

        public loading()
        {
            InitializeComponent();


        }
        private void loading_Load(object sender, EventArgs e)
        {
            pLicense.Invoke((MethodInvoker)delegate
            {
                pLicense.Visible = false;
            });
            bgw = new BackgroundWorker();
            bgw.DoWork += load;
            bgw.RunWorkerAsync();
        }
        void load(object sender, DoWorkEventArgs e)
        {
            if (DEBUG)
            {
                Thread sf = new Thread(new ThreadStart(showForm));
                sf.Start();
                return;
            }
            
            if (validation)
            {
                lblLoading.Invoke((MethodInvoker)delegate
                { lblLoading.Text = "Starting..."; });
                Thread.Sleep(200);

                Thread sf = new Thread(new ThreadStart(showForm));
                sf.Start();
                return;
            }
            

            additionalFiles();
            continueLoading();
            validation = LoadCheckLicense();

            if (validation)
            {
                lblLoading.Invoke((MethodInvoker)delegate
                { lblLoading.Text = "Starting..."; });
                Thread.Sleep(200);

                Thread sf = new Thread(new ThreadStart(showForm));
                sf.Start();
            }

        }
        private bool LoadCheckLicense()
        {
            bool IsValid = false;
            Licensing.LicenseResponse resp = new Licensing.LicenseResponse();
            try
            {
                MyPropertyManager.OnLoad(); //call only once !!!

                string LocalTID = (string)MyPropertyManager.GetProperty("TID");
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("YTRLicense", true);
                    if (key == null)
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("YTRLicense");
                    else
                        LocalTID = key.GetValue("tid") == null ? "" : key.GetValue("tid").ToString();
                    key.Close();
                }
                catch { }

                if (LocalTID.Length > 0)
                {

                    Task.Factory.StartNew(() => { Thread.Sleep(100); });
                    SetMessage("Checking license...", Color.Black); ;
                    Http request = new Http();
                    resp = Licensing.CheckLicense(request, LocalTID);
                }
                else
                {
                    pLicense.Invoke((MethodInvoker)delegate { pLicense.Visible = true; });
                    SetMessage("Enter your License ID " + Environment.NewLine + "and Click 'Verify'", Color.Black);

                }

                IsValid = resp.IsValid;
                if (!IsValid)
                {
                    SetMessage(resp.Message, resp.color);
                    pLicense.Invoke((MethodInvoker)delegate { pLicense.Visible = true; });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error SF100. Please contact support ytr@healzer.com.");
                return false;
            }
            return IsValid;
        }
        void continueLoading()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://healzer.com/YTR/REG/updater.txt");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamRead = new StreamReader(stream);
            string RS = streamRead.ReadToEnd();

            if (RS.Contains("false"))
            {
                SetMessage("Please try again later.", Color.Red);
                MessageBox.Show("Performing security updates, try again later");
                close();
            }

            string FV;

            if (File.Exists(@".\updater.exe"))
            {
                FV = FileVersionInfo.GetVersionInfo(@".\updater.exe").FileVersion;
                RS = RS.Replace(".", "");
                FV = FV.Replace(".", "");

                if (int.Parse(RS) > int.Parse(FV))
                {
                    SetMessage("Updating. Please wait...", Color.Black);
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName("updater"))
                        {
                            proc.Kill();
                        }
                    }
                    catch { }

                    try
                    {
                        WebClient dl = new WebClient();
                        dl.DownloadFile("http://healzer.com/YTR/REG/updater.exe", @".\new_updater.exe");

                        File.Delete(@".\updater.exe");
                        File.Copy(@".\new_updater.exe", @".\updater.exe", true);
                        File.Delete(@".\new_updater.exe");
                    }
                    catch { }
                }

            }
            else
            {
                try
                {
                    SetMessage("Updating. Please wait...", Color.Red);

                    WebClient dl = new WebClient();
                    dl.DownloadFile("http://healzer.com/YTR/REG/updater.exe", @".\updater.exe");
                }
                catch { }
            }


            request = (HttpWebRequest)WebRequest.Create("http://healzer.com/YTR/REG/YTR.txt");
            response = (HttpWebResponse)request.GetResponse();
            stream = response.GetResponseStream();
            streamRead = new StreamReader(stream);
            RS = streamRead.ReadToEnd();

            if (RS.Contains("false"))
            {
                SetMessage("Please try again later.", Color.Red);
                MessageBox.Show("Performing security updates, try again later");
                close();
            }

            Console.WriteLine(Application.ProductVersion.ToString());
            FV = FileVersionInfo.GetVersionInfo(@".\YTR.exe").FileVersion;
            RS = RS.Replace(".", "");
            FV = FV.Replace(".", "");

            if (int.Parse(RS) > int.Parse(FV))
            {
                SetMessage("New version available!", Color.Red);
                if (MessageBox.Show("There is a newer version available, run updater?", "Newer version", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(@".\" + "updater.exe");
                    close();
                }
                else
                {
                    SetMessage("Canceled", Color.Red);
                    close(5);
                }
            }

        }
        private void showForm()
        {
            this.Invoke((MethodInvoker)delegate
                    {
                        this.Hide();
                        var form2 = new YTR(trial);
                        form2.Closed += (sender, args) => this.Close();
                        form2.Show();
                    });

        }

        string transID = "";
        private void btnStartTrial_Click(object sender, EventArgs e)
        {

            string RunningProcess = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(RunningProcess);
            if (processes.Length > 1)
            {
                MessageBox.Show("Application is already running", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                Application.ExitThread();
            }
            else
            {
                trial = true;
                validation = true;
                bgw = new BackgroundWorker();
                bgw.DoWork += load;
                bgw.RunWorkerAsync();
                return;
            }
        }

        private void SetMessage(string msg, Color color)
        {
            if (lblLoading.InvokeRequired)
            {
                lblLoading.Invoke((MethodInvoker)delegate
                {
                    lblLoading.Text = msg;
                    lblLoading.ForeColor = color;
                });
            }
            else
            {
                lblLoading.Text = msg;
                lblLoading.ForeColor = color;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*bgw = new BackgroundWorker();
            bgw.DoWork += submission;
            bgw.RunWorkerAsync();
             */

            string TID = txtLicense.Text.Trim().Replace("'", "").Replace("?", "").Replace("&", "").Replace(":", "");
            if (TID.Length == 0)
            {
                SetMessage("License ID is empty.", Color.Red);
                txtLicense.Focus();
                return;
            }

            try
            {
                btnStartTrial.Enabled = btnSubmit.Enabled = false;
                SetMessage("Checking License...", Color.Red);
                Http request = new Http();
                Licensing.LicenseResponse resp = Licensing.CheckLicense(request, TID);
                if (resp.IsValid)
                {
                    //PREMIUM = true;                    
                    SetMessage("Starting YTR...", Color.Green);

                    validation = true;
                    bgw = new BackgroundWorker();
                    bgw.DoWork += load;
                    bgw.RunWorkerAsync();
                    return;
                }
                else
                {
                    SetMessage(resp.Message, resp.color);
                }
            }
            catch { }
            finally { btnStartTrial.Enabled = btnSubmit.Enabled = true; }
        }
     
        //updates
        public string MD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private void additionalFiles()
        {
            try
            {
                if (!File.Exists(@".\Newtonsoft.Json.dll"))
                {
                    lblLoading.Invoke((MethodInvoker)delegate
                    { lblLoading.Text = "Downloading additional files..."; });
                }

                if (!File.Exists(@".\Newtonsoft.Json.dll"))
                {
                    WebClient dl = new WebClient();
                    dl.DownloadFile("http://healzer.com/YTR/REG/" + "Newtonsoft.Json.dll", @".\Newtonsoft.Json.dll");
                }
            }
            catch
            {
                lblLoading.Invoke((MethodInvoker)delegate
                { lblLoading.Text = "Error occured!"; });
                MessageBox.Show("error occured: DL#ADIT", "error");
                close();
            }
        }

        //exit
        void close(int delay = 0)
        {

            if (delay > 0)
            {
                lblLoading.Invoke((MethodInvoker)delegate
                { lblLoading.Text = "Closing in " + delay.ToString() + " sec..."; });
                Thread.Sleep(delay * 1000);
                //Closing in 5 sec...
            }
            else
            {
                lblLoading.Invoke((MethodInvoker)delegate
                { lblLoading.Text = "Exiting..."; });
            }
            try
            {
                string RunningProcess = Process.GetCurrentProcess().ProcessName;
                foreach (Process proc in Process.GetProcessesByName(RunningProcess))
                {
                    proc.Kill();
                }
            }
            catch
            {
                MessageBox.Show("Unable to close " + "YouTube Calculator" + ", contact support #CLSER", "error");
            }
        }



        void toggleButtons()
        {
            btnStartTrial.Invoke((MethodInvoker)delegate
            {
                if (btnStartTrial.Enabled && btnSubmit.Enabled)
                {
                    btnStartTrial.Enabled = btnSubmit.Enabled = false;
                }
                else
                {
                    btnStartTrial.Enabled = btnSubmit.Enabled = true;
                }
            });
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            transID = txtLicense.Text.Trim();
        }

        private void lblBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://healzer.com/YTR/");
        }

        private void loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            string RunningProcess = Process.GetCurrentProcess().ProcessName;
            foreach (Process proc in Process.GetProcessesByName(RunningProcess))
            {
                proc.Kill();
            }
        }

    }
}
