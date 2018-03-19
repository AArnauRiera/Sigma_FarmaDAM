using Sigma_FarmaDAM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_basic
{
    public partial class SplashScreen : Form
    {
        frmMain main;
        public SplashScreen()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 3500;
            main = new frmMain();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Close();
            Dispose();
            DialogResult = DialogResult.OK;
        }
    }
}
