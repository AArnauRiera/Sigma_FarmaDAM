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
            // Console.WriteLine(Cryptography.Cryptography.Encrypt("12345aA", "admin"));
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            control = new LoginControl.LoginControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, pnltxt.Controls) && 
                control.CheckIsReal(tbxUsername, errorProvider, "Seller"))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, errorProvider))
                {
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            control = new LoginControl.LoginControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, pnltxt.Controls) && 
               control.CheckIsReal(tbxUsername, errorProvider, "Seller") &&  
               control.CheckIfUserIsAdmin(tbxUsername, lblError))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, errorProvider))
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
