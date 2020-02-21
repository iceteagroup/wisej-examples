using System;
using Wisej.Web;

namespace PageApplication
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main()
		{

			Application.Session.pagePrimary = new PrimaryPage();
			Application.Session.pageSecondary = new SecondaryPage();
			Application.Session.primaryWindow = new PrimaryForm();
			Application.Session.secondaryWindow = new SecondaryForm();
			Application.Session.switchWindow = new SwitchForm();

			Application.MainPage = Application.Session.pagePrimary;
		}
	}
}