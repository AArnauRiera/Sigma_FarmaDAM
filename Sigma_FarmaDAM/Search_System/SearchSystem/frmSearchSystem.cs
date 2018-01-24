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
<<<<<<< HEAD
        public DataSet dts;
        String query, Value;
         DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();

=======

        public DataSet dts;

        String query, Value;
        
>>>>>>> master
        #region
        public string changebutton
        {
            get { return Value; }
            set { Value = value; }
        }
<<<<<<< HEAD
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
=======

        /***CHANGE LABEL TEXT 1 ***///
        public string LabelText1
        {
            get
            {
                return lblSearch1.Text;
            }
            set
            {
                lblSearch1.Text = value;
            }
        }
        /***CHANGE LABEL TEXT 2 ***///
        public string LabelText2
        {
            get
            {
                return lblSearch2.Text;
            }
            set
            {
                lblSearch2.Text = value;
            }
        }
        /***CHANGE LABEL TEXT 3 ***///
        public string LabelText3
        {
            get
            {
                return lblSearch3.Text;
            }
            set
            {
                lblSearch3.Text = value;
            }
>>>>>>> master
        }
        #endregion

        ///***FUNCTIONS***///
<<<<<<< HEAD
        #region
        ///*** FUNCTION SEARCH DATA IN BBDD***///
        
        private void portardadesSQL()
        {
            if (Value.Equals("Drugs"))
=======

        #region
        ///*** FUNCTION SEARCH DATA IN BBDD***///
        private void portardadesSQL()
        {
            DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();
            ///***Search in BBDD***///
            if (Value.Equals("Drugs"))

>>>>>>> master
            {
                query = "select* from Drugs where Register_Number ='" + txtSearch1.Text + "' and Sanitary_Register_Num ='" + txtSearch2.Text + "' and id_active ='" + txtSearch3.Text + "'";
            }
            else if (Value.Equals("Clients"))
            {
<<<<<<< HEAD
=======

>>>>>>> master
                query = "select* from Clients where   DNI =  '" + txtSearch1.Text + "' and Name  ='" + txtSearch2.Text + "' and lastName1 ='" + txtSearch3.Text + "'";
            }
            else
            {
<<<<<<< HEAD
                query = "select* from Active_Principles  where id ='" + txtSearch1.Text + "' and Sanitary_Register_Number ='" + txtSearch2.Text + "' and Name ='" + txtSearch3.Text + "'";
=======

                query = "select* from Active_Principles  where id ='" + txtSearch1.Text + "' and Sanitary_Register_Number ='" + txtSearch2.Text + "' and Name ='" + txtSearch3.Text + "'";

>>>>>>> master
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
<<<<<<< HEAD
        { 
            InitializeComponent();       
=======
        {

            InitializeComponent();
           

>>>>>>> master
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           portardadesSQL();         
        }
        private void dgView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
=======

            portardadesSQL();         
        }
        private void dgView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> master
            foreach (DataGridViewBand band in dgView_List.Columns)
            {
                band.ReadOnly = true;
            }
        }        
    }
#endregion
}
