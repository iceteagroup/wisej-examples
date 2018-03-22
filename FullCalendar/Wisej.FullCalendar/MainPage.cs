using System;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.FullCalendar;


namespace Wisej.FullCalendar
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this.fullCalendar1.CurrentDate = DateTime.Now.Date;
			this.fullCalendar1.View = ViewType.AgendaWeek;

			this.fullCalendar1.Events.Add(new Event()
			{
				Id = "Event1",
				Start = DateTime.Now,
				End = DateTime.Now.AddHours(1),
				Title = "Try Wisej!",
				ClassName = "Other"
			});

			this.fullCalendar1.Events.Add(new Event()
			{
				Id = "Event2",
				Start = DateTime.Now.Date.AddHours(12),
				End = DateTime.Now.Date.AddHours(13),
				Title = "Lunch",
				ClassName = "Appointment"
			});

			this.fullCalendar1.Events.Add(new Event()
			{
				Id = "Event3",
				Start = DateTime.Now.Date.AddDays(-1).AddHours(10.5),
				End = DateTime.Now.Date.AddDays(-1).AddHours(11.75),
				Title = "Meeting",
				ClassName = "Meeting"
			});

			this.fullCalendar1.Events.Add(new Event()
			{
				Id = "Event4",
				Start = DateTime.Now.Date.AddDays(2),
				End = DateTime.Now.Date.AddDays(4),
				AllDay = true,
				Title = "Holidays :-)",
				ClassName = "Vacation"
			});
		}

		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			this.fullCalendar1.CurrentDate = e.Start;
		}

		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button == this.tbNew)
			{
				// create an empty event
				Wisej.Web.Ext.FullCalendar.Event ev = new Event();
				ev.Start = DateTime.Now;
				ev.End = DateTime.Now.AddHours(0.5);

				// show the editor
				using (EventEditor editor = new EventEditor())
				{
					editor.eventEntry = ev;
					if (editor.ShowDialog(this.FindForm()) == DialogResult.OK)
						this.fullCalendar1.Events.Add(ev);
				}

				return;
			}

			if (e.Button.Tag != null)
			{
				foreach (ToolBarButton button in this.toolBar1.Buttons)
					button.Pushed = false;

				e.Button.Pushed = true;

				// change the calendar view
				ViewType calendarView;
				if (Enum.TryParse(e.Button.Tag.ToString(), out calendarView))
					this.fullCalendar1.View = calendarView;
			}
		}

		private void fullCalendar1_EventDoubleClick(object sender, EventClickEventArgs e)
		{
			// edit the event
			using (EventEditor editor = new EventEditor())
			{
				editor.eventEntry = e.Event;
				editor.ShowDialog(this.FindForm());
			}
		}
	}
}
