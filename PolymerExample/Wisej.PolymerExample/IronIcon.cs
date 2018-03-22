using System.ComponentModel;
using Wisej.Web.Ext.Polymer;

namespace Wisej.PolymerExample
{
	/// <summary>
	/// Implementation of the iron-icon polymer widget.
	/// </summary>
	public class IronIcon : PolymerWidget
	{
		public IronIcon()
		{
			// define the element type.
			base.ElementType = "iron-icon";
		}

		/// <summary>
		/// Returns or sets the name of the icon to use. The name should be of the form: iconset_name:icon_name.
		/// </summary>
		[DefaultValue("")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Icon
		{
			get { return this.Properties.icon ?? ""; }
			set
			{
				this.Properties.icon = value;
				Update();
			}
		}

		/// <summary>
		/// If using iron-icon without an iconset, you can set the src to be the URL of an 
		/// individual icon image file. Note that this will take precedence over a given icon attribute.
		/// </summary>
		[DefaultValue("")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Src
		{
			get { return this.Properties.src ?? ""; }
			set
			{
				this.Properties.src = value;
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
	}
}