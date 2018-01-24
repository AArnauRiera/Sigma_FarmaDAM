using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using SearchSystem;
=======
using Mantein;
>>>>>>> master

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
<<<<<<< HEAD
            Application.Run(new frmTest());
=======
            //Application.Run(new frmQueryBase(null,"Clients"));
            Application.Run(new frmMain());
>>>>>>> master
        }
    }
}
