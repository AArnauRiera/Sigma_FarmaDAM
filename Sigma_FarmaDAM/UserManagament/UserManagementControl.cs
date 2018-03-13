using System;
using DBUtils;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;
using Helpers;

namespace UserManagament
{
    class UserManagementControl
    {
        private DataSet dts = new DataSet();
        public UserManagementControl()
        {
        }

        public DataTable SearchTableFromQuery (string query)
        {
            DBUtilities db = new DBUtilities();
            try
            {
                db.Conexion();
                dts = db.PortarPerConsulta(query);
                DataTable t = dts.Tables["Taula"];
                if (t.Rows.Count == 0)
                {
                    return null;
                }
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        private void DataBindingComboBox(DataSet dts, Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is cbxSigma)
                {
                    cbxSigma text = (cbxSigma)control;
                    text.DataBindings.Clear();
                    foreach (DataColumn c in dts.Tables["Taula"].Columns)
                    {
                        if (c.ColumnName == text.DBReference)
                        {
                            text.SelectedIndex = (int)dts.Tables["Taula"].Rows[0].ItemArray[c.Ordinal];
                        }
                    }
                }
            }
        }

        public bool CheckIfUserIsRegistered(TxtSigma NTS, TxtSigma DNI, DataSet dts)
        {
            bool isRegistered = false;

            foreach (DataRow row in dts.Tables["Taula"].Rows)
            {
                if (row[NTS.DBReference].ToString() == NTS.Text || row[DNI.DBReference].ToString() == DNI.Text)
                {
                    isRegistered = true;
                    break;
                }
            }

            return isRegistered;
        }

        public void getDataFromNtsSeach (Control.ControlCollection Controls, ErrorProvider errorProvider)
        {
            TxtSigma tbxNTS = (TxtSigma)Controls.Find("tbxNTS", false)[0];
            TxtSigma tbxDNI = (TxtSigma)Controls.Find("tbxDNI", false)[0];
            Label lblError = (Label)Controls.Find("lblError", false)[0];
            TxtSigma[] control = new TxtSigma[] { tbxNTS };

            if (ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)control[0]) && tbxNTS.Text != "NTS")
            {
                DataSet dts = DBHelper.GetQuery("Clients", control);
                if (dts.Tables["Taula"].Rows.Count != 0)
                {
                    lblError.Text = "";
                    DBHelper.BindingTextBox(Controls, dts);
                    DataBindingComboBox(dts, Controls);

                    // tbxNTS.Enabled = false;
                    // tbxDNI.Enabled = false;
                }
                else
                {
                    errorProvider.SetError((Control)control[0], "Entrada no valida para buscar");
                    tbxNTS.Focus(); // NOSE SI ESTA BE AIXO
                }
            }
            else
            {
                errorProvider.SetError((Control)control[0], "Entrada no valida para buscar");
                tbxNTS.Focus(); // AIXO TAMPOC
            }
        }

        public void AddComboBoxData(DataTable t, cbxSigma comboBox)
        {

            comboBox.Items.Add("Selecciona...");
            comboBox.SelectedIndex = 0;
            for (var i = 0; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];
                if (r.ItemArray[0] != null)
                {
                    comboBox.Items.Add(r.ItemArray[0].ToString());
                }
            }

        }

        public bool CheckControlsFormat(Control.ControlCollection Controls, ErrorProvider errorProvider)
        {
            bool error = false;
            bool pass = true;

            foreach (Control control in Controls)
            {
                error = ControlsErrorsHelper.CheckControlsErrors(errorProvider, control);
                
                if (!error)
                {
                    pass = false;
                }
            }

            return pass;
        }
        public bool CheckControlsFormat(TxtSigma[] Controls, ErrorProvider errorProvider)
        {
            bool error = false;
            bool pass = true;

            foreach (Control control in Controls)
            {
                error = ControlsErrorsHelper.CheckControlsErrors(errorProvider, control);

                if (!error)
                {
                    pass = false;
                }
            }

            return pass;
        }

        public DataRow CreateDataRowFromControls(DataRow r, Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TxtSigma)
                {
                    TxtSigma cntrl = (TxtSigma)control;
                    r[cntrl.DBReference] = cntrl.Text;

                }
                else if (control is cbxSigma)
                {
                    cbxSigma cntrl = (cbxSigma)control;
                    r[cntrl.DBReference] = cntrl.SelectedIndex;
                }
            }
            return r;
        }
        public bool CheckControlsFormat(ErrorProvider error, Control.ControlCollection Controls)
        {
            bool isCorrect = false;
            bool pass = true;

            foreach (Control control in Controls)
            {
                if (control is TxtSigma || control is cbxSigma)
                {
                    isCorrect = ControlsErrorsHelper.CheckControlsErrors(error, control);

                    if (!isCorrect)
                    {
                        pass = isCorrect;
                    }
                }
            }

            return pass;
        }

        public void SaveChanges(Control.ControlCollection Controls, bool edit, ErrorProvider errorProvider)
        {
            DBUtilities db = new DBUtilities();
            string query;
            DataSet dts;
            DataRow r;
            bool correct = false;
            bool errorMessage = false;
            TxtSigma NTS = (TxtSigma)Controls.Find("tbxNTS", false)[0];
            TxtSigma DNI = (TxtSigma)Controls.Find("tbxDNI", false)[0];
            Button button = (Button)Controls.Find("btnGuardar", false)[0];

            try
            {
                if (CheckControlsFormat(errorProvider, Controls))
                {
                    if (edit)
                    {
                        query = "SELECT * FROM Clients WHERE NTS='" + NTS.Text + "'";
                        dts = db.PortarPerConsulta(query);
                        r = dts.Tables["Taula"].Rows[0];

                    }
                    else
                    {
                        query = "SELECT * FROM Clients";
                        dts = db.PortarPerConsulta(query);

                        if (CheckIfUserIsRegistered(NTS, DNI, dts))
                        {
                            errorProvider.SetError(button, "Este cliente ya esta registrado");
                            errorMessage = true;
                        }
                        
                        r = dts.Tables["Taula"].NewRow();

                    }

                    if (!errorMessage)
                    {
                        r = CreateDataRowFromControls(r, Controls);

                        if (!edit)
                        {
                            dts.Tables["Taula"].Rows.Add(r);
                        }

                        correct = db.Actualizar(query, "Taula", dts);
                        errorProvider.SetError(NTS, "");
                    }

                }
                else
                {
                    errorMessage = true;
                }

                if (errorMessage)
                {
                    errorProvider.SetError(button, "Algun campo es incorrecto");

                } else
                {
                    errorProvider.SetError(button, "");

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
    }
}
