using Wisej.Web;

namespace MultiHtml.Customers
{
    static class CustomersStartup
    {
        static void Main()
        {
            Application.MainPage = new CustomerPage();
        }
    }
}