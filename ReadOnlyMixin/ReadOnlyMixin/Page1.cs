using System;
using Wisej.Web;

namespace ReadOnlyMixin
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Appear(object sender, EventArgs e)
        {
            SetState(controlState.Text);
        }

        private void comboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            SetState(controlState.Text);
        }

        private void SetState(string state)
        {
            statePanel.Text = state;

            var isDisabled = state == "Disabled";
            var isReadOnly = state == "ReadOnly";

            foreach (Control control in statePanel.Controls)
            {
                control.Enabled = !isDisabled;
                var type = control.GetType();

                if (type == typeof(TextBox))
                    ((TextBox) control).ReadOnly = isReadOnly;
                else if (type == typeof(ComboBox))
                    ((ComboBox) control).ReadOnly = isReadOnly;
                else if (type == typeof(DomainUpDown))
                    ((DomainUpDown) control).ReadOnly = isReadOnly;
                else if (type == typeof(NumericUpDown))
                    ((NumericUpDown) control).ReadOnly = isReadOnly;
                else if (type == typeof(DateTimePicker))
                    ((DateTimePicker) control).ReadOnly = isReadOnly;
                else if (type == typeof(ListBox))
                    ((ListBox) control).ReadOnly = isReadOnly;
            }
        }
    }
}