using System;
using Wisej.Web;

namespace DesktopApplication
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main()
		{
			Application.Session.desktopPrimary = new PrimaryDesktop();
			Application.Session.desktopSecondary = new SecondaryDesktop();
			Application.Session.primaryWindow = new PrimaryForm();
			Application.Session.secondaryWindow = new SecondaryForm();
			Application.Session.switchWindow = new SwitchForm();

			Application.Desktop = Application.Session.desktopPrimary;
		}
	}
}