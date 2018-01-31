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

namespace SellSystem
{
    public partial class frmSellsytem : Form
    {
        DBUtils.DBUtils DBUTILS = new DBUtils.DBUtils();

        public DataSet dts;
        ///***FUNCTIONS***///
        #region    
        private void Client_exist()
        {
            String Querry = "select* from Clients  where DNI ='" + txtClient.Text + "'";
            Boolean Update = false;
            dts = DBUTILS.PortarPerConsulta(Querry);
            if(dts.Tables[0].Rows.Count > 0){
                MessageBox.Show("There Client exist ");
            }else{
                DBUTILS.Actualizar(Querry, "Taula", dts);
                MessageBox.Show("The Client Has been created ");
            }
        }
#endregion

        ///***MAIN***///
        #region
        public frmSellsytem()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            Client_exist();
        }
    }
}
#endregion