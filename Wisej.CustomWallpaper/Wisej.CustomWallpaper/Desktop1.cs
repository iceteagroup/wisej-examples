using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.CustomWallpaper
{
    public partial class Desktop1 : Desktop
    {
        public Desktop1()
        {
            InitializeComponent();
        }

        private void Desktop1_Load(object sender, EventArgs e)
        {
            ImageListEntry[] imageList = new ImageListEntry[3];
            imageList[0] = new ImageListEntry();
            imageList[0].Name = "blue";
            imageList[0].Image = Image.FromFile(Application.StartupPath + "/Wallpapers/" + "blue.png");

            imageList[1] = new ImageListEntry();
            imageList[1].Name = "purple";
            imageList[1].Image = Image.FromFile(Application.StartupPath + "/Wallpapers/" + "purple.png");

            imageList[2] = new ImageListEntry();
            imageList[2].Name = "orange";
            imageList[2].Image = Image.FromFile(Application.StartupPath + "/Wallpapers/" + "orange.png");


            this.customWallpaper.Images = imageList;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.customWallpaper.EnableAnimation = !this.customWallpaper.EnableAnimation;
        }

        private void btnFadingInterval_Click(object sender, EventArgs e)
        {
            this.customWallpaper.FadeTime = (int)nudFadingInterval.Value;
        }

        private void btnRotationInterval_Click(object sender, EventArgs e)
        {
            this.customWallpaper.RotationInterval = (int)nudRotationInterval.Value;
        }
    }
}
