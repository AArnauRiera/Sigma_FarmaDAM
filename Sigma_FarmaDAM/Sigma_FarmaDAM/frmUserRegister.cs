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

namespace UserRegister
{
    public partial class frmUserRegister : Form
    {
        private bool exit = false;
        public frmUserRegister()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            LoginControl.LoginControl control = new LoginControl.LoginControl();

            if (!control.CheckUserIsReal(tbxUsername, lblError, "Usuario") && !control.CheckUserIsReal(tbxEmail, lblError, "Email") && !control.CheckUserIsReal(tbxDNI, lblError, "DNI"))
            {
                if (control.CheckIfPasswordRepeatIsEqual(tbxPassword, tbxRepeatPassword, tbxUsername, lblError))
                {
                    exit = control.SaveChanges(Controls);
                    if (exit)
                    {
                        Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserRegister_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: Save();
                    break;
            }
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
