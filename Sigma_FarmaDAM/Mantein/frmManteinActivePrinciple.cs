using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mantein
{
    public partial class frmManteinActivePrinciple : Mantein.frmManteinBase
    {
        public frmManteinActivePrinciple()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryActivePrinciple query = new frmQueryActivePrinciple(dgwBase, "Active_Principles");
            query.Show();
        }
    }
}
