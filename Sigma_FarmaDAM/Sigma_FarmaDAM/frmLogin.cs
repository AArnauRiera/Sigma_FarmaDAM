﻿using MDI_basic;
using System;
using System.Windows.Forms;
using UserRegister;

namespace Login
{
    public partial class frmLogin : Form
    {
        LoginControl.LoginControl control;
        public frmLogin()
        {
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

            if (control.CheckUserIsReal(tbxUsername, lblError, "Usuario"))
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
            control = new LoginControl.LoginControl(tbxUsername.Text);

            if(control.CheckUserIsReal(tbxUsername, lblError, "Usuario") && control.CheckIfUserIsAdmin(tbxUsername, lblError))
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
