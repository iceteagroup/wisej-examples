using System;
using Wisej.Web;

namespace Wisej.BingWallpaper
{
    public partial class MyDesktop : Desktop
    {
        public MyDesktop()
        {
            InitializeComponent();
        }

        private void btnFadingInterval_Click(object sender, EventArgs e)
        {
            this.bingWallpaper.FadeTime = (int)this.nudFadingInterval.Value;
        }

        private void btnRotationInterval_Click(object sender, EventArgs e)
        {
            this.bingWallpaper.RotationInterval = (int)this.nudRotationInterval.Value;
        }

        private void btnPictureCount_Click(object sender, EventArgs e)
        {
            this.bingWallpaper.MaxImages = (int)this.nudPictureCount.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.bingWallpaper.EnableAnimation = !this.bingWallpaper.EnableAnimation;
        }
    }
}
