
using System;
using Wisej.Web;

namespace Wisej.Sample.ClrScript
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new frmCommandLine().Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            new frmEvents().Show();
        }
    }
}
