using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mantein;

namespace SearchSystem
{
    public partial class frmQueryLaboratories : Mantein.frmQueryBase
    {
        public frmQueryLaboratories()
        {
            InitializeComponent();
        }

        public frmQueryLaboratories(DataGridView dgw, string table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }

    }
}
