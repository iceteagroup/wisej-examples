
using System;
using Wisej.Web;

namespace EditorsChoice
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }
        // previous text
        string prevText = "";

        private void Window1_Load(object sender, EventArgs e)
        {
            // set defaults
            this.cbLiveSync.Checked = true;
            this.ckEditor1.Text = "Hello";                                
            this.timer1.Interval = 50;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // sync if text has changed
            if (cbLiveSync.Checked && this.ckEditor1.Text != prevText)
            {                
                this.ckEditor2.Text = this.ckEditor1.Text;
                this.Tinyeditor1.Text = this.ckEditor1.Text;
                this.tinyMCE1.Text = this.ckEditor1.Text;

                prevText = this.ckEditor1.Text;
            }
        }       
    }
}
