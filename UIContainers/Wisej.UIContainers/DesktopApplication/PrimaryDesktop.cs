using System;
using Wisej.Web;

namespace DesktopApplication
{
	public partial class PrimaryDesktop : Desktop
	{
		public PrimaryDesktop()
		{
			InitializeComponent();
		}

		private void PrimaryDesktop_Load(object sender, EventArgs e)
		{
			var switchForm = Application.Session.switchWindow;
			switchForm.Show();

			var primaryForm = Application.Session.primaryWindow;
			primaryForm.Show();

			var secondaryForm = Application.Session.secondaryWindow;
			secondaryForm.Show();
		}
	}
}
