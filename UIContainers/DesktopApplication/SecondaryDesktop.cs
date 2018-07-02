using System;
using Wisej.Web;

namespace DesktopApplication
{
    public partial class SecondaryDesktop : Desktop
    {
        public SecondaryDesktop()
        {
            InitializeComponent();
        }

        private void SecondaryDesktop_Load(object sender, EventArgs e)
        {
            var switchForm = Program.SwitchWindow;
            switchForm.Show();

            var primaryForm = Program.PrimaryWindow;
            primaryForm.Show();

            var secondaryForm = Program.SecondaryWindow;
            secondaryForm.Show();
        }
    }
}
