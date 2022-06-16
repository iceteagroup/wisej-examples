namespace Wisej.Mobile.Portal.Views
{
	partial class Bind
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bind));
			this.labelDescription = new Wisej.Web.Label();
			this.textBoxBind = new Wisej.Web.TextBox();
			this.buttonBind = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Text = "Bind Wisej App";
			// 
			// labelDescription
			// 
			this.labelDescription.AllowHtml = true;
			this.labelDescription.Dock = Wisej.Web.DockStyle.Top;
			this.labelDescription.Location = new System.Drawing.Point(16, 128);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(618, 151);
			this.labelDescription.TabIndex = 10;
			this.labelDescription.Text = resources.GetString("labelDescription.Text");
			// 
			// textBoxBind
			// 
			this.textBoxBind.AutoSize = false;
			this.textBoxBind.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBind.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxBind.InputType.Type = Wisej.Web.TextBoxType.Url;
			this.textBoxBind.Label.Size = 50;
			this.textBoxBind.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxBind.LabelText = "URL";
			this.textBoxBind.Location = new System.Drawing.Point(16, 279);
			this.textBoxBind.Name = "textBoxBind";
			this.textBoxBind.Size = new System.Drawing.Size(618, 70);
			this.textBoxBind.TabIndex = 9;
			// 
			// buttonBind
			// 
			this.buttonBind.BackColor = System.Drawing.Color.FromName("@accent");
			this.buttonBind.Dock = Wisej.Web.DockStyle.Top;
			this.buttonBind.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonBind.ForeColor = System.Drawing.Color.FromName("@window");
			this.buttonBind.Location = new System.Drawing.Point(16, 369);
			this.buttonBind.Name = "buttonBind";
			this.buttonBind.Size = new System.Drawing.Size(618, 45);
			this.buttonBind.TabIndex = 11;
			this.buttonBind.Text = "Bind App";
			this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 349);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Bind
			// 
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.AutoScroll = true;
			this.Controls.Add(this.buttonBind);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxBind);
			this.Controls.Add(this.labelDescription);
			this.Name = "Bind";
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.labelDescription, 0);
			this.Controls.SetChildIndex(this.textBoxBind, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonBind, 0);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Label labelDescription;
		private Web.TextBox textBoxBind;
		private Web.Button buttonBind;
		private Web.Spacer spacer1;
	}
}
