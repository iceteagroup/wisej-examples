using System;
using System.ComponentModel;
using System.IO;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Alerts")]
	public partial class Notifications : TestBase
	{
		public Notifications()
		{
			InitializeComponent();
		}

		private void Notifications_Load(object sender, EventArgs e)
		{
			Device.ReceivedNotification += Device_ReceivedNotification;
			Device.SubscribedNotifications += Device_SubscribedNotifications;

			if (Device.Info.Notifications)
				this.textBoxToken.Text = Device.Info.DeviceToken;
			else
				Device.RequestPermission(Device.PermissionType.Notifications);
		}

		private void Device_ReceivedNotification(object sender, DeviceEventArgs e)
		{
			AlertBox.Show($"Received {e.Data}");
		}

		private void Device_SubscribedNotifications(object sender, DeviceEventArgs e)
		{
			this.textBoxToken.Text = Device.Info.DeviceToken;
		}

		private void buttonPushNotification_Click(object sender, EventArgs e)
		{
			var title = this.textBoxTitle.Text;
			var sound = this.checkBoxSound.Checked;
			var message = this.textBoxMessage.Text;
			var badge = (int)this.numericUpDownBadge.Value;

			NotificationResponse result;

			if (Device.Info.SystemName == "iOS")
			{
				var certPath = Application.MapPath("Data\\Certificates.p12");
				if (!File.Exists(certPath))
				{
					AlertBox.Show("Missing .p12 certificate.");
					return;
				}
					
				result = NotificationManager.PushiOS("com.iceteagroup.wisej.mobile", new string[] { Device.Info.DeviceToken }, certPath, "", new
				{
					aps = new
					{
						alert = new
						{
							title = title,
							body = message,
						},
						badge = badge,
						sound = sound ? "default" : null
					}
				});
			} 
			else
			{
				var serverKeyPath = Application.MapPath("Data/ServerAuthKey.lic");
				if (!File.Exists(serverKeyPath))
				{
					AlertBox.Show("Missing FCM Server Key");
					return;
				}

				var serverKey = File.ReadAllText(serverKeyPath);
				result = NotificationManager.PushAndroid(serverKey, new
				{
					to = Device.Info.DeviceToken,
					notification = new
					{
						title = title,
						body = message,
						sound = sound ? "default" : null
					}
				});
			}

			AlertBox.Show(result.ToString());
			if (!result.Success)
				File.WriteAllText(Application.MapPath("Notification.log"), result.ToString());
		}
	}
}