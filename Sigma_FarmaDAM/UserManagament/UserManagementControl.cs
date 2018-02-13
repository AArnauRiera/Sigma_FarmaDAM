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

        private void ShowSelectData(DataSet dts, Control.ControlCollection Controls)
        {
            DBHelper.BindingTextBox(Controls, dts);

        }
        public void getDataFromNtsSeach (Control.ControlCollection Controls)
        {
            TxtSigma tbxNTS = (TxtSigma)Controls.Find("tbxNTS", false)[0];
            Label lblError = (Label)Controls.Find("lblError", false)[0];

            if (tbxNTS.Text.Length > 0 && tbxNTS.Text != "NTS")
            {
                TxtSigma[] control = new TxtSigma[] { tbxNTS };
                DataSet dts = DBHelper.GetQuery("Clients", control);
                if (dts.Tables["Taula"].Rows != null)
                {
                    lblError.Text = "";
                    ShowSelectData(dts, Controls);
                    DataBindingComboBox(dts, Controls);
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
        public void SaveChanges(Control.ControlCollection Controls)
        {
            UserManagementControl umc = new UserManagementControl();
            string query = "SELECT * FROM Clients";
            bool correct = false;
            bool saveError = false;

            try
            {
                DBUtilities db = new DBUtilities();
                DataSet dts = db.PortarPerConsulta(query);
                DataRow r = dts.Tables["Taula"].NewRow();
                Label lblErrorText = (Label)Controls.Find("lblErrorText", false)[0];

                foreach (var control in Controls)
                {
                    if (control is TxtSigma)
                    {
                        TxtSigma cntrl = (TxtSigma)control;
                        if (cntrl.IsFieldCorrect())
                        {
                            r[cntrl.DBReference] = cntrl.Text;
                        } else
                        {
                            cntrl.Text = "";
                            cntrl.Focus();
                            saveError = true;
                            break;
                        }

                    } else if (control is cbxSigma)
                    {
                        cbxSigma cntrl = (cbxSigma)control;
                        if (cntrl.SelectedIndex != 0)
                        {
                            r[cntrl.DBReference] = cntrl.SelectedIndex;
                        } else
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
                } else
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
