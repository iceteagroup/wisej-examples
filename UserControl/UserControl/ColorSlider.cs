using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace UserControl
{
	public partial class ColorSlider : Wisej.Web.UserControl
	{
		public ColorSlider()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Fired when the value of the color sliders changes.
		/// </summary>
		public event EventHandler ValueChanged;

		/// <summary>
		/// Fires the ValueChanged event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnValueChanged(EventArgs e)
		{
			if (this.ValueChanged != null)
				ValueChanged(this, e);
		}

		/// <summary>
		/// Returns or sets a value indicating whether the track bars in the color slider
		/// control show their value in a bubble when the user moves the slider.
		/// </summary>
		[DefaultValue(true)]
		[Description("Returns or sets a value indicating whether the track bars in the color slider control show their value in a bubble when the user moves the slider")]
		public bool ShowValueBubbles
		{
			get { return this._showValueBubbles; }
			set
			{
				if (this._showValueBubbles != value)
				{
					this._showValueBubbles
						= this.trackBarR.ShowValue
						= this.trackBarG.ShowValue
						= this.trackBarB.ShowValue
						= this.trackBarAll.ShowValue = value;
				}
			}
		}
		private bool _showValueBubbles = true;

		/// <summary>
		/// Returns the currently selected color.
		/// </summary>
		[Browsable(false)]
		public Color Color
		{
			get
			{
				return Color.FromArgb(
					this.trackBarR.Value,
					this.trackBarG.Value,
					this.trackBarB.Value);
			}
		}

		private void trackBar_ValueChanged(object sender, EventArgs e)
		{
			// when sliding the All trackbar, adjust all sliders at the same time.
			// and avoid re-entering the event.
			if (sender == this.trackBarAll)
			{
				this._inValueChanged = true;
				try
				{
					this.trackBarR.Value
					= this.trackBarG.Value
					 = this.trackBarB.Value = this.trackBarAll.Value;

					OnValueChanged(EventArgs.Empty);
				}
				finally
				{
					this._inValueChanged = false;
				}
			}
			else if (!this._inValueChanged)
			{
				OnValueChanged(EventArgs.Empty);
			}
		}
		private bool _inValueChanged = false;
	}
}
