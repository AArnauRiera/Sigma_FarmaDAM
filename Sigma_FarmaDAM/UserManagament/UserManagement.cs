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
        private bool _NTSHasChanged = true;
        public UserManagement()
        {
            InitializeComponent();
        }
        private void SearchFromNTS(object sender, EventArgs e)
        {
            if (tbxNTS.Text.Length > 0 && tbxNTS.Text != "NTS")
            {
                TxtSigma[] control = new TxtSigma[] { tbxNTS };
                DataSet dts = DBHelper.GetQuery("Clients", control);
                if (dts.Tables["Taula"].Rows != null)
                {
                    lblError.Text = "";
                    ShowSelectData(dts);
                    DataBindingComboBox(dts);
                } else
                {
                    lblError.Text = "Entry not valid for search";
                    tbxNTS.Focus(); // NOSE SI ESTA BE AIXO
                }
            }
            else
            {
                lblError.Text = "Entry not valid for search";
                tbxNTS.Focus(); // AIXO TAMPOC
            }
        }

        private void DataBindingComboBox(DataSet dts)
        {
            foreach (Control control in Controls)
            {
                if (control is CbxSigma)
                {
                    CbxSigma text = (CbxSigma)control;
                    text.DataBindings.Clear();
                    foreach (DataColumn c in dts.Tables["Taula"].Columns)
                    {
                        if (c.ColumnName == text.DBReference)
                        {
                            text.SelectedIndex = (int)dts.Tables["Taula"].Rows[0].ItemArray[c.Ordinal];
                        }
                    }
                }
            }
        }

        private void ShowSelectData (DataSet dts)
        {
            DBHelper.BindingTextBox(Controls, dts);

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserManagementControl umc = new UserManagementControl();
            string query = "SELECT name FROM " + cbxNTS_Type.DBReference;
            DataTable t = umc.SearchTableFromQuery(query);
            AddComboBoxData(t);
        }
         
        private void AddComboBoxData(DataTable t)
        {
            
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
            
        }

        private void tbxNTS_Leave(object sender, EventArgs e)
        {
            if (_NTSHasChanged)
            {
                SearchFromNTS(sender, e);
                _NTSHasChanged = false;
            }
        }

        private void tbxNTS_TextChanged(object sender, EventArgs e)
        {
            _NTSHasChanged = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UserManagementControl umc = new UserManagementControl();
            string query = "SELECT * FROM Clients";

            try
            {

                DBUtilities db = new DBUtilities();
                DataSet dts = db.PortarPerConsulta(query);
                DataRow r = dts.Tables["Taula"].NewRow();

                r["DNI"] = tbxDNI.Text;
                r["NTS"] = tbxNTS.Text;
                r["Name"] = tbxFirstName.Text;
                r["lastName1"] = tbxLastName1.Text;
                r["lastName2"] = tbxLastName2.Text;
                r["Type_NTS"] = cbxNTS_Type.SelectedItem;

                dts.Tables["Taules"].Rows.Add(r);

                umc.SaveChanges(dts, query);
                MessageBox.Show("Your tits");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
