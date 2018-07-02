using System;
using System.Globalization;
using Wisej.Web;

namespace Wisej.RibbonBar
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			//Application.CurrentCulture = CultureInfo.GetCultureInfo("de");
			new Window1().Show();
			new Window1().Show();
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