
namespace Wisej.JSWidgets.Views
{
    partial class frmBubbles
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
            this.cbx = new Wisej.Web.ComboBox();
            this.btn = new Wisej.Web.Button();
            this.numUpDwn = new Wisej.Web.NumericUpDown();
            this.txtbx = new Wisej.Web.TextBox();
            this.tagtxtbx = new Wisej.Web.TagTextBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.lblCurrentUser = new Wisej.Web.Label();
            this.pannelMsgs = new Wisej.Web.Panel();
            this.lvMsgs = new Wisej.Web.ListBox();
            this.btnConfirmUsername = new Wisej.Web.Button();
            this.txtbxUsername = new Wisej.Web.TextBox();
            this.btnSendMessage = new Wisej.Web.Button();
            this.txtbxMessage = new Wisej.Web.TextBox();
            this.bubble = new Wisej.Web.Ext.Bubbles.BubbleNotification(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pannelMsgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.numUpDwn);
            this.groupBox1.Controls.Add(this.txtbx);
            this.groupBox1.Controls.Add(this.tagtxtbx);
            this.groupBox1.Location = new System.Drawing.Point(40, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Forms";
            // 
            // cbx
            // 
            this.cbx.Location = new System.Drawing.Point(14, 220);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(351, 22);
            this.cbx.TabIndex = 4;
            this.cbx.SelectedValueChanged += new System.EventHandler(this.cbx_SelectedValueChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(14, 170);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(155, 27);
            this.btn.TabIndex = 3;
            this.btn.Text = "Increment";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // numUpDwn
            // 
            this.numUpDwn.Location = new System.Drawing.Point(14, 122);
            this.numUpDwn.Name = "numUpDwn";
            this.numUpDwn.Size = new System.Drawing.Size(351, 22);
            this.numUpDwn.TabIndex = 2;
            this.numUpDwn.ValueChanged += new System.EventHandler(this.numUpDwn_ValueChanged);
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(14, 75);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(351, 22);
            this.txtbx.TabIndex = 1;
            this.txtbx.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // tagtxtbx
            // 
            this.tagtxtbx.Location = new System.Drawing.Point(14, 23);
            this.tagtxtbx.Name = "tagtxtbx";
            this.tagtxtbx.Size = new System.Drawing.Size(351, 28);
            this.tagtxtbx.TabIndex = 0;
            this.tagtxtbx.TagAdded += new Wisej.Web.TagTextBoxEventHandler(this.tagtxtbx_TagAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCurrentUser);
            this.groupBox2.Controls.Add(this.pannelMsgs);
            this.groupBox2.Controls.Add(this.btnConfirmUsername);
            this.groupBox2.Controls.Add(this.txtbxUsername);
            this.groupBox2.Controls.Add(this.btnSendMessage);
            this.groupBox2.Controls.Add(this.txtbxMessage);
            this.groupBox2.Location = new System.Drawing.Point(473, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 521);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Simple chat";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(8, 52);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(8, 15);
            this.lblCurrentUser.TabIndex = 5;
            this.lblCurrentUser.Text = "-";
            // 
            // pannelMsgs
            // 
            this.pannelMsgs.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pannelMsgs.Controls.Add(this.lvMsgs);
            this.pannelMsgs.Location = new System.Drawing.Point(8, 75);
            this.pannelMsgs.Name = "pannelMsgs";
            this.pannelMsgs.Size = new System.Drawing.Size(569, 361);
            this.pannelMsgs.TabIndex = 4;
            this.pannelMsgs.TabStop = true;
            // 
            // lvMsgs
            // 
            this.lvMsgs.Dock = Wisej.Web.DockStyle.Fill;
            this.lvMsgs.Location = new System.Drawing.Point(0, 0);
            this.lvMsgs.Name = "lvMsgs";
            this.lvMsgs.Size = new System.Drawing.Size(569, 361);
            this.lvMsgs.TabIndex = 0;
            // 
            // btnConfirmUsername
            // 
            this.btnConfirmUsername.Location = new System.Drawing.Point(486, 20);
            this.btnConfirmUsername.Name = "btnConfirmUsername";
            this.btnConfirmUsername.Size = new System.Drawing.Size(91, 27);
            this.btnConfirmUsername.TabIndex = 3;
            this.btnConfirmUsername.Text = "Confirm";
            this.btnConfirmUsername.Click += new System.EventHandler(this.btnConfirmUsername_Click);
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(8, 22);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(454, 22);
            this.txtbxUsername.TabIndex = 2;
            this.txtbxUsername.Watermark = "Set your username";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnSendMessage.Enabled = false;
            this.btnSendMessage.Location = new System.Drawing.Point(486, 486);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(91, 27);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtbxMessage
            // 
            this.txtbxMessage.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.txtbxMessage.Enabled = false;
            this.txtbxMessage.Location = new System.Drawing.Point(8, 453);
            this.txtbxMessage.Multiline = true;
            this.txtbxMessage.Name = "txtbxMessage";
            this.txtbxMessage.Size = new System.Drawing.Size(470, 61);
            this.txtbxMessage.TabIndex = 0;
            this.txtbxMessage.Watermark = "Type your message";
            // 
            // bubble
            // 
            this.bubble.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmBubbles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBubbles";
            this.Text = "Bubbles";
            this.Load += new System.EventHandler(this.frmBubbles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pannelMsgs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.GroupBox groupBox1;
        private Web.GroupBox groupBox2;
        private Web.Panel pannelMsgs;
        private Web.Button btnConfirmUsername;
        private Web.TextBox txtbxUsername;
        private Web.Button btnSendMessage;
        private Web.TextBox txtbxMessage;
        private Web.Label lblCurrentUser;
        private Web.ListBox lvMsgs;
        private Web.Ext.Bubbles.BubbleNotification bubble;
        private Web.ComboBox cbx;
        private Web.Button btn;
        private Web.NumericUpDown numUpDwn;
        private Web.TextBox txtbx;
        private Web.TagTextBox tagtxtbx;
    }
}