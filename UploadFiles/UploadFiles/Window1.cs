
using System;
using System.Drawing;
using System.Web;
using Wisej.Web;
using System.IO;

namespace UploadFiles
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void upload1_Uploaded(object sender, UploadedEventArgs e)
		{
			LoadFile(e.Files);
		}

		private void upload2_Uploaded(object sender, UploadedEventArgs e)
		{
			LoadFiles(e.Files);
		}

		private void pictureBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void pictureBox_DragDrop(object sender, DragEventArgs e)
		{
			LoadFile((HttpFileCollection)e.Data.GetData(DataFormats.Files));
		}

		private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.AllowedFileTypes = "image.*";

				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (files != null)
				{
					foreach (string type in files)
					{
						if (type.IndexOf("/png") > -1
							|| type.IndexOf("/jpg") > -1
							|| type.IndexOf("/jpeg") > -1
							|| type.IndexOf("/gif") > -1)
						{
							e.Effect = DragDropEffects.Copy;
							return;
						}
					}
				}
			}

			e.Effect = DragDropEffects.None;
		}

		private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
		{
			LoadFiles((HttpFileCollection)e.Data.GetData(DataFormats.Files));
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.flowLayoutPanel.Controls.Clear(true);

		}

		private void LoadFile(HttpFileCollection files)
		{
			if (files == null)
				return;

			if (files.Count == 0)
			{
				this.pictureBox.Image = null;
			}
			else
			{
				this.pictureBox.Image = GetImageFromStream(files[0].InputStream);
			}
		}

		// Process multiple files and create a new child PictureBox inside
		// the flow layout panel. Each PictureBox handles the click event to trigger the download of the
		// uploaded file.
		private void LoadFiles(HttpFileCollection files)
		{
			if (files == null)
				return;

			int count = files.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					PictureBox box = new PictureBox()
					{
						Name = files[i].FileName,
						Width = 64,
						Height = 64,
						SizeMode = PictureBoxSizeMode.Zoom,
						BorderStyle = BorderStyle.Solid,
						Margin = new Padding(5),
						Cursor = Cursors.Hand
					};

					box.Image = GetImageFromStream(files[i].InputStream);
					box.MouseClick += (se, ev) =>
					{
						DialogResult result = MessageBox.Show(
							"You clicked " + box.Name + "<br/><br/>Would you like to download this file?",
							"Download",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (result == DialogResult.Yes)
						{
							Application.Download(box.Image, box.Name);
						}
					};


					this.flowLayoutPanel.Controls.Add(box);
				}
			}
		}

		// Reads the image from the uploaded stream and preserves the stream
		// in case it's an animated gif.
		private Image GetImageFromStream(Stream stream)
		{
			MemoryStream mem = new MemoryStream();
			stream.CopyTo(mem, 1024);
			mem.Position = 0;
			return Image.FromStream(mem);
		}
	}
}
