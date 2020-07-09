
using System;
using Wisej.Web;

namespace Wisej.NavigationBarTest
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.button1.Collapsed = !this.button1.Collapsed;
			this.flexLayoutPanel1.Visible = !this.button1.Collapsed;
		}

		private void panel1_ItemClick(object sender, Web.Ext.NavigationBar.NavigationBarItemClickEventArgs e)
		{
			this.label1.Text = e.Item.Text;
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			Application.ResponsiveProfileChanged += Application_ResponsiveProfileChanged;
		}

		private void Application_ResponsiveProfileChanged(object sender, ResponsiveProfileChangedEventArgs e)
		{
			if (Application.Browser.ScreenSize.Width < 700)
				this.panel1.CompactView = true;
			else
				this.panel1.CompactView = false;
		}

		private void panel1_TitleClick(object sender, EventArgs e)
		{
			this.panel1.CompactView = !this.panel1.CompactView;
		}
	}
}
