
namespace Wisej.JSWidgets.Views
{
    partial class frmJQueryKnob
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
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.label4 = new Wisej.Web.Label();
            this.lblCurrentTime = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.shape3 = new Wisej.Web.Shape();
            this.shape2 = new Wisej.Web.Shape();
            this.shape1 = new Wisej.Web.Shape();
            this.knobSecond = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.knobMinute = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.knobHour = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.timerCurrentTime = new Wisej.Web.Timer(this.components);
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.knobRandom = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.groupBox3 = new Wisej.Web.GroupBox();
            this.cmbBorderStyle = new Wisej.Web.ComboBox();
            this.cmbKnobStyle = new Wisej.Web.ComboBox();
            this.cmbLineStyle = new Wisej.Web.ComboBox();
            this.knobCustom = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shape3);
            this.groupBox1.Controls.Add(this.shape2);
            this.groupBox1.Controls.Add(this.shape1);
            this.groupBox1.Controls.Add(this.knobSecond);
            this.groupBox1.Controls.Add(this.knobMinute);
            this.groupBox1.Controls.Add(this.knobHour);
            this.groupBox1.Location = new System.Drawing.Point(29, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowCloseButton = true;
            this.groupBox1.Size = new System.Drawing.Size(394, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "KnobClock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Time: ";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(256, 432);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(8, 15);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // shape3
            // 
            this.shape3.BackColor = System.Drawing.Color.SlateBlue;
            this.shape3.BorderStyle.Size = 0;
            this.shape3.BorderStyleBottom.Size = 0;
            this.shape3.BorderStyleLeft.Size = 0;
            this.shape3.BorderStyleRight.Size = 0;
            this.shape3.BorderStyleTop.Size = 0;
            this.shape3.Location = new System.Drawing.Point(27, 429);
            this.shape3.Name = "shape3";
            this.shape3.Size = new System.Drawing.Size(19, 20);
            // 
            // shape2
            // 
            this.shape2.BackColor = System.Drawing.Color.Green;
            this.shape2.BorderStyle.Size = 0;
            this.shape2.BorderStyleBottom.Size = 0;
            this.shape2.BorderStyleLeft.Size = 0;
            this.shape2.BorderStyleRight.Size = 0;
            this.shape2.BorderStyleTop.Size = 0;
            this.shape2.Location = new System.Drawing.Point(27, 467);
            this.shape2.Name = "shape2";
            this.shape2.Size = new System.Drawing.Size(19, 20);
            // 
            // shape1
            // 
            this.shape1.BackColor = System.Drawing.Color.OrangeRed;
            this.shape1.BorderStyle.Size = 0;
            this.shape1.BorderStyleBottom.Size = 0;
            this.shape1.BorderStyleLeft.Size = 0;
            this.shape1.BorderStyleRight.Size = 0;
            this.shape1.BorderStyleTop.Size = 0;
            this.shape1.Location = new System.Drawing.Point(27, 392);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(19, 20);
            // 
            // knobSecond
            // 
            this.knobSecond.BackColor = System.Drawing.Color.FromArgb(2, 255, 255, 255);
            this.knobSecond.ForeColor = System.Drawing.Color.Green;
            this.knobSecond.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round;
            this.knobSecond.Location = new System.Drawing.Point(133, 151);
            this.knobSecond.MaxValue = 60;
            this.knobSecond.Name = "knobSecond";
            this.knobSecond.ShowInput = false;
            this.knobSecond.Size = new System.Drawing.Size(120, 115);
            this.knobSecond.TabIndex = 2;
            this.knobSecond.Text = "knob3";
            this.knobSecond.Value = 80;
            // 
            // knobMinute
            // 
            this.knobMinute.BackColor = System.Drawing.Color.FromArgb(2, 255, 255, 255);
            this.knobMinute.ForeColor = System.Drawing.Color.SlateBlue;
            this.knobMinute.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round;
            this.knobMinute.Location = new System.Drawing.Point(83, 100);
            this.knobMinute.MaxValue = 60;
            this.knobMinute.Name = "knobMinute";
            this.knobMinute.ShowInput = false;
            this.knobMinute.Size = new System.Drawing.Size(224, 218);
            this.knobMinute.TabIndex = 1;
            this.knobMinute.Text = "knob2";
            this.knobMinute.Value = 80;
            // 
            // knobHour
            // 
            this.knobHour.ForeColor = System.Drawing.Color.OrangeRed;
            this.knobHour.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round;
            this.knobHour.Location = new System.Drawing.Point(27, 42);
            this.knobHour.MaxValue = 24;
            this.knobHour.Name = "knobHour";
            this.knobHour.ShowInput = false;
            this.knobHour.Size = new System.Drawing.Size(336, 335);
            this.knobHour.TabIndex = 0;
            this.knobHour.Text = "knob1";
            this.knobHour.Value = 24;
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Interval = 800;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.knobRandom);
            this.groupBox2.Location = new System.Drawing.Point(451, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.ShowCloseButton = true;
            this.groupBox2.Size = new System.Drawing.Size(402, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Random position";
            // 
            // knobRandom
            // 
            this.knobRandom.AngleArc = 230;
            this.knobRandom.AngleOffset = 255;
            this.knobRandom.Location = new System.Drawing.Point(97, 42);
            this.knobRandom.MinValue = 10;
            this.knobRandom.Name = "knobRandom";
            this.knobRandom.Size = new System.Drawing.Size(212, 190);
            this.knobRandom.TabIndex = 0;
            this.knobRandom.Text = "knob1";
            this.knobRandom.Value = 90;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBorderStyle);
            this.groupBox3.Controls.Add(this.cmbKnobStyle);
            this.groupBox3.Controls.Add(this.cmbLineStyle);
            this.groupBox3.Controls.Add(this.knobCustom);
            this.groupBox3.Location = new System.Drawing.Point(451, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.ShowCloseButton = true;
            this.groupBox3.Size = new System.Drawing.Size(402, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "Properties";
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.LabelText = "Border Style";
            this.cmbBorderStyle.Location = new System.Drawing.Point(238, 175);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(158, 42);
            this.cmbBorderStyle.TabIndex = 4;
            this.cmbBorderStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBorderStyle_SelectedIndexChanged);
            // 
            // cmbKnobStyle
            // 
            this.cmbKnobStyle.LabelText = "Knob Style";
            this.cmbKnobStyle.Location = new System.Drawing.Point(238, 99);
            this.cmbKnobStyle.Name = "cmbKnobStyle";
            this.cmbKnobStyle.Size = new System.Drawing.Size(158, 42);
            this.cmbKnobStyle.TabIndex = 3;
            this.cmbKnobStyle.SelectedIndexChanged += new System.EventHandler(this.cmbKnobStyle_SelectedIndexChanged);
            // 
            // cmbLineStyle
            // 
            this.cmbLineStyle.LabelText = "Lyne Style";
            this.cmbLineStyle.Location = new System.Drawing.Point(238, 21);
            this.cmbLineStyle.Name = "cmbLineStyle";
            this.cmbLineStyle.Size = new System.Drawing.Size(158, 42);
            this.cmbLineStyle.TabIndex = 2;
            this.cmbLineStyle.SelectedIndexChanged += new System.EventHandler(this.cmbLineStyle_SelectedIndexChanged);
            // 
            // knobCustom
            // 
            this.knobCustom.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.knobCustom.LineCapStyle = Wisej.Web.Ext.jQueryKnob.LineCapType.Round;
            this.knobCustom.Location = new System.Drawing.Point(6, 21);
            this.knobCustom.Name = "knobCustom";
            this.knobCustom.Size = new System.Drawing.Size(226, 196);
            this.knobCustom.TabIndex = 1;
            this.knobCustom.Text = "knob1";
            this.knobCustom.Value = 60;
            // 
            // frmJQueryKnob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmJQueryKnob";
            this.Text = "frmJQueryKnob";
            this.Load += new System.EventHandler(this.frmJQueryKnob_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.GroupBox groupBox1;
        private Web.Ext.jQueryKnob.Knob knobSecond;
        private Web.Ext.jQueryKnob.Knob knobMinute;
        private Web.Ext.jQueryKnob.Knob knobHour;
        private Web.Timer timerCurrentTime;
        private Web.Label lblCurrentTime;
        private Web.Label label3;
        private Web.Label label2;
        private Web.Label label1;
        private Web.Shape shape3;
        private Web.Shape shape2;
        private Web.Shape shape1;
        private Web.Label label4;
        private Web.GroupBox groupBox2;
        private Web.Ext.jQueryKnob.Knob knobRandom;
        private Web.GroupBox groupBox3;
        private Web.ComboBox cmbBorderStyle;
        private Web.ComboBox cmbKnobStyle;
        private Web.ComboBox cmbLineStyle;
        private Web.Ext.jQueryKnob.Knob knobCustom;
    }
}