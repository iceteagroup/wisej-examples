using System.ComponentModel;
using Wisej.Web;

namespace PageNavigation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Session.Username = string.Empty;

            Application.ThreadException += Application_ThreadException;
            Application.SessionTimeout += Application_SessionTimeout;

            Navigation.Navigate(typeof(Login));
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string faultPageName = Application.MainPage.Name;
            ErrorPage page = (ErrorPage) Application.OpenPages["ErrorPage"];
            if (page != null)
            {
                page.FaultPageName = faultPageName;
                page.Message = e.Exception.Message;
                page.Show();
            }
            else
            {
                new ErrorPage {FaultPageName = faultPageName, Message = e.Exception.Message}.Show();
            }
        }

        private static void Application_SessionTimeout(object sender, HandledEventArgs e)
        {
            // override default timeout management
            e.Handled = true;

            // use your own timeout manager
            //TimeoutManager.DoManage();
        }
    }
}