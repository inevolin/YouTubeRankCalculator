namespace YTR
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.pLicense = new System.Windows.Forms.Panel();
            this.lblBuy = new System.Windows.Forms.LinkLabel();
            this.btnStartTrial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YTR.Properties.Resources.red_search_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            this.label1.Text = "YTR | YouTube SEO Tool";
            // 
            // lblLoading
            // 
            resources.ApplyResources(this.lblLoading, "lblLoading");
            this.lblLoading.ForeColor = System.Drawing.Color.Blue;
            this.lblLoading.Name = "lblLoading";
            // 
            // pLicense
            // 
            this.pLicense.Controls.Add(this.lblBuy);
            this.pLicense.Controls.Add(this.btnStartTrial);
            this.pLicense.Controls.Add(this.label3);
            this.pLicense.Controls.Add(this.btnSubmit);
            this.pLicense.Controls.Add(this.txtLicense);
            this.pLicense.Controls.Add(this.label2);
            resources.ApplyResources(this.pLicense, "pLicense");
            this.pLicense.Name = "pLicense";
            // 
            // lblBuy
            // 
            resources.ApplyResources(this.lblBuy, "lblBuy");
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.TabStop = true;
            this.lblBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuy_LinkClicked);
            // 
            // btnStartTrial
            // 
            resources.ApplyResources(this.btnStartTrial, "btnStartTrial");
            this.btnStartTrial.Name = "btnStartTrial";
            this.btnStartTrial.UseVisualStyleBackColor = true;
            this.btnStartTrial.Click += new System.EventHandler(this.btnStartTrial_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLicense
            // 
            resources.ApplyResources(this.txtLicense, "txtLicense");
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // loading
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pLicense);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "loading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loading_FormClosing);
            this.Load += new System.EventHandler(this.loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLicense.ResumeLayout(false);
            this.pLicense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Panel pLicense;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartTrial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblBuy;
    }
}