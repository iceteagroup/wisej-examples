using System;
using Wisej.Web;
using Wisej.Web.Ext.TourPanel;

namespace TourPanelSample
{
	public partial class MyDesktop : Desktop
	{
		public MyDesktop()
		{
			InitializeComponent();
		}

		private string Watermark;
		TourPanel1 Tour1;
		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			Tour1 = new TourPanel1();
			// wire events
			Tour1.Closed += Tour1_Closed;
			Tour1.BeforeStep += Tour1_BeforeStep;
			Tour1.AfterStep += Tour1_AfterStep;
			Tour1.Paused += Tour1_Paused;
			Tour1.Playing += Tour1_Playing;
			Tour1.Ended += Tour1_Ended;			
			//
			if (e.Button == this.toolBarButton2)
				Tour1.AutoPlay = true;
			else
				Tour1.AutoPlay = false;

			// browse through all steps and disable steps tagged as Chrome if not running in Chrome
			if (Application.Browser.Type != "Chrome")
			{
				foreach (TourStep Step in Tour1.Steps)
				{
					if (Step.Tag != null && Step.Tag.ToString() == "Chrome")
						Step.Enabled = false;
				}
			}

			Tour1.Show();
		}

		private void Tour1_Ended(object sender, EventArgs e)
		{
			AlertBox.Show("Your tour ends here. Thanks for paying attention");
		}

		private void Tour1_Playing(object sender, EventArgs e)
		{
			AlertBox.Show("Autoplaying of tour has started. Use the pause button to have a break.");
		}

		private void Tour1_Paused(object sender, EventArgs e)
		{
			AlertBox.Show("Autoplaying has paused.");
		}

		private void Tour1_AfterStep(object sender, TourPanelEventArgs e)
		{
			if (e.Step.TargetName == "Window5.textBoxWatermark")
			{
				// restore with saved text
				Window5 win5 = (Window5)Application.OpenForms["Window5"];

				win5.textBoxWatermark.Text = Watermark;				
			}
		}

		private void Tour1_BeforeStep(object sender, Wisej.Web.Ext.TourPanel.TourPanelEventArgs e)
		{
			if (e.Step.TargetName == "Window3.dataGridView1.colNAME")
			{
				Window3 win3 = (Window3)Application.OpenForms["Window3"];
				win3?.SortDGVByName();
			}

			// set different colors and additional text for required fields
			if (e.Step.TargetName.Contains ("txtFirstName") || e.Step.TargetName.Contains("txtName") )
			{
				e.Step.Tour.HighlightColor = System.Drawing.Color.FromArgb(120, 230, 10, 10);
				e.Step.Tour.BackColor = System.Drawing.Color.FromArgb(255, 209, 204);
				string RequiredFieldInfo = "<br/><br/><small> This is a required field</small>";
				if (!e.Step.Text.Contains(RequiredFieldInfo))
					e.Step.Text += RequiredFieldInfo;
			}
			else
			{
				// use default color
				e.Step.Tour.HighlightColor = System.Drawing.Color.Empty;
				e.Step.Tour.BackColor = System.Drawing.Color.Empty;
			}

			if (e.Step.TargetName == "Window5.textBoxWatermark")
			{
				// save existing text and emtpy field to have the Watermark displayed
				Window5 win5 = (Window5)Application.OpenForms["Window5"];

				Watermark = win5.textBoxWatermark.Text;
				win5.textBoxWatermark.Clear();
			}
		}

		private void Tour1_Closed(object sender, EventArgs e)
		{
			Tour1.Dispose();
		}
	}
}
