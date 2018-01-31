using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using System.Windows.Forms;
using Sigma_Controls;

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
                UserManagementControl umc = new UserManagementControl();
                string query = "SELECT * FROM Clients where NTS = '" + tbxNTS.Text + "'";
                DataRow r = umc.SearchFromQuery(query);
                TxtSigma[] control = new TxtSigma[] { tbxNTS };
                DataSet dts = DBHelper.GetQuery("Clients", control);
                if (r != null)
                {
                    lblError.Text = "";
                    ShowSelectData(dts);
                } else
                {
                    lblError.Text = "Entry not valid for search";
                    tbxNTS.Focus();
                }
            }
            else
            {
                lblError.Text = "Entry not valid for search";
                tbxNTS.Focus();
            }
        }

        private void SetComboBoxValue(DataSet dts, string DBReference)
        {

        }

        private void ShowSelectData (DataSet dts)
        {
            DBHelper.BindingTextBox(Controls, dts);

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserManagementControl umc = new UserManagementControl();
            string query = "SELECT name FROM Type_NTS";
            DataTable t = umc.SearchTableFromQuery(query);
            AddComboBoxData(t);
        }
         
        private void AddComboBoxData(DataTable t)
        {
            /*
            cbxNTS_Type.Items.Add("Selecciona...");
            cbxNTS_Type.SelectedIndex = 0;
            for(var i = 0; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];
                if (r.ItemArray[0] != null)
                {
                    cbxNTS_Type.Items.Add(r.ItemArray[0].ToString());
                }
            }
            */
        }
    }
}
