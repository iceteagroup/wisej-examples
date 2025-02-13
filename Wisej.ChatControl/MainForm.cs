using System.Drawing;
using System.Threading;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.ChatControl
{
	public partial class MainForm : Form
	{
		private readonly User _bot = new User("2", "Bot");

		public MainForm()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.chatBox1.User.Id = "1";
			this.chatBox1.User.Name = "Me";

			this.chatBox1.DataSource.Add(new Message
			{
				Content = "What would you like to see?",
				User = _bot
			});

			var options = new MenuOptions("Pet", "City", "Tree");
			options.MenuItemClicked += Options_MenuItemClicked;

			this.chatBox1.DataSource.Add(new Message
			{
				BubbleVisible = false,
				Control = options,
				User = _bot
			});
		}

		private void Options_MenuItemClicked(object sender, string e)
		{
			this.chatBox1.DataSource.Add(new Message
			{
				Control = new PictureBox
				{
					MinimumSize = new Size(200, 200),
					SizeMode = PictureBoxSizeMode.Zoom,
					ImageSource = $"/Images/{e.ToLower()}.jpg"
				},
				User = _bot
			});
		}

		private void chatBox1_SentMessage(object sender, MessageEventArgs e)
		{
			// only process user messages.
			if (e.IsChatBoxUser)
			{
				var message = new LazyMessage(_bot);

				this.chatBox1.DataSource.Add(message);

				Application.StartTask(() =>
				{
					Thread.Sleep(3000);

					message.SetResult("OK!");

					Application.Update(this);
				});
			}
		}

		private void chatBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			this.upload1.UploadFiles();
		}

		private void upload1_Uploaded(object sender, UploadedEventArgs e)
		{
			this.chatBox1.DataSource.Add(new Message
			{
				Control = new PictureBox 
				{ 
					MinimumSize = new Size(200, 200),
					SizeMode = PictureBoxSizeMode.Zoom,
					Image = Image.FromStream(e.Files[0].InputStream) 
				},
				User = _bot
			});
		}
	}
}
 