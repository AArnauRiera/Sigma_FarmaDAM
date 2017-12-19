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
        DBUtils.DBUtils db = new DBUtils.DBUtils();
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
        }

        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {
            db.Conexion();
            if (_edit)
            {
                SetDrugData();
            }
        }

        private void SetDrugData()
        {
            txtActivePrinciple.Text = "POLLA";
            txtBasePrice.Text = "POLLA";
            txtContent.Text = "POLLA";
            txtIVA.Text = "POLLA";
            txtNRN.Text = "POLLA";
            txtNRS.Text = "POLLA";
            txtName.Text = "POLLA";
            txtPharmaceuticLab.Text = "POLLA";

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            string query = "select * from Drugs";
            dts = db.PortarPerConsulta(query);
            DataRow dr = dts.Tables[0].NewRow();
            dr["Register_Number"] = txtNRN.Text;
            dr["Sanitary_Register"] = txtNRS.Text;
            dr["Denomination"] = txtName.Text;
            dr["Content"] = txtContent.Text;
            dr["IVA"] = txtIVA.Text;
            dr["id_active"] = txtActivePrinciple.Text;

            dts.Tables[0].Rows.Add(dr);
            db.Actualizar(query, "Drugs", dts);
        }
    }
}
