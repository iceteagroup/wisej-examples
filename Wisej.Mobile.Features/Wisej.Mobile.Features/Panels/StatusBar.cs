using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web.Ext.MobileIntegration;
using static Wisej.Web.Ext.MobileIntegration.DeviceStatusbar;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class StatusBar : TestBase
	{
		public StatusBar()
		{
			InitializeComponent();
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.Statusbar.Visible = this.checkBoxStatusbar.Checked;
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
			Device.Statusbar.BackColor = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
		}

		private void comboBoxTextColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			var color = (string) comboBoxTextColor.SelectedItem;
			Device.Statusbar.ForeColor = (StatusBarForeColor) Enum.Parse(typeof(StatusBarForeColor), color);
		}

		private void StatusBar_Disposed(object sender, EventArgs e)
		{
			Device.Statusbar.Visible = true;
			Device.Statusbar.ForeColor = StatusBarForeColor.Black;
			Device.Statusbar.BackColor = Color.FromArgb(253, 253, 253);
		}
	}
}
