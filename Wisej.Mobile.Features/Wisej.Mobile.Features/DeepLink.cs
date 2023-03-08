using System;
using System.Net;
using Wisej.Web;


namespace Wisej.Mobile.Features
{
	public partial class DeepLink : Page
	{
		public DeepLink()
		{
			InitializeComponent();
		}

		private void buttonNavigate_Click(object sender, EventArgs e)
		{
			Application.Navigate($"wisej://{WebUtility.UrlEncode(this.textBox1.Text)}");
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.label1.Text = $"wisej://{WebUtility.UrlEncode(this.textBox1.Text)}";
		}
	}
}
