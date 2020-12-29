namespace YTR.Forms
{
    partial class RankChecker
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
            this.btnClearGridRC = new System.Windows.Forms.Button();
            this.txtKeywordRankChecker = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRankChecker = new System.Windows.Forms.Label();
            this.txtVideoRankCheck = new System.Windows.Forms.TextBox();
            this.btnKeywordRankChecker = new System.Windows.Forms.Button();
            this.dgvRankChecker = new System.Windows.Forms.DataGridView();
            this.rankKeyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearGridRC
            // 
            this.btnClearGridRC.Location = new System.Drawing.Point(741, 69);
            this.btnClearGridRC.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearGridRC.Name = "btnClearGridRC";
            this.btnClearGridRC.Size = new System.Drawing.Size(100, 28);
            this.btnClearGridRC.TabIndex = 29;
            this.btnClearGridRC.Text = "clear grid";
            this.btnClearGridRC.UseVisualStyleBackColor = true;
            // 
            // txtKeywordRankChecker
            // 
            this.txtKeywordRankChecker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKeywordRankChecker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeywordRankChecker.Location = new System.Drawing.Point(15, 69);
            this.txtKeywordRankChecker.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeywordRankChecker.Name = "txtKeywordRankChecker";
            this.txtKeywordRankChecker.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtKeywordRankChecker.Size = new System.Drawing.Size(253, 223);
            this.txtKeywordRankChecker.TabIndex = 28;
            this.txtKeywordRankChecker.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Keywords:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "URL or Video ID:";
            // 
            // lblRankChecker
            // 
            this.lblRankChecker.AutoSize = true;
            this.lblRankChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankChecker.Location = new System.Drawing.Point(638, 14);
            this.lblRankChecker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRankChecker.Name = "lblRankChecker";
            this.lblRankChecker.Size = new System.Drawing.Size(70, 25);
            this.lblRankChecker.TabIndex = 25;
            this.lblRankChecker.Text = "status";
            // 
            // txtVideoRankCheck
            // 
            this.txtVideoRankCheck.Location = new System.Drawing.Point(137, 14);
            this.txtVideoRankCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtVideoRankCheck.Name = "txtVideoRankCheck";
            this.txtVideoRankCheck.Size = new System.Drawing.Size(375, 22);
            this.txtVideoRankCheck.TabIndex = 24;
            // 
            // btnKeywordRankChecker
            // 
            this.btnKeywordRankChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeywordRankChecker.Location = new System.Drawing.Point(521, 10);
            this.btnKeywordRankChecker.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeywordRankChecker.Name = "btnKeywordRankChecker";
            this.btnKeywordRankChecker.Size = new System.Drawing.Size(109, 34);
            this.btnKeywordRankChecker.TabIndex = 23;
            this.btnKeywordRankChecker.Text = "check";
            this.btnKeywordRankChecker.UseVisualStyleBackColor = true;
            // 
            // dgvRankChecker
            // 
            this.dgvRankChecker.AllowUserToAddRows = false;
            this.dgvRankChecker.AllowUserToDeleteRows = false;
            this.dgvRankChecker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRankChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankChecker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankKeyword,
            this.rankPosition});
            this.dgvRankChecker.Location = new System.Drawing.Point(278, 69);
            this.dgvRankChecker.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRankChecker.Name = "dgvRankChecker";
            this.dgvRankChecker.ReadOnly = true;
            this.dgvRankChecker.Size = new System.Drawing.Size(455, 223);
            this.dgvRankChecker.TabIndex = 22;
            // 
            // rankKeyword
            // 
            this.rankKeyword.HeaderText = "Keyword";
            this.rankKeyword.Name = "rankKeyword";
            this.rankKeyword.ReadOnly = true;
            this.rankKeyword.Width = 170;
            // 
            // rankPosition
            // 
            this.rankPosition.HeaderText = "Position";
            this.rankPosition.Name = "rankPosition";
            this.rankPosition.ReadOnly = true;
            // 
            // RankChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 305);
            this.Controls.Add(this.btnClearGridRC);
            this.Controls.Add(this.txtKeywordRankChecker);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblRankChecker);
            this.Controls.Add(this.txtVideoRankCheck);
            this.Controls.Add(this.btnKeywordRankChecker);
            this.Controls.Add(this.dgvRankChecker);
            this.Name = "RankChecker";
            this.Text = "RankChecker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearGridRC;
        private System.Windows.Forms.RichTextBox txtKeywordRankChecker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRankChecker;
        private System.Windows.Forms.TextBox txtVideoRankCheck;
        private System.Windows.Forms.Button btnKeywordRankChecker;
        private System.Windows.Forms.DataGridView dgvRankChecker;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankPosition;
    }
}