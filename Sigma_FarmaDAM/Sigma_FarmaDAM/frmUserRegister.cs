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
        public frmUserRegister()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LoginControl.LoginControl control = new LoginControl.LoginControl();

            if(control.CheckUserIsReal(tbxUsername, lblError, "Usuario") && control.CheckUserIsReal(tbxEmail, lblError, "Email"))
            {
                if (control.CheckIfPasswordRepeatIsEqual(tbxPassword, tbxRepeatPassword, tbxUsername, lblError))
                {

                }
            }
        }
    }
}
