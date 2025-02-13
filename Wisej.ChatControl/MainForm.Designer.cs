namespace Wisej.ChatControl
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			this.chatBox1 = new Wisej.Web.Ext.ChatControl.ChatBox();
			this.upload1 = new Wisej.Web.Upload();
			this.SuspendLayout();
			// 
			// chatBox1
			// 
			this.chatBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.chatBox1.Name = "chatBox1";
			this.chatBox1.ResizableEdges = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.chatBox1.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.chatBox1.Size = new System.Drawing.Size(598, 551);
			this.chatBox1.TabIndex = 0;
			componentTool2.ImageSource = "icon-upload";
			this.chatBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
			this.chatBox1.SentMessage += new Wisej.Web.Ext.ChatControl.MessageEventHandler(this.chatBox1_SentMessage);
			this.chatBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.chatBox1_ToolClick);
			// 
			// upload1
			// 
			this.upload1.Location = new System.Drawing.Point(184, 82);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(200, 30);
			this.upload1.TabIndex = 1;
			this.upload1.Text = "upload1";
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 551);
			this.Controls.Add(this.chatBox1);
			this.Controls.Add(this.upload1);
			this.Name = "MainForm";
			this.Text = "Wisej.NET Chat Control";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.ChatControl.ChatBox chatBox1;
		private Web.Upload upload1;
	}
}

