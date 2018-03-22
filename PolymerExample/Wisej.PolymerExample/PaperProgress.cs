using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the paper-progress polymer widget.
	/// </summary>
	public class PaperProgress : PolymerWidget
	{
		public PaperProgress()
		{
			// define the element type.
			base.ElementType = "paper-progress";
		}

		/// <summary>
		/// Returns or sets the minimum value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Min
		{
			get { return this.Properties.min ?? 0; }
			set
			{
				this.Properties.min = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the maximum value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Max
		{
			get { return this.Properties.max ?? 0; }
			set
			{
				this.Properties.max = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Value
		{
			get { return this.Properties.value ?? 0; }
			set
			{
				this.Properties.value = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets the secondary-progress value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int SecondaryProgress
		{
			get { return this.Properties["secondary-progress"] ?? 0; }
			set
			{
				this.Properties["secondary-progress"] = value;
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
	}
}