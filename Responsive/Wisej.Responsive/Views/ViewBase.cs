using System;
using Wisej.Web;

namespace Wisej.Responsive.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		public ViewBase()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Title
		{
			get { return this.labelTitle.Text; }
			set { this.labelTitle.Text = value; }
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
