namespace Wisej.Mobile.Features.Panels
{
	partial class UserData
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
			this.textBoxUserData = new Wisej.Web.TextBox();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonClear = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// textBoxUserData
			// 
			this.textBoxUserData.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxUserData.Location = new System.Drawing.Point(16, 128);
			this.textBoxUserData.Multiline = true;
			this.textBoxUserData.Name = "textBoxUserData";
			this.textBoxUserData.Size = new System.Drawing.Size(618, 119);
			this.textBoxUserData.TabIndex = 0;
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSave.Location = new System.Drawing.Point(16, 267);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(618, 40);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.BackColor = System.Drawing.Color.FromName("@switchOff");
			this.buttonClear.Dock = Wisej.Web.DockStyle.Top;
			this.buttonClear.Location = new System.Drawing.Point(16, 327);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(618, 40);
			this.buttonClear.TabIndex = 2;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 247);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 307);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// UserData
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxUserData);
			this.Name = "UserData";
			this.Load += new System.EventHandler(this.UserData_Load);
			this.Controls.SetChildIndex(this.textBoxUserData, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxUserData;
		private Web.Button buttonSave;
		private Web.Button buttonClear;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
