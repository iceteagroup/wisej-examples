using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class Flashlight : TestBase
	{
		public Flashlight()
		{
			InitializeComponent();
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			try
			{
				Device.Camera.SetFlashlight(true);
				AlertBox.Show("Success");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void buttonOff_Click(object sender, EventArgs e)
		{
			try
			{
				Device.Camera.SetFlashlight(false);
				AlertBox.Show("Success");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Flashlight_Disposed(object sender, EventArgs e)
		{
			try
			{
				Device.Camera.SetFlashlight(false);
			} catch { }
		}
	}
}
