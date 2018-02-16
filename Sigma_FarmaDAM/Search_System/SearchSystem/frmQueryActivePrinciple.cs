using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SearchSystem
{
    public partial class frmQueryActivePrinciple : frmQueryBase
    {

        public frmQueryActivePrinciple()
        {
            InitializeComponent();
        }

        public frmQueryActivePrinciple(DataGridView dgw, string table){
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }


    }
}
