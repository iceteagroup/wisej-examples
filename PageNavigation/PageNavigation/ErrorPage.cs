using System;
using System.Drawing;
using Wisej.Web;

namespace PageNavigation
{
    public partial class ErrorPage : Page
    {
        public string FaultPageName { get; set; }
        public string Message { get; set; }

        private DateTimeOffset _startExit;

        public ErrorPage()
        {
            InitializeComponent();
        }

        private void ErrorPage_Appear(object sender, EventArgs e)
        {
            details.Text = $"There was a {Message} on {FaultPageName}." +
                           Environment.NewLine + Environment.NewLine +
                           "We should display some details of the error here.";

            continueButton.Text = @"Go back to " + FaultPageName;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Application.OpenPages[FaultPageName].Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            _startExit = DateTimeOffset.Now;
            AlertBox.Show("Exit the application...", MessageBoxIcon.Warning, true, ContentAlignment.BottomRight, 3000,
                AppExit, true);
        }

        private void AppExit()
        {
            var endExit = DateTimeOffset.Now;

            if ((endExit - _startExit).TotalMilliseconds >= 3000)
                Application.Exit();
        }
    }
}