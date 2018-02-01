using MDI_basic;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            this.Close();
            DialogResult = DialogResult.OK;

        }
    }
}
