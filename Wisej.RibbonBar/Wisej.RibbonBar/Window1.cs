
using System;
using System.IO;
using Wisej.Web;
using Wisej.Web.Ext.RibbonBar;

namespace Wisej.RibbonBar
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void RibbonBar_MenuButtonItemClick(object sender, RibbonBarMenuItemEventArgs e)
		{
			var button = e.Item;
			AlertBox.Show(button.ToString() + " => " + e.Item.ToString());
		}

		private void ribbonBar_ItemClick(object sender, Web.Ext.RibbonBar.RibbonBarItemEventArgs e)
		{
			AlertBox.Show(e.Item.ToString(), showProgressBar: true);
		}

		private void themePicker1_ThemeClicked(object sender, EventArgs e)
		{
			AlertBox.Show("Theme changed.", showProgressBar: false);
			Application.LoadTheme(Path.GetFileNameWithoutExtension(this.themePicker1.SelectedTheme));
		}

		private void ribbonBar_GroupClick(object sender, RibbonBarGroupEventArgs e)
		{
			AlertBox.Show(e.Group.ToString(), showProgressBar: true);
		}

		private void ribbonBar_AppButtonClick(object sender, EventArgs e)
		{
			AlertBox.Show("App Button Clicked");
		}

		private void ribbonBar_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("Tool Click: " + e.Tool.Name);

		}
	}
}
