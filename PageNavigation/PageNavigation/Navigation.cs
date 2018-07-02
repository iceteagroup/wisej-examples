using System;
using Wisej.Web;

namespace PageNavigation
{
    internal static class Navigation
    {
        public static Page PreviousPage
        {
            get { return Application.Session.PreviousPage; }
            private set { Application.Session.PreviousPage = value; }
        }

        public static void Navigate(Page page)
        {
            PreviousPage = Application.MainPage;

            page.Show();
        }

        public static Page Navigate(Type pageType, params object[] args)
        {
            PreviousPage = Application.MainPage;

            Page page = Application.OpenPages[pageType.Name];

            if (page == null)
                page = (Page) Activator.CreateInstance(pageType, args);

            page.Show();

            return page;
        }

        public static Page WorkspaceNavigate(string pageName)
        {
            PreviousPage = Application.MainPage;

            Workspace page = (Workspace) Application.OpenPages[pageName];

            if (page == null)
                page = new Workspace(pageName);
            page?.Show();

            return page;
        }

        public static void NavigateBack()
        {
            PreviousPage.Show();
        }

        public static void Close(this Page page)
        {
            page.Dispose();
            PreviousPage.Show();
        }
    }
}