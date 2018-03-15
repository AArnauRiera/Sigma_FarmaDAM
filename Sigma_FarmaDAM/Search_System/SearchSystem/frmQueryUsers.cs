using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantein;

namespace SearchSystem
{
    public partial class frmQueryUsers : frmQueryBase
    {
        public frmQueryUsers()
        {
            InitializeComponent();
        }
        public frmQueryUsers(frmManteinBase frm, string table)
        {
            InitializeComponent();
            _frm = frm;
            Table = table;
        }

        private void txtSigma2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSigma3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
