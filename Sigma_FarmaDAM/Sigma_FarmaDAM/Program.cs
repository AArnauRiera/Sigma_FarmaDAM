using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
using MDI_basic;
using RegisterEditDrugs;
using XMLTools;
using SellSystem;

namespace Sigma_FarmaDAM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin Login = new frmLogin();

            if (Login.ShowDialog() == DialogResult.OK)
            {
                SplashScreen splash = new SplashScreen();

                if (splash.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMain(Login.getUserId()));
                }
            }
            else
            {
                Application.Exit();
            }


        }
    }
}
