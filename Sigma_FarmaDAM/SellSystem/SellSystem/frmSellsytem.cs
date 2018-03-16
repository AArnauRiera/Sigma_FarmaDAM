using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DBUtils;
using GenerateTicket;
using SearchSystem;
using Sigma_Controls;

namespace SellSystem
{
    public partial class frmSellsytem : Form
    {
        DBUtilities DBUTILS = new DBUtils.DBUtilities();
        SellSystemHelper SSHelper = new SellSystemHelper();
        public DataSet dts;
        DataTable dt = new DataTable();
        public DataRow dr;

        string Querry;
        bool validate = false;
        bool Client = false;
        int contador = 1;

        public string[] values = new string[4];

        private string ID_Sell = "1";

        ///***CONSTRUCTOR***///
        public frmSellsytem(String ID_sell) {
            InitializeComponent();
            lblName.Text = "";
            txtCantidad.Enabled = false;
            txtCod.Enabled = false;
            btnAdd.Enabled = false;
            btnBuy.Enabled = false;
            ID_Sell = ID_sell;

        }
        ///***MAIN***///
        #region
        public frmSellsytem()
        {
            InitializeComponent();
            lblName.Text = "";
            txtCantidad.Enabled = false;
            txtCod.Enabled      = false;
            btnAdd.Enabled      = false;
            btnBuy.Enabled      = false;
        }
        /// <summary>
        /// Este metodo actualiza los valores de los medicamentos en el DataGridView 
        /// Lo que hace es primero comprueva si el nombre del producto no es nullo
        /// si no lo es entonces comprueva si el valor existe con un for si existe actualiza la cantidad y pone el boolean
        /// exist en true si no es true entonces añade los valores en un datarow 
        /// luego si el dataset que guarda el nombre del medicamento codigo etz tiene mas de una row entonces
        /// muestra el datagridview si no es asi muestra  un mensaje por pantalla avisando que es nullo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //CheckDrugData();

            bool exist = false;
            String Drug = txtCod.Text.ToString();

