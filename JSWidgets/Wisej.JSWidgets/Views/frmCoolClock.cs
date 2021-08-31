using System;
using Wisej.Web;

namespace Wisej.JSWidgets.Views
{
    public partial class frmCoolClock : Form
    {
        public frmCoolClock()
        {
            InitializeComponent();
        }

        private void frmCoolClock_Load(object sender, EventArgs e)
        {
            cbClockSkin.DataSource = Enum.GetNames(typeof(Web.Ext.CoolClock.CoolClockSkin));
            cbClockType.DataSource = Enum.GetNames(typeof(Web.Ext.CoolClock.CoolClockType));
        }

        private void cbClockSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Web.Ext.CoolClock.CoolClockSkin OptionSelected;

            if (cbClockSkin.SelectedValue != null)
            {
                Enum.TryParse<Web.Ext.CoolClock.CoolClockSkin>(cbClockSkin.SelectedValue.ToString(), out OptionSelected);

                this.coolClock1.Skin = OptionSelected;
            }
        }

        private void cbClockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Web.Ext.CoolClock.CoolClockType OptionSelected;

            if (cbClockType.SelectedValue != null)
            {
                Enum.TryParse<Web.Ext.CoolClock.CoolClockType>(cbClockType.SelectedValue.ToString(), out OptionSelected);

                this.coolClock1.ClockType = OptionSelected;
            }
        }
    }
}
