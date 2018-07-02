using System;
using System.Threading;
using Wisej.Web;

namespace Wisej.CodeProject.Popups
{
	public partial class GagePopup : Wisej.Web.UserPopup
	{
		public GagePopup()
		{
			InitializeComponent();
		}

		private void GagePopup_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
				SatrtUpdatingGage();
		}

		private void SatrtUpdatingGage()
		{
			Application.StartTask(() =>
			{
				while (this.Visible && !Application.IsTerminated)
				{
					this.justGage1.Value = Program.CPU;

					Application.Update(this);

					Thread.Sleep(1000);
				}

			});
		}
	}
}
