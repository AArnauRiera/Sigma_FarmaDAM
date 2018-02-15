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

        public void getDataFromNtsSeach (Control.ControlCollection Controls)
        {
            TxtSigma tbxNTS = (TxtSigma)Controls.Find("tbxNTS", false)[0];
            TxtSigma tbxDNI = (TxtSigma)Controls.Find("tbxDNI", false)[0];
            Label lblError = (Label)Controls.Find("lblError", false)[0];
            TxtSigma[] control = new TxtSigma[] { tbxNTS };

            if (!CheckControlsFormat(control) && tbxNTS.Text != "NTS")
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
                    lblError.Text = "Entry not valid for search";
                    tbxNTS.Focus(); // NOSE SI ESTA BE AIXO
                }
            }
            else
            {
                lblError.Text = "Entry not valid for search";
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

        public bool CheckControlsFormat(Control.ControlCollection Controls)
        {
            bool error = false;

            foreach (var control in Controls)
            {
                if (control is TxtSigma)
                {
                    TxtSigma cntrl = (TxtSigma)control;
                    if (!cntrl.IsFieldCorrect() || String.IsNullOrWhiteSpace(cntrl.Text))
                    {
                        error = true;
                        cntrl.Text = "";
                    }
                }
                else if (control is cbxSigma)
                {
                    cbxSigma cntrl = (cbxSigma)control;
                    if (cntrl.SelectedIndex == 0)
                    {
                        error = true;
                    }
                }
            }

            return error;
        }
        public bool CheckControlsFormat(TxtSigma[] Controls)
        {
            bool error = false;

            foreach (var control in Controls)
            {
                if (!control.IsFieldCorrect() || String.IsNullOrWhiteSpace(control.Text))
                {
                    error = true;
                    control.Text = "";
                }
                
            }

            return error;
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

        public void SaveChanges(Control.ControlCollection Controls, bool edit)
        {
            DBUtilities db = new DBUtilities();
            string query;
            DataSet dts;
            DataRow r;
            bool correct = false;
            bool errorMessage = false;
            TxtSigma NTS = (TxtSigma)Controls.Find("tbxNTS", false)[0];
            TxtSigma DNI = (TxtSigma)Controls.Find("tbxDNI", false)[0];
            Label lblErrorText = (Label)Controls.Find("lblErrorText", false)[0];
            lblErrorText.Text = "";

            try
            {
                if (!CheckControlsFormat(Controls))
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
                            lblErrorText.Text = "Este cliente ya esta registrado";
                        }
                        
                        r = dts.Tables["Taula"].NewRow();

                    }

                    if (!errorMessage && !String.IsNullOrWhiteSpace(lblErrorText.Text))
                    {
                        r = CreateDataRowFromControls(r, Controls);

                        if (!edit)
                        {
                            dts.Tables["Taula"].Rows.Add(r);
                        }

                        correct = db.Actualizar(query, "Taula", dts);
                        lblErrorText.Text = "";
                    }
                    
                }
                else
                {
                    errorMessage = true;
                }

                if (errorMessage)
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
    }
}
