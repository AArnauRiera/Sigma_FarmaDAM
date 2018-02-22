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

        public frmAddEditDrugs()
        {
            InitializeComponent();
            _edit = false;
            btnEditAdd.Text = "Add";
            lblTitol.Text = "Añadir medicamentos";
            CenterPanel(pnlAddEditDrugs);
        }

        public frmAddEditDrugs(string drug)
        {
            InitializeComponent();
            _edit = true;
            btnEditAdd.Text = "Edit";
            lblTitol.Text = "Editar medicamentos";
            CenterPanel(pnlAddEditDrugs);
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();

            txtNRN.Leave += new EventHandler(NRN_Leave);
        }

        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            fillCombo(cmbPharmaceuticLab.DBReference, cmbPharmaceuticLab, "Denomination", cmbLabId);
            fillCombo(cmbIVA.DBReference, cmbIVA, "value", cmbIVAId);

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (_edit)
                editReg(pnlAddEditDrugs.Controls);
            else
                AddReg();

        }

        private void fillCombo(String DBReference, cbxSigma cmb, String tableName, ComboBox cmbId)
        {

            AddEditDrugsHelper addEdDrugs = new AddEditDrugsHelper();
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            string query = "SELECT id, " + tableName + " FROM " + DBReference;
            DataSet ds = db.PortarPerConsulta(query);
            DataTable dt = ds.Tables[0];

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

                r["id"] = 1;
                foreach (var control in pnlAddEditDrugs.Controls)
                {
                    if (control is TxtSigma)
                    {
                        TxtSigma cntrl = (TxtSigma)control;
                        if (cntrl.IsFieldCorrect())
                        {
                            if (cntrl.DBReference.Equals("Register_Number") || cntrl.DBReference.Equals("Sanitary_Register_Num") || cntrl.DBReference.Equals("ActivePrincipleID"))
                                r[cntrl.DBReference] = int.Parse(cntrl.Text);
                            else
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
                    else if (control is cbxSigma)
                    {
                        cbxSigma cntrl = (cbxSigma)control;
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
        //        else if (control is cbxSigma)
        //        {
        //            cbxSigma cntrl = (cbxSigma)control;
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
            DBUtils.DBUtilities db = new DBUtils.DBUtilities();
            db.Conexion();

            string query = "SELECT * FROM Drugs";
            dts = db.PortarPerConsulta(query);
            Boolean error = false;

            DataRow dr = dts.Tables[0].NewRow();

            try
            {
                dr["id"] = 1;
                foreach (var control in pnlAddEditDrugs.Controls)
                {
                    if (control is TxtSigma) 
                    {
                        TxtSigma ctrl = (TxtSigma)control;
                        if (ctrl.IsFieldCorrect() || ctrl.DBReference.Equals("Price"))
                        {
                            if (ctrl.DBReference.Equals("Register_Number") || ctrl.DBReference.Equals("Sanitary_Register_Num") || ctrl.DBReference.Equals("ActivePrincipleID"))
                                dr[ctrl.DBReference] = int.Parse(ctrl.Text);
                            else if (ctrl.DBReference.Equals("Price"))
                                dr[ctrl.DBReference] = double.Parse(ctrl.Text);
                            else
                                dr[ctrl.DBReference] = ctrl.Text;
                    }
                    else
                    {
                            ctrl.Text = "";
                            ctrl.Focus();
                            error = true;

                            break;
                    }

                }
                    else if (control is cbxSigma)
                    {
                        cbxSigma ctrl = (cbxSigma)control;
                        if (ctrl.SelectedIndex != 0)
                        {
                            if (ctrl.DBReference.Equals("Laboratories"))
                                dr["LabId"] = int.Parse(cmbLabId.Items[cmbPharmaceuticLab.SelectedIndex - 1].ToString());
                            else if (ctrl.DBReference.Equals("IVA"))
                                dr["IVAId"] = int.Parse(cmbIVAId.Items[cmbIVA.SelectedIndex - 1].ToString());
                        }
                        else
                        {
                            ctrl.Focus();
                            error = true;
                            break;
                        }
                    }
                    else if (control is CheckBoxSigma)
                    {
                        CheckBoxSigma cntrl = (CheckBoxSigma)control;

                        if (cntrl.Checked)
                            dr[cntrl.DBReference] = 1;
                        else
                            dr[cntrl.DBReference] = 0;
                    }
                }

                if (!error)
                {
                    lblError.Text = "";
                    dts.Tables[0].Rows.Add(dr);
                    db.Actualizar(query, "Taula", dts);
                    MessageBox.Show("Medicine Added");
                    clearControls();
                }
                else
                {
                    lblError.Text = "Algun campo es incorrecto";
                }

                //if (error)
                //    MessageBox.Show("Operation Failed");
                //else

                
            }
            catch (Exception e)
            {
                //MessageBox.Show("ERROR");
                MessageBox.Show(e.ToString());
            }

        }

        private void clearControls()
        {


            foreach (var txt in pnlAddEditDrugs.Controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma t = (TxtSigma)txt;
                    t.Text = "";
                }
                else if (txt is CheckBoxSigma)
                {

                    CheckBoxSigma t = (CheckBoxSigma)txt;
                    t.Checked = false;
                }

                else if (txt is ComboBox)
                {

                    ComboBox t = (ComboBox)txt;
                    t.Text = "Selecciona...";
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TxtSigma).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
