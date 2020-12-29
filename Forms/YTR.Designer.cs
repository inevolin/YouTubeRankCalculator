namespace YTR
{
    partial class YTR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCopyAllRelated = new System.Windows.Forms.Button();
            this.btnKWlist1CLEAR = new System.Windows.Forms.Button();
            this.btnImportKW1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstKWS = new System.Windows.Forms.ListBox();
            this.btnCalcSelected = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalcAll = new System.Windows.Forms.Button();
            this.btnKeepList = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.experienceLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboExpLevel = new System.Windows.Forms.ToolStripComboBox();
            this.threadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThreadCount = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabs2 = new System.Windows.Forms.TabControl();
            this.KWS = new System.Windows.Forms.TabPage();
            this.dgvKeywords = new System.Windows.Forms.DataGridView();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVideos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallesViewCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstP = new System.Windows.Forms.TabPage();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpRelatedKeywords = new System.Windows.Forms.GroupBox();
            this.bgWorkerFullSearch = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerQuickSearch = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerVideosSearch = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Views = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Countcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLinksDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelUrl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabs2.SuspendLayout();
            this.KWS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).BeginInit();
            this.FirstP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.grpRelatedKeywords.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 15000;
            this.tt.InitialDelay = 500;
            this.tt.ReshowDelay = 100;
            // 
            // btnAbort
            // 
            this.btnAbort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbort.BackgroundImage")));
            this.btnAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbort.FlatAppearance.BorderSize = 0;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Location = new System.Drawing.Point(798, 62);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(35, 30);
            this.btnAbort.TabIndex = 38;
            this.tt.SetToolTip(this.btnAbort, "Abort all current operations.");
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.BackgroundImage = global::YTR.Properties.Resources.notepad;
            this.btnNotepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotepad.Location = new System.Drawing.Point(367, 113);
            this.btnNotepad.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(59, 54);
            this.btnNotepad.TabIndex = 37;
            this.tt.SetToolTip(this.btnNotepad, "Open notepad");
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(235, 60);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(412, 30);
            this.txtKeyword.TabIndex = 28;
            this.tt.SetToolTip(this.txtKeyword, "Write your keyword which you want to analyze here");
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(657, 60);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 33);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.tt.SetToolTip(this.btnCalculate, "Write your keyword in the KW textbox and click here\r\nto start a calculation proce" +
        "ss.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCopyAllRelated
            // 
            this.btnCopyAllRelated.Location = new System.Drawing.Point(645, 81);
            this.btnCopyAllRelated.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyAllRelated.Name = "btnCopyAllRelated";
            this.btnCopyAllRelated.Size = new System.Drawing.Size(90, 28);
            this.btnCopyAllRelated.TabIndex = 21;
            this.btnCopyAllRelated.Text = "Copy all";
            this.tt.SetToolTip(this.btnCopyAllRelated, "Copy all related keywords to Clipboard");
            this.btnCopyAllRelated.UseVisualStyleBackColor = true;
            this.btnCopyAllRelated.Click += new System.EventHandler(this.btnCopyAllRelated_Click);
            // 
            // btnKWlist1CLEAR
            // 
            this.btnKWlist1CLEAR.Location = new System.Drawing.Point(645, 52);
            this.btnKWlist1CLEAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnKWlist1CLEAR.Name = "btnKWlist1CLEAR";
            this.btnKWlist1CLEAR.Size = new System.Drawing.Size(90, 28);
            this.btnKWlist1CLEAR.TabIndex = 20;
            this.btnKWlist1CLEAR.Text = "Clear";
            this.tt.SetToolTip(this.btnKWlist1CLEAR, "Clear this list.");
            this.btnKWlist1CLEAR.UseVisualStyleBackColor = true;
            this.btnKWlist1CLEAR.Click += new System.EventHandler(this.btnKWlist1CLEAR_Click);
            // 
            // btnImportKW1
            // 
            this.btnImportKW1.Location = new System.Drawing.Point(553, 52);
            this.btnImportKW1.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportKW1.Name = "btnImportKW1";
            this.btnImportKW1.Size = new System.Drawing.Size(90, 28);
            this.btnImportKW1.TabIndex = 19;
            this.btnImportKW1.Text = "Import";
            this.tt.SetToolTip(this.btnImportKW1, "import line-based keywords from textfile");
            this.btnImportKW1.UseVisualStyleBackColor = true;
            this.btnImportKW1.Click += new System.EventHandler(this.btnImportKW1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(553, 23);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(182, 28);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove selected";
            this.tt.SetToolTip(this.btnRemove, "Remove selected keyword from the list.");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstKWS
            // 
            this.lstKWS.FormattingEnabled = true;
            this.lstKWS.ItemHeight = 16;
            this.lstKWS.Location = new System.Drawing.Point(8, 23);
            this.lstKWS.Margin = new System.Windows.Forms.Padding(4);
            this.lstKWS.Name = "lstKWS";
            this.lstKWS.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstKWS.Size = new System.Drawing.Size(351, 148);
            this.lstKWS.TabIndex = 4;
            this.tt.SetToolTip(this.lstKWS, "Right-Click on an item to Copy to clipboard");
            // 
            // btnCalcSelected
            // 
            this.btnCalcSelected.Location = new System.Drawing.Point(367, 23);
            this.btnCalcSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcSelected.Name = "btnCalcSelected";
            this.btnCalcSelected.Size = new System.Drawing.Size(182, 28);
            this.btnCalcSelected.TabIndex = 5;
            this.btnCalcSelected.Text = "Calculate selected";
            this.tt.SetToolTip(this.btnCalcSelected, "Calculates the selected keyword from the list.");
            this.btnCalcSelected.UseVisualStyleBackColor = true;
            this.btnCalcSelected.Click += new System.EventHandler(this.btnCalcSelected_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 81);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Quick save selected";
            this.tt.SetToolTip(this.btnSave, "Instantly saves the selected keyword(s) to \"kws.txt\" file from this list.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalcAll
            // 
            this.btnCalcAll.Location = new System.Drawing.Point(367, 52);
            this.btnCalcAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcAll.Name = "btnCalcAll";
            this.btnCalcAll.Size = new System.Drawing.Size(182, 28);
            this.btnCalcAll.TabIndex = 7;
            this.btnCalcAll.Text = "Calculate all";
            this.tt.SetToolTip(this.btnCalcAll, "Run a calculation for all the keywords in this list.\r\nThe result of all the keywo" +
        "rds will be displayed in\r\nthe Keywords gridview.");
            this.btnCalcAll.UseVisualStyleBackColor = true;
            this.btnCalcAll.Click += new System.EventHandler(this.btnCalcAll_Click);
            // 
            // btnKeepList
            // 
            this.btnKeepList.Location = new System.Drawing.Point(553, 81);
            this.btnKeepList.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeepList.Name = "btnKeepList";
            this.btnKeepList.Size = new System.Drawing.Size(90, 28);
            this.btnKeepList.TabIndex = 11;
            this.btnKeepList.Text = "Save all";
            this.tt.SetToolTip(this.btnKeepList, "Saves the current list to a custom text file.");
            this.btnKeepList.UseVisualStyleBackColor = true;
            this.btnKeepList.Click += new System.EventHandler(this.btnKeepList_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DividerWidth = 1;
            this.dataGridViewImageColumn1.HeaderText = "Likes/Dislikes";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuProperties,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "mnuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(102, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuProperties
            // 
            this.mnuProperties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experienceLevelToolStripMenuItem,
            this.threadsToolStripMenuItem});
            this.mnuProperties.Name = "mnuProperties";
            this.mnuProperties.Size = new System.Drawing.Size(88, 24);
            this.mnuProperties.Text = "Properties";
            // 
            // experienceLevelToolStripMenuItem
            // 
            this.experienceLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboExpLevel});
            this.experienceLevelToolStripMenuItem.Name = "experienceLevelToolStripMenuItem";
            this.experienceLevelToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.experienceLevelToolStripMenuItem.Text = "Experience level";
            // 
            // cboExpLevel
            // 
            this.cboExpLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpLevel.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboExpLevel.Items.AddRange(new object[] {
            "Beginner",
            "Experienced",
            "Professional"});
            this.cboExpLevel.Name = "cboExpLevel";
            this.cboExpLevel.Size = new System.Drawing.Size(121, 28);
            // 
            // threadsToolStripMenuItem
            // 
            this.threadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThreadCount});
            this.threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            this.threadsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.threadsToolStripMenuItem.Text = "Threads";
            // 
            // mnuThreadCount
            // 
            this.mnuThreadCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mnuThreadCount.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.mnuThreadCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.mnuThreadCount.Name = "mnuThreadCount";
            this.mnuThreadCount.Size = new System.Drawing.Size(121, 28);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.mnuHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuManual
            // 
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(127, 24);
            this.mnuManual.Text = "Manual";
            this.mnuManual.Click += new System.EventHandler(this.mnuManual_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(127, 24);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::YTR.Properties.Resources.red_search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(926, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // tabs2
            // 
            this.tabs2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs2.Controls.Add(this.KWS);
            this.tabs2.Controls.Add(this.FirstP);
            this.tabs2.Location = new System.Drawing.Point(4, 4);
            this.tabs2.Margin = new System.Windows.Forms.Padding(4);
            this.tabs2.Name = "tabs2";
            this.tabs2.SelectedIndex = 0;
            this.tabs2.Size = new System.Drawing.Size(1048, 187);
            this.tabs2.TabIndex = 30;
            // 
            // KWS
            // 
            this.KWS.Controls.Add(this.dgvKeywords);
            this.KWS.Location = new System.Drawing.Point(4, 25);
            this.KWS.Margin = new System.Windows.Forms.Padding(4);
            this.KWS.Name = "KWS";
            this.KWS.Padding = new System.Windows.Forms.Padding(4);
            this.KWS.Size = new System.Drawing.Size(1040, 158);
            this.KWS.TabIndex = 1;
            this.KWS.Text = "Keywords";
            this.KWS.UseVisualStyleBackColor = true;
            // 
            // dgvKeywords
            // 
            this.dgvKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeywords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Keyword,
            this.results,
            this.avgViews,
            this.newVideos,
            this.smallesViewCount,
            this.highestViews,
            this.overall});
            this.dgvKeywords.Location = new System.Drawing.Point(4, 4);
            this.dgvKeywords.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKeywords.Name = "dgvKeywords";
            this.dgvKeywords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKeywords.Size = new System.Drawing.Size(1030, 144);
            this.dgvKeywords.TabIndex = 0;
            // 
            // Keyword
            // 
            this.Keyword.HeaderText = "Keyword";
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            // 
            // results
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.results.DefaultCellStyle = dataGridViewCellStyle1;
            this.results.HeaderText = "Results";
            this.results.Name = "results";
            this.results.ReadOnly = true;
            // 
            // avgViews
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.avgViews.DefaultCellStyle = dataGridViewCellStyle2;
            this.avgViews.HeaderText = "Avg. views";
            this.avgViews.Name = "avgViews";
            this.avgViews.ReadOnly = true;
            // 
            // newVideos
            // 
            this.newVideos.HeaderText = "new/old count";
            this.newVideos.Name = "newVideos";
            this.newVideos.ReadOnly = true;
            // 
            // smallesViewCount
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.smallesViewCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.smallesViewCount.HeaderText = "Lowest views";
            this.smallesViewCount.Name = "smallesViewCount";
            this.smallesViewCount.ReadOnly = true;
            // 
            // highestViews
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.highestViews.DefaultCellStyle = dataGridViewCellStyle4;
            this.highestViews.HeaderText = "Highest views";
            this.highestViews.Name = "highestViews";
            this.highestViews.ReadOnly = true;
            // 
            // overall
            // 
            this.overall.HeaderText = "Overall";
            this.overall.Name = "overall";
            this.overall.ReadOnly = true;
            // 
            // FirstP
            // 
            this.FirstP.Controls.Add(this.dgvOverview);
            this.FirstP.Location = new System.Drawing.Point(4, 25);
            this.FirstP.Margin = new System.Windows.Forms.Padding(4);
            this.FirstP.Name = "FirstP";
            this.FirstP.Padding = new System.Windows.Forms.Padding(4);
            this.FirstP.Size = new System.Drawing.Size(1040, 158);
            this.FirstP.TabIndex = 0;
            this.FirstP.Text = "Videos";
            this.FirstP.UseVisualStyleBackColor = true;
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToDeleteRows = false;
            this.dgvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Views,
            this.Subscribers,
            this.Uploaded,
            this.Last_comment,
            this.Countcomments,
            this.DisLikes,
            this.URL,
            this.duration,
            this.description,
            this.numLinksDesc,
            this.channelUrl});
            this.dgvOverview.Location = new System.Drawing.Point(4, 4);
            this.dgvOverview.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.ReadOnly = true;
            this.dgvOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOverview.Size = new System.Drawing.Size(1047, 150);
            this.dgvOverview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Keyword:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(653, 97);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 25);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "status";
            // 
            // grpRelatedKeywords
            // 
            this.grpRelatedKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpRelatedKeywords.Controls.Add(this.btnCopyAllRelated);
            this.grpRelatedKeywords.Controls.Add(this.btnKWlist1CLEAR);
            this.grpRelatedKeywords.Controls.Add(this.btnNotepad);
            this.grpRelatedKeywords.Controls.Add(this.btnImportKW1);
            this.grpRelatedKeywords.Controls.Add(this.btnRemove);
            this.grpRelatedKeywords.Controls.Add(this.lstKWS);
            this.grpRelatedKeywords.Controls.Add(this.btnCalcSelected);
            this.grpRelatedKeywords.Controls.Add(this.btnSave);
            this.grpRelatedKeywords.Controls.Add(this.btnCalcAll);
            this.grpRelatedKeywords.Controls.Add(this.btnKeepList);
            this.grpRelatedKeywords.Location = new System.Drawing.Point(4, 199);
            this.grpRelatedKeywords.Margin = new System.Windows.Forms.Padding(4);
            this.grpRelatedKeywords.Name = "grpRelatedKeywords";
            this.grpRelatedKeywords.Padding = new System.Windows.Forms.Padding(4);
            this.grpRelatedKeywords.Size = new System.Drawing.Size(745, 172);
            this.grpRelatedKeywords.TabIndex = 32;
            this.grpRelatedKeywords.TabStop = false;
            this.grpRelatedKeywords.Text = "Related Keywords";
            // 
            // bgWorkerFullSearch
            // 
            this.bgWorkerFullSearch.WorkerReportsProgress = true;
            this.bgWorkerFullSearch.WorkerSupportsCancellation = true;
            this.bgWorkerFullSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerFullSearch_DoWork);
            this.bgWorkerFullSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerFullSearch_ProgressChanged);
            this.bgWorkerFullSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerFullSearch_RunWorkerCompleted);
            // 
            // bgWorkerQuickSearch
            // 
            this.bgWorkerQuickSearch.WorkerReportsProgress = true;
            this.bgWorkerQuickSearch.WorkerSupportsCancellation = true;
            this.bgWorkerQuickSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerQuickSearch_DoWork);
            this.bgWorkerQuickSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerQuickSearch_ProgressChanged);
            this.bgWorkerQuickSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerQuickSearch_RunWorkerCompleted);
            // 
            // bgWorkerVideosSearch
            // 
            this.bgWorkerVideosSearch.WorkerReportsProgress = true;
            this.bgWorkerVideosSearch.WorkerSupportsCancellation = true;
            this.bgWorkerVideosSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerVideosSearch_DoWork);
            this.bgWorkerVideosSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerVideosSearch_ProgressChanged);
            this.bgWorkerVideosSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerVideosSearch_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabs2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpRelatedKeywords, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 375);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 52;
            // 
            // Views
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Views.DefaultCellStyle = dataGridViewCellStyle5;
            this.Views.HeaderText = "Views";
            this.Views.Name = "Views";
            this.Views.ReadOnly = true;
            this.Views.Width = 60;
            // 
            // Subscribers
            // 
            this.Subscribers.HeaderText = "#Subscribers";
            this.Subscribers.Name = "Subscribers";
            this.Subscribers.ReadOnly = true;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "Published";
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // Last_comment
            // 
            this.Last_comment.HeaderText = "Last comment";
            this.Last_comment.Name = "Last_comment";
            this.Last_comment.ReadOnly = true;
            this.Last_comment.ToolTipText = "Time of last comment";
            this.Last_comment.Width = 94;
            // 
            // Countcomments
            // 
            this.Countcomments.HeaderText = "#Comments";
            this.Countcomments.Name = "Countcomments";
            this.Countcomments.ReadOnly = true;
            this.Countcomments.Width = 87;
            // 
            // DisLikes
            // 
            this.DisLikes.HeaderText = "+ / -";
            this.DisLikes.Name = "DisLikes";
            this.DisLikes.ReadOnly = true;
            this.DisLikes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DisLikes.ToolTipText = "likes / dislikes";
            this.DisLikes.Width = 52;
            // 
            // URL
            // 
            this.URL.ActiveLinkColor = System.Drawing.Color.Blue;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.URL.Text = "test";
            this.URL.Width = 54;
            // 
            // duration
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.duration.DefaultCellStyle = dataGridViewCellStyle6;
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.ToolTipText = "Minutes:Seconds";
            this.duration.Width = 70;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 83;
            // 
            // numLinksDesc
            // 
            this.numLinksDesc.HeaderText = "#Links";
            this.numLinksDesc.Name = "numLinksDesc";
            this.numLinksDesc.ReadOnly = true;
            // 
            // channelUrl
            // 
            this.channelUrl.HeaderText = "Channel";
            this.channelUrl.Name = "channelUrl";
            this.channelUrl.ReadOnly = true;
            // 
            // YTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2394, 1122);
            this.MinimumSize = new System.Drawing.Size(1074, 550);
            this.Name = "YTR";
            this.Text = "YouTube Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YTR_FormClosing);
            this.Load += new System.EventHandler(this.YTR_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabs2.ResumeLayout(false);
            this.KWS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).EndInit();
            this.FirstP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.grpRelatedKeywords.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.TabControl tabs2;
        private System.Windows.Forms.TabPage KWS;
        private System.Windows.Forms.DataGridView dgvKeywords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn results;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn newVideos;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallesViewCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn overall;
        private System.Windows.Forms.TabPage FirstP;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpRelatedKeywords;
        private System.Windows.Forms.Button btnCopyAllRelated;
        private System.Windows.Forms.Button btnKWlist1CLEAR;
        private System.Windows.Forms.Button btnImportKW1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstKWS;
        private System.Windows.Forms.Button btnCalcSelected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalcAll;
        private System.Windows.Forms.Button btnKeepList;
        private System.ComponentModel.BackgroundWorker bgWorkerFullSearch;
        private System.ComponentModel.BackgroundWorker bgWorkerQuickSearch;
        private System.ComponentModel.BackgroundWorker bgWorkerVideosSearch;
        private System.Windows.Forms.ToolStripMenuItem experienceLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboExpLevel;
        private System.Windows.Forms.ToolStripMenuItem threadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mnuThreadCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Views;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscribers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisLikes;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLinksDesc;
        private System.Windows.Forms.DataGridViewLinkColumn channelUrl;
    }
}

