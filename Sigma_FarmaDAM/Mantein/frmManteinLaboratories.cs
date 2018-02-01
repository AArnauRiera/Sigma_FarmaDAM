using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mantein
{
    public partial class frmManteinLaboratories : Mantein.frmManteinBase
    {
        public frmManteinLaboratories()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryLaboratories query = new frmQueryLaboratories(dgwBase, "Laboratories");
            query.Show();
        }
    }
}
