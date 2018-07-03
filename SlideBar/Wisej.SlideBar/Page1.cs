using System;
using System.Linq;
using Wisej.Web;


namespace Wisej.SlideBar
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void slideBar_ScrollAnimationEnd(object sender, EventArgs e)
		{
			AlertBox.Show("Done scrolling!");
		}

		private void buttonScroll100Px_Click(object sender, EventArgs e)
		{
			this.slideBar1.ScrollBy(100, 1000);
			this.slideBar2.ScrollBy(100, 1000);
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			LoadComboWithPictures();			
		}

		private void LoadComboWithPictures()
		{
			var items = new PictureBox[this.slideBar1.Controls.Count];
			this.slideBar1.Controls.CopyTo(items, 0);
			this.comboBox1.DataSource = items;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.slideBar1.Spacing = this.slideBar2.Spacing = (int)this.numericUpDown1.Value;						
		}

		private void buttonScrollIntoView_Click(object sender, EventArgs e)
		{
			string tag = (string)((Control)this.comboBox1.SelectedItem)?.Tag;
			foreach (Control c in this.slideBar1.Controls)
			{
				if (tag == (string)c.Tag)
				{
					this.slideBar1.ScrollControlIntoView(c, HorizontalAlignment.Left);
					break;
				}
			}
			foreach (Control c in this.slideBar2.Controls)
			{
				if (tag == (string)c.Tag)
				{
					this.slideBar2.ScrollControlIntoView(c, VerticalAlignment.Top);
					break;
				}
			}
		}

		private void buttonAddFirst_Click(object sender, EventArgs e)
		{
			var newControl = new PictureBox();
			var cloneControl = (PictureBox)this.slideBar1.Controls[this.slideBar1.Controls.Count -1];
			newControl.ImageSource = cloneControl.ImageSource;
			newControl.SizeMode = cloneControl.SizeMode;
			newControl.Size = cloneControl.Size;
			this.slideBar1.Controls.Add(newControl);
			newControl.ScrollControlIntoView();

			newControl = new PictureBox();
			cloneControl = (PictureBox)this.slideBar2.Controls[this.slideBar2.Controls.Count - 1];
			newControl.ImageSource = cloneControl.ImageSource;
			newControl.SizeMode = cloneControl.SizeMode;
			newControl.Size = cloneControl.Size;
			this.slideBar2.Controls.Add(newControl);
			newControl.ScrollControlIntoView();
		}

		private void buttonAddLast_Click(object sender, EventArgs e)
		{
			var newControl = new PictureBox();
			var cloneControl = (PictureBox)this.slideBar1.Controls[0];
			newControl.ImageSource = cloneControl.ImageSource;
			newControl.SizeMode = cloneControl.SizeMode;
			newControl.Size = cloneControl.Size;
			this.slideBar1.Controls.Add(newControl);
			newControl.BringToFront();
			newControl.ScrollControlIntoView();

			newControl = new PictureBox();
			cloneControl = (PictureBox)this.slideBar2.Controls[0];
			newControl.ImageSource = cloneControl.ImageSource;
			newControl.SizeMode = cloneControl.SizeMode;
			newControl.Size = cloneControl.Size;
			this.slideBar2.Controls.Add(newControl);
			newControl.BringToFront();
			newControl.ScrollControlIntoView();
		}

		private void slideBar2_Scroll(object sender, ScrollEventArgs e)
		{
			this.label3.Text = e.NewValue.ToString();
		}

		private void slideBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.label2.Text = e.NewValue.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Button1 clicked.");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Button2 clicked.");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Button3 clicked.");
		}
	}
}
