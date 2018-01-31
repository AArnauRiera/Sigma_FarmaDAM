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
        DBUtils.DBUtilities DBUTILS = new DBUtils.DBUtilities();
        frmActive f = new frmActive();
        public DataSet dts;
        public DataTable dt;

        String Querry;
        Boolean validate = false;
        Boolean Client = false;

        ///***FUNCTIONS***///
        #region    
        private Boolean Client_exist()
        {
            Querry = "select* from Clients  where DNI ='" + txtClient.Text + "'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0){ validate = true;}
            else
            {
                MessageBox.Show("The Client doesn't exist");
                validate = false;
            }
            return validate;
        }
        private Boolean drug_exist(String drug)
        {
            Querry = "select* from Drugs  where Register_Number='" + drug + "'" ;
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) {validate = true;}
            else{validate = false;}
            return validate;
        }
        private Boolean stock(String drug)
        {
            Querry = "select * from Stock where id='" + drug + "'and stock >0'";
            dts = DBUTILS.PortarPerConsulta(Querry);
            if (dts.Tables[0].Rows.Count > 0) {validate = true;}
            else {validate = false;}
            return validate;
        }
       
       #endregion
        ///***MAIN***///
        #region
        public frmSellsytem()
        {
            InitializeComponent();
        }
        private void lswDrugs_Layout(object sender, LayoutEventArgs e)
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            lswDrugs.HeaderStyle = ColumnHeaderStyle.None;
            columnHeader1.Width = 500;
            this.lswDrugs.Columns.Add(columnHeader1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client = Client_exist();
            if (Client)
            {     
                String Drug = txtProduct.Text.ToString();
                ListViewItem item = new ListViewItem(Drug);
                lswDrugs.Items.AddRange(new ListViewItem[] { item });
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Boolean drug = false;
            int contadors = 0;
            foreach (ListViewItem itemRow in this.lswDrugs.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    String Value = itemRow.SubItems[i].ToString();
                   drug = drug_exist(Value); 
                   if (drug == false){contadors++;}
                }
            }
            if (contadors > 0){MessageBox.Show("There are products that doesn't exist");}
            else{MessageBox.Show("Bought Correctly");}
        }
    }
}
 
#endregion