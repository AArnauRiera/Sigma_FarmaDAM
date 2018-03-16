using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Helpers;

namespace Manteniment
{
    public partial class frmManteinProviders : frmManteinBase
    {
        bool error;
        bool updated;
        public frmManteinProviders()
        {
            InitializeComponent();
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
