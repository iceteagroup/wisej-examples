namespace Wisej.TagInput
{
	partial class Page1
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
			this.panel1 = new Wisej.Web.FlexLayoutPanel();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
			this.label3 = new Wisej.Web.Label();
			this.tagTextBox1 = new Wisej.Web.TagTextBox();
			this.flexLayoutPanel3 = new Wisej.Web.FlexLayoutPanel();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.separator1 = new Wisej.Web.Spacer();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.panel1.SuspendLayout();
			this.flexLayoutPanel1.SuspendLayout();
			this.flexLayoutPanel2.SuspendLayout();
			this.flexLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel1.AppearanceKey = "states-panel";
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.Controls.Add(this.flexLayoutPanel1);
			this.panel1.Controls.Add(this.flexLayoutPanel2);
			this.panel1.Controls.Add(this.flexLayoutPanel3);
			this.panel1.HeaderSize = 40;
			this.panel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.panel1.Location = new System.Drawing.Point(487, 206);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(546, 255);
			this.panel1.TabIndex = 0;
			this.panel1.Text = "Select States";
			this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.AutoSize = true;
			this.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flexLayoutPanel1.Controls.Add(this.label1);
			this.flexLayoutPanel1.Controls.Add(this.label2);
			this.flexLayoutPanel1.HeaderSize = 40;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(10, 10);
			this.flexLayoutPanel1.Margin = new Wisej.Web.Padding(10, 10, 10, 5);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.ShowCloseButton = false;
			this.flexLayoutPanel1.Size = new System.Drawing.Size(522, 56);
			this.flexLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selected States:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 3);
			this.label2.MaximumSize = new System.Drawing.Size(365, 0);
			this.label2.MinimumSize = new System.Drawing.Size(365, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(365, 0);
			this.label2.TabIndex = 1;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flexLayoutPanel2
			// 
			this.flexLayoutPanel2.AutoSize = true;
			this.flexLayoutPanel2.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flexLayoutPanel2.Controls.Add(this.label3);
			this.flexLayoutPanel2.Controls.Add(this.tagTextBox1);
			this.flexLayoutPanel2.HeaderSize = 40;
			this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel2.Location = new System.Drawing.Point(10, 86);
			this.flexLayoutPanel2.Margin = new Wisej.Web.Padding(10, 5, 10, 10);
			this.flexLayoutPanel2.Name = "flexLayoutPanel2";
			this.flexLayoutPanel2.ShowCloseButton = false;
			this.flexLayoutPanel2.Size = new System.Drawing.Size(522, 58);
			this.flexLayoutPanel2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 15);
			this.label3.Margin = new Wisej.Web.Padding(3, 15, 3, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Select a State:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tagTextBox1
			// 
			this.tagTextBox1.AutoComplete = Wisej.Web.AutoComplete.On;
			this.tagTextBox1.AutoCompleteList = new string[] {
        "Alabama",
        "Alaska",
        "Arizona",
        "Arkansas",
        "California",
        "Colorado",
        "Connecticut",
        "Delaware",
        "Florida",
        "Georgia",
        "Hawaii",
        "Idaho",
        "Illinois",
        "Indiana",
        "Iowa",
        "Kansas",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota",
        "Mississippi",
        "Missouri",
        "Montana",
        "Nebraska",
        "Nevada",
        "New Hampshire",
        "New Jersey",
        "New Mexico",
        "New York",
        "North Carolina",
        "North Dakota",
        "Ohio",
        "Oklahoma",
        "Oregon",
        "Pennsylvania",
        "Rhode Island",
        "South Carolina",
        "South Dakota",
        "Tennessee",
        "Texas",
        "Utah",
        "Vermont",
        "Virginia",
        "Washington",
        "West Virginia",
        "Wisconsin",
        "Wyoming",
        "District of Columbia",
        "Puerto Rico",
        "Guam",
        "American Samoa",
        "U.S. Virgin Islands",
        "Northern Mariana Islands"};
			this.tagTextBox1.Location = new System.Drawing.Point(154, 15);
			this.tagTextBox1.Margin = new Wisej.Web.Padding(3, 15, 3, 15);
			this.tagTextBox1.MaxTagWidth = 200;
			this.tagTextBox1.Name = "tagTextBox1";
			this.tagTextBox1.Size = new System.Drawing.Size(365, 28);
			this.tagTextBox1.TabIndex = 1;
			this.tagTextBox1.TagAdded += new Wisej.Web.TagTextBoxEventHandler(this.tagTextBox1_TagAdded);
			this.tagTextBox1.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.tagTextBox1_TagRemoved);
			this.tagTextBox1.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.tagTextBox1_TagRejected);
			this.tagTextBox1.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.tagTextBox1_TagSelected);
			this.tagTextBox1.TagRender += new Wisej.Web.TagTextBoxRenderEventHandler(this.tagTextBox1_TagRender);
			this.tagTextBox1.TextChanged += new System.EventHandler(this.tagTextBox1_TextChanged);
			// 
			// flexLayoutPanel3
			// 
			this.flexLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(180, 207, 221);
			this.flexLayoutPanel3.Controls.Add(this.checkBox1);
			this.flexLayoutPanel3.Controls.Add(this.separator1);
			this.flexLayoutPanel3.Controls.Add(this.button1);
			this.flexLayoutPanel3.Controls.Add(this.button2);
			this.flexLayoutPanel3.HeaderSize = 40;
			this.flexLayoutPanel3.HorizontalAlign = Wisej.Web.HorizontalAlignment.Right;
			this.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel3.Location = new System.Drawing.Point(0, 164);
			this.flexLayoutPanel3.Margin = new Wisej.Web.Padding(0);
			this.flexLayoutPanel3.Name = "flexLayoutPanel3";
			this.flexLayoutPanel3.Padding = new Wisej.Web.Padding(5);
			this.flexLayoutPanel3.ShowCloseButton = false;
			this.flexLayoutPanel3.Size = new System.Drawing.Size(542, 47);
			this.flexLayoutPanel3.TabIndex = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
			this.checkBox1.Location = new System.Drawing.Point(6, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(142, 31);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Auto Center";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// separator1
			// 
			this.flexLayoutPanel3.SetFillWeight(this.separator1, 1);
			this.separator1.Location = new System.Drawing.Point(164, 8);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(175, 31);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(355, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 31);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(445, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 31);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1521, 665);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.flexLayoutPanel2.ResumeLayout(false);
			this.flexLayoutPanel2.PerformLayout();
			this.flexLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.FlexLayoutPanel panel1;
		private Web.FlexLayoutPanel flexLayoutPanel2;
		private Web.Label label3;
		private Web.TagTextBox tagTextBox1;
		private Web.FlexLayoutPanel flexLayoutPanel3;
		private Web.Button button1;
		private Web.Button button2;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.Label label1;
		private Web.Label label2;
		private Web.CheckBox checkBox1;
		private Web.Spacer separator1;
	}
}

