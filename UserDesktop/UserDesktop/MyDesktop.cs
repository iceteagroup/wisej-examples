using System;
using System.Drawing;
using Wisej.Web;

namespace UserDesktop
{
	public partial class MyDesktop : Wisej.Web.Desktop
	{
		public MyDesktop()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Window1().Show();
		}

		private void buttonTheme_CheckedChanged(object sender, EventArgs e)
		{
			var button = (RadioButton)sender;
			if (button.Checked)
				Application.LoadTheme(button.Text);
		}
	}
}
