using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the paper-slider polymer widget.
	/// </summary>
	[DefaultEvent("ValueChanged")]
	public class PaperSlider : PolymerWidget
	{
		public PaperSlider()
		{
			// define the element type.
			base.ElementType = "paper-slider";

			// define the events that we want to handle on the server side using WidgetEvent.
			base.Events = new[] { "change" };

			// initialize the properties that we want to update on the server when any event is fired.
			base.Properties.value = 0;
			base.Properties.pin = true;
		}

		/// <summary>
		/// Define a specialized event for when the value changes
		/// </summary>
		public event EventHandler ValueChanged;

		/// <summary>
		/// Fires the ValueChanged event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnValueChanged(EventArgs e)
		{
			this.ValueChanged?.Invoke(this, e);
		}

		/// <summary>
		/// Returns or sets the value of the slider.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Value
		{
			get { return this.Properties.value ?? 0; }
			set
			{
				this.Properties.value = value;
				OnValueChanged(EventArgs.Empty);
				Update();
			}
		}

		/// <summary>
		/// Returns or sets whether the slider shows a pin with the value when sliding.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool ShowPin
		{
			get { return this.Properties.pin ?? false; }
			set
			{
				this.Properties.pin = value;
				Update();
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
			set { }
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
					OnValueChanged(EventArgs.Empty);
					break;
			}
		}
	}
}