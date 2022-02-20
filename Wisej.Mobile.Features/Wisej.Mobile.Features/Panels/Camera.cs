using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Media")]
	public partial class Camera : TestBase
	{
		public Camera()
		{
			InitializeComponent();
		}

		private void buttonPicture_Click(object sender, EventArgs e)
		{
			this.pictureBoxImage.ShowLoader = true;
			try
			{
				var image = Device.Camera.TakePicture((float)(this.trackBarQuality.Value / 10.0));
				this.pictureBoxImage.Image = image;
			} 
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
			this.pictureBoxImage.ShowLoader = false;
		}
	}
}
