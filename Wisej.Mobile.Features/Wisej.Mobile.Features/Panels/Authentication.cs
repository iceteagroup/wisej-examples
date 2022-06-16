using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Security")]
	public partial class Authentication : TestBase
	{
		public Authentication()
		{
			InitializeComponent();
		}

		private void buttonAuthenticate_Click(object sender, EventArgs e)
		{
			try
			{
				Device.Authenticate(this.textBoxReason.Text);
				AlertBox.Show("Success!");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Authentication_Load(object sender, EventArgs e)
		{
			var image = "";
			switch (Device.Info.AuthenticationType)
			{
				case DeviceAuthenticationType.None:
					image = "none-id.png";
					break;

				case DeviceAuthenticationType.TouchID:
					image = "touch-id.png";
					break;

				case DeviceAuthenticationType.FaceID:
					image = "face-id.png";
					break;

				case DeviceAuthenticationType.Passcode:
					image = "passcode.png";
					break;

				case DeviceAuthenticationType.UnknownBiometric:
					image = "unknown.png";
					break;

			}

			this.pictureBoxAuthenticate.ImageSource = $"Images/{image}";
		}
	}
}
