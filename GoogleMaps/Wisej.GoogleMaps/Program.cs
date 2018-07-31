using System;
using Wisej.Web;

namespace Wisej.GoogleMaps
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.SessionTimeout += Application_SessionTimeout;

            Application.MainPage = new MapPage();
        }

        private static void Application_SessionTimeout(object sender, System.ComponentModel.HandledEventArgs e)
        {
            e.Handled = true;
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