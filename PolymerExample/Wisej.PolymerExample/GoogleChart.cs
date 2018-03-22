using System;
using System.ComponentModel;
using Wisej.Core;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the google-chart polymer widget.
	/// </summary>
	public class GoogleChart : PolymerWidget
	{
		public GoogleChart()
		{
			// define the element type.
			base.ElementType = "google-chart";

			// define the events that we want to handle on the server side using WidgetEvent.
			base.Events = new[] { "google-chart-select" };

			// initialize the properties that we want to update on the server when any event is fired.
			base.Properties.selection = new[] { new { row = 0, column = 0 } };
		}

		/// <summary>
		/// Define a specialized event for when the selection changes
		/// </summary>
		public event EventHandler SelectionChanged;

		/// <summary>
		/// Fires the SelectionChanged event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnSelectionChanged(EventArgs e)
		{
			this.SelectionChanged?.Invoke(this, e);
		}

		/// <summary>
		/// Returns or sets the chart type.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Type
		{
			get { return this.Properties.type ?? string.Empty; }
			set
			{
				this.Properties.type = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the selected elements in the chart.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic[] Selection
		{
			get { return this.Properties.selection; }
			set
			{
				this.Properties.selection = value;
				OnSelectionChanged(EventArgs.Empty);
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the data to display.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic Data
		{
			get { return this.Properties.data; }
			set
			{
				this.Properties.data = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the data columns.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic Cols
		{
			get { return this.Properties.cols; }
			set
			{
				this.Properties.cols = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the data rows.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic Rows
		{
			get { return this.Properties.rows; }
			set
			{
				this.Properties.rows = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the options.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic Options
		{
			get
			{
				if (this.Properties.options == null)
					this.Properties.options = new DynamicObject();

				return this.Properties.options;
			}
			set
			{
				this.Properties.options = value;
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
				case "google-chart-select":
					OnSelectionChanged(EventArgs.Empty);
					break;
			}
		}
	}
}