using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class ProgressBar : TestBase
	{
		public ProgressBar()
		{
			InitializeComponent();
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.ProgressBar.SetVisible(this.checkBoxVisible.Checked);
		}

		private void trackBarValue_ValueChanged(object sender, EventArgs e)
		{
			Device.ProgressBar.SetProgress(this.trackBarValue.Value, true);
		}

		private void ProgressBar_Disposed(object sender, EventArgs e)
		{
			Device.ProgressBar.SetVisible(false);
		}
	}
}
