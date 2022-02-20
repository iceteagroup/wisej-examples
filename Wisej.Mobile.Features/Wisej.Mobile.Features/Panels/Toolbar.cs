using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Navigation")]
	public partial class Toolbar : TestBase
	{
		public Toolbar()
		{
			InitializeComponent();
		}

		private void Toolbar_Load(object sender, EventArgs e)
		{
			Device.Toolbar.Click += Toolbar_Click;

			this.checkBoxVisible.Checked = Device.Toolbar.Visible;
			this.color.Text = ColorTranslator.ToHtml(Device.Toolbar.Color);
			this.backColor.Text = ColorTranslator.ToHtml(Device.Toolbar.BackColor);

			UpdateButtons();
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.Toolbar.Visible = this.checkBoxVisible.Checked;
		}

		private void backColor_TextChanged(object sender, EventArgs e)
		{
			Device.Toolbar.BackColor = ColorTranslator.FromHtml(this.backColor.Text);
		}

		private void color_TextChanged(object sender, EventArgs e)
		{
			Device.Toolbar.Color = ColorTranslator.FromHtml(this.color.Text);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void Toolbar_Click(object sender, DeviceToolbar.ClickEventArgs e)
		{
			Device.Popups.Alert("Event", $"Clicked button no: {Array.IndexOf(Device.Toolbar.Buttons, e.Button)}");
		}

		private void UpdateButtons()
		{
			Device.Toolbar.Buttons =
				this.flowLayoutPanelItems.Controls
					.Where(c => c is ToolbarButton && ((ToolbarButton)c).Show)
						.Select(c => ((ToolbarButton)c).ToButton()).ToArray();
		}

		private void Toolbar_Disposed(object sender, EventArgs e)
		{
			Device.Toolbar.Visible = false;
			Device.Toolbar.Click -= Toolbar_Click;
		}
	}
}
