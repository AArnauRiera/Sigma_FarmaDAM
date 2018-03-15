using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginControl;

namespace Sigma_FarmaDAM
{
    public partial class frmLoginSellSystem : Form
    {
        LoginControl.LoginControl control = new LoginControl.LoginControl();

        public frmLoginSellSystem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            control = new LoginControl.LoginControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, Controls) &&
                control.CheckIsReal(tbxUsername, errorProvider, "Seller"))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, errorProvider))
                {
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Login();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Close();

        }
    }
}
