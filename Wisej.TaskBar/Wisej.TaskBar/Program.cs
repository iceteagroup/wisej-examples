using System;
using Wisej.TaskBar.Pages;
using Wisej.Web;

namespace Wisej.TaskBar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
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