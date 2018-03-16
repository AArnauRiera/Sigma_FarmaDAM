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
    public partial class frmQueryProviders : Mantein.frmQueryBase
    {
        bool error;
        bool updated;
        public frmQueryProviders()
        {
            InitializeComponent();
        }
    }
}
