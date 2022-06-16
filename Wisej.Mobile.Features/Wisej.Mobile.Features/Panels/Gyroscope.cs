using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class Gyroscope : TestBase
	{
		public Gyroscope()
		{
			InitializeComponent();
		}

		private void Gyroscope_Load(object sender, EventArgs e)
		{
			Device.GyroscopeUpdate += Device_GyroscopeUpdate;
		}

		private void Gyroscope_Appear(object sender, EventArgs e)
		{
			try
			{
				Device.Sensors.StartGyro();
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Device_GyroscopeUpdate(object sender, DeviceEventArgs e)
		{
			this.labelX.Text = $"X: {e.Data.x}";
			this.labelY.Text = $"Y: {e.Data.y}";
			this.labelZ.Text = $"Z: {e.Data.z}";
		}

		private void Gyroscope_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.StopGyro();
			Device.GyroscopeUpdate -= Device_GyroscopeUpdate;
		}
	}
}
