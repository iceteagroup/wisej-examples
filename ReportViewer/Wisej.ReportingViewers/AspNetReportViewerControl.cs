using Microsoft.Reporting.WebForms;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls;
using Wisej.Web;
using Wisej.Web.Ext.AspNetControl;

namespace Wisej.ReportingViewers
{
	/// <summary>
	/// Sample ReportViewer wrapper.
	/// </summary>
	[ToolboxItem(true)]
	public class AspNetReportViewerControl : AspNetWrapper<ReportViewer>
	{
		/// <summary>
		/// Returns or sets the URL of the Reporting Services server.
		/// </summary>
		public string ServerUrl
		{
			get { return this._serverUrl; }

			set
			{
				value = value ?? "";

				if (this._serverUrl != value)
				{
					this._serverUrl = value;
					Update();
				}
			}
		}
		private string _serverUrl = "";

		/// <summary>
		/// Returns or sets the path to the report on the server.
		/// </summary>
		[DefaultValue("")]
		public string ReportPath
		{
			get { return this._reportPath; }

			set
			{
				value = value ?? "";

				if (this._reportPath != value)
				{
					this._reportPath = value;
					Update();
				}
			}
		}
		private string _reportPath = "";

		/// <summary>
		/// Returns or sets the authentication user name.
		/// </summary>
		[DefaultValue(null)]
		public string UserName
		{
			get;
			set;
		}

		/// <summary>
		/// Returns or sets the authentication password.
		/// </summary>
		[DefaultValue(null)]
		public string Password
		{
			get;
			set;
		}

		/// <summary>
		/// Returns or sets the authentication domain name.
		/// </summary>
		[DefaultValue(null)]
		public string DomainName
		{
			get;
			set;
		}

		/// <summary>
		/// Returns or sets the <see cref="ProcessingMode"/> of the report viewer.
		/// </summary>
		public ProcessingMode ProcessingMode
		{
			get;
			set;
		}

		/// <summary>
		/// Shows or hide the export controls.
		/// </summary>
		public bool ShowExportControls
		{
			get;
			set;
		}

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			var viewer = this.WrappedControl;
			if (!this.IsPostBack)
			{
				viewer.SizeToReportContent = true;
				viewer.ProcessingMode = this.ProcessingMode;

				if (this.ProcessingMode == ProcessingMode.Local)
				{
					viewer.LocalReport.ReportPath = this.ReportPath;
				}
				else
				{
					viewer.ServerReport.ReportPath = this.ReportPath;
					viewer.ServerReport.ReportServerUrl = new Uri(this.ServerUrl);
					if (!this.IsPostBack && this.UserName != null)
						viewer.ServerReport.ReportServerCredentials = new ReportViewerCredentials(this.UserName, this.Password, this.DomainName);
				}

				viewer.ShowExportControls = this.ShowExportControls;
			}

			// attach the handled events to fire the event on the wrapper.
			if (this.Toggle != null)
				viewer.Toggle += viewer_Toggle;
			if (this.BookmarkNavigation != null)
				viewer.BookmarkNavigation += viewer_BookmarkNavigation;
			if (this.PageNavigation != null)
				viewer.PageNavigation += viewer_PageNavigation;
		}

		void viewer_BookmarkNavigation(object sender, BookmarkNavigationEventArgs e)
		{
			// this call is coming from the aspnet handler. if the
			// event handler in the wisej application updates a control, we need
			// either call Application.Update, or run the handler in an Update block to
			// push any update back to the client after the block is executed.
			Application.Update(this, () =>
			{
				BookmarkNavigation(sender, e);
			});
		}

		void viewer_PageNavigation(object sender, PageNavigationEventArgs e)
		{
			Application.Update(this, () =>
			{
				PageNavigation(sender, e);
			});
		}

		void viewer_Toggle(object sender, CancelEventArgs e)
		{
			Application.Update(this, () =>
			{
				Toggle(sender, e);
			});
		}

		/// <summary>
		/// Toggle event.
		/// </summary>
		public event CancelEventHandler Toggle;

		/// <summary>
		/// PageNavigation event.
		/// </summary>
		public event PageNavigationEventHandler PageNavigation;

		/// <summary>
		/// BookmarkNavigation event.
		/// </summary>
		public event BookmarkNavigationEventHandler BookmarkNavigation;
	}
}