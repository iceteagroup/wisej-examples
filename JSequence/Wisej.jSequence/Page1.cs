
using System;
using Wisej.Web;

namespace Wisej.Sequence
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if(this.txtSequence.Text.Length == 0)
            {
                MessageBox.Show("Text area shouldn't be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            this.sequence.UML = this.txtSequence.Text;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sequence.Theme = this.cmbTheme.Text;
        }

        private void cmbBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var borderStyle = BorderStyle.None;
            if (Enum.TryParse<BorderStyle>(cmbBorderStyle.Text, out borderStyle));
                this.sequence.BorderStyle = borderStyle;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            var image = await this.sequence.GetImageAsync();
            if (image != null)
                Application.Download(image, "jSeq" + DateTime.UtcNow.ToString() + ".png");
        }

        private async void btnPreview_Click(object sender, EventArgs e)
        {
            var image = await this.sequence.GetImageAsync();
            frmPreview oFrmPreview = new frmPreview();
            oFrmPreview.pictureBox1.Image = image;
            oFrmPreview.Show();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            this.cmbBorderStyle.SelectedIndex = 0;
            this.cmbTheme.SelectedIndex = 0; 
        }
    }
}
