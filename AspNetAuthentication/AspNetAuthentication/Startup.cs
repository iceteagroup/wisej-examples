using AspNetAuthentication.WisejViews;
using Microsoft.Owin;
using Owin;
using Wisej.Web;

[assembly: OwinStartupAttribute(typeof(AspNetAuthentication.Startup))]

namespace AspNetAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.MainPage = new Page1();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}