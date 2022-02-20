using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	public partial class TabBarButton : UserControl
	{
		public TabBarButton()
		{
			InitializeComponent();
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

		public string Label
		{
			get { return this.textBox1.Text; }
			set { this.textBox1.Text = value; }
		}

		public new bool Show
		{
			get { return this.checkBox1.Checked; }
			set { this.checkBox1.Checked = value; }
		}

		internal DeviceTabBar.Button ToButton()
		{
			return new DeviceTabBar.Button() { 
				Text = this.Label,
				Icon = this.pictureBox1.Image,
				IconSource = this.pictureBox1.ImageSource
			};
		}
	}
}
