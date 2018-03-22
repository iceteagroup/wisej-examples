using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the paper-button polymer widget.
	/// </summary>
	[DefaultEvent("Click")]
	public class PaperButton : PolymerWidget
	{
		public PaperButton()
		{
			// define the element type.
			base.ElementType = "paper-button";
		}

		/// <summary>
		/// Returns or sets whether the element will not produce a ripple effect when interacted with via the pointer.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool NoInk
		{
			get { return this.Properties.noink ?? false; }
			set
			{
				this.Properties.noink = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets whether the button should be styled with a shadow.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Raised
		{
			get { return this.Properties.raised ?? false; }
			set
			{
				this.Properties.raised = value;
				Update();
			}
		}

		/// <summary>
		/// Returns or sets whether the button toggles the active state with each tap or press of the spacebar.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Toggles
		{
			get { return this.Properties.toggles ?? false; }
			set
			{
				this.Properties.toggles = value;
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