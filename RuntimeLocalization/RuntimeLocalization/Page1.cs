using System;
using System.Globalization;
using Wisej.Web;

namespace RuntimeLocalization
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Today;

            dataGridView.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Daily standup");
            dataGridView.Rows[0].Selected = false;

            SetLanguageMenu();
        }

        public void SetLanguageMenu()
        {
            var lang = GetLanguage();
            if (lang == "fr")
            {
                selectEnglish.Checked = false;
                selectFrench.Checked = true;
            }
            else
            {
                selectEnglish.Checked = true;
                selectFrench.Checked = false;
            }
        }

        private string GetLanguage()
        {
            var culture = Application.CurrentCulture;
            return culture.IetfLanguageTag.Substring(0, 2);
        }

        private void selectlanguage_Click(object sender, EventArgs e)
        {
            var lang = GetLanguage();
            if (lang == "fr")
            {
                Application.CurrentCulture = CultureInfo.GetCultureInfo("en");
                selectEnglish.Checked = true;
                selectFrench.Checked = false;
            }
            else
            {
                Application.CurrentCulture = CultureInfo.GetCultureInfo("fr");
                selectEnglish.Checked = false;
                selectFrench.Checked = true;
            }

            Application.Reload();

            new RuntimeLocalizer().ApplyResources(this);
        }

        private void showOnWindow_Click(object sender, EventArgs e)
        {
            using (var window = new Window1())
            {
                window.ShowDialog();
            }
        }
    }
}