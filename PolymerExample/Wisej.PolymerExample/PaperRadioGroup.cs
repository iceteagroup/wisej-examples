using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the paper-radio-group polymer widget.
	/// </summary>
	[DefaultEvent("SelectedChanged")]
	public class PaperRadioGroup : PolymerWidget
	{
		public PaperRadioGroup()
		{
			// define the element type.
			base.ElementType = "paper-radio-group";

			// define the events that we want to handle on the server side using WidgetEvent.
			base.Events = new[] { "paper-radio-group-changed" };

			// initialize the properties that we want to update on the server when any event is fired.
			base.Properties.selected = string.Empty;

		}

		/// <summary>
		/// Define a specialized event for when the selected item changes
		/// </summary>
		public event EventHandler SelectedChanged;

		/// <summary>
		/// Fires the SelectedChanged event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnSelectedChanged(EventArgs e)
		{
			this.SelectedChanged?.Invoke(this, e);
		}

		/// <summary>
		/// Returns or sets whether the radio-group allows multiple selection.
		/// </summary>
		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Multi
		{
			get { return this.Properties.multi ?? false; }
			set
			{
				this.Properties.multi = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the currently selected item by name.
		/// </summary>
		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Selected
		{
			get { return this.Properties.selected ?? string.Empty; }
			set
			{
				this.Properties.selected = value;
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
				case "paper-radio-group-changed":
					OnSelectedChanged(EventArgs.Empty);
					break;
			}
		}
	}
}