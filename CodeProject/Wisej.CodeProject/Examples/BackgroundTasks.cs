using System;
using Wisej.Web;
using System.Threading;

namespace Wisej.CodeProject.Examples
{
	public partial class BackgroundTasks : Form
	{
		public BackgroundTasks()
		{
			InitializeComponent();

			this.button1.Enabled = true;
			this.button2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.stop = false;
			this.button1.Enabled = false;
			this.button2.Enabled = true;

			Application.StartTask(() => {

				for (int count=0; count <= 100;count++)
				{
					if (this.stop || Application.IsTerminated || this.IsDisposed)
						break;

					this.progressBar1.Value = count;
					this.progressCircle1.Value = count;
					this.progressBar1.Text = count + "%";
					this.label1.Text = BuildText(count);
					Application.Update(this);

					Thread.Sleep(500);
				}

				this.button1.Enabled = true;
				Application.Update(this);

			});
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.stop = true;
			this.button2.Enabled = false;
		}
		private bool stop;

		private string BuildText(int count)
		{
			switch (count)
			{
				case 0: return "Started!";
				case 10: return "Reached 10, still going...";
				case 50: return "Half way there.";
				case 100: return "<big><big>Done</big></big>";
				default: return "<i>Current Progress:</i> " + count;
			}
		}
	}
}
