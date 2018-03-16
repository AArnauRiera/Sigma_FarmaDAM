using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;
using Sigma_Controls;

namespace Manteniment
{
    public partial class frmManteinActivePrinciple : frmManteinBase
    {

        public frmManteinActivePrinciple()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryActivePrinciple query = new frmQueryActivePrinciple(this, "Active_Principles");

            query.Show();
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
    }
}
