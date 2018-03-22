using System;
using Wisej.Web;
using System.Threading;

namespace Wisej.CodeProject
{
	public partial class MyDesktop : Desktop
	{
		public MyDesktop()
		{
			InitializeComponent();

			this.startPopup = new Popups.StartPopup()
			{
				Alignment = Placement.TopLeft
			};
			this.startPopup.ExampleCreated += StartPopup_ExampleCreated;
		}

		private Popups.GagePopup gageuPopup;
		private Popups.StartPopup startPopup;

		private void MyDesktop_ItemClick(object sender, DesktopTaskBarItemClickEventArgs e)
		{
			if (e.Item == this.desktopStart)
			{
				// show/hide the start popup.
				if (this.startPopup.Visible)
					this.startPopup.Close();
				else
					this.startPopup.ShowPopup(e.Item);
			}
		}

		private void justGage1_Click(object sender, EventArgs e)
		{
			// show the gage popup.
			if (this.gageuPopup == null)
				this.gageuPopup = new Popups.GagePopup()
				{
					Alignment = Placement.TopRight
				};

			if (this.gageuPopup.Visible)
				this.gageuPopup.Close();
			else
				this.gageuPopup.ShowPopup(this.desktopCPU);
		}

		private void StartPopup_ExampleCreated(object sender, EventArgs e)
		{
			// close the start popup when an example form is created.
			this.startPopup.Close();
		}

		private void MyDesktop_Load(object sender, EventArgs e)
		{
			// start gage background task.
			SatrtUpdatingGageItem();
		}

		private void SatrtUpdatingGageItem()
		{
			int lastValue = 0;
			int speekCounter = 0;

			Application.StartTask(() =>
			{

				while (!Application.IsTerminated)
				{
					this.justGage1.Value = Program.CPU;

					// speak!
					// use some arbitrary rules to decide when to say something.
					if (lastValue != this.justGage1.Value)
					{
						speekCounter++;
						if (speekCounter > 30)
						{
							speekCounter = 0;
							lastValue = (int)Math.Round(this.justGage1.Value);
							this.speechSynthesis.Speak("The CPU is running at " + lastValue + "%.");
						}
					}

					Application.Update(this);

					Thread.Sleep(1000);
				}

			});
		}
	}
}
