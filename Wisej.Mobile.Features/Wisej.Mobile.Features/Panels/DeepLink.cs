using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
    [Category("Navigation")]
    public partial class DeepLink : TestBase
    {
        public DeepLink()
        {
            InitializeComponent();
        }

        private void buttonNativeBrowser_Click(object sender, EventArgs e)
        {
            Device.OpenBrowser($"{Application.StartupUrl}/DeepLink");
        }
    }
}
