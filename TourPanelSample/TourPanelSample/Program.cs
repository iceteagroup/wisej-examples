using System;
using Wisej.Web;

namespace TourPanelSample
{
	static class Program
	{				
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Desktop = new MyDesktop();

			Window1 window = new Window1();
			window.Show();

			Window2 window2 = new Window2();
			window2.Show();

			Window3 window3 = new Window3();
			window3.Show();

			Window4 window4 = new Window4();
			window4.Show();

			Window5 window5 = new Window5();
			window5.Show();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}