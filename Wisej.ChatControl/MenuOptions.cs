using System;
using Wisej.Web;

namespace Wisej.ChatControl
{
	public partial class MenuOptions : UserControl
	{
		public MenuOptions()
		{
			InitializeComponent();
		}

		public MenuOptions(string item1, string item2, string item3) : this()
		{
			this.button1.Text = item1;
			this.button2.Text = item2;
			this.button3.Text = item3;
		}

		public event EventHandler<string> MenuItemClicked;

		private void button_Click(object sender, EventArgs e)
		{
			MenuItemClicked?.Invoke(this, ((Button)sender).Text);
		}
	}
}
