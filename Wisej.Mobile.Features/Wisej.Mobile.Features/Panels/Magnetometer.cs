using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class Magnetometer : TestBase
	{
		public Magnetometer()
		{
			InitializeComponent();
		}

		private void Magnetometer_Load(object sender, EventArgs e)
		{
			Device.MagnetometerUpdate += Device_MagnetometerUpdate;
		}

		private void Magnetometer_Appear(object sender, EventArgs e)
		{
			try
			{
				Device.Sensors.StartMagnetometer();
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Device_MagnetometerUpdate(object sender, DeviceEventArgs e)
		{
			this.labelX.Text = $"X: {e.Data.x}";
			this.labelY.Text = $"Y: {e.Data.y}";
			this.labelZ.Text = $"Z: {e.Data.z}";
		}

		private void Magnetometer_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.StopMagnetometer();
			Device.MagnetometerUpdate -= Device_MagnetometerUpdate;
		}
	}
}
