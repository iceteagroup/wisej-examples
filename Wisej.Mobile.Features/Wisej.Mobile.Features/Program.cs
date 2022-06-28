using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			//if (Device.Valid)
				Application.MainPage = new MainView();
			//else
			//	Application.Navigate("Unavailable/Default.html");
		}
	}
}