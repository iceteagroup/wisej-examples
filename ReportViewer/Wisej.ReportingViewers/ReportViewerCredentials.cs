using Microsoft.Reporting.WebForms;
using System.Net;
using System.Security.Principal;

namespace Wisej.ReportingViewers
{
	internal class ReportViewerCredentials : IReportServerCredentials
	{
		private string userName;
		private string password;
		private string domainName;

		public ReportViewerCredentials(string UserName, string Password, string DomainName)
		{
			this.userName = UserName;
			this.password = Password;
			this.domainName = DomainName;
		}

		public WindowsIdentity ImpersonationUser
		{
			get { return null; }
		}

		public ICredentials NetworkCredentials
		{
			get { return new NetworkCredential(this.userName, this.password, this.domainName); }
		}

		bool IReportServerCredentials.GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
		{
			authCookie = null;
			userName = null;
			password = null;
			authority = null;

			return false;
		}

	}
}