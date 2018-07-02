namespace TourPanelSample
{
	partial class Window4
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
			this.labelChrome = new Wisej.Web.Label();
			this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
			this.SuspendLayout();
			// 
			// labelChrome
			// 
			this.labelChrome.AutoSize = true;
			this.labelChrome.Location = new System.Drawing.Point(17, 14);
			this.labelChrome.Name = "labelChrome";
			this.labelChrome.Size = new System.Drawing.Size(255, 16);
			this.labelChrome.TabIndex = 0;
			this.labelChrome.Text = "This label is only visible for Chrome users";
			// 
			// ckEditor1
			// 
			this.ckEditor1.Location = new System.Drawing.Point(16, 41);
			this.ckEditor1.Name = "ckEditor1";
			this.ckEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.ckEditor1.Size = new System.Drawing.Size(801, 289);
			this.ckEditor1.TabIndex = 1;
			this.ckEditor1.Text = "ckEditor1";
			// 
			// Window4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 367);
			this.CloseBox = false;
			this.Controls.Add(this.ckEditor1);
			this.Controls.Add(this.labelChrome);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "Window4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Window4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelChrome;
		private Wisej.Web.Ext.CKEditor.CKEditor ckEditor1;
	}
}

