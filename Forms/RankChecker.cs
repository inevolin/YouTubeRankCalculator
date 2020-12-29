using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YTR.Forms
{
    public partial class RankChecker : Form
    {
        public RankChecker()
        {
            InitializeComponent();
        }

        private void btnKeywordRankChecker_Click(object sender, EventArgs e)
        {
            if (txtKeywordRankChecker.Text.Length <= 1)
            { MessageBox.Show("Keywords are missing"); return; }

            if (txtVideoRankCheck.Text.Length <= 1)
            { MessageBox.Show("URL/Video ID missing"); return; }

            try
            {


            }
            catch (Exception) { MessageBox.Show("Unable to Check Rank Error #RNKCHK1", "Unexpected error"); }
        }

        //RankChecker
        private void rc_lw(int i, int count)
        {
            lblRankChecker.Invoke((MethodInvoker)delegate
            {
                if (count != 0)
                {
                    lblRankChecker.Text = "I'm working..." + " (" + i + "/" + count + ")";
                    lblRankChecker.ForeColor = Color.Red;
                }
                else
                {
                    if (!lblRankChecker.Text.Contains("/"))
                    {
                        lblRankChecker.Text = "I'm working...";
                        lblRankChecker.ForeColor = Color.Red;
                    }
                }
            });
        }
        private void rc_ld()
        {
            lblRankChecker.Invoke((MethodInvoker)delegate
            {
                lblRankChecker.Text = "I'm done!";
                lblRankChecker.ForeColor = Color.Green;
            });
        }

        private void btnClearGridRC_Click(object sender, EventArgs e)
        {
            dgvRankChecker.Rows.Clear();
        }

    }
}
