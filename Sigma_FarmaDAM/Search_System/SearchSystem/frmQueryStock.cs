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

    public partial class frmQueryStock : frmQueryBase
    {
        bool error;
        bool updated;
        public frmQueryStock()
        {
            InitializeComponent();
        }
    }
}
