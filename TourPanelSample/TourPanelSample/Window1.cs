
using System;
using Wisej.Web;

namespace TourPanelSample
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void menuItem5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("Not implemented in this sample.");
		}
	}
}
