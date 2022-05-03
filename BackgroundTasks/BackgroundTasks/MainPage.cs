using System;
using Wisej.Web;

namespace BackgroundTasks
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.sortBox1.Delay =
				this.sortBox2.Delay =
				this.sortBox3.Delay =
					(int)this.numericUpDown1.Value;
		}

		private void sortBox_SortCompleted(object sender, EventArgs e)
		{
			this.notification.Show("Sort Completed!", "SortBox: " + ((Control)sender).Name + " has just finished sorting.", "http://iconshow.me/download.php?file=path/media/images/Application/Common-Icon/png/64/Information.png");
		}
	}
}
