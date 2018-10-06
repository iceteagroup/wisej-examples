namespace Wisej.FullCalendar
{
    partial class EventEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventEditor));
			this.buttonOK = new Wisej.Web.Button();
			this.buttonClose = new Wisej.Web.Button();
			this.label4 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label1 = new Wisej.Web.Label();
			this.eventID = new Wisej.Web.TextBox();
			this.eventStart = new Wisej.Web.DateTimePicker();
			this.eventEnd = new Wisej.Web.DateTimePicker();
			this.eventText = new Wisej.Web.TextBox();
			this.eventType = new Wisej.Web.ComboBox();
			this.label5 = new Wisej.Web.Label();
			this.styleSheet1 = new Wisej.Web.StyleSheet(this.components);
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonOK.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(131, 418);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(129, 36);
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonClose.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(266, 418);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(129, 36);
			this.buttonClose.TabIndex = 11;
			this.buttonClose.Text = "Close";
			this.buttonClose.CausesValidation = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Text";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "End";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Start";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// eventID
			// 
			this.eventID.AutoSize = false;
			this.eventID.InvalidMessage = "Please enter a unique ID.";
			this.eventID.Location = new System.Drawing.Point(80, 26);
			this.eventID.Name = "eventID";
			this.eventID.Size = new System.Drawing.Size(100, 30);
			this.eventID.TabIndex = 1;
			this.eventID.Validating += new System.ComponentModel.CancelEventHandler(this.eventID_Validating);
			// 
			// eventStart
			// 
			this.eventStart.AutoSize = false;
			this.eventStart.Format = Wisej.Web.DateTimePickerFormat.DateTime;
			this.eventStart.Location = new System.Drawing.Point(80, 76);
			this.eventStart.Name = "eventStart";
			this.eventStart.Size = new System.Drawing.Size(200, 30);
			this.eventStart.TabIndex = 3;
			this.eventStart.Value = new System.DateTime(2017, 2, 8, 16, 20, 0, 0);
			// 
			// eventEnd
			// 
			this.eventEnd.AutoSize = false;
			this.eventEnd.Format = Wisej.Web.DateTimePickerFormat.DateTime;
			this.eventEnd.Location = new System.Drawing.Point(80, 126);
			this.eventEnd.Name = "eventEnd";
			this.eventEnd.Size = new System.Drawing.Size(200, 30);
			this.eventEnd.TabIndex = 5;
			this.eventEnd.Value = new System.DateTime(2017, 2, 8, 16, 21, 0, 0);
			// 
			// eventText
			// 
			this.eventText.AutoSize = false;
			this.eventText.Location = new System.Drawing.Point(80, 226);
			this.eventText.Multiline = true;
			this.eventText.Name = "eventText";
			this.eventText.Size = new System.Drawing.Size(315, 125);
			this.eventText.TabIndex = 9;
			// 
			// eventType
			// 
			this.eventType.AllowHtml = true;
			this.eventType.AutoSize = false;
			this.eventType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.eventType.Location = new System.Drawing.Point(80, 176);
			this.eventType.Name = "eventType";
			this.eventType.Size = new System.Drawing.Size(200, 30);
			this.eventType.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Type";
			// 
			// styleSheet1
			// 
			this.styleSheet1.Styles = resources.GetString("styleSheet1.Styles");
			// 
			// EventEditor
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(409, 469);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.eventType);
			this.Controls.Add(this.eventText);
			this.Controls.Add(this.eventEnd);
			this.Controls.Add(this.eventStart);
			this.Controls.Add(this.eventID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EventEditor";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Edit Event";
			this.Load += new System.EventHandler(this.EventEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button buttonOK;
        private Wisej.Web.Button buttonClose;
        private Web.Label label4;
        private Web.Label label3;
        private Web.Label label2;
        private Web.Label label1;
        private Web.TextBox eventID;
        private Web.DateTimePicker eventStart;
        private Web.DateTimePicker eventEnd;
        private Web.TextBox eventText;
		private Web.ComboBox eventType;
		private Web.Label label5;
		private Web.StyleSheet styleSheet1;
	}
}