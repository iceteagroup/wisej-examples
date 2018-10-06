using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.FullCalendar
{
	public partial class EventEditor : Form
	{
		public Wisej.Web.Ext.FullCalendar.Event eventEntry;

		public EventEditor()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			eventEntry.Id = eventID.Text;

			if (String.IsNullOrEmpty(eventEntry.Id))
			{
				this.eventID.Invalid = true;
				this.eventID.Focus();
				return;
			}

			eventEntry.Start = eventStart.Value;
			eventEntry.End = eventEnd.Value;
			eventEntry.Title = eventText.Text;

			if (this.eventType.SelectedIndex > -1)
				eventEntry.ClassName = EventTypes[this.eventType.SelectedIndex];

			Close();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void EventEditor_Load(object sender, EventArgs e)
		{
			eventID.Text = eventEntry.Id;
			eventStart.Value = eventEntry.Start;
			eventEnd.Value = eventEntry.End;
			eventText.Text = eventEntry.Title;

			LoadEventTypes();

			var className = eventEntry.ClassName;
			eventType.SelectedIndex = Array.IndexOf(EventTypes, className);
		}

		private void LoadEventTypes()
		{
			foreach (var text in EventTypes)
			{
				this.eventType.Items.Add(
					String.Format(
						"<div class=\"event-item\" style=\"height:28px\"><div class=\"event-item-color event-item-color-{0}\"></div><div class=\"event-item-text\">{0}</div>",
						text));
			}
		}

		private void eventID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.CloseReason == CloseReason.None)
			{
				if (this.eventID.Text == "")
					e.Cancel = true;
			}
		}

		private static string[] EventTypes = new[] { "Appointment", "Meeting", "Vacation", "Other" };
	}
}
