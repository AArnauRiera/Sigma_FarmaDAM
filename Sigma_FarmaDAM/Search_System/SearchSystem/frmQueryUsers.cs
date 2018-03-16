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
using Helpers;

namespace SearchSystem
{
    public partial class frmQueryUsers : frmQueryBase
    {
        bool error;
        bool updated;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
