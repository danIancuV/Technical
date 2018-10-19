using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace SatelliteAssemblies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeCulture("en-US");
        }

        System.Resources.ResourceManager rm =
            new System.Resources.ResourceManager("SatelliteAssemblies.string", Assembly.GetExecutingAssembly());     

        private void cmbLanguage_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string sLangCode;
            if (cmbLanguage.SelectedIndex == 0)
            {
                sLangCode = "en-US";
                ChangeCulture(sLangCode);
            }
            if (cmbLanguage.SelectedIndex == 1)
            {
                sLangCode = "de-DE";
                ChangeCulture(sLangCode);
            }
            if (cmbLanguage.SelectedIndex == 2)
            {
                sLangCode = "fr-FR";
                ChangeCulture(sLangCode);
            }
        }

        private void ChangeCulture(string sLangCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(sLangCode);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(sLangCode);
            lblMultiLangResult.Text = rm.GetString("lblResult");
        }
    }
}
