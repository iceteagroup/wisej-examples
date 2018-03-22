
using System;
using System.IO;
using Wisej.Web;

namespace Wisej.ChatServer
{
	public partial class SimpleChatClient : Page
	{
		private bool joined;

		public SimpleChatClient()
		{
			InitializeComponent();
		}

		private void buttonJoin_Click(object sender, EventArgs e)
		{
			var name = this.textBoxName.Text;
			if (name == "")
			{
				this.errorProvider.SetError(this.textBoxName, "Please enter your name.");
			}
			else
			{
				SimpleChatServer.IncomingMessage += SimpleChatServer_IncomingMessage;
				try
				{

					SimpleChatServer.Join(name);
					this.joined = true;

					UpdateUIState();

					this.textBoxMessage.Focus();
					this.errorProvider.SetError(this.textBoxName, null);

					// when joining from a browser that doesn't support WebSocket, enable the update timer.
					if (!Application.IsWebSocket)
						this.updateTimer.Start();
				}
				catch
				{
					SimpleChatServer.IncomingMessage -= this.SimpleChatServer_IncomingMessage;
					throw;
				}
			}
		}

		private void SimpleChatServer_IncomingMessage(SimpleChatServerEventArgs e)
		{
			// important to run in context and push the update since the
			// message may come in from a different thread.
			Application.Update(this, () =>
			{
				int index = this.listBoxMessage.Items.Add($"{e.TimeStamp}: {e.From} => {e.Message}");

				// remove the top message, after reaching 100.
				if (index >= 100)
				{
					this.listBoxMessage.Items.RemoveAt(0);
				}

				this.listBoxMessage.SelectedIndex = index;
			});
		}

		private void buttonLeave_Click(object sender, EventArgs e)
		{
			var name = this.textBoxName.Text;
			SimpleChatServer.Leave(name);
			SimpleChatServer.IncomingMessage -= this.SimpleChatServer_IncomingMessage;

			this.joined = false;
			UpdateUIState();

			// when leaving from a browser that doesn't support WebSocket, stop the update timer.
			if (this.updateTimer.Enabled)
				this.updateTimer.Stop();
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			var text = this.textBoxMessage.Text;
			if (text == "")
			{
				this.errorProvider.SetError(this.textBoxMessage, "Please enter a message.");
			}
			else
			{
				this.textBoxMessage.Text = "";
				var name = this.textBoxName.Text;
				SimpleChatServer.SendMessage(name, text);
				this.errorProvider.SetError(this.textBoxMessage, null);
			}
		}

		private void textBoxMessage_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (e.Tool.Name == "Clear")
				this.textBoxMessage.Text = "";
		}

		private void listBoxMessage_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "Clear":
					this.listBoxMessage.Items.Clear();
					break;

				case "Save":
					if (this.listBoxMessage.Items.Count > 0)
					{
						SaveMessages();
					}
					else
					{
						MessageBox.Show(
							"The list is empty, there is nothing to save.", 
							icon: MessageBoxIcon.Information, 
							modal: false);
					}
					break;
			}
		}

		void UpdateUIState()
		{
			this.buttonJoin.Enabled = !this.joined;
			this.buttonLeave.Enabled = this.joined;
			this.buttonSend.Enabled = this.joined;

			this.textBoxName.Enabled = !this.joined;
			this.textBoxMessage.Enabled = this.joined;
		}

		void SaveMessages()
		{
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);
			foreach (var item in this.listBoxMessage.Items)
			{
				writer.WriteLine(item.ToString());
			}
			Application.Download(stream, "ChatLog.txt");
		}

		private void SimpleChatClient_Load(object sender, EventArgs e)
		{
			UpdateUIState();

			this.textBoxName.Focus();
		}

		private void SimpleChatClient_Accelerator(object sender, AcceleratorEventArgs e)
		{
			if (this.textBoxName.Focused)
				this.buttonJoin.PerformClick();
			else if (this.textBoxMessage.Focused)
				this.buttonSend.PerformClick();
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			// do nothing, Wisej will update everything that was pending.
		}
	}
}
