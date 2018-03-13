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

namespace Manteniment
{
    public partial class frmManteinUsers : frmManteinBase
    {
        public frmManteinUsers()
        {
            InitializeComponent();
        }

        public override void bntNew_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
    }
}
