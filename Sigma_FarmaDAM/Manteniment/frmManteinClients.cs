﻿using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;
using Helpers;

namespace Manteniment
{
    public partial class frmManteinClients : frmManteinBase
    {
        bool error;
        bool updated = false;
        public frmManteinClients()
        {
            InitializeComponent();
            cbxSigma1.FillDictionary("Type_NTS", "name", "Id");
        }

        protected override void OpenQuery()
        {
            frmQueryClients frm = new frmQueryClients(this, "Clients");
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
