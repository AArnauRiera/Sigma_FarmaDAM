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
    }
}
