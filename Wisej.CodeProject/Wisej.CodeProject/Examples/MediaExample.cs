using System;
using Wisej.Web;

namespace Wisej.CodeProject.Examples
{
	public partial class MediaExample : Form
	{
		public MediaExample()
		{
			InitializeComponent();
		}

		private void audio1_CurrentTimeChanged(object sender, EventArgs e)
		{
			this.label2.Text = "Position: <span style='color:red'>" + this.audio1.CurrentTime + "</span>";
		}

		private void audio1_Paused(object sender, EventArgs e)
		{
			this.label1.Text = "Audio Status: Paused";
			this.button1.Enabled = true;
			this.button2.Enabled = false;
		}

		private void audio1_Playing(object sender, EventArgs e)
		{
			this.label1.Text = "Audio Status: Playing";
			this.button1.Enabled = false;
			this.button2.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.audio1.Play();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.audio1.Pause();
		}
	}
}
