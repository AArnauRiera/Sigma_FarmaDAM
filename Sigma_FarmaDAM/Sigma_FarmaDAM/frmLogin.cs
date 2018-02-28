using MDI_basic;
using System;
using System.Windows.Forms;
using UserRegister;
using LoginControl;
using Helpers;

namespace Login
{
    public partial class frmLogin : Form
    {
        LoginControl.LoginControl control;
        public frmLogin()
        {
            InitializeComponent();
            lblError.Text = "";
            control = new LoginControl.LoginControl(tbxUsername.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (control.CheckControls(errorProvider, pnltxt.Controls) && 
                !control.CheckIsReal(tbxUsername, errorProvider))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, lblError))
                {
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(control.CheckControls(errorProvider, Controls) && 
               !control.CheckIsReal(tbxUsername, errorProvider) &&  
               control.CheckIfUserIsAdmin(tbxUsername, lblError))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, lblError))
                {
                    frmUserRegister frmUR = new frmUserRegister();
                    frmUR.Show();
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Login();
                    break;
            }
        }
    }
}
