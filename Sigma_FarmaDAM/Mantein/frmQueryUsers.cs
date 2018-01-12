using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mantein
{
    class frmQueryUsers : Mantein.frmQueryBase
    {
      public frmQueryUsers(DataGridView dgw, string table) : base(dgw, table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }
    }
}
