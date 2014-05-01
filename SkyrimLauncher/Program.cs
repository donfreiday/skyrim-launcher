using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkyrimLauncher
{
    static class SkyrimLauncher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool autoLaunch = false;

            foreach (string arg in args)
            {
                if(String.Compare(arg, "-AUTO",true) == 0)
                {
                    autoLaunch = true;
                    break;
                }
            }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainwin(autoLaunch));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
