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

        String query;






        private  void portardadesSQL()
        {
            DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();
            query = "Select * from Clients";
            dts = DBUTILS.PortarPerConsulta(query);
            dgView_List.DataSource = dts.Tables[0];

            DBUTILS = null;
        }

        

        public frmSearchSystem()
        {
            InitializeComponent();



        }



        private void btnSearch_Click(object sender, EventArgs e)
        {


            portardadesSQL();
                  
        }

        
    }
}
