
using System;
using Wisej.Web;
using Report.Views;

namespace Report
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fReport = new frmReport();

            fReport.ShowDialog();
        }
    }
}
