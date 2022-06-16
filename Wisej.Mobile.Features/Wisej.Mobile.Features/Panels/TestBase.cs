using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	public partial class TestBase : UserControl
	{
		public event WidgetEventHandler ViewRequested;

		public void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		public TestBase()
		{
			InitializeComponent();
		}

		private void TestBase_Load(object sender, EventArgs e)
		{
			if (Device.Valid)
			{
				ApplyOrientationSizing();
				Device.OrientationChanged += Device_OrientationChanged;
			}

			this.labelTitle.Text = String.Join(" ", Regex.Split(this.GetType().Name, @"(?<!^)(?=[A-Z])"));
		}

		private void Device_OrientationChanged(object sender, DeviceEventArgs e)
		{
			ApplyOrientationSizing();
		}

		private void ApplyOrientationSizing()
		{
			var width = Application.Browser.Size.Width;
			var height = Application.Browser.Size.Height;

			var portrait = Math.Min(width, height) == width;

			if (!portrait)
				MinimizeTitle();	
			else
				MaximizeTitle();
		}

		public void MinimizeTitle()
		{
			this.labelTitle.Height = 60;
			this.labelTitle.Font = new System.Drawing.Font("@windowTitleLandscape", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
		}

		public void MaximizeTitle()
		{
			this.labelTitle.Height = 128;
			this.labelTitle.Font = new System.Drawing.Font("@windowTitle", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
		}
	}
}
