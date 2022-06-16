
using System;
using System.Drawing;
using System.Threading;
using Wisej.Ext.MaterialDesign;
using Wisej.Mobile.Portal.Views;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Portal
{
	public partial class MainView : Page
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void MainView_Load(object sender, EventArgs e)
		{	
			var apps = new Apps();
			apps.Dock = DockStyle.Fill;
			this.Controls.Add(apps);

			SetupNative();
		}

		private void SetupNative()
		{
			var color = Color.FromArgb(253, 253, 253);
			
			Device.SetBackgroundColor(color);

			Device.Statusbar.ForeColor = DeviceStatusbar.StatusBarForeColor.Black; 
			Device.Statusbar.BackColor = color;

			Device.TabBar.Selected += TabBar_Selected;
			Device.TabBar.Color = Color.Black;
			Device.TabBar.BackColor = color;
			Device.TabBar.Buttons = new[]
			{
				new DeviceTabBar.Button {
					Text = "Apps",
					IconSource = Icons.ShowAppsButton
				},
				new DeviceTabBar.Button {
					Text = "Bind",
					IconSource = Icons.LockedPadlockOutline
				}
			};
			Device.TabBar.Buttons[0].Selected = true;
			Device.TabBar.Visible = true;
		}

		private void TabBar_Selected(object sender, DeviceTabBar.SelectedEventArgs e)
		{
			switch (e.Button.Text)
			{
				case "Apps":
					SwitchView(typeof(Apps));
					break;

				case "Bind":
					SwitchView(typeof(Bind));
					break;

			}
		}

		private ViewBase SwitchView(Type type)
		{
			ViewBase control = null;

			foreach (ViewBase openControl in this.Controls)
			{
				if (openControl.GetType() == type)
				{
					openControl.Visible = true;
					control = openControl;
				}
				else
				{
					openControl.Visible = false;
				}
			}

			if (control == null)
			{
				control = (ViewBase)Activator.CreateInstance(type);
				this.Controls.Add(control);
				control.Dock = DockStyle.Fill;
			}
			return control;
		}
	}
}
