using System;
using Wisej.Web;

namespace PageNavigation
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Unknown Issue");
        }
    }
}