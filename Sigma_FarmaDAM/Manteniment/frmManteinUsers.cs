using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantein;
using SearchSystem;
using UserRegister;
using Helpers;

namespace Manteniment
{
    public partial class frmManteinUsers : frmManteinBase
    {
        bool error;
        bool updated;

        public frmManteinUsers()
        {
            InitializeComponent();
        }

        private bool isOpened = false;

        public override void bntNew_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        /// <summary>
        /// abre un formulario para crear un nuevo usuario
        /// </summary>
        private void AddNewUser()
        {
            bool isOpened = false;
            frmUserRegister frmReg = new frmUserRegister();
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.GetType() == frmReg.GetType())
                {
                    isOpened = true;
                }
            }
            if (!isOpened)
            {
                frmReg.Show();
            }
        }

        protected override void OpenQuery()
        {
            frmQueryUsers frm = new frmQueryUsers(this, "Seller");
            frm.Show();
        }

        private void checkControls()
        {
            error = false;
            foreach (Control cntrl in pnlTextBox.Controls)
            {
                cntrl.Focus();
            }
        }

        private void tbxEmpty_Leave(object sender, EventArgs e)
        {
            updated = false;
            if (!ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)sender, true))
            {
                error = true;
            }
        }
        private void tbx_Leave(object sender, EventArgs e)
        {
            updated = false;
            if (!ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)sender))
            {
                error = true;
            }
        }

        public void btnUpdate_Click_1(object sender, EventArgs e)
        {
            checkControls();
            if (!error && !updated)
            {
                MessageBox.Show("Actualizado");
                base.UpdateQuery();
                updated = true;
            }
            else
            {
                MessageBox.Show("Algun campo no es correcto");
            }
        }
    }
}
