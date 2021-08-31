using System;
using Wisej.Web;

namespace Wisej.JSWidgets.Views
{
    public partial class frmJustGage : Form
    {
        public frmJustGage()
        {
            InitializeComponent();
        }

        private void frmJustGage_Load(object sender, EventArgs e)
        {
            // Get initial values of properties of JustGaje
            //
            justGageTest.Minimum = (int)numericUpDown1.Value;
            justGageTest.Maximum = (int)numericUpDown2.Value;
            chkDonut.Checked = justGageTest.Donut;
            chkHumanFriendly.Checked = justGageTest.HumanFriendly;
            cbAnimationType.DataSource = Enum.GetNames(typeof(Web.Ext.JustGage.JustGage.JustGageAnimationType));
            trackBarGageChange.Minimum = (int)numericUpDown1.Value;
            trackBarGageChange.Maximum = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            justGageTest.Minimum = (int)numericUpDown1.Value;
            trackBarGageChange.Minimum = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            justGageTest.Maximum = (int)numericUpDown2.Value;
            trackBarGageChange.Maximum = (int)numericUpDown2.Value;
        }

        private void chkDonut_CheckedChanged(object sender, EventArgs e)
        {
            justGageTest.Donut = chkDonut.Checked;
        }

        private void chkHumanFriendly_CheckedChanged(object sender, EventArgs e)
        {
            justGageTest.HumanFriendly = chkHumanFriendly.Checked;
        }

        private void cbAnimationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Web.Ext.JustGage.JustGage.JustGageAnimationType OptionSelected;

            if (cbAnimationType.SelectedValue != null)
            {
                Enum.TryParse<Web.Ext.JustGage.JustGage.JustGageAnimationType>(cbAnimationType.SelectedValue.ToString(), out OptionSelected);

                this.justGageTest.RefreshAnimationType = OptionSelected;
            }
        }

        private void trackBarGageChange_ValueChanged(object sender, EventArgs e)
        {
            justGageTest.Value = trackBarGageChange.Value;
        }
    }
}
