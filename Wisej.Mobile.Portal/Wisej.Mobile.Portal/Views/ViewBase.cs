using System;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Portal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		public ViewBase()
		{
			InitializeComponent();
		}

		private void ViewBase_Load(object sender, EventArgs e)
		{
			if (Device.Valid)
			{
				ApplyOrientationSizing();
				Device.OrientationChanged += Device_OrientationChanged;
			}
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
