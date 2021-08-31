
using System;
using Wisej.JSWidgets.Views;
using Wisej.Web;

namespace Wisej.JSWidgets
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnJQueryKnob_Click(object sender, EventArgs e)
        {
            var window = new Views.frmJQueryKnob();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var window = new Views.frmBubbles();
            window.Show();
        }

        private void btnJustGage_Click(object sender, EventArgs e)
        {
            new frmJustGage().Show();
        }

        private void btnCoolClock_Click(object sender, EventArgs e)
        {
            new frmCoolClock().Show();
           
        }

        private void btnCountUp_Click(object sender, EventArgs e)
        {
            var window = new Views.frmCountUp();
            window.Show();
        }



    }
}
