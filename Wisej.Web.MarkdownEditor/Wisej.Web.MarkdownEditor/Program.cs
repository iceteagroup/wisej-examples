using System.Collections.Specialized;

namespace Wisej.Web.MarkdownEditor;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">Arguments from the URL.</param>
    static void Main(NameValueCollection args)
    {
        new Window1().Show();
    }
}