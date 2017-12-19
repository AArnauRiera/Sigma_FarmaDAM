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
            if (Value.Equals("Drugs"))
            {
                query = "select* from drugs where Register_Number = "+ txtSearch.Text + "'";
            }
            else
            {
                query = "select* from Clients where   Name =  '" + txtSearch.Text + "'";
            }

            dts = DBUTILS.PortarPerConsulta(query);

            dgView_List.DataSource = dts.Tables[0].Rows[0].Table;

            dgView_List.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
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

        private void dgView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgView_List.Rows[e.RowIndex].ReadOnly = true;

            if (dgView_List.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)

            {

                dgView_List.Rows[e.RowIndex].ReadOnly = false;
            }
        }

        
    }
}
