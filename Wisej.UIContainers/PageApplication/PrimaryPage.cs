using System;
using Wisej.Web;

namespace PageApplication
{
    public partial class PrimaryPage : Page
    {
        public PrimaryPage()
        {
            InitializeComponent();
        }

        private void PrimaryPage_Load(object sender, EventArgs e)
        {
            var switchForm = Program.SwitchWindow;
            switchForm.Show();

            var primaryForm = Program.PrimaryWindow;
            primaryForm.Show();

            var secondaryForm = Program.SecondaryWindow;
            secondaryForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var primaryForm = Program.PrimaryWindow;
            primaryForm.WindowState = FormWindowState.Normal;

            var secondaryForm = Program.SecondaryWindow;
            secondaryForm.WindowState = FormWindowState.Normal;
        }
    }
}