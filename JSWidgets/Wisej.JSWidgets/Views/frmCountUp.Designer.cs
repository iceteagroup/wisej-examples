
namespace Wisej.JSWidgets.Views
{
    partial class frmCountUp
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
            this.countUp1 = new Wisej.Web.Ext.CountUp.CountUp();
            this.nudNewValue = new Wisej.Web.NumericUpDown();
            this.chkGrouping = new Wisej.Web.CheckBox();
            this.chkEasing = new Wisej.Web.CheckBox();
            this.btnApplyValue = new Wisej.Web.Button();
            this.nudDuration = new Wisej.Web.NumericUpDown();
            this.btnNewDuration = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // countUp1
            // 
            this.countUp1.Font = new System.Drawing.Font("default", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.countUp1.Location = new System.Drawing.Point(28, 28);
            this.countUp1.Name = "countUp1";
            this.countUp1.Size = new System.Drawing.Size(716, 60);
            this.countUp1.TabIndex = 0;
            this.countUp1.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.countUp1.Value = 9550F;
            // 
            // nudNewValue
            // 
            this.nudNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudNewValue.LabelText = "Value";
            this.nudNewValue.Location = new System.Drawing.Point(14, 128);
            this.nudNewValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudNewValue.Name = "nudNewValue";
            this.nudNewValue.Size = new System.Drawing.Size(228, 53);
            this.nudNewValue.TabIndex = 1;
            this.nudNewValue.Value = new decimal(new int[] {
            9550,
            0,
            0,
            0});
            // 
            // chkGrouping
            // 
            this.chkGrouping.Checked = true;
            this.chkGrouping.CheckState = Wisej.Web.CheckState.Checked;
            this.chkGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkGrouping.Location = new System.Drawing.Point(14, 307);
            this.chkGrouping.Name = "chkGrouping";
            this.chkGrouping.Size = new System.Drawing.Size(155, 30);
            this.chkGrouping.TabIndex = 2;
            this.chkGrouping.Text = "Use Grouping";
            this.chkGrouping.CheckedChanged += new System.EventHandler(this.chkGrouping_CheckedChanged);
            // 
            // chkEasing
            // 
            this.chkEasing.Checked = true;
            this.chkEasing.CheckState = Wisej.Web.CheckState.Checked;
            this.chkEasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkEasing.Location = new System.Drawing.Point(14, 358);
            this.chkEasing.Name = "chkEasing";
            this.chkEasing.Size = new System.Drawing.Size(134, 30);
            this.chkEasing.TabIndex = 3;
            this.chkEasing.Text = "Use Easing";
            this.chkEasing.CheckedChanged += new System.EventHandler(this.chkEasing_CheckedChanged);
            // 
            // btnApplyValue
            // 
            this.btnApplyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnApplyValue.Location = new System.Drawing.Point(282, 154);
            this.btnApplyValue.Name = "btnApplyValue";
            this.btnApplyValue.Size = new System.Drawing.Size(191, 27);
            this.btnApplyValue.TabIndex = 4;
            this.btnApplyValue.Text = "Apply New Value";
            this.btnApplyValue.Click += new System.EventHandler(this.btnApplyValue_Click);
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nudDuration.LabelText = "Duration";
            this.nudDuration.Location = new System.Drawing.Point(14, 222);
            this.nudDuration.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(228, 53);
            this.nudDuration.TabIndex = 5;
            this.nudDuration.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // btnNewDuration
            // 
            this.btnNewDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNewDuration.Location = new System.Drawing.Point(282, 248);
            this.btnNewDuration.Name = "btnNewDuration";
            this.btnNewDuration.Size = new System.Drawing.Size(191, 27);
            this.btnNewDuration.TabIndex = 4;
            this.btnNewDuration.Text = "Apply Duration";
            this.btnNewDuration.Click += new System.EventHandler(this.btnNewDuration_Click);
            // 
            // frmCountUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 528);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.btnNewDuration);
            this.Controls.Add(this.btnApplyValue);
            this.Controls.Add(this.chkEasing);
            this.Controls.Add(this.chkGrouping);
            this.Controls.Add(this.nudNewValue);
            this.Controls.Add(this.countUp1);
            this.Name = "frmCountUp";
            this.Text = "CountUp";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.CountUp.CountUp countUp1;
        private Web.NumericUpDown nudNewValue;
        private Web.CheckBox chkGrouping;
        private Web.CheckBox chkEasing;
        private Web.Button btnApplyValue;
        private Web.NumericUpDown nudDuration;
        private Web.Button btnNewDuration;
    }
}