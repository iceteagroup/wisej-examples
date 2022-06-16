using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Navigation")]
	public partial class BackButton : TestBase
	{
		public BackButton()
		{
			InitializeComponent();
		}

		private void BackButton_Load(object sender, EventArgs e)
		{
			Device.BackButtonPressed += Device_BackButtonPressed;
		}

		private void Device_BackButtonPressed(object sender, DeviceEventArgs e)
		{
			AlertBox.Show("Back button pressed.");
		}

		private void BackButton_Disposed(object sender, EventArgs e)
		{
			Device.BackButtonPressed -= Device_BackButtonPressed;
		}
	}
}
