using System;
using System.ComponentModel;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Input")]
	public partial class KeyboardFocus : TestBase
	{
		public KeyboardFocus()
		{
			InitializeComponent();
		}

		private void KeyboardFocus_Appear(object sender, EventArgs e)
		{
			this.textBoxInput.Focus();
		}
	}
}
