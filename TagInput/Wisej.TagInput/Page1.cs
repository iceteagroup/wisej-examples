
using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.TagInput
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
		}

		private void tagTextBox1_TagAdded(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"Added: {e.Text}");
		}

		private void tagTextBox1_TagRemoved(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"Removed: {e.Text}", icon: MessageBoxIcon.Warning);
		}

		private void tagTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.label2.Text = this.tagTextBox1.Text;
		}

		private void tagTextBox1_TagRejected(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"Rejected: {e.Text}", icon:MessageBoxIcon.Error);
		}

		private void tagTextBox1_TagSelected(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"Selected: {e.Text}");
		}

		private void panel1_SizeChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
				this.panel1.CenterToParent();
		}

		private void tagTextBox1_TagRender(object sender, TagTextBoxRenderEventArgs e)
		{
			switch (e.Text)
			{
				case "Arizona":
					e.BackColor = Color.Beige;
					break;

				case "Florida":
					e.BackColor = Color.LightGreen;
					break;

				case "Alaska":
					e.Html = "<b>" + e.Text + "</b>";
					break;

				case "California":
					e.Html = "<u>" + e.Text + "</u>";
					break;

				case "Georgia":
					e.Html = "<img src='Images/fullstar.png' style='display:inline-block;float:left;padding-right:5px' width=16/>" + e.Text;
					break;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
				this.panel1.CenterToParent();
		}
	}
}
