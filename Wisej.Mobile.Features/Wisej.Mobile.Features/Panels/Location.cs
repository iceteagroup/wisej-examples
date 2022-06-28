using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Navigation")]
	public partial class Location : TestBase
	{
		public Location()
		{
			InitializeComponent();
		}

		private async void buttonGetLocation_Click(object sender, EventArgs e)
		{
			if (this.checkBoxUseNativeLocationServices.Checked)
			{
				try
				{
					var position = Device.Location.GetPosition();

					this.labelLat.Text = $"Lat: {position.Lat}";
					this.labelLon.Text = $"Lon: {position.Lng}";
				} 
				catch (DeviceException ex)
				{
					AlertBox.Show(ex.Reason);
				}
			}
			else
			{
				// use browser geolocation integration.
				var position = await this.geolocation1.GetCurrentPositionAsync();

				this.labelLat.Text = $"Lat: {position.Latitude}";
				this.labelLon.Text = $"Lon: {position.Longitude}";
			}
			
		}
	}
}
