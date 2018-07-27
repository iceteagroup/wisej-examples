using Wisej.Web;

namespace RuntimeLocalization
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //Application.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("fr");

            Application.MainPage = new Page1();
        }
    }
}