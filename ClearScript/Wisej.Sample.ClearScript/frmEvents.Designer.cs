
namespace Wisej.Sample.ClrScript
{
    partial class frmEvents
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
            this.btnForm = new Wisej.Web.Button();
            this.txtKeyPress = new Wisej.Web.TextBox();
            this.btnAlert = new Wisej.Web.Button();
            this.btnMsgBox = new Wisej.Web.Button();
            this.lblKeyPressResult = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(18, 33);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(180, 52);
            this.btnForm.TabIndex = 0;
            this.btnForm.Text = "Click me!";
            // 
            // txtKeyPress
            // 
            this.txtKeyPress.LabelText = "Write something!";
            this.txtKeyPress.Location = new System.Drawing.Point(18, 113);
            this.txtKeyPress.Name = "txtKeyPress";
            this.txtKeyPress.Size = new System.Drawing.Size(614, 42);
            this.txtKeyPress.TabIndex = 1;
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(628, 171);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(129, 41);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "Alert";
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(464, 171);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(142, 41);
            this.btnMsgBox.TabIndex = 3;
            this.btnMsgBox.Text = "MessageBox";
            // 
            // lblKeyPressResult
            // 
            this.lblKeyPressResult.AutoSize = true;
            this.lblKeyPressResult.Location = new System.Drawing.Point(18, 161);
            this.lblKeyPressResult.Name = "lblKeyPressResult";
            this.lblKeyPressResult.Size = new System.Drawing.Size(39, 15);
            this.lblKeyPressResult.TabIndex = 4;
            this.lblKeyPressResult.Text = "label1";
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 233);
            this.Controls.Add(this.lblKeyPressResult);
            this.Controls.Add(this.btnMsgBox);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.txtKeyPress);
            this.Controls.Add(this.btnForm);
            this.Name = "frmEvents";
            this.Text = "Events Sample";
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Web.Button btnForm;
        public Web.TextBox txtKeyPress;
        public Web.Button btnAlert;
        public Web.Button btnMsgBox;
        public Web.Label lblKeyPressResult;
    }
}