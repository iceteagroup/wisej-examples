
using System;
using Wisej.Web;

namespace UserDesktop
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = "You can type, but you can't save. This is just a demo window.";
		}
	}
}
