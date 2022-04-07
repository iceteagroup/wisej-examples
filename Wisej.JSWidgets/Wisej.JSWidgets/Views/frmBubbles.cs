using System;
using System.Linq;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.JSWidgets.Views
{
    public partial class frmBubbles : Form
    {
        private int _maxTags = 4;
        private int _click = 0;
        private Models.User CurrentUser { get; set; }
        private readonly Wisej.Web.Ext.Notification.Notification _notification;
        private List<object> _comboBoxData;

        public frmBubbles()
        {
            InitializeComponent();

            _notification = new Web.Ext.Notification.Notification();
            _comboBoxData = new List<object>();

            lvMsgs.DataSource = AppData.Messages;

            AppData.RaiseNewMessage += AppData_RaiseNewMessage;
            bubble.SetBubbleStyle(lblCurrentUser, Web.Ext.Bubbles.BubbleStyle.Alert);
            IniliazizeComboBox();

        }

        private void IniliazizeComboBox()
        {
            for (var i = 1; i <= 10; i++)
                _comboBoxData.Add(new
                {
                    Id = i,
                    Item = $"Item - {i}"
                });
            cbx.ValueMember = "Id";
            cbx.DisplayMember = "Item";
            cbx.DataSource = _comboBoxData;
        }

        private void btnConfirmUsername_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrWhiteSpace(txtbxUsername.Text))
                    throw new Exception("Username is required");

                Application.RunInContext(this, () =>
                {
                    CurrentUser = new Models.User
                    {
                        SessionId = Application.SessionId,
                        Username = txtbxUsername.Text
                    };
                    AppData.AddUser(CurrentUser);
                    lblCurrentUser.Text = CurrentUser.Username;
                });
                txtbxUsername.Enabled = false;
                btnConfirmUsername.Enabled = false;
                txtbxMessage.Enabled = true;
                btnSendMessage.Enabled = true;
            }
            catch (Exception ex)
            {
                AlertBox.Show(ex.Message, MessageBoxIcon.Error);
            }
        }

        private void frmBubbles_Load(object sender, EventArgs e)
        {
            bubble.SetBubbleValue(tagtxtbx, _maxTags);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbxMessage.Text) || string.IsNullOrWhiteSpace(txtbxMessage.Text))
                    throw new Exception("Message must have a value");

                AppData.AddMessage(new Models.Message
                {
                    Content = txtbxMessage.Text,
                    Date = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    Sender = CurrentUser
                });
            }
            catch (Exception ex)
            {
                AlertBox.Show(ex.Message, MessageBoxIcon.Error);
            }
        }

        private void AppData_RaiseNewMessage(object sender, Models.MessageEventArgs e)
        {
            if (CurrentUser.SessionId != ((Models.User)sender).SessionId)
            {
                Application.Update(this, () =>
                {
                    var bubbleValue = bubble.GetBubbleValue(lblCurrentUser);
                    if ( bubbleValue == 0)
                        bubble.SetBubbleValue(lblCurrentUser, 1);
                    else
                        bubble.SetBubbleValue(lblCurrentUser, bubbleValue + 1);
                    _notification.Show("New message", "New message from " + ((Models.User)sender).Username);
                });
            }
                
        }

        private void tagtxtbx_TagAdded(object sender, TagTextBoxEventArgs e)
        {
            if(_maxTags <= 1)
            {
                var lists = tagtxtbx.Text.Split(',').ToList();
                lists.Remove(e.Text);
                tagtxtbx.Text = string.Join(",", lists);
                AlertBox.Show("Max tag is arrived", MessageBoxIcon.Hand, true);
                Application.Update(this);
                return;
            }
            else
            {
                _maxTags--;
                bubble.SetBubbleValue(tagtxtbx, _maxTags);
            }
            Application.Update(this);

        }

        private void cbx_SelectedValueChanged(object sender, EventArgs e)
        {
            bubble.SetBubbleValue(cbx, Convert.ToInt32(cbx.SelectedIndex) + 1);
        }

        private void numUpDwn_ValueChanged(object sender, EventArgs e)
        {
            bubble.SetBubbleValue(numUpDwn, Convert.ToInt32 (numUpDwn.Value));
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            bubble.SetBubbleValue(txtbx, txtbx.Text.Length);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            _click++;
            bubble.SetBubbleValue(btn, _click);
        }
    }
}
