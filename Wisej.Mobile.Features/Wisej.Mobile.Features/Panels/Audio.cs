using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Media")]
	public partial class Audio : TestBase
	{
		public Audio()
		{
			InitializeComponent();
		}

		private void buttonPlayAudio_Click(object sender, EventArgs e)
		{
			Application.Play("Data\\service-bell_daniel_simion.mp3");
		}
	}
}
