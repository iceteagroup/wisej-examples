using System;
using Wisej.Web;


namespace UserControl
{
	public partial class MyPage : Page
	{
		public MyPage()
		{
			InitializeComponent();
		}

		private void colorSlider_ValueChanged(object sender, EventArgs e)
		{
			this.colorPanel.BackColor = this.colorSlider.Color;
		}

		private void MyPage_Load(object sender, EventArgs e)
		{
			this.colorPanel.BackColor = this.colorSlider.Color;
		}

		private void checkBoxShowValueBubble_CheckedChanged(object sender, EventArgs e)
		{
			this.colorSlider.ShowValueBubbles = this.checkBoxShowValueBubble.Checked;
		}
	}
}
