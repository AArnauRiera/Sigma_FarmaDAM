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
        public frmAddEditDrugs()
        {
            InitializeComponent();
            _edit = false;
            btnEditAdd.Text = "Add";
            CenterPanel(pnlAddEditDrugs);

        }

        public frmAddEditDrugs(string drug)
        {
            InitializeComponent();
            _edit = true;
            btnEditAdd.Text = "Edit";
            CenterPanel(pnlAddEditDrugs);
            DBUtils.DBUtils db = new DBUtils.DBUtils();
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
            txtActivePrinciple.Text = "AAAAA";
            txtBasePrice.Text = "AAAAA";
            txtContent.Text = "AAAAA";
            txtIVA.Text = "AAAAA";
            txtNRN.Text = "AAAAA";
            txtNRS.Text = "AAAAA";
            txtName.Text = "AAAAA";
            txtPharmaceuticLab.Text = "AAAAA";

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            DBUtils.DBUtils db = new DBUtils.DBUtils();
            db.Conexion();
            //string query = "select Register_Number, Sanitary_Register_Num, Denomination, Content,id_active from 'Drugs'";
            string query = "SELECT * FROM Drugs";
            dts = db.PortarPerConsulta(query);

            DataTable dt = dts.Tables[0];
            //DataTable dt = new DataTable("test");
            //dt.Columns.Add(new DataColumn("Register_Number", typeof(int)));
            //dt.Columns.Add(new DataColumn("Sanitary_Register_Num", typeof(int)));
            //dt.Columns.Add(new DataColumn("Content", typeof(string)));
            //dt.Columns.Add(new DataColumn("id_active", typeof(int)));

            //DataRow dr = dt.NewRow();

            DataRow dr = dts.Tables[0].NewRow();

            dr["Register_Number"] = 50;
            dr["Sanitary_Register_Num"] = 50;
            dr["Denomination"] = "74174174174174";
            dr["Replacable"] = 0;
            dr["Generic"] = 0;
            dr["Obligatory"] = 0;
            dr["id_active"] = 50;
            //dt.Rows.Add(dr);
            //dts.Tables.Add(dt);

            ////DataRow dr = dts.NewRow();
            //dr = dts.Tables[0].Rows[0];
            //dr["Register_Number"] = txtNRN.Text;
            //dr["Sanitary_Register_Num"] = txtNRS.Text;
            ////dr["Denomination"] = txtName.Text;
            //dr["Content"] = txtContent.Text;
            //dr["id_active"] = txtActivePrinciple.Text;

            //dt.Rows.Add(dr);
            //dts.Tables.Add(dt);

            dts.Tables[0].Rows.Add(dr);
            db.Actualizar(query, "Drugs", dts);
        }
    }
}
