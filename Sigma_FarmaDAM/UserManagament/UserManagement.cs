using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagament
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxNTS.Text.Length > 0 && tbxNTS.Text != "NTS")
            {
                UserManagementControl umc = new UserManagementControl(tbxNTS.Text);

            }
            else
            {
                lblError.Text = "Entry not valid for search";
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            tbxDNI.Focus();
        }
    }
}
