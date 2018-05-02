using MDI_basic;
using System;
using System.Windows.Forms;
using UserRegister;
using LoginControl;
using Helpers;
using System.Data;

namespace Login
{
    public partial class frmLogin : Form
    {
        LoginControl.LoginControl control;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            control = new LoginControl.LoginControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, pnltxt.Controls) && 
                control.CheckIsReal(tbxUsername, errorProvider, "Seller"))
            {
                if (control.CheckCredentials(tbxUsername, tbxPassword, errorProvider))
                {
                    Close();
                    DialogResult = DialogResult.OK;
                    Dispose();
                }
            }
        }

        public int getUserId()
        {
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            DataSet dts = db.PortarPerConsulta("SELECT * FROM Seller WHERE username = '" + tbxUsername.Text + "'");

            if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
            {
                return (Int32)dts.Tables[0].Rows[0]["id"];
            }
            else
            {
                return -1;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Login();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Close();
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
