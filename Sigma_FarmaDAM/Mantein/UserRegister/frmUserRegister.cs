using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegister
{
    public partial class frmUserRegister : Form
    {
        private bool exit = false;
        public frmUserRegister()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            LoginControl.LoginControl control = new LoginControl.LoginControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, Controls, tbxUsername, tbxPassword) &&
                !control.CheckIsReal(tbxUsername, errorProvider, "Seller") &&
                !control.CheckIsReal(tbxEmail, errorProvider, "Seller") && 
                !control.CheckIsReal(tbxDNI, errorProvider, "Seller"))
            {
                if (control.CheckIfPasswordRepeatIsEqual(tbxPassword, tbxRepeatPassword, tbxUsername))
                {
                    exit = control.SaveChanges(Controls);
                    if (exit)
                    {
                        Close();
                    }
                }
            }
        }
        private void Clear()
        {
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox cntrl = (CheckBox)control;
                    cntrl.Checked = false;
                } else
                {
                    control.Text = "";
                }
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
