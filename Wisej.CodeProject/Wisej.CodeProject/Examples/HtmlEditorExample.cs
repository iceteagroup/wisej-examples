using System;
using Wisej.Web;

namespace Wisej.CodeProject.Examples
{
	public partial class HtmlEditorExample : Form
	{
		public HtmlEditorExample()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void HtmlEditorExample_Load(object sender, EventArgs e)
		{
			this.ckEditor1.Text = "Hello, <b>World!</b>";
		}
	}
}
