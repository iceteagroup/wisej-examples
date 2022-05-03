using System;
using System.ComponentModel;
using System.Drawing.Design;
using Wisej.Web;

namespace Wisej.LazyLoadingPanel
{
	public partial class ItemPanel : Wisej.Web.UserControl
	{
		public ItemPanel()
		{
			InitializeComponent();
		}

		public event EventHandler ActionClick;

		private void action_Click(object sender, EventArgs e)
		{
			this.ActionClick?.Invoke(this, EventArgs.Empty);
		}

		[TypeConverter("Wisej.Web.Design.ImageSourceConverter, Wisej.Web.Design")]
		public string ImageSource
		{
			get { return this.icon.ImageSource; }
			set { this.icon.ImageSource = value; }
		}

		public string Title
		{
			get { return this.title.Text; }
			set { this.title.Text = value; }
		}

		public override string Text
		{
			get { return this.text.Text; }
			set { this.text.Text = value; }
		}
	}
}
