
using System;
using System.Threading;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.Notifications
{
    public partial class Window1 : Form
    {
        private Thread _customThread;
        private bool isRunning;
        public Window1()
        {
            InitializeComponent();
            btnStopThread.Enabled = false;
            _customThread = new Thread(ExcuteCustomThread);
        }

        private async void ExcuteCustomThread()
        {
            while (true)
            {
                if (isRunning)
                {
                    await Task.Delay(1500);
                    notificationObj.Show("title", "With another thread");
                    Application.Update(this);
                }
                
            }
        }

        private async Task LoadProgessBar()
        {
            
            int progressVal = 0;
            pgBar.Value = progressVal;
            while (true)
            {
                if (progressVal > 100)
                    break;
                pgBar.Text = progressVal.ToString() + "%";
                pgBar.Value = progressVal;
                progressVal += 10;
                
                await Task.Delay(900);
                Application.Update(this);
            }
        }

        private void btnSimpleNotification_Click(object sender, EventArgs e)
        {
            if (Wisej.Web.Ext.Notification.Notification.IsSupported)
                notificationObj.Show("Notification", "Direct notification");
            else
                AlertBox.Show("Notification is not supported on this Browser");
        }

        private async void btnNotificationAfterTask_Click(object sender, EventArgs e)
        {
            if (!(Wisej.Web.Ext.Notification.Notification.IsSupported))
            {
                AlertBox.Show("Notification is not supported on this Browser");
                return;
            }
            await Application.StartTask(async () =>
            {
                btnNotificationAfterTask.Enabled = false;
                await LoadProgessBar();
                btnNotificationAfterTask.Enabled = true;
                Application.Update(this);
                notificationObj.Show("Notification", "Notification after executing task");
                Application.Update(this);
            });
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            if (!(Wisej.Web.Ext.Notification.Notification.IsSupported))
            {
                AlertBox.Show("Notification is not supported on this Browser");
                return;
            }
            btnStartThread.Enabled = false;
            btnStopThread.Enabled = true;
            isRunning = true;
            if (_customThread.ThreadState == ThreadState.Unstarted)
                _customThread.Start();
        }

        private void btnStopThread_Click(object sender, EventArgs e)
        {
            isRunning = false;
            btnStartThread.Enabled = true;
            btnStopThread.Enabled = false;
        }

        private void linkBrowserCompatibility_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Navigate("https://support.google.com/chrome/answer/3220216?co=GENIE.Platform%3DDesktop&hl=en", "_blank");
        }

        private void linkNotificationDetailGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Navigate("https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.Notification", "_blank");
        }
    }
}
