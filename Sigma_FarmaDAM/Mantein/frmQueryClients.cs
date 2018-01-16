using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mantein
{
    class frmQueryClients : Mantein.frmQueryBase
    {
      public frmQueryClients(DataGridView dgw, string table) : base(dgw, table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }



    }
}
