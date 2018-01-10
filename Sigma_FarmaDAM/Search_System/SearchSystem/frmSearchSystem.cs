using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtils;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SearchSystem
{
    public partial class frmSearchSystem : Form
    {

        public DataSet dts;

        String query, Value;
        ///***BUTTON CALL FROM OTHER FORM***///

        public string changebutton
        {
            get { return Value; }
            set {Value  = value; }
        }
        
       
        
        


        ///*** FUNCTION SEARCH DATA IN BBDD***///
        private void portardadesSQL()
        {
            DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();
            ///***Search in BBDD***///
            if (Value.Equals("Drugs"))

            {
                query = "select* from Drugs where Register_Number ='"+ txtSearch1.Text + "and Sanitary_Register_Number ='" + txtSearch2.Text + " and id_active ='" + txtSearch3.Text + "'";
            }
            if(Value.Equals("Clients"))
            {
             
              query = "select* from Clients where   DNI =  '" + txtSearch1.Text + " and Name  ='" + txtSearch2.Text + " and lastName1 ='" + txtSearch3.Text + "'";
            }
            if (Value.Equals("Active_Principles"))
            {
             
                query = "select* from Active_Principles  where id ='" + txtSearch1.Text + " and Sanitary_Register_Number ='" + txtSearch2.Text + " and Name ='" + txtSearch3.Text + "'";

            }
            
           
            dts = DBUTILS.PortarPerConsulta(query);
            ///***Rows Count***///
            if (dts.Tables[0].Rows.Count != 0)
            {
                dgView_List.DataSource = dts.Tables[0].Rows[0].Table;
            }
            else
            {
                MessageBox.Show("There are no values ");
            }
            dgView_List.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        /// ***UPDATE LABEL TEXT***///

        private void Label_Update()
        {
            if (Value.Equals("Drugs"))

            {
                lblSearch1.Text = "Register Number";
                lblSearch2.Text = "Sanitary Register Number";
                lblSearch3.Text = "Denomination";
               
            }
            if (Value.Equals("Clients"))
            {
                lblSearch1.Text = "DNI";
                lblSearch2.Text = "Name";
                lblSearch3.Text = "Last Name";
            }
            if (Value.Equals("Active_Principles"))
            {
                lblSearch1.Text = "ID";
                lblSearch2.Text = "Sanitary Register Number";
                lblSearch3.Text = "Name";

           }
        }

        ///***MAIN***///
        public frmSearchSystem()
        {
            InitializeComponent();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            portardadesSQL();         
        }

        private void lblSearch1_TextChanged(object sender, EventArgs e)
        {

            Label_Update();
        }

        private void dgView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewBand band in dgView_List.Columns)
            {
                band.ReadOnly = true;
            }


        }

        
    }
}
