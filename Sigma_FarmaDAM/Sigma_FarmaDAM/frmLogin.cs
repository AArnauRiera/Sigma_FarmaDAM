using MDI_basic;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        LoginControl.LoginControl control = new LoginControl.LoginControl();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (control.CheckUserIsReal(tbxUsername, lblError))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, lblError))
                {
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
