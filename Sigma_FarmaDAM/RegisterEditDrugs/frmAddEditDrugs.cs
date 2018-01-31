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

    //Num. registre nacional (Clau)   ###   --> cod_nacion
    //Num de registre sanitari        ###   --> nro_definitivo
    //Denominació comercial           ###   --> des_nomco
    //Principi actiu                  ojo   --> composicion_pa, cod_principio_activo
    //Contingut                       ###   --> nro_conte
    //Laboratori farmacèutic          ###   --> laboratorio_titular
    //Preu de venda(sense IVA)        ###   --> -NO DISPONIBLE-
    //Iva(Tipus aplicable)            falta --> -NO DISPONIBLE-
    //Si es substituïble o no         ojo   --> -NO DISPONIBLE-
    //Si és genèric o no              ###   --> sw_generico
    //Si és obligatòria la recepta    ###   --> sw_receta

    //Documentació de la fitxa tècnica(PDF)   coming soon --> url_fictec
    //Prospecte(PDF)                          coming soon --> url_prosp

namespace RegisterEditDrugs
{
    public partial class frmAddEditDrugs : CentredForm
    {
        private bool _edit;
        private String RegNumEdit = "49";

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
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();
            if (_edit)
            {
                //SetDrugData(db);
            }
        }

        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {

        }

        private void AddReg() {

            //Num. registre nacional (Clau) 
            //Num de registre sanitari      
            //Denominació comercial         
            //Principi actiu                
            //Contingut                     
            //Laboratori farmacèutic        
            //Preu de venda(sense IVA)      
            //Iva(Tipus aplicable)          
            //Si es substituïble o no       
            //Si és genèric o no            
            //Si és obligatòria la recepta  

            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();

            string query = "SELECT * FROM Drugs";
            dts = db.PortarPerConsulta(query);

            DataTable dt = dts.Tables[0];

            DataRow dr = dts.Tables[0].NewRow();

            try
            {
                dr["Register_Number"] = int.Parse(txtNRN.Text);
                dr["Sanitary_Register_Num"] = int.Parse(txtNRS.Text);
                dr["CommercialName"] = txtName.Text;
                dr["ActivePrincipleID"] = txtActivePrinciple.Text;
                dr["Content"] = txtContent.Text;
                dr["LabId"] = int.Parse(txtPharmaceuticLab.Text);
                dr["Price"] = double.Parse(txtBasePrice.Text);
                dr["IVAId"] = int.Parse(txtIVA.Text);

                //Documentation
                //   Prospectus

                if (chkReplaceable.Checked)
                    dr["Replaceable"] = 1;
                else
                    dr["Replaceable"] = 0;

                if (chkGeneric.Checked)
                    dr["IsGeneric"] = 1;
                else
                    dr["IsGeneric"] = 0;

                if (chkRecipe.Checked)
                    dr["NeedsRecipe"] = 1;
                else
                    dr["NeedsRecipe"] = 0;


                dts.Tables[0].Rows.Add(dr);
                db.Actualizar(query, "Taula", dts);

                MessageBox.Show("Medicine Added");
            }
            catch (Exception x) {
                MessageBox.Show("ERROR");
            }

        }

        private void clearControls() {

            txtNRN.Text = "";
            txtNRS.Text = "";
            txtName.Text = "";
            txtActivePrinciple.Text = "";
            txtContent.Text = "";
            txtPharmaceuticLab.Text = "";
            txtBasePrice.Text = "";
            txtIVA.Text = "";

            chkReplaceable.Checked = false;
            chkGeneric.Checked = false;
            chkRecipe.Checked = false;
        }

        private void SetDrugData ()
        {

            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();
            string query = "SELECT * FROM Drugs WHERE Register_Number LIKE " + "49";
            dts = db.PortarPerConsulta(query);

            txtNRN.Text             = dts.Tables[0].Rows[0][0].ToString();
            txtNRS.Text             = dts.Tables[0].Rows[0][1].ToString();
            txtName.Text            = dts.Tables[0].Rows[0][2].ToString();
            txtActivePrinciple.Text = dts.Tables[0].Rows[0][3].ToString();
            txtContent.Text         = dts.Tables[0].Rows[0][4].ToString();
            txtPharmaceuticLab.Text = dts.Tables[0].Rows[0][5].ToString();
            txtBasePrice.Text       = dts.Tables[0].Rows[0][6].ToString();
            
                    //////////////////////////
                    /////////COMBOBOX/////////
                    //////////////////////////

            if (dts.Tables[0].Rows[0][7].ToString().Equals("1"))
                chkReplaceable.Checked = true;
            else
                chkReplaceable.Checked = false;

            if (dts.Tables[0].Rows[0][8].ToString().Equals("1"))
                chkGeneric.Checked = true;
            else
                chkGeneric.Checked = false;

            if (dts.Tables[0].Rows[0][9].ToString().Equals("1"))
                chkRecipe.Checked = true;
            else
                chkRecipe.Checked = false;

            //   1   Register_Number
            //   2   Sanitary_Register_Num
            //   3   CommercialName
            //   4   ActivePrincipleID
            //   5   Content
            //   6   LabId
            //   7   Price
            //   8   IVAId
            //   9   Replaceable tinyint(1)
            //   10  IsGeneric tinyint(1)
            //   11  NeedsRecipe tinyint(1)
            //   12  Documentation
            //   13  Prospectus

            //dr["Register_Number"] = int.Parse(txtNRN.Text);
            //dr["Sanitary_Register_Num"] = int.Parse(txtNRS.Text);
            //dr["Denomination"] = txtName.Text;

            //if (chkReplaceable.Checked)
            //    dr["Replaceable"] = 1;
            //else
            //    dr["Replaceable"] = 0;

            //if (chkGeneric.Checked)
            //    dr["Generic"] = 1;
            //else
            //    dr["Generic"] = 0;

            //if (chkRecipe.Checked)
            //    dr["Obligatory"] = 1;
            //else
            //    dr["Obligatory"] = 0;

            //dr["id_active"] = 50;

            //dts.Tables[0].Rows.Add(dr);
            //db.Actualizar(query, "Taula", dts);

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (_edit)
                SetDrugData();
            else
                AddReg();
        }
    }
}
