
using System;
using Wisej.Web;

namespace TourPanelSample
{
	public partial class Window4 : Form
	{
		public Window4()
		{
			InitializeComponent();
		}

		

		private void Window4_Load(object sender, EventArgs e)
		{
			// hide/show label for Chrome Browser
			if (Application.Browser.Type == "Chrome")
				labelChrome.Visible = true;
			else
				labelChrome.Visible = false;

			this.ckEditor1.Text = "This is a CKEditor. It supports <font color=\"blue\">blue</font> text";
		}

		
	}
}
