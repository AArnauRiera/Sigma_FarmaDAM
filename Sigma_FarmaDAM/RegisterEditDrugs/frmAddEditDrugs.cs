using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
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

        private DataSet dts = new DataSet();

        public frmAddEditDrugs()//(string drug)
        {
            InitializeComponent();
            _edit = false;
            btnEditAdd.Text = "Add";
            CenterPanel(pnlAddEditDrugs);
        }

        public frmAddEditDrugs/*()*/(string drug)
        {
            InitializeComponent();
            _edit = true;
            btnEditAdd.Text = "Edit";
            CenterPanel(pnlAddEditDrugs);
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();

            txtNRN.Leave += new EventHandler(NRN_Leave);
        }

        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {
            AddEditDrugsHelper addEdDrugs = new AddEditDrugsHelper();
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            fillCombo(cmbPharmaceuticLab.DBReference, cmbPharmaceuticLab, "Denomination", cmbLabId);
            fillCombo(cmbIVA.DBReference, cmbIVA, "value", cmbIVAId);

            //txtNRN.Leave += new EventHandler(NRN_Leave);

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (_edit)
                //SearchAndFillData();
                editReg(pnlAddEditDrugs.Controls);
            else
                AddReg();

        }

        private void fillCombo(String DBReference, cmbSigma cmb, String tableName, ComboBox cmbId)
        {

            AddEditDrugsHelper addEdDrugs = new AddEditDrugsHelper();
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            string query = "SELECT id, " + tableName + " FROM " + DBReference;
            DataSet ds = db.PortarPerConsulta(query);
            DataTable dt = ds.Tables[0];

            //foreach (DataColumn c in dts.Tables["Taula"].Columns)
            //{

            //}

            ////////////////////////////////////////////////////////
            //System.Windows.Controls.ComboBoxItem item = new System.Windows.Controls.ComboBoxItem();
            //item.Tag = 1;
            //item.Content = "item 1";
            //cmbPharmaceuticLab.Items.Add(item);
            ////////////////////////////////////////////////////////
            addEdDrugs.AddComboBoxData(dt, cmb, cmbId);


        }


        public void editReg(Control.ControlCollection Controls)
        {
            string query = "SELECT * FROM Drugs";
            bool correct = false;
            bool saveError = false;

            try
            {
                DBUtils.DBUtilities db = new DBUtils.DBUtilities();
                DataSet dts = db.PortarPerConsulta(query);
                DataRow r = dts.Tables["Taula"].NewRow();
                Label lblErrorText = (Label)pnlAddEditDrugs.Controls.Find("lblError", false)[0];

                foreach (var control in pnlAddEditDrugs.Controls)
                {
                    if (control is TxtSigma)
                    {
                        TxtSigma cntrl = (TxtSigma)control;
                        if (cntrl.IsFieldCorrect())
                        {
                            r[cntrl.DBReference] = cntrl.Text;
                        }
                        else
                        {
                            cntrl.Text = "";
                            cntrl.Focus();
                            saveError = true;
                            break;
                        }

                    }
                    else if (control is cmbSigma)
                    {
                        cmbSigma cntrl = (cmbSigma)control;
                        if (cntrl.SelectedIndex != 0)
                        {
                            r[cntrl.DBReference] = cntrl.SelectedIndex;
                        }
                        else
                        {
                            cntrl.Focus();
                            saveError = true;
                            break;
                        }
                    }
                }

                dts.Tables["Taula"].Rows.Add(r);

                if (!saveError)
                {
                    correct = db.Actualizar(query, "Taula", dts);
                    lblErrorText.Text = "";
                }
                else
                {
                    lblErrorText.Text = "Algun campo es incorrecto";
                }

                if (correct)
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        //private void addReg2() {

        //    string query = "SELECT * FROM Drugs";
        //    //bool correct = false;
        //    //bool saveError = false;

        //    DBUtils.DBUtilities db = new DBUtils.DBUtilities();
        //    DataSet dts = db.PortarPerConsulta(query);
        //    DataRow r = dts.Tables["Taula"].NewRow();
        //    Label lblErrorText = (Label)pnlAddEditDrugs.Controls.Find("lblError", false)[0];

        //    foreach (var control in pnlAddEditDrugs.Controls)
        //    {
        //        if (control is TxtSigma)
        //        {
        //            TxtSigma cntrl = (TxtSigma)control;
        //            if (cntrl.IsFieldCorrect())
        //            {
        //                r[cntrl.DBReference] = cntrl.Text;
        //            }
        //            else
        //            {
        //                cntrl.Text = "";
        //                cntrl.Focus();
        //                //saveError = true;
        //                break;
        //            }

        //        }
        //        else if (control is cmbSigma)
        //        {
        //            cmbSigma cntrl = (cmbSigma)control;
        //            if (cntrl.SelectedIndex != 0)
        //            {
        //                r[cntrl.DBReference] = cntrl.SelectedIndex;
        //            }
        //            else
        //            {
        //                cntrl.Focus();
        //                //saveError = true;
        //                break;
        //            }
        //        }
        //    }
        //}

        private void AddReg()
        {

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

            DataRow dr = dts.Tables[0].NewRow();


            //foreach (var control in pnlAddEditDrugs.Controls)
            //{
            //    if (control is TxtSigma)
            //    {
            //        TxtSigma cntrl = (TxtSigma)control;
            //        if (cntrl.IsFieldCorrect())
            //        {
            //            dr[cntrl.DBReference] = cntrl.Text;
            //        }
            //        else
            //        {
            //            cntrl.Text = "";
            //            cntrl.Focus();

            //            break;
            //        }

            //    }
            //    else if (control is cmbSigma)
            //    {
            //        cmbSigma cntrl = (cmbSigma)control;
            //        if (cntrl.SelectedIndex != 0)
            //        {
            //            dr[cntrl.DBReference] = cntrl.SelectedIndex;
            //        }
            //        else
            //        {
            //            cntrl.Focus();

            //            break;
            //        }
            //    }
            //}

            try
            {
                dr["Register_Number"] = int.Parse(txtNRN.Text);
                dr["Sanitary_Register_Num"] = int.Parse(txtNRS.Text);
                dr["CommercialName"] = txtName.Text;
                dr["ActivePrincipleID"] = txtActivePrinciple.Text;
                dr["Content"] = txtContent.Text;

                //MessageBox.Show(cmbLabId.Items[int.Parse(cmbPharmaceuticLab.SelectedIndex.ToString())].ToString());
                //dr["LabId"] = int.Parse(cmbPharmaceuticLab.SelectedIndex.ToString());
                //int mansana = cmbPharmaceuticLab.SelectedIndex-1;
                //int painapel = cmbIVA.SelectedIndex-1;
                dr["LabId"] = int.Parse(cmbLabId.Items[cmbPharmaceuticLab.SelectedIndex - 1].ToString());

                //MessageBox.Show(cmbLabId.Items[3].ToString());

                dr["Price"] = double.Parse(txtBasePrice.Text);
                //dr["IVAId"] = int.Parse(cmbIVA.SelectedIndex.ToString());
                dr["IVAId"] = int.Parse(cmbIVAId.Items[cmbIVA.SelectedIndex - 1].ToString());

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
            catch (Exception e)
            {
                MessageBox.Show("ERROR");
                MessageBox.Show(e.ToString());
            }

        }

        private void clearControls()
        {


            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                {
                    TextBox t = (TextBox)txt;
                    t.Text = "";
                }
                else if (txt is CheckBox)
                {

                    CheckBox t = (CheckBox)txt;
                    t.Checked = false;
                }

            }
            #region
            //txtNRN.Text = "";
            //txtNRS.Text = "";
            //txtName.Text = "";
            //txtActivePrinciple.Text = "";
            //txtContent.Text = "";
            //txtPharmaceuticLab.Text = "";
            //txtBasePrice.Text = "";
            //txtIVA.Text = "";

            //chkReplaceable.Checked = false;
            //chkGeneric.Checked = false;
            //chkRecipe.Checked = false;
            #endregion
        }

        private void SearchAndFillData()
        {
            AddEditDrugsHelper DrugHelper = new AddEditDrugsHelper();

            if (!string.IsNullOrWhiteSpace(txtNRN.Text))
            {
                TxtSigma[] control = new TxtSigma[] { txtNRN };    //matriz de controles
                DataSet dts = DBHelper.GetQuery("Drugs", control); // pilla todo lo de control (txtsigma con dbreference) consulta de la tabla seleccionada. devuelve un dts que es eso.

                if (dts.Tables["Taula"].Rows != null)
                {
                    DBHelper.BindingTextBox(pnlAddEditDrugs.Controls, dts); // enlaza lo del dts a los controles
                    DrugHelper.DataBindingComboBox(dts, Controls);

                }
            }

        }

        private void NRN_Leave(object sender, EventArgs e)
        {
            SearchAndFillData();

            //if (_edit)
            //    //SearchAndFillData();
            //    editReg(pnlAddEditDrugs.Controls);
            //else
            //    AddReg();
        }
    }
}
