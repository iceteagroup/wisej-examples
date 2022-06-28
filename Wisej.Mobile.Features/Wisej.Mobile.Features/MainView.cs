
using System;
using System.Drawing;
using Wisej.Mobile.Features.Panels;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features
{
	public partial class MainView : Page
	{
		private TestBase currentView;

		public MainView()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			// default view.
			SwitchView(typeof(Tests));

			if (Device.Valid)
				InitializeNative();
		}

		private void InitializeNative()
		{
			Device.SetBackgroundColor(Color.FromArgb(253, 253, 253));

			Device.Shake += Device_Shake;
			Device.Terminate += Device_Terminate;
			Device.ScreenAdded += this.Screen_Added;
			Device.ScreenRemoved += this.Screen_Removed;
			Device.PermissionStateChanged += Device_PermissionStateChanged;
		}

		private void SwitchView(Type type)
		{
			if (type.Equals(this.currentView?.GetType()))
				return;

			if (this.currentView != null)
			{
				this.currentView.ViewRequested -= View_ViewRequested;
				this.currentView.Dispose();
			}
			
			this.currentView = (TestBase)Activator.CreateInstance(type);
			
			this.currentView.Dock = DockStyle.Fill;
			this.currentView.ViewRequested += View_ViewRequested;

			this.panelContainer.Controls.Add(this.currentView);

			if (type.Equals(typeof(Tests)))
			{
				this.buttonBack.Hide();
				this.buttonPortal.Show();
			}
			else
			{
				this.buttonBack.Show();
				this.buttonPortal.Hide();
			}
		}

		private void View_ViewRequested(object sender, WidgetEventArgs e)
		{
			SwitchView(e.Data);
		}

		private void Device_PermissionStateChanged(object sender, DeviceEventArgs e)
		{
			AlertBox.Show($"Permission State Changed {e.Data.type}: {e.Data.result}");
		}   

		private void Device_Shake(object sender, DeviceEventArgs e)
		{
			new Toast("Shake").Show();
		}

		private void Device_Terminate(object sender, EventArgs e)
		{
			AlertBox.Show("Terminating...");
		}

		private void Screen_Removed(object sender, DeviceEventArgs e)
		{
			AlertBox.Show("A screen was removed from the device.");
		}

		private void Screen_Added(object sender, DeviceEventArgs e)
		{
			AlertBox.Show("A new screen was attached to the device.");
		}

		private void MainView_Disappear(object sender, EventArgs e)
		{
			Device.ScreenAdded -= this.Screen_Added;
			Device.ScreenRemoved -= this.Screen_Removed;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Navigate("http://demo.wisej.com/MobilePortal");
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SwitchView(typeof(Tests));
		}
	}
}
