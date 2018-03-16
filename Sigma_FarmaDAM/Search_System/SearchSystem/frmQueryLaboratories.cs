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
    }
}
