using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.LazyLoadingPanel
{
	public partial class ContainerPanel : Wisej.Web.UserControl
	{
		public ContainerPanel()
		{
			InitializeComponent();
		}

		public event EventHandler LoadPanels;

		public string LoadingMessage
		{
			get { return this.label1.Text; }
			set { this.label1.Text = value; }
		}

		private void ContainerPanel_Scroll(object sender, ScrollEventArgs e)
		{
			if (this.loaderPanel.Visible)
			{
				if (e.Type == ScrollEventType.Last)
					LoadNewPanels();
				else if (e.NewValue + this.Height >= this.loaderPanel.Top)
					ScrollControlIntoView(this.loaderPanel);
			}
		}

		private void ContainerPanel_Resize(object sender, EventArgs e)
		{
			if (this.loaderPanel.Visible)
			{
				var scrollHeight = this.Height + this.VerticalScroll.Value;
				if (this.loaderPanel.Top < scrollHeight && this.loaderPanel.Bottom > scrollHeight)
					ScrollControlIntoView(this.loaderPanel);
			}
		}

		private void ContainerPanel_Load(object sender, EventArgs e)
		{
			// firs load.
			LoadNewPanels();
		}

		private void LoadNewPanels()
		{
			var count = this.Controls.Count;
			this.LoadPanels?.Invoke(this, EventArgs.Empty);

			// nothing loaded?
			if (count == this.Controls.Count)
				this.loaderPanel.Hide();
		}
	}
}
