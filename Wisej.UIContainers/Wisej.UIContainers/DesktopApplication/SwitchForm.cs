using System;
using Wisej.Web;

namespace DesktopApplication
{
	public partial class SwitchForm : Form
	{
		public SwitchForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Application.Desktop.GetType() == typeof(SecondaryDesktop))
				Application.Desktop = Application.Session.desktopPrimary;
			else
				Application.Desktop = Application.Session.desktopSecondary;
		}
	}
}
