using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mantein;
using Helpers;

namespace SearchSystem
{
    public partial class frmQueryLaboratories : Mantein.frmQueryBase
    {
        bool error;
        bool updated;
        public frmQueryLaboratories()
        {
            InitializeComponent();
        }

        public frmQueryLaboratories(frmManteinBase frm, string table)
        {
            InitializeComponent();
            _frm = frm;
            Table = table;
        }

        private void checkControls()
        {
            error = false;
            foreach (Control cntrl in pnlTB.Controls)
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
                GetQuery();
                BindingDate();
                DisableColumns();
                updated = true;
            }
        }
    }
}
