using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchSystem
{
    public partial class frmTest : Form
    {
        String form = "";
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnDrugs_Click(object sender, EventArgs e)
        {
            form = "Drugs";

            frmSearchSystem f = new frmSearchSystem();

                if (form.Equals("Drugs"))
                {

                f.changebutton = form;
                    
                }
            f.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
          

            form = "Clients";

            frmSearchSystem f = new frmSearchSystem();

                if (form.Equals("Clients"))
                {
                f.changebutton = form;
                    
                }
            f.Show();



        }

        private void btnActive_Click(object sender, EventArgs e)
        {

            form = "Active_Principles";
            frmSearchSystem f = new frmSearchSystem();
            if (form.Equals("Active_Principles"))
            {
                f.changebutton = form;
            }
            f.Show();
        }
    }
}
