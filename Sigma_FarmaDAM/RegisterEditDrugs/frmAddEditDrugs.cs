using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;


namespace RegisterEditDrugs
{
    public partial class frmAddEditDrugs : CentredForm

    {
        private bool _edit;
        
        private DataSet dts = new DataSet();
        public frmAddEditDrugs(string drug)
        {
            InitializeComponent();
            _edit = false;
            btnEditAdd.Text = "Add";
            CenterPanel(pnlAddEditDrugs);

        }

        public frmAddEditDrugs()
        {
            InitializeComponent();
            _edit = true;
            btnEditAdd.Text = "Edit";
            CenterPanel(pnlAddEditDrugs);
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();
            if (_edit)
            {
                SetDrugData();
            }
        }

        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {

        }

        private void SetDrugData()
        {
            txtActivePrinciple.Text = "234";
            txtBasePrice.Text = "234";

            txtIVA.Text = "234";
            txtNRN.Text = "234";
            txtNRS.Text = "234";
            txtName.Text = "hola";


        }
        private void FuncEdit() {

            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();
            string query = "SELECT * FROM Drugs WHERE Register_Number LIKE " + int.Parse(txtNRN.Text);
            dts = db.PortarPerConsulta(query);

            DataTable dt = dts.Tables[0];
            DataRow dr = dts.Tables[0].NewRow();


            try
            {
                txtActivePrinciple.Text = dts.Tables["Taula"].Rows[0].ToString();
                txtBasePrice.Text = dts.Tables["Taula"].Rows[0].ToString();
                txtIVA.Text = dts.Tables["Taula"].Rows[0].ToString();
                txtNRN.Text = dts.Tables["Taula"].Rows[0].ToString();
                txtNRS.Text = dts.Tables["Taula"].Rows[0].ToString();
                txtName.Text = dts.Tables["Taula"].Columns[0].ToString();
            }
            catch (Exception e){
                Console.WriteLine(e);
            }

        }
        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();
            
            string query = "SELECT * FROM Drugs";
            dts = db.PortarPerConsulta(query);

            DataTable dt = dts.Tables[0];

            DataRow dr = dts.Tables[0].NewRow();
                        
            dr["Register_Number"] = int.Parse(txtNRN.Text);
            dr["Sanitary_Register_Num"] = int.Parse(txtNRS.Text);
            dr["Denomination"] = txtName.Text;

            if (chkReplaceable.Checked)
                dr["Replaceable"] = 1;
            else
                dr["Replaceable"] = 0;

            if (chkGeneric.Checked)
                dr["Generic"] = 1;
            else
                dr["Generic"] = 0;

            if (chkRecipe.Checked)
                dr["Obligatory"] = 1;
            else
                dr["Obligatory"] = 0;

            dr["id_active"] = 50;
            
            dts.Tables[0].Rows.Add(dr);
            db.Actualizar(query, "Taula", dts);
        }

        private void txtNRN_TextChanged(object sender, EventArgs e)
        {
            FuncEdit();
        }
    }
}
