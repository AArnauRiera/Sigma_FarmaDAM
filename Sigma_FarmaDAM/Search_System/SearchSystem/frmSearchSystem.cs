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
         DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();

        #region
        public string changebutton
        {
            get { return Value; }
            set { Value = value; }
        }
        ////***CHANGE LABEL TEXT 1 ***///
        public string LabelText1
        {
           get{ return lblSearch1.Text; }
           set{ lblSearch1.Text = value;}
        }
        ///***CHANGE LABEL TEXT 2 ***///
        public string LabelText2
        {
            get{ return lblSearch2.Text; }
            set{ lblSearch2.Text = value; }
        }
        ///***CHANGE LABEL TEXT 3 ***///
        public string LabelText3
        {
            get{ return lblSearch3.Text;}
            set{ lblSearch3.Text = value;}
        }
        #endregion

        ///***FUNCTIONS***///
        #region
        ///*** FUNCTION SEARCH DATA IN BBDD***///
        
        private void portardadesSQL()
        {
            if (Value.Equals("Drugs"))
            {
                query = "select* from Drugs where Register_Number ='" + txtSearch1.Text + "' and Sanitary_Register_Num ='" + txtSearch2.Text + "' and id_active ='" + txtSearch3.Text + "'";
            }
            else if (Value.Equals("Clients"))
            {
                query = "select* from Clients where   DNI =  '" + txtSearch1.Text + "' and Name  ='" + txtSearch2.Text + "' and lastName1 ='" + txtSearch3.Text + "'";
            }
            else
            {
                query = "select* from Active_Principles  where id ='" + txtSearch1.Text + "' and Sanitary_Register_Number ='" + txtSearch2.Text + "' and Name ='" + txtSearch3.Text + "'";
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
    

        #endregion

        ///***MAIN***///
        #region
        
        public frmSearchSystem()
        { 
            InitializeComponent();       
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
           portardadesSQL();         
        }
        private void dgView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewBand band in dgView_List.Columns)
            {
                band.ReadOnly = true;
            }
        }        
    }
#endregion
}
