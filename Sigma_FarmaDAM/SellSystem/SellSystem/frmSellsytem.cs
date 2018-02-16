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

namespace SellSystem
{
    public partial class frmSellsytem : Form
    {
        DBUtils.DBUtilities DBUTILS = new DBUtils.DBUtilities();
        frmActive f = new frmActive();
        public DataSet dts;
        DataTable dt = new DataTable();
        public DataRow dr;

        String Querry;
        Boolean validate = false;
        Boolean Client = false;
        int contador = 1;

        public string[] values = new string[4];

        ///***FUNCTIONS***///
        #region    
        private Boolean Client_exist()
        {
            Querry = "select* from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        private String Client_ID(String id)
        {
            Querry = "select NTS  from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            String ID = dts.Tables[0].Rows[0]["NTS"].ToString();
            return ID;
        }
        private Boolean drug_exist(String drug)
        {
            Querry = "select* from Drugs  where Register_Number='" + drug + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        private Boolean stock(String drug)
        {
            Querry = "select * from Stock where id='" + drug + "'and stock >0'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
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
            Querry = "select CommercialName from Drugs where Register_Number = '" + txtCod.Text + "'";
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
            if (!(exist)&&string.IsNullOrWhiteSpace(txtProd.Text)) ;
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
        private void btnBuy_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dgView_Sell.Rows.Count - 1; row++)
            {

                if (!drug_exist(dgView_Sell.Rows[row].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("the drug " + dgView_Sell.Rows[row].Cells[0].Value.ToString() + " doesn't exist");
                }
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
            if (e.KeyCode == Keys.Enter)
            {
                string productName = name_product();
                if (!String.IsNullOrEmpty(productName))
                {
                    txtProd.Text = productName;
 
                }
                else
                {
                    txtCod.Text = "";
                    txtProd.Text = "";

                }
            }
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
                    MessageBox.Show("There Client doesn't exist");
                }
            }   
        }
    }
}

 
#endregion