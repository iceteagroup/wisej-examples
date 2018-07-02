using System.ComponentModel;
using Wisej.Web;

namespace DataBinding
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            var main = new MainPage();
            main.Show();
            Application.SessionTimeout += Application_SessionTimeout;
        }

        private static void Application_SessionTimeout(object sender, HandledEventArgs e)
        {
            // you can display a form and override the default session timeout dialog.
            e.Handled = true;
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //private static void Main(NameValueCollection args)
        //{
        //}
    }
}