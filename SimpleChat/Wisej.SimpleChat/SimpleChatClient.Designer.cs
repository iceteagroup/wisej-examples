namespace Wisej.ChatServer
{
	partial class SimpleChatClient
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
			this.components = new System.ComponentModel.Container();
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			this.textBoxName = new Wisej.Web.TextBox();
			this.buttonJoin = new Wisej.Web.Button();
			this.buttonLeave = new Wisej.Web.Button();
			this.listBoxMessage = new Wisej.Web.ListBox();
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.buttonSend = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			this.label1 = new Wisej.Web.Label();
			this.updateTimer = new Wisej.Web.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxName.AutoSize = false;
			this.textBoxName.Location = new System.Drawing.Point(88, 89);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(126, 46);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Watermark = "Name";
			// 
			// buttonJoin
			// 
			this.buttonJoin.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonJoin.Location = new System.Drawing.Point(247, 89);
			this.buttonJoin.Name = "buttonJoin";
			this.buttonJoin.Size = new System.Drawing.Size(236, 46);
			this.buttonJoin.TabIndex = 2;
			this.buttonJoin.Text = "Join";
			this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
			// 
			// buttonLeave
			// 
			this.buttonLeave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonLeave.Enabled = false;
			this.buttonLeave.Location = new System.Drawing.Point(508, 89);
			this.buttonLeave.Name = "buttonLeave";
			this.buttonLeave.Size = new System.Drawing.Size(236, 46);
			this.buttonLeave.TabIndex = 3;
			this.buttonLeave.Text = "Leave";
			this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
			// 
			// listBoxMessage
			// 
			this.listBoxMessage.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.listBoxMessage.HorizontalScrollbar = true;
			this.listBoxMessage.Location = new System.Drawing.Point(88, 163);
			this.listBoxMessage.Name = "listBoxMessage";
			this.listBoxMessage.Size = new System.Drawing.Size(656, 267);
			this.listBoxMessage.TabIndex = 4;
			componentTool1.ImageSource = "tab-close";
			componentTool1.Name = "Clear";
			componentTool1.ToolTipText = "Clear all messages.";
			componentTool2.ImageSource = "icon-save";
			componentTool2.Name = "Save";
			componentTool2.ToolTipText = "Save messages.";
			this.listBoxMessage.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2});
			this.listBoxMessage.ToolClick += new Wisej.Web.ToolClickEventHandler(this.listBoxMessage_ToolClick);
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxMessage.AutoSize = false;
			this.textBoxMessage.Enabled = false;
			this.textBoxMessage.Location = new System.Drawing.Point(88, 459);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(395, 46);
			this.textBoxMessage.TabIndex = 5;
			componentTool3.ImageSource = "tab-close";
			componentTool3.Name = "Clear";
			componentTool3.ToolTipText = "Clear";
			this.textBoxMessage.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
			this.textBoxMessage.Watermark = "Message";
			this.textBoxMessage.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBoxMessage_ToolClick);
			// 
			// buttonSend
			// 
			this.buttonSend.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSend.Enabled = false;
			this.buttonSend.Location = new System.Drawing.Point(508, 459);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(236, 46);
			this.buttonSend.TabIndex = 6;
			this.buttonSend.Text = "Send";
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromName("@activeCaption");
			this.label1.Location = new System.Drawing.Point(88, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Simple Chat";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// updateTimer
			// 
			this.updateTimer.Interval = 1000;
			this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
			// 
			// SimpleChatClient
			// 
			this.Accelerators = new Wisej.Web.Keys[] {
        Wisej.Web.Keys.Return};
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.listBoxMessage);
			this.Controls.Add(this.buttonLeave);
			this.Controls.Add(this.buttonJoin);
			this.Controls.Add(this.textBoxName);
			this.Name = "SimpleChatClient";
			this.Size = new System.Drawing.Size(832, 586);
			this.Text = "SimpleChat";
			this.Load += new System.EventHandler(this.SimpleChatClient_Load);
			this.Accelerator += new Wisej.Web.AcceleratorEventHandler(this.SimpleChatClient_Accelerator);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxName;
		private Web.Button buttonJoin;
		private Web.Button buttonLeave;
		private Web.ListBox listBoxMessage;
		private Web.TextBox textBoxMessage;
		private Web.Button buttonSend;
		private Web.ErrorProvider errorProvider;
		private Web.Label label1;
		private Web.Timer updateTimer;
	}
}

