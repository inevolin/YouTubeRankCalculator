using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Threading;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using YTR.Managers;
using YTR.Objects;
using YTR.Helpers;

namespace YTR
{
    public partial class YTR : Form
    {
        private bool TRIAL;
        private CoreManager coreManager;

        #region loading

        public YTR(bool trial)
        {
            InitializeComponent();

            this.TRIAL = trial;
            this.ResizeRedraw = true;

            this.Text =
                "YouTube Calculator" +
                " v" +
                Application.ProductVersion.ToString()
                + (trial == true ? " - TRIAL" : "");

            this.AcceptButton = btnCalculate;
            coreManager = new CoreManager(TRIAL);

            lstKWS.MouseDown += new MouseEventHandler(lstKWS_OnMouseDown);
            dgvKeywords.MouseDown += new MouseEventHandler(dgvKeywords_OnMouseDown);
            dgvOverview.MouseDown += new MouseEventHandler(dgvOverview_OnMouseDown);
            dgvOverview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvOverview_CellClick);
            dgvOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOverview.AutoResizeColumns();

            LoadProperties(); //1
            if (TRIAL) Trial(); //2
        }

        private void YTR_Load(object sender, EventArgs e)
        {
            txtKeyword.Select();
        }

        void Trial()
        {
            mnuThreadCount.SelectedIndex = 0;
            mnuThreadCount.Enabled      =
            grpRelatedKeywords.Enabled  = false;
        }

        #endregion

        #region search

