using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Mobile.Portal.Views
{
	public partial class Apps : ViewBase
	{
		public BindingList<App> AppList = new BindingList<App>();

		public Apps()
		{
			InitializeComponent();
		}

		private int _itemWidth;

		private void Apps_Load(object sender, EventArgs e)
		{
			var screenSize = Application.Browser.ScreenSize;
			var screenWidth = Math.Min(screenSize.Width, screenSize.Height);
			
			this._itemWidth = (screenWidth - 32) / 2 - 20;

			var features = new AppItemView("Features", "http://demo.wisej.com/MobileTest")
			{
				Width = this._itemWidth
			};

			this.flowLayoutPanelApps.Controls.Add(features);

			LoadApps();
		}

		private async void buttonAdd_Click(object sender, EventArgs e)
		{
			var title = await Application.PromptAsync("Enter Application Name");
			if (string.IsNullOrEmpty(title))
				return;

			var url = await Application.PromptAsync("Enter Application URL", "http://");
			if (String.IsNullOrEmpty(url))
				return;

			if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
			{
				AlertBox.Show($"{url} is not a valid URL.");
				return;
			}	

			var appItem = new AppItemView(title, url)
			{
				Width = this._itemWidth
			};
			appItem.Save();

			this.flowLayoutPanelApps.Controls.Add(appItem);
		}

		private void LoadApps()
		{
			var apps = App.Load();
			foreach (var app in apps)
			{
				var appView = new AppItemView(app)
				{
					Width = this._itemWidth
				};
				this.flowLayoutPanelApps.Controls.Add(appView);
			}
		}

		private void flowLayoutPanelApps_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue == 0)
				this.MaximizeTitle();
			else
				this.MinimizeTitle();
		}
	}
}
