using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	public partial class ToolbarButton : UserControl
	{
		public ToolbarButton()
		{
			InitializeComponent();

			this.comboBox1.DataSource = Enum.GetNames(typeof(DeviceToolbar.ButtonType));
			this.comboBox1.Text = "Default";
		}

		public Image Icon
		{
			get { return this.pictureBox1.Image; }
			set { this.pictureBox1.Image = value; }
		}

		[Editor("Wisej.Design.ImageSourceEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
		[TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
		public string IconSource
		{
			get { return this.pictureBox1.ImageSource; }
			set { this.pictureBox1.ImageSource = value; }
		}

		public new bool Show
		{
			get { return this.checkBox1.Checked; }
			set { this.checkBox1.Checked = value; }
		}

		public DeviceToolbar.ButtonType Type
		{
			get
			{
				return (DeviceToolbar.ButtonType)Enum.Parse(
					typeof(DeviceToolbar.ButtonType),
					String.IsNullOrEmpty(this.comboBox1.Text) ? "Default" : this.comboBox1.Text);
			}
			set { this.comboBox1.Text = value.ToString(); }
		}

		public int ButtonWidth
		{
			get { return (int)this.numericUpDown1.Value; }
			set { this.numericUpDown1.Value = value; }
		}

		internal DeviceToolbar.Button ToButton()
		{
			return new DeviceToolbar.Button() {
				Type = this.Type,
				Icon = this.Icon,
				Width = this.ButtonWidth,
				IconSource = this.IconSource,
			};
		}
	}
}
