using System;
using System.Drawing;
using Wisej.Web;

namespace MDIExample
{
    public partial class Modeless : Form
    {
        public Modeless()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modeless_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}