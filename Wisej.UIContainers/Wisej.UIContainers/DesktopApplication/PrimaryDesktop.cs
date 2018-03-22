using System;
using Wisej.Web;

namespace DesktopApplication
{
    public partial class PrimaryDesktop : Desktop
    {
        public PrimaryDesktop()
        {
            InitializeComponent();
        }

        private void PrimaryDesktop_Load(object sender, EventArgs e)
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
