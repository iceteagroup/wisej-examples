using System;
using System.Net.NetworkInformation;
using Wisej.Web;

namespace Wisej.JSWidgets.Views
{
    public partial class frmJQueryKnob : Form
    {
        private readonly Random _random;
        private readonly Ping _ping;
        public frmJQueryKnob()
        {
            InitializeComponent();
            _random = new Random();
            _ping = new Ping();
            timerCurrentTime.Start();
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            knobRandom.Value = _random.Next(1, 99);

            var currentDate = DateTime.Now;
            
            knobHour.Value = currentDate.Hour;
            knobMinute.Value = currentDate.Minute;
            knobSecond.Value = currentDate.Second;
            lblCurrentTime.Text = currentDate.ToLongTimeString();
        }

        private void frmJQueryKnob_Load(object sender, EventArgs e)
        {
            this.cmbLineStyle.DataSource = Enum.GetNames(typeof(Web.Ext.jQueryKnob.LineCapType));

            this.cmbKnobStyle.DataSource = Enum.GetNames(typeof(Web.Ext.jQueryKnob.KnobType));

            this.cmbBorderStyle.DataSource = Enum.GetNames(typeof(Wisej.Web.BorderStyle));
        }

        private void cmbLineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Web.Ext.jQueryKnob.LineCapType OptionSelected;

            if (cmbLineStyle.SelectedValue != null)
            {
                Enum.TryParse<Web.Ext.jQueryKnob.LineCapType>(cmbLineStyle.SelectedValue.ToString(), out OptionSelected);

                this.knobCustom.LineCapStyle = OptionSelected;
            }
        }

        private void cmbKnobStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Web.Ext.jQueryKnob.KnobType OptionSelected;

            if (cmbKnobStyle.SelectedValue != null)
            {
                Enum.TryParse<Web.Ext.jQueryKnob.KnobType>(cmbKnobStyle.SelectedValue.ToString(), out OptionSelected);

                this.knobCustom.KnobType = OptionSelected;
            }
        }

        private void cmbBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wisej.Web.BorderStyle OptionSelected;

            if (cmbBorderStyle.SelectedValue != null)
            {
                Enum.TryParse<Wisej.Web.BorderStyle>(cmbBorderStyle.SelectedValue.ToString(), out OptionSelected);

                this.knobCustom.BorderStyle = OptionSelected;
            }
        }

 
    }
}
