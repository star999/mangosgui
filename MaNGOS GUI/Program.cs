using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaNGOS_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrEmpty(Properties.Settings.Default.GUID))
            {
                string s = Guid.NewGuid().ToString();
                Properties.Settings.Default.GUID = s;
                Properties.Settings.Default.Save();
            }

            // Added to retreive choosen language
            string lang = Properties.Settings.Default.ChoosenLanguage;
            if (!string.IsNullOrEmpty(lang)) {
                //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);//System.Threading.Thread.CurrentThread.CurrentCulture;
            }
            Application.Run(new ManguiMain());
        }
    }
}