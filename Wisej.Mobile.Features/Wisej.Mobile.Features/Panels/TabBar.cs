using System;
using System.Linq;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;
using System.ComponentModel;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Navigation")]
	public partial class TabBar : TestBase
	{
		public TabBar()
		{
			InitializeComponent();
		}

		private void TabBar_Load(object sender, EventArgs e)
		{
			Device.TabBar.Selected += TabBar_Selected;

			this.checkBoxVisible.Checked = Device.TabBar.Visible;

			this.color.Text = ColorTranslator.ToHtml(Device.TabBar.Color);
			this.backColor.Text = ColorTranslator.ToHtml(Device.TabBar.BackColor);
			this.selectedColor.Text = ColorTranslator.ToHtml(Device.TabBar.SelectedColor);

			UpdateButtons();
		}

		private void TabBar_Selected(object sender, DeviceTabBar.SelectedEventArgs e)
		{
			AlertBox.Show($"Selected {e.Button.Text}");
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.BackColor = ColorTranslator.FromHtml(this.selectedColor.Text);
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.TabBar.Visible = this.checkBoxVisible.Checked;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void UpdateButtons()
		{
			Device.TabBar.Buttons =
				this.flowLayoutPanelItems.Controls
					.Where(c => c is TabBarButton && ((TabBarButton)c).Show)
						.Select(c => ((TabBarButton)c).ToButton()).ToArray();
		}

		private void backColor_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.BackColor = ColorTranslator.FromHtml(this.backColor.Text);
		}

		private void color_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.Color = ColorTranslator.FromHtml(this.color.Text);
		}

		private void selectedColor_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.SelectedColor = ColorTranslator.FromHtml(this.selectedColor.Text);
		}

		private void TabBar_Disposed(object sender, EventArgs e)
		{
			Device.TabBar.Visible = false;
			Device.TabBar.Selected -= TabBar_Selected;
		}
	}
}
