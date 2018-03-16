using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;
using Helpers;
using Sigma_Controls;

namespace Manteniment
{
    public partial class frmManteinActivePrinciple : frmManteinBase
    {
        bool error;
        bool updated;
        public frmManteinActivePrinciple()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryActivePrinciple query = new frmQueryActivePrinciple(this, "Active_Principles");

            query.Show();
        }

        private void checkControls()
        {
            error = false;
            foreach (Control cntrl in pnlTextBox.Controls)
            {
                cntrl.Focus();
            }
        }
        
	/// <summary>
        /// Selecciona la ultima row ya que esta esta vacia y asi es como añadir una nueva row.
        /// </summary>
        public override void AddNewRow()
        {
            base.AddNewRow();

            int index = Convert.ToInt32(dgwBase.Rows[dgwBase.Rows.Count - 3].Cells["id"].Value);
            index++;
            dgwBase.Rows[dgwBase.Rows.Count - 2].Cells["id"].Value = index;
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
