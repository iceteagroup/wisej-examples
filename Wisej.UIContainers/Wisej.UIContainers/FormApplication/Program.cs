using System;
using Wisej.Web;

namespace FormApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            PrimaryForm primaryForm = new PrimaryForm();
            primaryForm.Show();

            SecondaryForm secondaryForm = new SecondaryForm();
            secondaryForm.Show();
        }
    }
}