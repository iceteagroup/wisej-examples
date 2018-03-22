namespace Wisej.PolymerExample
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
			this.polymerWidget1 = new Wisej.Web.Ext.Polymer.PolymerWidget();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.label3 = new Wisej.Web.Label();
			this.label4 = new Wisej.Web.Label();
			this.styleSheet = new Wisej.Web.StyleSheet(this.components);
			this.paperButton1 = new Wisej.PolymerExample.PaperButton();
			this.polymerComponent1 = new Wisej.Web.Ext.Polymer.PolymerComponent(this.components);
			this.googleChart1 = new Wisej.PolymerExample.GoogleChart();
			this.paperRadioButton2 = new Wisej.PolymerExample.PaperRadioButton();
			this.paperRadioButton1 = new Wisej.PolymerExample.PaperRadioButton();
			this.paperRadioGroup1 = new Wisej.PolymerExample.PaperRadioGroup();
			this.ironIcon1 = new Wisej.PolymerExample.IronIcon();
			this.paperProgress1 = new Wisej.PolymerExample.PaperProgress();
			this.paperSlider1 = new Wisej.PolymerExample.PaperSlider();
			this.paperCheckBox1 = new Wisej.PolymerExample.PaperCheckBox();
			this.SuspendLayout();
			// 
			// polymerWidget1
			// 
			this.polymerWidget1.ElementType = "paper-slider";
			this.polymerWidget1.Events = new string[] {
        "change"};
			this.polymerWidget1.Location = new System.Drawing.Point(43, 83);
			this.polymerWidget1.Name = "polymerWidget1";
			this.polymerWidget1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":10}")));
			this.polymerWidget1.Size = new System.Drawing.Size(184, 47);
			this.polymerWidget1.TabIndex = 4;
			this.polymerWidget1.Text = "polymerWidget1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Polymer Created on the Page";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Specialized Polymer Classes";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(300, 285);
			this.button1.Name = "button1";
			this.button1.Repeat = true;
			this.button1.Size = new System.Drawing.Size(36, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "+";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(342, 285);
			this.button2.Name = "button2";
			this.button2.Repeat = true;
			this.button2.Size = new System.Drawing.Size(36, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "-";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.BorderStyle = Wisej.Web.BorderStyle.Double;
			this.label3.Location = new System.Drawing.Point(394, 287);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 23);
			this.label3.TabIndex = 11;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = Wisej.Web.BorderStyle.Double;
			this.label4.Location = new System.Drawing.Point(300, 225);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 23);
			this.label4.TabIndex = 12;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// styleSheet
			// 
			this.styleSheet.Styles = resources.GetString("styleSheet.Styles");
			// 
			// paperButton1
			// 
			this.styleSheet.SetCssClass(this.paperButton1, "paper");
			this.paperButton1.ElementClassName = "circle red";
			this.paperButton1.Location = new System.Drawing.Point(43, 408);
			this.paperButton1.Name = "paperButton1";
			this.paperButton1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.paperButton1.Size = new System.Drawing.Size(115, 115);
			this.paperButton1.TabIndex = 14;
			this.paperButton1.Text = "\r\n<div style=\"\r\n    text-align:center;\r\n    position:relative;\r\n    top:50%;\r\n   " +
    " transform:translateY(-50%)\">\r\n<iron-icon icon=\"file-download\"></iron-icon>Click" +
    " Me\r\n</div>";
			this.paperButton1.Click += new System.EventHandler(this.paperButton1_Click);
			// 
			// polymerComponent1
			// 
			this.polymerComponent1.Imports = new string[] {
        "iron-icons/iron-icons.html",
        "iron-icons/maps-icons.html"};
			// 
			// googleChart1
			// 
			this.googleChart1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.googleChart1.Location = new System.Drawing.Point(537, 109);
			this.googleChart1.Name = "googleChart1";
			this.googleChart1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selection\":[{\"row\":0,\"column\":0}],\"options\":{}}")));
			this.googleChart1.Size = new System.Drawing.Size(294, 201);
			this.googleChart1.TabIndex = 19;
			this.googleChart1.Text = "googleChart1";
			this.googleChart1.SelectionChanged += new System.EventHandler(this.googleChart1_SelectionChanged);
			// 
			// paperRadioButton2
			// 
			this.paperRadioButton2.Location = new System.Drawing.Point(415, 433);
			this.paperRadioButton2.Name = "paperRadioButton2";
			this.paperRadioButton2.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"checked\":false}")));
			this.paperRadioButton2.Size = new System.Drawing.Size(160, 23);
			this.paperRadioButton2.TabIndex = 18;
			this.paperRadioButton2.Text = "paperRadioButton2";
			this.paperRadioButton2.CheckedChanged += new System.EventHandler(this.paperRadioButton2_CheckedChanged);
			// 
			// paperRadioButton1
			// 
			this.paperRadioButton1.Location = new System.Drawing.Point(226, 433);
			this.paperRadioButton1.Name = "paperRadioButton1";
			this.paperRadioButton1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"checked\":false}")));
			this.paperRadioButton1.Size = new System.Drawing.Size(152, 23);
			this.paperRadioButton1.TabIndex = 17;
			this.paperRadioButton1.Text = "paperRadioButton1";
			this.paperRadioButton1.CheckedChanged += new System.EventHandler(this.paperRadioButton1_CheckedChanged);
			// 
			// paperRadioGroup1
			// 
			this.paperRadioGroup1.Location = new System.Drawing.Point(291, 48);
			this.paperRadioGroup1.Name = "paperRadioGroup1";
			this.paperRadioGroup1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selected\":\"\"}")));
			this.paperRadioGroup1.Size = new System.Drawing.Size(308, 45);
			this.paperRadioGroup1.TabIndex = 16;
			this.paperRadioGroup1.Text = "<paper-radio-button name=\"small\">Small</paper-radio-button>\r\n  <paper-radio-butto" +
    "n name=\"medium\">Medium</paper-radio-button>\r\n  <paper-radio-button name=\"large\">" +
    "Large</paper-radio-button>";
			this.paperRadioGroup1.SelectedChanged += new System.EventHandler(this.paperRadioGroup1_SelectedChanged);
			// 
			// ironIcon1
			// 
			this.ironIcon1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.ironIcon1.Location = new System.Drawing.Point(43, 581);
			this.ironIcon1.Name = "ironIcon1";
			this.ironIcon1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"icon\":\"face\"}")));
			this.ironIcon1.Size = new System.Drawing.Size(115, 82);
			this.ironIcon1.TabIndex = 15;
			// 
			// paperProgress1
			// 
			this.paperProgress1.ElementClassName = "green";
			this.paperProgress1.Location = new System.Drawing.Point(43, 365);
			this.paperProgress1.Name = "paperProgress1";
			this.paperProgress1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.paperProgress1.Size = new System.Drawing.Size(400, 23);
			this.paperProgress1.TabIndex = 13;
			this.paperProgress1.Text = "paperProgress1";
			// 
			// paperSlider1
			// 
			this.paperSlider1.Location = new System.Drawing.Point(43, 285);
			this.paperSlider1.Name = "paperSlider1";
			this.paperSlider1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":0,\"pin\":true}")));
			this.paperSlider1.Size = new System.Drawing.Size(180, 23);
			this.paperSlider1.TabIndex = 8;
			this.paperSlider1.Text = "polymerSlider1";
			this.paperSlider1.ValueChanged += new System.EventHandler(this.paperSlider1_ValueChanged);
			// 
			// paperCheckBox1
			// 
			this.paperCheckBox1.Location = new System.Drawing.Point(43, 225);
			this.paperCheckBox1.Name = "paperCheckBox1";
			this.paperCheckBox1.Properties = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"checked\":false}")));
			this.paperCheckBox1.Size = new System.Drawing.Size(105, 23);
			this.paperCheckBox1.TabIndex = 7;
			this.paperCheckBox1.Text = "CheckBox";
			this.paperCheckBox1.CheckedChanged += new System.EventHandler(this.paperCheckBox1_CheckedChanged);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.googleChart1);
			this.Controls.Add(this.paperRadioButton2);
			this.Controls.Add(this.paperRadioButton1);
			this.Controls.Add(this.paperRadioGroup1);
			this.Controls.Add(this.ironIcon1);
			this.Controls.Add(this.paperButton1);
			this.Controls.Add(this.paperProgress1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.paperSlider1);
			this.Controls.Add(this.paperCheckBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.polymerWidget1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1299, 791);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Ext.Polymer.PolymerWidget polymerWidget1;
		private Web.Label label1;
		private Web.Label label2;
		private PaperCheckBox paperCheckBox1;
		private PaperSlider paperSlider1;
		private Web.Button button1;
		private Web.Button button2;
		private Web.Label label3;
		private Web.Label label4;
		private PaperProgress paperProgress1;
		private PaperButton paperButton1;
		private Web.StyleSheet styleSheet;
		private IronIcon ironIcon1;
		private Web.Ext.Polymer.PolymerComponent polymerComponent1;
		private PaperRadioGroup paperRadioGroup1;
		private PaperRadioButton paperRadioButton1;
		private PaperRadioButton paperRadioButton2;
		private GoogleChart googleChart1;
	}
}
