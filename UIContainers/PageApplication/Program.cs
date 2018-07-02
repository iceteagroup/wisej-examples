using System;
using Wisej.Web;

namespace PageApplication
{
    internal static class Program
    {
        internal static PrimaryPage PagePrimary { get; set; }
        internal static SecondaryPage PageSecondary { get; set; }
        internal static PrimaryForm PrimaryWindow { get; set; }
        internal static SecondaryForm SecondaryWindow { get; set; }
        internal static SwitchForm SwitchWindow { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            PagePrimary = new PrimaryPage();
            PageSecondary = new SecondaryPage();

            PrimaryWindow = new PrimaryForm();
            SecondaryWindow = new SecondaryForm();
            SwitchWindow = new SwitchForm();

            Application.MainPage = PagePrimary;
        }
    }
}