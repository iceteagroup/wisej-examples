using System;
using Wisej.Web;

namespace ChartJS
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.progressBar1.Value=0;

			Application.StartTask(() => {

				while (this.progressBar1.Value < 100)
				{
					this.progressBar1.Value++;
					this.Top++;
					this.Left++;
					this.BackColor = System.Drawing.Color.Yellow;

					Application.Update(this);
					System.Threading.Thread.Sleep(50);

					this.BackColor = System.Drawing.Color.FromName("@buttonFace");
					System.Threading.Thread.Sleep(50);
					Application.Update(this);
				}

				AlertBox.Show("Done!", icon: MessageBoxIcon.Information);
				Application.Update(this);
			});
		}
	}
}
