using System;
using Wisej.Web;
using Wisej.Web.Ext.CountUp;
namespace Wisej.JSWidgets.Views
{
    public partial class frmCountUp : Form
    {
        public frmCountUp()
        {
            InitializeComponent();
        }

        private void btnApplyValue_Click(object sender, EventArgs e)
        {
            this.countUp1.Value = (float)this.nudNewValue.Value;
        }

        private void chkGrouping_CheckedChanged(object sender, EventArgs e)
        {
            this.countUp1.UseGrouping = !this.countUp1.UseGrouping;
        }

        private void chkEasing_CheckedChanged(object sender, EventArgs e)
        {
            this.countUp1.UseEasing = !this.countUp1.UseEasing;
        }

        private void btnNewDuration_Click(object sender, EventArgs e)
        {
            this.countUp1.Duration = (int)this.nudDuration.Value;
        }
    }
}
