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

        public string[] values = new string[4];

        private string ID_Sell ="1";

        ///***CONSTRUCTOR***///
        public frmSellsytem(String ID_sell){ ID_Sell = ID_sell; }

        ///***FUNCTIONS***///
        #region    
        ///Busca si el cliente existe///
        private bool Client_exist()
        {
            Querry = "select* from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        ///Devuelve la ID del cliente///
        private string Client_ID(String id)
        {
            Querry = "select ID from Clients  where NTS ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            String ID;
            try
            {
                ID = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                ID = "";
            }   
            return ID;
        }
        ///Busca si el medicamento existe///
        private bool drug_exist(String drug)
        {
            Querry = "select* from Drugs  where Register_Number = '" + drug + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) { validate = true; }
            else { validate = false; }
            return validate;
        }
        ///Busca si el medicamento tiene stock///
        private bool stock(String drug)
        {
            int stock = 0;
            String ID_Drug = "select id from Drugs where where Register_Number = '" + drug + "";
            String Drug = dts.Tables[0].Rows[0][0].ToString();
            Querry = "select * from Stock where ID_Drug='" +Drug + "'and Quantity >'"+stock+"'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count >0) { validate = true; }
            else { validate = false; }
            return validate;
        }

        ///Devuelve un DataSet con los valores de la taula Clients donde NTS sea igual al valor introduido///
        private DataSet client()
        {
            Querry = "select Name,lastName1,lastName2,DNI from Clients where NTS = '" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            return dts;
        }
        ///Devuelve el nombre del producto///
        private string name_product()
        {
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
        ///Devuelve la ID  del principio activo de la tabla drugs///
        private string id_active()
        {
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
        private void Stock_Update(string Register_Number)
        {
            Querry = "Select  Stock.Quantity from Drugs,Stock where Drugs.id = Stock.ID_Drug and Drugs.Register_Number ='" + Register_Number+"'";
            
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

            if (!String.IsNullOrEmpty(txtProd.Text)) {

                ///comprueba si un medicamento esta introduido en la tabla y si esta introduido le añade suma la cantidad introduida///
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
                ///Si no existe lo introduce a la Tabla///
                if ((!exist)) 
                {
                    contador = 1;
                    dr = dt.NewRow();
                    dr[0] = txtCod.Text;
                    dr[1] = txtProd.Text;
                    dr[2] = ID_Sell;
                    dr[3] = Client_ID(Drug);
                    dr[4] = txtCantidad.Text;

                    dt.Rows.Add(dr);
                    txtCod.Text = "";
                    txtProd.Text = "";
                    txtCantidad.Text = "1";
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
            ///Comprueba si se pulsa la key enter y que no este null el campo del codigo del medicamento///
            if (e.KeyCode == Keys.Enter &&!string.IsNullOrEmpty(txtCod.Text))
            {
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
        ///Genera un Array a partir del custom control donde los valores son todos los de el panel///
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
            ///Comprueba si es pulsada la key enter y si el cliente existe añade el nombre y apellidos a los  textbox de nombre y apellido///
            if (e.KeyCode == Keys.Enter)
            {
                Client = Client_exist();
                if (Client)
                {
                    txtClient.ReadOnly = true;
                    dts = client();
                    lblName.Text = dts.Tables[0].Rows[0][0].ToString()+" "+ dts.Tables[0].Rows[0][1].ToString()+" "+ dts.Tables[0].Rows[0][2].ToString();
                    
                }
                else
                {
                    MessageBox.Show("No existe el cliente");
                    txtClient.Text = "";
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Querry = "select * from Order_Header";
            dts = DBUTILS.PortarPerConsulta(Querry);
            dr = dts.Tables["taula"].NewRow();
            dr["Id_Client"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[3].Value.ToString());
            dr["Id_Seller"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[2].Value.ToString());
            dts.Tables["taula"].Rows.Add(dr);
            bool correct = DBUTILS.Actualizar(Querry, "taula", dts);
            if (correct)
            {
                Querry = "select Id_header from Order_Header where Id_Header =(SELECT MAX(Id_Header) FROM `Order_Header`)";
                dts = DBUTILS.PortarPerConsulta(Querry);
                int Id_Header = Convert.ToInt32(dts.Tables[0].Rows[0][0].ToString());
                for (int row = 0; row < dgView_Sell.Rows.Count - 1; row++)
                {
                    Querry = "select * from Order_Content";
                    dts = DBUTILS.PortarPerConsulta(Querry);
                    dr = dts.Tables["Taula"].NewRow();
                    dr["Id_Header"] = Id_Header;
                    dr["Id_Content"] = Convert.ToInt32(row.ToString());
                    dr["Id_Drug"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[0].Value.ToString());
                    dr["Quantity"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[4].Value.ToString());
                    dts.Tables["taula"].Rows.Add(dr);
                    bool correcte_FK = DBUTILS.Actualizar(Querry, "taula", dts);
                    if (correcte_FK) { MessageBox.Show("Order_Content Actualizado");
                    }else {MessageBox.Show("Error al Actualizar FK ");}   
                }
            }
            else{ MessageBox.Show("Error al Actualizar"); }
        }
    }
}

 
#endregion