using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the paper-checkbox polymer widget.
	/// </summary>
	[DefaultEvent("CheckedChanged")]
	public class PaperCheckBox : PolymerWidget
	{
		public PaperCheckBox()
		{
			// define the element type.
			base.ElementType = "paper-checkbox";

			// define the events that we want to handle on the server side using WidgetEvent.
			base.Events = new[] { "change" };

			// initialize the properties that we want to update on the server when any event is fired.
			base.Properties.@checked = false;
		}

		/// <summary>
		/// Define a specialized event for when the checked state changes
		/// </summary>
		public event EventHandler CheckedChanged;

		/// <summary>
		/// Fires the CheckedChanged event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnCheckedChanged(EventArgs e)
		{
			this.CheckedChanged?.Invoke(this, e);
		}

		/// <summary>
		/// Returns or sets the checked state.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Checked
		{
			get { return this.Properties.@checked ?? false; }
			set
			{
				if (this.Checked != value)
				{
					this.Properties.@checked = value;
					OnCheckedChanged(EventArgs.Empty);
					Update();
				}
			}
		}

		/// <summary>
		/// Returns or sets the polymer element type.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string ElementType
		{
			get { return base.ElementType; }
			set {}
		}

		/// <summary>
		/// Returns or sets the events from the polymer widget to handle on the server side.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string[] Events
		{
			get { return base.Events; }
			set { base.Events = value; }
		}

		/// <summary>
		/// Returns or sets the specified property values on the polymer widget
		/// and defines the properties to receive back when an event is fired.
		/// </summary>
		[Browsable(false)]
		public override dynamic Properties
		{
			get { return base.Properties; }
		}

		/// <summary>
		/// Handle widget events to fire the specialized events.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPolymerEvent(WidgetEventArgs e)
		{
			// let the polymer widget implementation process the
			// event first to update the incoming properties.
			base.OnPolymerEvent(e);

			switch (e.Type)
			{
				case "change":
					OnCheckedChanged(EventArgs.Empty);
					break;
			}
		}

	}
}