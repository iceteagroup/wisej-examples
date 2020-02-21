using System;
using Wisej.Web;

namespace PageApplication
{
	public partial class PrimaryPage : Page
	{
		public PrimaryPage()
		{
			InitializeComponent();
		}

		private void PrimaryPage_Load(object sender, EventArgs e)
		{
			var switchForm = Application.Session.switchWindow;
			switchForm.Show();

			var primaryForm = Application.Session.primaryWindow;
			primaryForm.Show();

			var secondaryForm = Application.Session.secondaryWindow;
			secondaryForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var primaryForm = Application.Session.primaryWindow;
			primaryForm.WindowState = FormWindowState.Normal;

			var secondaryForm = Application.Session.secondaryWindow;
			secondaryForm.WindowState = FormWindowState.Normal;
		}
	}
}