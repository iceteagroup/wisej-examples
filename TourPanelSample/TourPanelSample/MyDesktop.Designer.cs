namespace TourPanelSample
{
	partial class MyDesktop
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolBar1 = new Wisej.Web.ToolBar();
			this.toolBarButton1 = new Wisej.Web.ToolBarButton();
			this.toolBarButton2 = new Wisej.Web.ToolBarButton();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2});
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(1865, 66);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.TabStop = false;
			this.toolBar1.ButtonClick += new Wisej.Web.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageSource = "icon-help";
			this.toolBarButton1.Name = "toolBarButton1";
			this.toolBarButton1.Text = "Start tour";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.AllowHtml = true;
			this.toolBarButton2.ImageSource = "icon-play";
			this.toolBarButton2.Name = "toolBarButton2";
			this.toolBarButton2.Text = "Start Tour <br/>with AutoPlay";			
			// 
			// MyDesktop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.toolBar1);
			this.Name = "MyDesktop";
			this.Size = new System.Drawing.Size(1865, 857);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.ToolBar toolBar1;
		private Wisej.Web.ToolBarButton toolBarButton1;
		private Wisej.Web.ToolBarButton toolBarButton2;
	}
}
