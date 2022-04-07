
using System;
using Wisej.Web;
using System.Linq;
using Wisej.Core;
using System.Web;
using System.IO;

namespace Wisej.SAP3DViewer
{
	public partial class Page1 : Page
	{
		private Stream fileStream;
		public Page1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.openFileDialog.Roots[0].Root = Application.MapPath("~\\Samples");

			base.OnLoad(e);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if (Application.Browser.Device == "Mobile")
				this.openFileDialog.WindowState = FormWindowState.Maximized;

			if (await this.openFileDialog.ShowDialogAsync() == DialogResult.OK)
			{
				// The widget will issue a request to download the file using the special postback url 
				// to route the request back to the specific instance of the widget.
				this.widget1.Call("loadFile", this.openFileDialog.FileName);
			}
		}

		private void widget1_WebRequest(object sender, WebRequestEventArgs e)
		{
			// Wisej.Web.Widget is able to act as a request handler and return any content.
			switch (e.Request["action"])
			{
				case "load":

					var file = e.Request["file"];

					if (file == "*")
					{
						// return the stream.
						if (this.fileStream != null)
						{
							this.fileStream.CopyTo(e.Response.OutputStream);
							e.Response.Flush();
							this.fileStream = null;
						}
					}
					else
					{
						// map the path on the server so we don't send unsafe full paths to the browser.
						var path = this.openFileDialog.MapPath(file);
						e.Response.TransmitFile(path);
					}
					break;
			}
		}

		private async void widget1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "loaded":

					// load the procedures in the combobox once the file is loaded.
					dynamic[] list = await this.widget1.CallAsync("readProcedures");
					this.comboBox1.Enabled = true;
					this.comboBox1.Items.Clear();
					this.comboBox1.Items.AddRange(list);
					if (list.Length > 0)
						this.comboBox1.SelectedIndex = 0;
					break;

				case "nodeSelected":
					AlertBox.Show($"Selected Node: {e.Data}");
					break;
			}
		}

		private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboBox2.Items.Clear();

			if (this.comboBox1.SelectedIndex > -1)
			{
				// load the steps in the combobox when a procedure is selected.
				dynamic[] list = await this.widget1.CallAsync("readSteps", ((dynamic)this.comboBox1.SelectedItem).id);
				this.button2.Enabled = true;
				this.comboBox2.Enabled = true;
				this.comboBox2.Items.AddRange(list);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.comboBox2.SelectedIndex  > -1)
				this.widget1.Call("playStep", ((dynamic)this.comboBox2.SelectedItem).id);
		}

		private void widget1_DragEnter(object sender, DragEventArgs e)
		{
			e.AllowedFileTypes = ".vds";
			e.Effect = DragDropEffects.Copy;
		}

		private void widget1_DragDrop(object sender, DragEventArgs e)
		{
			var files = (HttpFileCollection)e.Data.GetData(DataFormats.Files);
			if (files?.Count > 0)
				LoadFileStream(files[0].InputStream);
		}

		private void upload1_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count > 0)
				LoadFileStream(e.Files[0].InputStream);
		}

		private void LoadFileStream(Stream stream)
		{
			this.fileStream = new MemoryStream();
			stream.CopyTo(this.fileStream);
			this.fileStream.Position = 0;

			this.widget1.Call("loadFile", "*");
		}
	}
}
