using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Mobile.Features.Panels
{
	public partial class AppItemView : UserControl
	{

		#region Properties

		private Type viewType;

		private Random random = new Random((int)DateTime.Now.Ticks);

		#endregion

		#region Constructors

		public AppItemView()
		{
			InitializeComponent();
		}

		public AppItemView(Type type)
		{
			InitializeComponent();

			this.viewType = type;
		}

		#endregion

		#region Events

		public event WidgetEventHandler ViewRequested;

		private void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		#endregion

		private void AppItem_Load(object sender, EventArgs e)
		{
			var category = GetCategory(this.viewType);
			var title = String.Join(" ", Regex.Split(this.viewType.Name, @"(?<!^)(?=[A-Z])"));

			this.labelTitle.Text = title;
			this.labelDescription.Text = category;
			this.pictureBoxIcon.ImageSource = $"Images/Icons/{category}.svg?color={GetRandomColor()}";
		}

		private string GetRandomColor()
		{
			var color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
			return ColorTranslator.ToHtml(color);
		}

		public string GetDescription(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute));
			return ((DescriptionAttribute)attribute).Description ?? "";
		}

		public string GetCategory(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(CategoryAttribute));
			return ((CategoryAttribute)attribute)?.Category ?? "";
		}

		private void AppItemView_Click(object sender, EventArgs e)
		{
			this.OnViewRequested(new WidgetEventArgs("ViewRequested", this.viewType));
		}
	}
}
