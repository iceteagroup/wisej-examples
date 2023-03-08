using DevExpress.DataAccess;
using System;
using Wisej.Web;

namespace Wisej.DxDashboardSample
{
    public class WisejSecureDataConverter : ISecureDataConverter
    {
        public string Protect(string entity)
        {
            var id = Guid.NewGuid().ToString();
            Application.Session[id] = entity;

            return id;
        }

        public string Unprotect(string protectedEntity)
        {
            return Application.Session[protectedEntity];
        }
    }
}
