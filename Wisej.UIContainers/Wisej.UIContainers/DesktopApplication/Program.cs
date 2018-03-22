using System;
using Wisej.Web;

namespace DesktopApplication
{
    internal static class Program
    {
        internal static PrimaryDesktop DesktopPrimary { get; set; }
        internal static SecondaryDesktop DesktopSecondary { get; set; }
        internal static PrimaryForm PrimaryWindow { get; set; }
        internal static SecondaryForm SecondaryWindow { get; set; }
        internal static SwitchForm SwitchWindow { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            DesktopPrimary = new PrimaryDesktop();
            DesktopSecondary = new SecondaryDesktop();

            PrimaryWindow = new PrimaryForm();
            SecondaryWindow = new SecondaryForm();
            SwitchWindow = new SwitchForm();

            Application.Desktop = DesktopPrimary;
        }
    }
}