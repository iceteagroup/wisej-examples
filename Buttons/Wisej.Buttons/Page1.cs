using System;
using Wisej.Web;


namespace Wisej.Buttons
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.button11.ImageKey != this.imageList1.Images[1].Name)
            {
				this.button11.ImageKey = this.imageList1.Images[1].Name;
            }
            else
            {
                this.button11.ImageKey = this.imageList1.Images[0].Name;
            }

			

		}
    }
}
