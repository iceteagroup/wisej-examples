
using System;
using Wisej.Web;

namespace KeyboardHandling
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.label2.Text = e.KeyChar.ToString();
		}
	}
}
