using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtils;
using MySql.Data.MySqlClient;
using SearchSystem;
using Sigma_Controls;

namespace SellSystem
{
    public partial class frmSellsytem : Form
    {
        DBUtilities DBUTILS = new DBUtils.DBUtilities();
        public DataSet dts;
        DataTable dt = new DataTable();
        public DataRow dr;
 
        string Querry;
        bool validate = false;
        bool Client = false;
        int contador = 1;
        bool insert = false;

        public string[] values = new string[4];

        ///***FUNCTIONS***///
        #region    
        private bool Client_exist()
        {
            Querry = "select* from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        private string Client_ID(String id)
        {
            Querry = "select NTS  from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            String ID = dts.Tables[0].Rows[0]["NTS"].ToString();
            return ID;
        }
        private bool drug_exist(String drug)
        {
            Querry = "select* from Drugs  where Register_Number = '" + drug + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        private bool stock(String drug)
        {
            int stock = 0;
            Querry = "select * from Stock where id='" + drug + "'and Quantity >'"+stock+"'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count >0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        private DataSet client()
        {
            DataSet dts;
            Querry = "select Name,lastName1,lastName2,DNI from Clients where NTS = '" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            return dts;
        }
        private string name_product()
        {
            DataSet dts;
            Querry = "select CommercialName from Drugs where Register_Number= '" + txtCod.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            string Name;
            try
            {
                Name = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                Name = "";
            }
            return Name;
        }
        private string id_active()
        {
            DataSet dts;
            Querry = "select ActivePrincipleID from Drugs where Register_Number ='" + txtCod.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            string active;
            try
            {
                active = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                active="";
            }
            return active;
        }

        #endregion
        ///***MAIN***///
        #region
        public frmSellsytem()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool exist = false;
            String Drug = txtCod.Text.ToString();

            for (int row = 0; row < dgView_Sell.Rows.Count - 1; row++)
            {
                if (dgView_Sell.Rows[row].Cells[0].Value.ToString().Equals(Drug))
                {
                    exist = true;
                    dgView_Sell.Rows[row].Cells[4].Value = txtCantidad.Text;
                }
            }
            if (dts.Tables[0].Rows.Count != 0)
            {
                dgView_Sell.DataSource = dt;
            }
            else { MessageBox.Show("There are no values "); }
            if ((!exist)&&insert);
            {
                contador = 1;
                dr = dt.NewRow();
                dr[0] = txtCod.Text;
                dr[1] = txtProd.Text;
                dr[2] = "1";
                dr[3] = Client_ID(Drug);
                dr[4] = txtCantidad.Text;
                dt.Rows.Add(dr);
                txtCod.Text = "";
                txtProd.Text = "";
                txtCantidad.Text = "1";
            }
        }
        private void frmSellsytem_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID_Stock ");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_Seller");
            dt.Columns.Add("ID_client");
            dt.Columns.Add("quantity");
            txtCantidad.Text = "1";
        }
        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&&string.IsNullOrEmpty(txtCod.Text))
            {
                insert = true;
                string productName = name_product();
                if (!String.IsNullOrEmpty(productName))
                {
                    txtProd.Text = productName;
                    if (!(drug_exist(txtCod.Text)&&stock(txtCod.Text)))
                    {
                        if (MessageBox.Show("¿Quieres buscar medicamentos similares?", "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string condition2 = txtCod.Text;
                            frmQueryDrugs r = new frmQueryDrugs(GetTxtSigma(),"Drugs", id_active(),txtCod.Text);
                            r.Show();
                        }
                        else
                        {
                            txtCod.Text = "";
                            txtProd.Text = "";
                        }
                    }
                }else{
                    txtCod.Text = "";
                    txtProd.Text = "";
                }
            }
        }

        private TxtSigma[] GetTxtSigma()
        {
            List<TxtSigma> txts = new List<TxtSigma>();
            for (int i = 0; i < pnltxt.Controls.Count; i++)
            {
                if (pnltxt.Controls[i] is TxtSigma)
                {
                    txts.Add(pnltxt.Controls[i] as TxtSigma);
                }
            }
            return txts.ToArray();
        }
        private void txtClient_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Client = Client_exist();
                if (Client)
                {
                    txtClient.ReadOnly = true;
                    dts = client();
                    txtName.Text = dts.Tables[0].Rows[0][0].ToString();
                    txtLastName.Text = dts.Tables[0].Rows[0][1].ToString();
                    txtLastname2.Text = dts.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("No hay valores");
                }
            }
        }

        private void dgView_Sell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewBand band in dgView_Sell.Columns)
            {
                band.ReadOnly = true;
            }
        }
    }
}

 
#endregion