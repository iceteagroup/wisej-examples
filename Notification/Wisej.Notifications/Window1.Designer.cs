
namespace Wisej.Notifications
{
    partial class Window1
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
            this.notificationObj = new Wisej.Web.Ext.Notification.Notification(this.components);
            this.btnSimpleNotification = new Wisej.Web.Button();
            this.btnNotificationAfterTask = new Wisej.Web.Button();
            this.pgBar = new Wisej.Web.ProgressBar();
            this.btnStartThread = new Wisej.Web.Button();
            this.btnStopThread = new Wisej.Web.Button();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.groupBox3 = new Wisej.Web.GroupBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.linkBrowserCompatibility = new Wisej.Web.LinkLabel();
            this.linkNotificationDetailGithub = new Wisej.Web.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpleNotification
            // 
            this.btnSimpleNotification.Location = new System.Drawing.Point(5, 41);
            this.btnSimpleNotification.Name = "btnSimpleNotification";
            this.btnSimpleNotification.Size = new System.Drawing.Size(189, 31);
            this.btnSimpleNotification.TabIndex = 0;
            this.btnSimpleNotification.Text = "Show Notification";
            this.btnSimpleNotification.Click += new System.EventHandler(this.btnSimpleNotification_Click);
            // 
            // btnNotificationAfterTask
            // 
            this.btnNotificationAfterTask.Location = new System.Drawing.Point(5, 41);
            this.btnNotificationAfterTask.Name = "btnNotificationAfterTask";
            this.btnNotificationAfterTask.Size = new System.Drawing.Size(189, 31);
            this.btnNotificationAfterTask.TabIndex = 2;
            this.btnNotificationAfterTask.Text = "Notification aftter task";
            this.btnNotificationAfterTask.Click += new System.EventHandler(this.btnNotificationAfterTask_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(15, 80);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(174, 24);
            this.pgBar.TabIndex = 1;
            this.pgBar.Text = "0%";
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(29, 39);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(150, 33);
            this.btnStartThread.TabIndex = 3;
            this.btnStartThread.Text = "Start with thread";
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // btnStopThread
            // 
            this.btnStopThread.BackColor = System.Drawing.Color.FromName("@bubble-alert-background");
            this.btnStopThread.Location = new System.Drawing.Point(233, 39);
            this.btnStopThread.Name = "btnStopThread";
            this.btnStopThread.Size = new System.Drawing.Size(150, 33);
            this.btnStopThread.TabIndex = 4;
            this.btnStopThread.Text = "Stop diffusion";
            this.btnStopThread.Click += new System.EventHandler(this.btnStopThread_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimpleNotification);
            this.groupBox1.Location = new System.Drawing.Point(40, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowCheckBox = true;
            this.groupBox1.ShowCloseButton = true;
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "Simple Click Notification";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNotificationAfterTask);
            this.groupBox2.Controls.Add(this.pgBar);
            this.groupBox2.Location = new System.Drawing.Point(287, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.ShowCheckBox = true;
            this.groupBox2.ShowCloseButton = true;
            this.groupBox2.Size = new System.Drawing.Size(200, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.Text = "Notification after task";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartThread);
            this.groupBox3.Controls.Add(this.btnStopThread);
            this.groupBox3.Location = new System.Drawing.Point(550, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.ShowCheckBox = true;
            this.groupBox3.ShowCloseButton = true;
            this.groupBox3.Size = new System.Drawing.Size(389, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.Text = "Notification with thread";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "More details for notification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "More details of Wisej.Web.Ext.Notification";
            // 
            // linkBrowserCompatibility
            // 
            this.linkBrowserCompatibility.AutoSize = true;
            this.linkBrowserCompatibility.Location = new System.Drawing.Point(203, 185);
            this.linkBrowserCompatibility.Name = "linkBrowserCompatibility";
            this.linkBrowserCompatibility.Size = new System.Drawing.Size(37, 15);
            this.linkBrowserCompatibility.TabIndex = 10;
            this.linkBrowserCompatibility.Text = "go to.";
            this.linkBrowserCompatibility.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkBrowserCompatibility_LinkClicked);
            // 
            // linkNotificationDetailGithub
            // 
            this.linkNotificationDetailGithub.AutoSize = true;
            this.linkNotificationDetailGithub.Location = new System.Drawing.Point(290, 223);
            this.linkNotificationDetailGithub.Name = "linkNotificationDetailGithub";
            this.linkNotificationDetailGithub.Size = new System.Drawing.Size(37, 15);
            this.linkNotificationDetailGithub.TabIndex = 11;
            this.linkNotificationDetailGithub.Text = "go to.";
            this.linkNotificationDetailGithub.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkNotificationDetailGithub_LinkClicked);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 268);
            this.Controls.Add(this.linkNotificationDetailGithub);
            this.Controls.Add(this.linkBrowserCompatibility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Window1";
            this.Text = "Wisej Notification Sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.Notification.Notification notificationObj;
        private Web.Button btnSimpleNotification;
        private Web.Button btnNotificationAfterTask;
        private Web.ProgressBar pgBar;
        private Web.Button btnStartThread;
        private Web.Button btnStopThread;
        private Web.GroupBox groupBox1;
        private Web.GroupBox groupBox2;
        private Web.GroupBox groupBox3;
        private Web.Label label1;
        private Web.Label label2;
        private Web.LinkLabel linkBrowserCompatibility;
        private Web.LinkLabel linkNotificationDetailGithub;
    }
}

