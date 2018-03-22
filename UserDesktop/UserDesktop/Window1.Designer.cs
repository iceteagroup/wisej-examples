namespace UserDesktop
{
	partial class Window1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolBar1 = new Wisej.Web.ToolBar();
			this.btnOpen = new Wisej.Web.ToolBarButton();
			this.btnSave = new Wisej.Web.ToolBarButton();
			this.btnNew = new Wisej.Web.ToolBarButton();
			this.textBox1 = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.AutoSize = false;
			this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.btnOpen,
            this.btnSave,
            this.btnNew});
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(613, 48);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.TabStop = false;
			this.toolBar1.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			// 
			// btnOpen
			// 
			this.btnOpen.ImageSource = "icon-open";
			this.btnOpen.IsDisposed = false;
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Text = "Open";
			// 
			// btnSave
			// 
			this.btnSave.ImageSource = "icon-save";
			this.btnSave.IsDisposed = false;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			// 
			// btnNew
			// 
			this.btnNew.ImageSource = "icon-new";
			this.btnNew.IsDisposed = false;
			this.btnNew.Name = "btnNew";
			this.btnNew.Text = "New";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 48);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(613, 384);
			this.textBox1.TabIndex = 1;
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 432);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.toolBar1);
			this.IconSource = "http://iconshow.me/media/images/social/flat-style-Metro-UI-Icons/Applications/png" +
    "/256/MetroUI-Notepad.png";
			this.Name = "Window1";
			this.Text = "Window1";
			this.Load += new System.EventHandler(this.Window1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.ToolBar toolBar1;
		private Wisej.Web.ToolBarButton btnOpen;
		private Wisej.Web.ToolBarButton btnSave;
		private Wisej.Web.ToolBarButton btnNew;
		private Wisej.Web.TextBox textBox1;
	}
}

