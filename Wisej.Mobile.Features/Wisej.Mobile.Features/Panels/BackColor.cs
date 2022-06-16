using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class BackColor : TestBase
	{
		public BackColor()
		{
			InitializeComponent();
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
			Device.SetBackgroundColor(ColorTranslator.FromHtml(this.textBoxBackColor.Text));
		}

		private void BackColor_Disposed(object sender, EventArgs e)
		{
			Device.SetBackgroundColor(Color.FromArgb(253, 253, 253));
		}
	}
}
