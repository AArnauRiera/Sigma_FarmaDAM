using DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellSystem
{
    public partial class frmActive : Form
    {
        DBUtilities DBUTILS = new DBUtilities();
        public DataSet dts;
        public DataTable dt;

        int Value;
        String query;
        public int Active_Principles
        {
            get { return Value; }
            set { Value = value; }
        }
        private DataSet search_equals(string query)
        {
           dts = DBUTILS.PortarPerConsulta(query);
           return dts;
        }
        public frmActive()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select* from Active_Principles  where id='" + Value + "'";
            dts = search_equals(query);
            if (dts.Tables[0].Rows.Count != 0) { dgView_Drugs.DataSource = dts.Tables[0].Rows[0].Table; }
            else { MessageBox.Show("There are no equals products"); }
        }

        private void dgView_Drugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewBand band in dgView_Drugs.Columns)
            {
                band.ReadOnly = true;
            }
        }
    }
}
