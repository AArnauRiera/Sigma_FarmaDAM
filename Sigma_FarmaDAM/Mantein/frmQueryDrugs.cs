using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mantein
{
    public partial class frmQueryDrugs : Mantein.frmQueryBase
    {
        public frmQueryDrugs()
        {
            InitializeComponent();
        }

        public frmQueryDrugs(DataGridView dgw, string table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }
    }
}
