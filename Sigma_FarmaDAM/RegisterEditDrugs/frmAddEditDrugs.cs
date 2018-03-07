using System;
using System.Data;
using System.Windows.Forms;
using Helpers;
using Sigma_Controls;

namespace RegisterEditDrugs
{
    /// <summary>
    /// Formulario para añadir o editar medicamentos.
    /// </summary>
    public partial class frmAddEditDrugs : CentredForm
    {

        /// <summary>
        /// Controla si se está editando o añadiendo.
        /// </summary>
        private bool _edit;

        /// <summary>
        /// Recoge los datos de la base de datos.
        /// </summary>
        private DataSet dts = new DataSet();

        /// <summary>
        /// Constructor sin paarámetros para añadir.
        /// </summary>
        public frmAddEditDrugs()
        {

            InitializeComponent();

            _edit = false;

            btnEditAdd.Text = "Add";

            lblTitol.Text = "Añadir medicamentos";

            CenterPanel(pnlAddEditDrugs);

        }

        /// <summary>
        /// Constructor para editar.
        /// </summary>
        /// <param name="drug">Medicamento que queremos editar</param>
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

        /// <summary>
        /// Llama al método para llenar las comboBox.
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void frmAddEditDrugs_Load(object sender, EventArgs e)
        {

            fillCombo(cmbPharmaceuticLab.DBReference, cmbPharmaceuticLab, "Denomination", cmbLabId);

            fillCombo(cmbIVA.DBReference, cmbIVA, "value", cmbIVAId);

        }

        /// <summary>
        /// Edita o añade registros a la base de datos.
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (_edit)
            {

                editReg(pnlAddEditDrugs.Controls);

            }
            else
            {

                AddReg();

            }
                
        }

        /// <summary>
        /// Llena las comboBox de datos.
        /// </summary>
        /// <param name="DBReference">Campo de la tabla de la base de datos</param>
        /// <param name="cmb">ComboBox que almacena el campo "Nombre"</param>
        /// <param name="tableName">Nombre de la tabla</param>
        /// <param name="cmbId">ComboBox que almacena los IDs</param>
        private void fillCombo(String DBReference, cbxSigma cmb, String tableName, ComboBox cmbId)
        {

            AddEditDrugsHelper addEdDrugs = new AddEditDrugsHelper();

            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            string query = "SELECT id, " + tableName + " FROM " + DBReference;

            DataSet ds = db.PortarPerConsulta(query);

            DataTable dt = ds.Tables[0];

            addEdDrugs.AddComboBoxData(dt, cmb, cmbId);
            
        }

        /// <summary>
        /// Edita un medicamento de la base de datos.
        /// </summary>
        /// <param name="Controls">Colección de controles para poner los campos correspondientes a la ID del medicamento</param>
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

                            if (cntrl.DBReference.Equals("Register_Number") ||
                                cntrl.DBReference.Equals("Sanitary_Register_Num") ||
                                cntrl.DBReference.Equals("ActivePrincipleID"))
                            {

                                r[cntrl.DBReference] = int.Parse(cntrl.Text);

                            }
                            else
                            {

                                r[cntrl.DBReference] = cntrl.Text;

                            }
                                
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

        /// <summary>
        /// Añade un registro nuevo a la tabla de medicamentos.
        /// </summary>
        private void AddReg()
        {

            DBUtils.DBUtilities db = new DBUtils.DBUtilities();

            db.Conexion();

            string query = "SELECT * FROM Drugs";

            dts = db.PortarPerConsulta(query);

            bool error = false;

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

                            if (ctrl.DBReference.Equals("Register_Number") ||
                                ctrl.DBReference.Equals("Sanitary_Register_Num") ||
                                ctrl.DBReference.Equals("ActivePrincipleID"))
                            {

                                dr[ctrl.DBReference] = int.Parse(ctrl.Text);

                            }
                            else if (ctrl.DBReference.Equals("Price"))
                            {

                                dr[ctrl.DBReference] = double.Parse(ctrl.Text);

                            }
                            else
                            {

                                dr[ctrl.DBReference] = ctrl.Text;

                            }

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
                            {

                                dr["LabId"] =
                                    int.Parse(cmbLabId.Items[cmbPharmaceuticLab.SelectedIndex - 1].ToString());
                                
                            }
                            else if (ctrl.DBReference.Equals("IVA"))
                            {

                                dr["IVAId"] = int.Parse(cmbIVAId.Items[cmbIVA.SelectedIndex - 1].ToString());
                                
                            }
                            
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
                        {

                            dr[cntrl.DBReference] = 1;

                        }
                        else
                        {

                            dr[cntrl.DBReference] = 0;

                        }
                        
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
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }

        }

        /// <summary>
        /// Vacía los controles del formulario.
        /// </summary>
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

        }

        /// <summary>
        /// Recoge los datos de un medicamento y rellena los campos.
        /// </summary>
        private void SearchAndFillData()
        {

            AddEditDrugsHelper DrugHelper = new AddEditDrugsHelper();

            if (!string.IsNullOrWhiteSpace(txtNRN.Text))
            {

                TxtSigma[] control = new TxtSigma[] { txtNRN };
                
                DataSet dts = DBHelper.GetQuery("Drugs", control); 

                if (dts.Tables["Taula"].Rows != null)
                {

                    DBHelper.BindingTextBox(pnlAddEditDrugs.Controls, dts);

                    DrugHelper.DataBindingComboBox(dts, Controls);

                }

            }

        }

        /// <summary>
        /// Llama al metodo SearchAndFillData cuando le decimos la id de un medicamento.
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void NRN_Leave(object sender, EventArgs e)
        {

            SearchAndFillData();

        }

        /// <summary>
        /// Controla que solo se puedan introducir números y letras.
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumento del evento</param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {

                e.Handled = true;

            }

            if ((e.KeyChar == ',') && ((sender as TxtSigma).Text.IndexOf(',') > -1))
            {

                e.Handled = true;

            }

        }

    }

}
