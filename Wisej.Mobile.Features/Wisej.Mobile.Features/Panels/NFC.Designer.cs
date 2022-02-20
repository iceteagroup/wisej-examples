namespace Wisej.Mobile.Features.Panels
{
	partial class NFC
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
			this.buttonReadNFC = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.textBoxWritable = new Wisej.Web.TextBox();
			this.buttonWrite = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonReadNFC
			// 
			this.buttonReadNFC.Dock = Wisej.Web.DockStyle.Top;
			this.buttonReadNFC.Location = new System.Drawing.Point(16, 168);
			this.buttonReadNFC.Name = "buttonReadNFC";
			this.buttonReadNFC.Size = new System.Drawing.Size(618, 40);
			this.buttonReadNFC.TabIndex = 0;
			this.buttonReadNFC.Text = "Read NFC";
			this.buttonReadNFC.Click += new System.EventHandler(this.buttonReadNFC_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Only devices that have NFC capabilities can use this feature";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxWritable
			// 
			this.textBoxWritable.AutoSize = false;
			this.textBoxWritable.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxWritable.Location = new System.Drawing.Point(16, 228);
			this.textBoxWritable.Name = "textBoxWritable";
			this.textBoxWritable.Size = new System.Drawing.Size(618, 50);
			this.textBoxWritable.TabIndex = 3;
			this.textBoxWritable.Text = "Hello, World!";
			// 
			// buttonWrite
			// 
			this.buttonWrite.Dock = Wisej.Web.DockStyle.Top;
			this.buttonWrite.Location = new System.Drawing.Point(16, 286);
			this.buttonWrite.Name = "buttonWrite";
			this.buttonWrite.Size = new System.Drawing.Size(618, 40);
			this.buttonWrite.TabIndex = 4;
			this.buttonWrite.Text = "Write to Tag";
			this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 148);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 208);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 278);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 8);
			// 
			// NFC
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonWrite);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxWritable);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonReadNFC);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.label1);
			this.Name = "NFC";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonReadNFC, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxWritable, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonWrite, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonReadNFC;
		private Web.Label label1;
		private Web.TextBox textBoxWritable;
		private Web.Button buttonWrite;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
	}
}
