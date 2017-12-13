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






        public frmSearchSystem()
        {
            InitializeComponent();



        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            DataSet dts = null;
           
            DBUtils.DBUtils DBUtils = new DBUtils.DBUtils();
             dts  = DBUtils.PortarPerConsulta("SELECT * FROM CLIENTS");

        }

        private void lvwSearch_Layout(object sender, LayoutEventArgs e)
        {

        }

    
    }
}
