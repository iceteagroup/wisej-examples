using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Mobile.Features.Panels
{
	public partial class Tests : TestBase
	{
		public Tests()
		{
			InitializeComponent();
		}

		private int _itemWidth;

		private void Apps_Load(object sender, EventArgs e)
		{
			// ScreenSize is different on Android vs. iOS.
			var screenSize = Application.Browser.ScreenSize;
			var screenWidth = Math.Min(screenSize.Width, screenSize.Height);
			
			this._itemWidth = (screenWidth - 32) / 2 - 20;

			LoadApps();
		}

		private void LoadApps()
		{
			var asm = GetType().Assembly;
			var apps = asm.GetTypes()
				.Where(t => t != typeof(TestBase) && t != typeof(Tests) && typeof(TestBase).IsAssignableFrom(t))
				.Select(t => new AppItemView(t) { Width = this._itemWidth })
				.ToArray();

			foreach (var app in apps)
			{
				app.ViewRequested += App_ViewRequested;
				this.flowLayoutPanelApps.Controls.Add(app);
			}
		}

		private void App_ViewRequested(object sender, WidgetEventArgs e)
		{
			this.OnViewRequested(e);
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
