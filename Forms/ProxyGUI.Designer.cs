namespace YTR.Forms
{
    partial class ProxyGUI
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
            this.chkProxies = new System.Windows.Forms.CheckBox();
            this.btnClearProxies = new System.Windows.Forms.Button();
            this.txtProxies = new System.Windows.Forms.TextBox();
            this.btnTestProxies = new System.Windows.Forms.Button();
            this.lblProxies = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveProxies = new System.Windows.Forms.Button();
            this.txtTimeoutProxies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkProxies
            // 
            this.chkProxies.AutoSize = true;
            this.chkProxies.Location = new System.Drawing.Point(13, 21);
            this.chkProxies.Margin = new System.Windows.Forms.Padding(4);
            this.chkProxies.Name = "chkProxies";
            this.chkProxies.Size = new System.Drawing.Size(113, 21);
            this.chkProxies.TabIndex = 59;
            this.chkProxies.Text = "Use Proxies?";
            this.chkProxies.UseVisualStyleBackColor = true;
            // 
            // btnClearProxies
            // 
            this.btnClearProxies.Location = new System.Drawing.Point(385, 161);
            this.btnClearProxies.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearProxies.Name = "btnClearProxies";
            this.btnClearProxies.Size = new System.Drawing.Size(100, 28);
            this.btnClearProxies.TabIndex = 65;
            this.btnClearProxies.Text = "clear";
            this.btnClearProxies.UseVisualStyleBackColor = true;
            // 
            // txtProxies
            // 
            this.txtProxies.Enabled = false;
            this.txtProxies.Location = new System.Drawing.Point(13, 44);
            this.txtProxies.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxies.Multiline = true;
            this.txtProxies.Name = "txtProxies";
            this.txtProxies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProxies.Size = new System.Drawing.Size(363, 144);
            this.txtProxies.TabIndex = 58;
            // 
            // btnTestProxies
            // 
            this.btnTestProxies.Enabled = false;
            this.btnTestProxies.Location = new System.Drawing.Point(385, 89);
            this.btnTestProxies.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestProxies.Name = "btnTestProxies";
            this.btnTestProxies.Size = new System.Drawing.Size(123, 28);
            this.btnTestProxies.TabIndex = 60;
            this.btnTestProxies.Text = "test and clean";
            this.btnTestProxies.UseVisualStyleBackColor = true;
            // 
            // lblProxies
            // 
            this.lblProxies.AutoSize = true;
            this.lblProxies.Location = new System.Drawing.Point(385, 66);
            this.lblProxies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxies.Name = "lblProxies";
            this.lblProxies.Size = new System.Drawing.Size(46, 17);
            this.lblProxies.TabIndex = 63;
            this.lblProxies.Text = "status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 62;
            this.label13.Text = "Timeout (s):";
            // 
            // btnSaveProxies
            // 
            this.btnSaveProxies.Location = new System.Drawing.Point(385, 125);
            this.btnSaveProxies.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProxies.Name = "btnSaveProxies";
            this.btnSaveProxies.Size = new System.Drawing.Size(100, 28);
            this.btnSaveProxies.TabIndex = 64;
            this.btnSaveProxies.Text = "save proxies";
            this.btnSaveProxies.UseVisualStyleBackColor = true;
            // 
            // txtTimeoutProxies
            // 
            this.txtTimeoutProxies.Enabled = false;
            this.txtTimeoutProxies.Location = new System.Drawing.Point(326, 18);
            this.txtTimeoutProxies.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeoutProxies.Name = "txtTimeoutProxies";
            this.txtTimeoutProxies.Size = new System.Drawing.Size(49, 22);
            this.txtTimeoutProxies.TabIndex = 61;
            this.txtTimeoutProxies.Text = "30";
            // 
            // ProxyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 214);
            this.Controls.Add(this.chkProxies);
            this.Controls.Add(this.btnClearProxies);
            this.Controls.Add(this.txtProxies);
            this.Controls.Add(this.btnTestProxies);
            this.Controls.Add(this.lblProxies);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSaveProxies);
            this.Controls.Add(this.txtTimeoutProxies);
            this.Name = "ProxyGUI";
            this.Text = "ProxyGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkProxies;
        private System.Windows.Forms.Button btnClearProxies;
        private System.Windows.Forms.TextBox txtProxies;
        private System.Windows.Forms.Button btnTestProxies;
        private System.Windows.Forms.Label lblProxies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveProxies;
        private System.Windows.Forms.TextBox txtTimeoutProxies;
    }
}