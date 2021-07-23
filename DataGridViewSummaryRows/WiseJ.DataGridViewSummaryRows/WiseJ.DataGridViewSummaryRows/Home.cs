using System;
using Wisej.Web;


namespace WiseJ.DataGridViewSummaryRows
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btnSummaryGroup_Click(object sender, EventArgs e)
        {
            
            frmSummaryGroup window = new frmSummaryGroup();
            window.StartPosition = FormStartPosition.CenterParent;
            window.Show();

        }

        private void btnCase1_Click(object sender, EventArgs e)
        {
            frmSummaryHugeData1 window = new frmSummaryHugeData1();
            window.StartPosition = FormStartPosition.CenterParent;
            window.Show();
        }

        private void btnCase2_Click(object sender, EventArgs e)
        {
            frmSummaryHugeData2 window = new frmSummaryHugeData2();
            window.StartPosition = FormStartPosition.CenterParent;
            window.Show();
        }

        private void btnAllCallsSummary_Click(object sender, EventArgs e)
        {
            frmSummaryAllCalls window = new frmSummaryAllCalls();
            window.StartPosition = FormStartPosition.CenterParent;
            window.Show();
        }
    }
}
