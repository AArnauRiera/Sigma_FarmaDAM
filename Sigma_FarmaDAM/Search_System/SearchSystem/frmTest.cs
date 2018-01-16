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


        ///***BTN DRUGS CLICK***///
        #region
        private void btnDrugs_Click(object sender, EventArgs e)
        {
            form = "Drugs";

            frmSearchSystem f = new frmSearchSystem();

                if (form.Equals("Drugs"))
                {

                f.changebutton = form;
                f.LabelText1 = "Register Number";
                f.LabelText2 = "Sanitary Register Number";
                f.LabelText3 = "ID Active";
              
                    
                }
            f.Show();

        }
        #endregion
        ///***BTN CLIENT CLICK***///
         #region

        private void btnClient_Click(object sender, EventArgs e)
        {
          

            form = "Clients";

            frmSearchSystem f = new frmSearchSystem();

                if (form.Equals("Clients"))
                {
                f.changebutton = form;
                f.LabelText1 = "DNI";
                f.LabelText2 = "Name";
                f.LabelText3 = "Last Name";
            }
            f.Show();
        }
         #endregion

        ///***BTN ACTIVE CLICK***///
        #region
        private void btnActive_Click(object sender, EventArgs e)
        {

            form = "Active_Principles";
            frmSearchSystem f = new frmSearchSystem();
            if (form.Equals("Active_Principles"))
            {
                f.changebutton = form;
                f.LabelText1 = "ID";
                f.LabelText2 = "Sanitary Register Number";
                f.LabelText3 = "Name";
            }
            f.Show();
        }
       #endregion
    }
}