            if (!String.IsNullOrEmpty(txtProd.Text))
            {
                ///comprueba si un medicamento esta introduido en la tabla y si esta introduido le añade suma la cantidad introduida///
                CheckDrugData();
                if (SSHelper.stock(txtCod.Text, txtCantidad.Text))
                {

                    try
                    {
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
                            dgView_Sell.Columns[0].HeaderText = "ID Medicamento";
                            dgView_Sell.Columns[1].HeaderText = "Nombre Medicamento";
                            // dgView_Sell.Columns[2].Visible = false;
                            // dgView_Sell.Columns[3].Visible = false;
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
                            dr[3] = SSHelper.Client_ID(txtClient.Text);
                            dr[4] = txtCantidad.Text;

                            dt.Rows.Add(dr);
                            txtCod.Text = "";
                            txtProd.Text = "";
                            txtCantidad.Text = "1";
                        }

                    }

                    catch
                    {
                        MessageBox.Show("There are no values ");
                    }

                } else {

                    MessageBox.Show("La candidad solicitada sobrepasa el stock actual");

                }
            
            }

        }

        /// <summary>
        /// Al cargar el form genera estas columnas en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSellsytem_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID_Stock ");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_Seller");
            dt.Columns.Add("ID_client");
            dt.Columns.Add("quantity");
            txtCantidad.Text = "1";
        }
        /// <summary>
        /// Este metodo valida si el codigo del medicamento existe y si tiene stock
        /// Pulsando la tecla enter actualiza el txtProd que es donde se pone el nombre del medicamento
        /// entonces mediante dos funciones una que comprueva si el medicamento existe y otra si tiene stock 
        /// te permite añadir el medicamento o si no tiene stock o no existe te busca medicamentos que tengan la misma ID 
        /// de Active Principle abriendo   el from frmQueryDrugs 
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            ///Comprueba si se pulsa la key enter y que no este null el campo del codigo del medicamento///
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtCod.Text))
            {
                CheckDrugData();
            }
        }


        private void CheckDrugData() {

            string productName = SSHelper.name_product(txtCod.Text);
            if (!String.IsNullOrEmpty(productName))
            {
                txtProd.Text = productName;
                if (!(SSHelper.drug_exist(txtCod.Text) && SSHelper.stock(txtCod.Text)))
                {
                    if (MessageBox.Show("¿Quieres buscar medicamentos similares?", "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string condition2 = txtCod.Text;
                        frmQueryDrugs r = new frmQueryDrugs(GetTxtSigma(), "Drugs", SSHelper.id_active(txtCod.Text), txtCod.Text);
                        r.Show();
                    }
                    else
                    {
                        txtCod.Text = "";
                        txtProd.Text = "";
                    }
                }
            }
            else
            {
                txtCod.Text = "";
                txtProd.Text = "";
            }

        }
       /// <summary>
       /// Esta Fucion utiliza el custom control para sacar el texto de cada control que hay en el panel
       /// utiliza un from que recorre todos los valores de el panel 
       /// </summary>
       /// <returns></returns>
        private TxtSigma[] GetTxtSigma()
        {
            List<TxtSigma> txts = new List<TxtSigma>();
            for (int i = 0; i < pnltxt.Controls.Count; i++)
            {
                if (pnltxt.Controls[i] is TxtSigma && !pnltxt.Controls[i].Name.Equals("txtCantidad"))
                {
                    txts.Add(pnltxt.Controls[i] as TxtSigma);
                }
            }
            return txts.ToArray();
        }
        

        /// <summary>
        ///Evita que se pueda hacer click en las columnas del DataGridView///
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void dgView_Sell_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            foreach (DataGridViewBand band in dgView_Sell.Columns)
            {
                band.ReadOnly = true;
            }
        }
        /// <summary>
        /// Actualiza las tablas Order_Header y  Order_Content que se utilizan para generar el crystal report
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            DataRow drOrder;
            string stockQuery;
            string queryHeader = "select * from Order_Header  where 1 = 2";
            try
            {
                ///Se añade un nuevo Header para el ticket de compra que esta en la tabla Order_Header///
                dts = DBUTILS.PortarPerConsulta(queryHeader);
                dr = dts.Tables["taula"].NewRow();

                dr["Id_Client"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[3].Value.ToString());
                dr["Id_Seller"] = Convert.ToInt32(dgView_Sell.Rows[0].Cells[2].Value.ToString());

                dr["Date"] = DateTime.Now;
                dts.Tables["taula"].Rows.Add(dr);

                bool correct = DBUTILS.Actualizar(queryHeader, "taula", dts);
                if (correct)
                {
                    ///Si se genera correctamente el header en la BBDD se actualiza la tabla Order_Content con el contenido de cada medicamento de la lista de la compra///
                    string queryID = "select Id_header from Order_Header where Id_Header =(SELECT MAX(Id_Header) FROM Order_Header)";
                    dts = DBUTILS.PortarPerConsulta(queryID);
                    int Id_Header = Convert.ToInt32(dts.Tables[0].Rows[0][0].ToString());

                    string queryOrder = "select * from Order_Content where 1 = 2";
                    dts = DBUTILS.PortarPerConsulta(queryOrder);

                    for (int row = 0; row < dgView_Sell.Rows.Count - 1; row++)
                    {
                        drOrder = dts.Tables["Taula"].NewRow();
                        drOrder["Id_Header"] = Id_Header;
                        drOrder["Id_Drug"] = SSHelper.Drug_ID(dgView_Sell.Rows[row].Cells[0].Value.ToString());//ojo
                        drOrder["Quantity"] = Convert.ToInt32(dgView_Sell.Rows[row].Cells[4].Value.ToString());
                        dts.Tables["Taula"].Rows.Add(drOrder);
                        Console.WriteLine(drOrder);
                    }
                    bool correcte_FK = DBUTILS.Actualizar(queryOrder, "Taula", dts);
                    ///Si se introducen correctamente tanto el header como los valores del los medicamentos de la lista de la compra///
                    if (correcte_FK)
                    {
                        int i = 0;
                        int quantity;
                        stockQuery = "SELECT * FROM Stock where ID_Drug = -1" + SSHelper.getIdDrugsStock(dts);
                        dts = DBUTILS.PortarPerConsulta(stockQuery);
                        ///Se Actualiza el Stock del medicamento que esta en la tabla stock con el stock que se quiere sacar en cada venda///
                        foreach (DataRow r in dts.Tables["Taula"].Rows)
                        {
                            foreach (DataGridViewRow row in dgView_Sell.Rows)
                            {
                                if (SSHelper.Drug_ID(row.Cells[0].Value.ToString()).ToString().Equals(r["ID_Drug"].ToString()))
                                {
                                    quantity = Convert.ToInt32(r["Quantity"]) - Convert.ToInt32(row.Cells["quantity"].Value.ToString());
                                    r["Quantity"] = quantity;
                                    break;
                                }
                            }
                        }
                        bool stockUpdated = DBUTILS.Actualizar(stockQuery, "Taula", dts);

                        frmGenerateTicket frmGenTicket = new frmGenerateTicket(Id_Header);

                        frmGenTicket.Show();

                    }
                    else { MessageBox.Show("Error al Actualizar FK "); }
                }
                else { MessageBox.Show("Error al Actualizar"); }
            }
            catch
            {
                MessageBox.Show("ERROR: Faltan datos por rellenar");
            }
            
        }
        private void pnltxt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgView_Sell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        ///comprueva que la cantidad introducida para comprar sea  mayor que la cantidad actual que hay en la tabla stock
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txtCod.Text)) { 

                    Querry = "SELECT Quantity FROM Stock WHERE ID_Drug ='" + SSHelper.Drug_ID(txtCod.Text) + "'";
                    dts = DBUTILS.PortarPerConsulta(Querry);
                    int Stock = Convert.ToInt32(dts.Tables[0].Rows[0][0].ToString());
                if (Stock < Convert.ToInt32(txtCantidad.Text))
                    {
                        MessageBox.Show("No hay suficiente Cantidad");
                        txtCantidad.Text = "1";
                    }

            }

            }
        }


        /// <summary>
        ///Permite validar si un client existe gracias a la funcion Client_exist y  introducce el nombre y apellidos a  lblName.text
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void txtClient_Leave(object sender, EventArgs e)
        {
            SetClient(txtClient);
        }

        public void SetClient(TxtSigma txt)
        {
            Client = SSHelper.Client_exist(txtClient);
            if (Client)
            {
                txtClient.ReadOnly = true;
                dts = SSHelper.client(txtClient);
                lblName.Text = dts.Tables[0].Rows[0][0].ToString() + " " + dts.Tables[0].Rows[0][1].ToString() + " " + dts.Tables[0].Rows[0][2].ToString();

                txtCantidad.Enabled = true;
                txtCod.Enabled = true;
                btnAdd.Enabled = true;
                btnBuy.Enabled = true;

                txtClient.Enabled = false;
            }
            else
            {
                MessageBox.Show("No existe el cliente");
                txtClient.Text = "";
            }
        }
    }

        /// <summary>
        /// Controla que solo se puedan introducir números y letras.
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void checkNumKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {

                e.Handled = true;

            }

            if ((e.KeyChar == ',') && ((sender as TxtSigma).Text.IndexOf(',') > -1))
            {

                e.Handled = true;

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmQueryClients clientQuery = new frmQueryClients(txtClient,"Clients");
            clientQuery.Show();
        }

        private void frmSellsytem_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DBUTILS = null;
            //DBUTILS = DBUTILS.Dispose();
            //SSHelper = SSHelper.Dispose();
            //dt = dt.Dispose();
        }
    }
}



#endregion