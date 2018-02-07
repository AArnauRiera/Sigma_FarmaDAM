using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;

namespace Manteniment
{
    public partial class frmManteinDrugs : frmManteinBase
    {
        public frmManteinDrugs()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryDrugs query = new frmQueryDrugs(dgwBase, "Drugs");
            query.Show();
        }
    }
}
