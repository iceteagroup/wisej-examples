
using System;
using Wisej.Web;

namespace Wisej.Pannellum
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();

			this.pannellum1.WidgetEvent += Pannellum1_WidgetEvent;
		}

		private void Pannellum1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			if (e.Type == "hotspot")
				AlertBox.Show(e.Data.text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.pannellum1.Options = new
			{
				type = "equirectangular",
				autoLoad = true,
				panorama = "https://pannellum.org/images/alma.jpg"
			};
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.pannellum1.Options = new
			{
				type = "equirectangular",
				autoLoad = true,
				autoRotate = -2,
				panorama = "https://pannellum.org/images/alma.jpg"
			};
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.pannellum1.Options = new
			{
				type = "cubemap",
				autoLoad = true,
				cubeMap = new[] {
					"https://pannellum.org/images/wyman-park-playground-cubic/face0.jpg",
					"https://pannellum.org/images/wyman-park-playground-cubic/face1.jpg",
					"https://pannellum.org/images/wyman-park-playground-cubic/face2.jpg",
					"https://pannellum.org/images/wyman-park-playground-cubic/face3.jpg",
					"https://pannellum.org/images/wyman-park-playground-cubic/face4.jpg",
					"https://pannellum.org/images/wyman-park-playground-cubic/face5.jpg" }
			};
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.pannellum1.Options = new
			{
				type = "equirectangular",
				autoLoad = true,
				autoRotate = -2,
				panorama = "https://pannellum.org/images/bma-1.jpg",

				hotSpots = new object[] {
					new {
						pitch= 14.1,
						yaw= 1.5,
						type= "info",
						text= "Baltimore Museum of Art",
						url = "https://artbma.org/"

					},
					new {
						pitch= -9.4,
						yaw= 222.6,
						type= "info",
						text= "Art Museum Drive"
					},
					new {
						pitch= -0.9,
						yaw= 144.4,
						type= "info",
						text= "North Charles Street"
					}
				}
			};
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.pannellum1.Options = new
			{
				type = "multires",
				autoLoad = true,
				multiRes = new
				{
					basePath = "https://pannellum.org/images/multires/library",
					path = "/%l/%s%y_%x",
					fallbackPath = "/fallback/%s",
					extension = "jpg",
					tileResolution = 512,
					maxLevel = 6,
					cubeResolution = 8432
				}
			};
		}
	}
}
