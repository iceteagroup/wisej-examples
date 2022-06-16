using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Portal
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			if (Device.Valid)
			{
				var savedApp = (string)Device.UserData["savedApp"];
				if (!string.IsNullOrEmpty(savedApp))
					Application.Navigate(savedApp);

				Application.MainPage = new MainView();
			}
			else
			{
				Application.Navigate("Unavailable/Default.html");
			}

			Application.SessionTimeout += Application_SessionTimeout;
		}

		private static void Application_SessionTimeout(object sender, HandledEventArgs e)
		{
			e.Handled = true;
		}
	}
}