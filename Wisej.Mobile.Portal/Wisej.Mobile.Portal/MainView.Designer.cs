using Wisej.Web;

namespace Wisej.Mobile.Portal
{
	partial class MainView
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
			this.SuspendLayout();
			// 
			// MainView
			// 
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(1628, 858);
			this.Text = "My Apps";
			this.Load += new System.EventHandler(this.MainView_Load);
			this.ResumeLayout(false);

		}

		#endregion
	}
}