        private void FillKeywordsGrid(AbstractKeyword details)
        {
            var index = dgvKeywords.Rows.Add();
            dgvKeywords.Rows[index].Cells[0].Value = details.Keyword;
            dgvKeywords.Rows[index].Cells[1].Value = details.Results;
            dgvKeywords.Rows[index].Cells[2].Value = details.AvgViewCount;
            dgvKeywords.Rows[index].Cells[3].Value = details.NewVideos + "/" + details.OldVideos;
            dgvKeywords.Rows[index].Cells[4].Value = details.LowestViewCount;
            dgvKeywords.Rows[index].Cells[5].Value = details.HighestViewCount;
            dgvKeywords.Rows[index].Cells[6].Value = details.Overall;
        }
        private void FillVideosGrid(IList<VideoDetails> vids)
        {
            dgvOverview.Rows.Clear();
            foreach (var a in vids)
            {
                int index = dgvOverview.Rows.Add();
                dgvOverview.Rows[index].Cells[0].Value = a.Title;
                dgvOverview.Rows[index].Cells[1].Value = a.ViewCount;
                dgvOverview.Rows[index].Cells[2].Value = a.Subscribers;
                dgvOverview.Rows[index].Cells[3].Value = a.UploadedDate.ToShortDateString();
                dgvOverview.Rows[index].Cells[4].Value = a.LastCommentDate.ToShortDateString();
                dgvOverview.Rows[index].Cells[5].Value = a.CommentCount;
                dgvOverview.Rows[index].Cells[6].Value = a.Likes + "/" + a.Dislikes;
                dgvOverview.Rows[index].Cells[7].Value = a.VideoURL;
                dgvOverview.Rows[index].Cells[8].Value = a.VideoDuration.ToString();
                dgvOverview.Rows[index].Cells[9].Value = a.Description;
                dgvOverview.Rows[index].Cells[10].Value = a.NumLinks;
                dgvOverview.Rows[index].Cells[11].Value = a.ChannelURL;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ToggleBusy(true);
            bgWorkerFullSearch.RunWorkerAsync(txtKeyword.Text);
        }

        private void btnCalcSelected_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0) return;
            else if (lstKWS.SelectedItems.Count > 1 && lstKWS.SelectedIndex != -1)
            {
                ToggleBusy(true);
                bgWorkerQuickSearch.RunWorkerAsync(lstKWS.SelectedItems);
            }
            else if (lstKWS.SelectedItems.Count == 1 && lstKWS.SelectedIndex != -1)
            {
                string s = lstKWS.SelectedItem.ToString();
                txtKeyword.Text = s;

                ToggleBusy(true);
                bgWorkerFullSearch.RunWorkerAsync(s);
            }
        }
        private void btnCalcAll_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0) return;
            ToggleBusy(true);
            bgWorkerQuickSearch.RunWorkerAsync(lstKWS.Items);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            coreManager.Abort();
            bgWorkerQuickSearch.CancelAsync();
            bgWorkerFullSearch.CancelAsync();
        }

        private void ToggleBusy(bool IsActive)
        {
            mnuProperties.Enabled =
            btnCalculate.Enabled =
            btnCalcAll.Enabled =
            btnCalcSelected.Enabled =
            btnImportKW1.Enabled =
            btnKWlist1CLEAR.Enabled =
            btnRemove.Enabled = !IsActive;
            btnAbort.Visible = IsActive;

            if (IsActive)
                lblStatus.Text = "Progress 0%";
            else
                lblStatus.Text = "Ready";
        }

        private void bgWorkerFullSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            var o = coreManager.FullSearch(e.Argument.ToString());
            e.Result = o;
        }
        private void bgWorkerFullSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Progress " + e.ProgressPercentage + "%";
        }
        private void bgWorkerFullSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                KeywordFullSearch o = e.Result as KeywordFullSearch;
                FillKeywordsGrid(o.Details);
                FillVideosGrid(o.Details.Videos);
                tabs2.TabPages[1].Text = "Video's: " + o.Details.Keyword;

                if (o.RelatedKeywords != null)
                {
                    lstKWS.Items.Clear();
                    lstKWS.Items.AddRange(o.RelatedKeywords.ToArray());
                }
            }
            catch { }
            finally
            {
                ToggleBusy(false);
            }
        }

        private void bgWorkerQuickSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (e.Argument.GetType() == typeof(System.Windows.Forms.ListBox.SelectedObjectCollection)) //calc multi selected
                {
                    var arg = e.Argument as System.Windows.Forms.ListBox.SelectedObjectCollection;
                    coreManager.QuickSearch(arg.Cast<string>().ToList<string>(), ref bgWorkerQuickSearch);
                }
                else if (e.Argument.GetType() == typeof(System.Windows.Forms.ListBox.ObjectCollection)) //calc all
                {
                    var arg = e.Argument as System.Windows.Forms.ListBox.ObjectCollection;
                    coreManager.QuickSearch(arg.Cast<string>().ToList<string>(), ref bgWorkerQuickSearch);
                }
            }
            catch (Exception) { }
        }
        private void bgWorkerQuickSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Progress " + e.ProgressPercentage + "%";

            KeywordQuickSearch o = e.UserState as KeywordQuickSearch;
            FillKeywordsGrid(o.Details);

        }
        private void bgWorkerQuickSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ToggleBusy(false);
        }

        private void bgWorkerVideosSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            var o = coreManager.QuickSearch(e.Argument.ToString());
            e.Result = o;
        }
        private void bgWorkerVideosSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Progress " + e.ProgressPercentage + "%";
        }
        private void bgWorkerVideosSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                KeywordQuickSearch o = e.Result as KeywordQuickSearch;
                FillVideosGrid(o.Details.Videos);
                tabs2.TabPages[1].Text = "Video's: " + o.Details.Keyword;
            }
            catch { }
            finally
            {
                /*
                 * When a "calc all" process is going on
                 * you may want to see first page of a certain kw
                 * but you may not disrupt the ongoing process.
                */
                //ToggleBusy(false);
            }
        }

        #endregion

        #region misc_kw_actions

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0) return;
            if (lstKWS.SelectedItems.Count > 1)
            {
                foreach (string s in lstKWS.SelectedItems)
                {
                    using (StreamWriter sw = new StreamWriter("kws.txt", true))
                    {
                        sw.WriteLine(s);
                    }
                }

                return;
            }
            else if (lstKWS.SelectedIndex != -1)
            {
                using (StreamWriter sw = new StreamWriter("kws.txt", true))
                {
                    sw.WriteLine(lstKWS.Items[lstKWS.SelectedIndex].ToString());
                }
            }
        }

        private void btnKeepList_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text file|*.txt";
            sfd.Title = "Save keyword list";
            sfd.ShowDialog();
            int i = 0;
            TextWriter tw = new StreamWriter(sfd.InitialDirectory.ToString() + sfd.FileName.ToString(), true);
            foreach (string s in lstKWS.Items)
            {
                tw.WriteLine(lstKWS.Items[i].ToString());
                i++;
            }
            tw.WriteLine("");
            tw.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvKeywords.Rows.Clear();
        }

        private void lstKWS_OnMouseDown(object sender, MouseEventArgs args)
        {
            if (args.Button == MouseButtons.Right)
            {
                lstKWS.ClearSelected();
                var item = lstKWS.IndexFromPoint(args.Location);
                lstKWS.SelectedIndex = item;
                if (item >= 0 && lstKWS.SelectedIndices.Contains(item) == true)
                {
                    Clipboard.SetText(lstKWS.Items[item].ToString());

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0 || lstKWS.SelectedIndex == -1) return;

            List<string> o = lstKWS.SelectedItems.Cast<string>().ToList();
            for (int i = 0; i < o.Count; i++)
                lstKWS.Items.Remove(o[i]);
        }

        private void btnImportKW1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text file|*.txt";
            ofd.Title = "Open keyword list";
            ofd.ShowDialog();
            if (ofd.SafeFileName == "") return;

            string line = "";
            using (StreamReader reader = new StreamReader(ofd.InitialDirectory.ToString() + ofd.FileName.ToString()))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "" || lstKWS.Items.Contains(line))
                    { continue; }
                    lstKWS.Items.Add(line);
                }
                reader.Dispose();
            }
        }

        private void btnKWlist1CLEAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Clear keywords", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                return;

            lstKWS.Items.Clear();
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell r in dgvKeywords.SelectedCells)
                {
                    using (StreamWriter sw = new StreamWriter("kws.txt", true))
                    {
                        sw.WriteLine(r.Value);
                    }
                }
            }
            catch (WebException) { }
            catch (Exception ex) { MessageBox.Show("Error occured - please contact support: " + ex.Message.ToString()); }
        }

        private void btnRemoveS_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell r in dgvKeywords.SelectedCells)
                {
                    dgvKeywords.Rows.RemoveAt(r.RowIndex);
                }
            }
            catch { }
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnClearFirstPage_Click(object sender, EventArgs e)
        {
            dgvOverview.Rows.Clear();
        }
        private void btnKeepURLs_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> urls = new List<string>();
                if (dgvOverview.SelectedCells.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "text file|*.txt";
                    sfd.Title = "Save keyword list";
                    sfd.ShowDialog();
                    int i = 0;
                    TextWriter tw = new StreamWriter(sfd.InitialDirectory.ToString() + sfd.FileName.ToString(), true);

                    foreach (DataGridViewCell r in dgvOverview.SelectedCells)
                    {
                        string url = dgvOverview.Rows[r.RowIndex].Cells[7].Value.ToString();
                        if (!urls.Contains(url))
                        {
                            urls.Add(url);
                            tw.WriteLine(url);
                        }
                        i++;
                    }

                    tw.Close();
                }

            }
            catch (WebException) { }
            catch (Exception ex) { MessageBox.Show("Error occured - please contact support: " + ex.Message.ToString()); }
        }

        private void btnCopyAllRelated_Click(object sender, EventArgs e)
        {
            if (lstKWS.Items.Count <= 0) return;

            string s = "";
            for (int i = 0; i < lstKWS.Items.Count; i++)
            {

                s += lstKWS.Items[i].ToString() + Environment.NewLine;
            }
            Clipboard.SetText(s);
        }

        #endregion

        #region gridview_actions

        private void dgvKeywords_OnMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell c = dgvKeywords.SelectedCells[0];
                if (e.Button == MouseButtons.Right)
                {
                    System.Windows.Forms.MenuItem[] mi = new System.Windows.Forms.MenuItem[5];

                    int currentMouseOverRow = dgvKeywords.HitTest(e.X, e.Y).RowIndex;
                    int currentMouseOverColumn = dgvKeywords.HitTest(e.X, e.Y).ColumnIndex;
                    if (currentMouseOverRow >= 0)
                    {
                        dgvKeywords.ClearSelection();
                        dgvKeywords.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Selected = true;

                        mi[0] = new System.Windows.Forms.MenuItem("Copy keyword", dgvKeywordsMenu_Click);
                        mi[0].Name = "0";

                        mi[1] = new System.Windows.Forms.MenuItem("Copy selected cell", dgvKeywordsMenu_Click);
                        mi[1].Name = "1";

                        mi[2] = new System.Windows.Forms.MenuItem("Display first page", dgvKeywordsMenu_Click);
                        mi[2].Name = "2";

                        mi[3] = new System.Windows.Forms.MenuItem("Open in browser", dgvKeywordsMenu_Click);
                        mi[3].Name = "3";

                        mi[4] = new System.Windows.Forms.MenuItem("Clear all", dgvKeywordsMenu_Click);
                        mi[4].Name = "4";
                    }

                    ContextMenu cm = new ContextMenu(mi);

                    cm.Show(dgvKeywords, new Point(e.X, e.Y));
                }
            }
            catch { }
        }

        private void dgvKeywordsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MenuItem mi = sender as System.Windows.Forms.MenuItem;
                if (mi != null)
                {
                    if (mi.Name == "0")
                    {
                        int r = dgvKeywords.SelectedCells[0].RowIndex;
                        string s = dgvKeywords.Rows[r].Cells[0].Value.ToString();
                        Clipboard.SetText(s);
                    }
                    else if (mi.Name == "1")
                    {
                        Clipboard.SetText(dgvKeywords.SelectedCells[0].Value.ToString());
                    }
                    else if (mi.Name == "2")
                    {
                        try
                        {
                            int r = dgvKeywords.SelectedCells[0].RowIndex;
                            string s = dgvKeywords.Rows[r].Cells[0].Value.ToString();

                            // Do not uncomment, there is a reason for this!
                            //ToggleBusy(true);
                            bgWorkerVideosSearch.RunWorkerAsync(s);

                        }
                        catch (WebException) { }
                        catch (Exception) { MessageBox.Show("Unable to calculate Error #MENUCALC", "Unexpected error"); }
                    }
                    else if (mi.Name == "3")
                    {
                        int r = dgvKeywords.SelectedCells[0].RowIndex;
                        string s = dgvKeywords.Rows[r].Cells[0].Value.ToString();

                        Process.Start("http://www.youtube.com/results?search_query=" + HttpUtility.UrlEncode(s));
                    }
                    else if (mi.Name == "4")
                    {
                        if (MessageBox.Show("Are you sure?", "Clear the grid", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dgvKeywords.Rows.Clear();
                        }
                    }
                }
            }
            catch { }
        }

        private void dgvOverview_OnMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewCell c = dgvOverview.SelectedCells[0];
                if (e.Button == MouseButtons.Right)
                {
                    System.Windows.Forms.MenuItem[] mi = new System.Windows.Forms.MenuItem[2];

                    int currentMouseOverRow = dgvOverview.HitTest(e.X, e.Y).RowIndex;
                    int currentMouseOverColumn = dgvOverview.HitTest(e.X, e.Y).ColumnIndex;
                    if (currentMouseOverRow >= 0)
                    {
                        dgvOverview.ClearSelection();
                        dgvOverview.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Selected = true;

                        mi[0] = new System.Windows.Forms.MenuItem("Copy selected cell", dgvFirstPageMenu_Click);
                        mi[0].Name = "0";

                        mi[1] = new System.Windows.Forms.MenuItem("Clear all", dgvFirstPageMenu_Click);
                        mi[1].Name = "1";
                    }

                    ContextMenu cm = new ContextMenu(mi);

                    cm.Show(dgvOverview, new Point(e.X, e.Y));
                }
            }
            catch { }
        }

        private void dgvFirstPageMenu_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MenuItem mi = sender as System.Windows.Forms.MenuItem;
                if (mi != null)
                {
                    if (mi.Name == "0")
                    {
                        Clipboard.SetText(dgvOverview.SelectedCells[0].Value.ToString());
                    }
                    else if (mi.Name == "1")
                    {
                        if (MessageBox.Show("Are you sure?", "Clear the grid", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dgvOverview.Rows.Clear();
                        }
                    }

                }
            }
            catch { }
        }

        private void dgvOverview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOverview.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dgvOverview.CurrentCell != null && dgvOverview.CurrentCell.Value != null)
                    Process.Start(dgvOverview.CurrentCell.Value.ToString());
            }

        }

        private void btnKeepListS_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKeywords.RowCount > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "text file|*.txt";
                    sfd.Title = "Save keyword list";
                    sfd.ShowDialog();
                    int i = 0;
                    TextWriter tw = new StreamWriter(sfd.InitialDirectory.ToString() + sfd.FileName.ToString(), true);
                    foreach (DataGridViewRow r in dgvKeywords.Rows)
                    {
                        DataGridViewCell c = r.Cells[0];
                        tw.WriteLine(c.Value);
                        i++;
                    }
                    tw.Close();
                }

            }
            catch (WebException) { }
            catch (Exception ex) { MessageBox.Show("Error occured - please contact support: " + ex.Message.ToString()); }
        }

        #endregion

        #region exit

        private void close()
        {
            btnAbort.PerformClick();
            try
            {
                string RunningProcess = Process.GetCurrentProcess().ProcessName;
                foreach (Process proc in Process.GetProcessesByName(RunningProcess))
                {
                    proc.Kill();
                }
            }
            catch { }
        }

        private void YTR_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            close();
        }
        #endregion

        #region menu_properties

        private void LoadProperties()
        {
            MyPropertyManager.OnLoad();

            ///////////     exp_level       ///////////
            if (MyPropertyManager.GetProperty("Difficulty") != null)
                cboExpLevel.SelectedItem = (string)MyPropertyManager.GetProperty("Difficulty");
            else
                cboExpLevel.SelectedIndex = 0;

            SetDifficulty();
            this.cboExpLevel.SelectedIndexChanged += new System.EventHandler(this.cboExpLevel_SelectedIndexChanged);

            ///////////     thread_count        ///////////
            if (MyPropertyManager.GetProperty("ThreadCount") != null)
                mnuThreadCount.SelectedIndex = (int)MyPropertyManager.GetProperty("ThreadCount") - 1;
            else
                mnuThreadCount.SelectedIndex = 0;

            SetThreadCount();
            this.mnuThreadCount.SelectedIndexChanged += new System.EventHandler(this.mnuThreadCount_SelectedIndexChanged);

        }
        private void cboExpLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyPropertyManager.SetProperty("Difficulty", cboExpLevel.SelectedItem);
            SetDifficulty();
        }
        private void SetDifficulty()
        {
            switch (cboExpLevel.SelectedItem.ToString())
            {
                case "Beginner":
                    coreManager.Difficulty = new Easy();
                    break;

                case "Experienced":
                    coreManager.Difficulty = new Medium();
                    break;

                case "Professional":
                    coreManager.Difficulty = new Hard();
                    break;
            }
        }

        private void mnuThreadCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyPropertyManager.SetProperty("ThreadCount", int.Parse(mnuThreadCount.SelectedItem.ToString()));
            SetThreadCount();
        }
        private void SetThreadCount()
        {
            coreManager.maxThreads = int.Parse(mnuThreadCount.SelectedItem.ToString());
        }

        #endregion

        #region menu_help

        private void mnuManual_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/document/d/1PNZd_QfX7LlykKZVBnhiZTYEjVKEwtkYLmf4Pf855HE/");
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            Process.Start("http://healzer.com/contactus/");
        }

        #endregion


    }
}

