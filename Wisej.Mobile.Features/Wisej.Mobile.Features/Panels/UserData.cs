using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Storage")]
	public partial class UserData : TestBase
	{
		public UserData()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Device.UserData = this.textBox1.Text;
			Device.UserData["myTest"] = this.textBoxUserData.Text;

			new Toast("Saved Data").Show();
		}

		private void UserData_Load(object sender, EventArgs e)
		{
			if (Device.UserData.ContainsKey("myTest"))
				this.textBoxUserData.Text = Device.UserData["myTest"].ToString();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			Device.UserData.Remove("myTest");
			this.textBoxUserData.Text = "";

			new Toast("Cleared").Show();
		}
	}
}
