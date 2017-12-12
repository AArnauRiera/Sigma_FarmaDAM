using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;

namespace RegisterEditDrugs
{
    public partial class frmAddEditDrugs : CentredForm

    {
        private bool _edit;
        public frmAddEditDrugs()
        {
            InitializeComponent();
            _edit = false;
            btnEditAdd.Text = "Add";
            CenterPanel(pnlAddEditDrugs);
        }

        public frmAddEditDrugs(string drug)
        {
            InitializeComponent();
            _edit = true;
            btnEditAdd.Text = "Edit";
            CenterPanel(pnlAddEditDrugs);
        }

    }
}
