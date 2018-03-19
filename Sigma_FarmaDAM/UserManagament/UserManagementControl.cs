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

        /// <summary>
        /// Genera una tabla a partir de la query pasada
        /// </summary>
        /// <param name="query">Query de busqueda</param>
        /// <returns>DataTable</returns>
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

        /// <summary>
        /// Busca un combobox dentro de la coleccíon de controles y inyecta los datos correspondientes dentro del mismo
        /// </summary>
        /// <param name="dts">DataSet con la informacion a inyectar</param>
        /// <param name="Controls">Todos los controles en el formulario o panel</param>
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

        /// <summary>
        /// Comprueba en la BBDD si el usuario esta registrado
        /// </summary>
        /// <param name="NTS"></param>
        /// <param name="DNI"></param>
        /// <param name="dts"></param>
        /// <returns>Un booleano (true=esta registrado / false=no registrado)</returns>
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

        /// <summary>
        /// comprueba que el dato en el campo de NTS sea correcto, si es asi coje los datos del usuario con ese NTS y los inyecta en el formulario
        /// </summary>
        /// <param name="Controls">Coleccion de controles</param>
        /// <param name="errorProvider">errorProvider donde se lanzaran los errores recibidos</param>
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
                    
                }
                else
                {
                    errorProvider.SetError((Control)control[0], "Entrada no valida para buscar");
                    tbxNTS.Focus();
                }
            }
            else
            {
                errorProvider.SetError((Control)control[0], "Entrada no valida para buscar");
                tbxNTS.Focus();
            }
        }

        /// <summary>
        /// inyecta los datos del DataTable en un combobox
        /// </summary>
        /// <param name="t">DataTable con los datos</param>
        /// <param name="comboBox">Combobox donde se inyectan los datos</param>
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

        /// <summary>
        /// Inyecta un dataRow con los datos de los controles
        /// </summary>
        /// <param name="r">DataRow donde inyectar los datos</param>
        /// <param name="controls">Coleccion de controles donde conseguir los datos</param>
        /// <returns></returns>
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


        /// <summary>
        /// compueba que los datos introducidos sean correctos
        /// </summary>
        /// <param name="Controls">Coleccion de controles</param>
        /// <param name="errorProvider">ErrorProvider donde se lanzaran los errores</param>
        /// <returns></returns>
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

        /// <summary>
        /// Comprueba si los datos introducidos son correctos, y actualiza la BBDD con los nuevos valores: estes añadiendo una entidad nueva o editando una existente
        /// </summary>
        /// <param name="Controls">coleccion de controles donde conseguir los datos</param>
        /// <param name="edit">boolean que informa si se esta editando</param>
        /// <param name="errorProvider">ErrorProvider donde lanzar los errores</param>
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
