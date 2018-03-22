using Wisej.Web;

namespace PageApplication
{
    public partial class SwitchForm : Form
    {
        public SwitchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (Application.MainPage.GetType() == typeof(SecondaryPage))
                Application.MainPage = Program.PagePrimary;
            else
                Application.MainPage = Program.PageSecondary;
        }
    }
}