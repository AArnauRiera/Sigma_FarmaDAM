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
    public partial class frmManteinClients : frmManteinBase
    {
        public frmManteinClients()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryClients frm = new frmQueryClients(this, "Clients");
            frm.Show();
        }
    }
}
