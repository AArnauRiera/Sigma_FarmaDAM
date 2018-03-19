using System;
using System.Windows.Forms;
using DBUtils;
using System.Data;
using Sigma_Controls;
using System.Threading.Tasks;
using Helpers;

namespace UserRegisterControl
{
    class UserRegisterControl
    {
        DBUtilities db = new DBUtilities();
        DataSet dts = new DataSet();
        string query;

        /// <summary>
        /// al inicial crea un DataSet con los datos del usuario
        /// </summary>
        /// <param name="userName">nombre del usuario</param>
        public UserRegisterControl(string userName)
        {
            query = "SELECT * FROM Seller WHERE username = '" + userName + "'";

            try
            {
                dts = db.PortarPerConsulta(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public UserRegisterControl()
        {

        }

        /// <summary>
        /// Comprueba si el dato del control no este dentro de la taba en la BBDD
        /// </summary>
        /// <param name="control">control que hay que comprobar</param>
        /// <param name="error">ErrorProvider donde se lanzaran los errores</param>
        /// <param name="taula">Tabla de la BBDD donde se buscaran similitudes</param>
        /// <returns>boolean(true=ya existe/false=no existe)</returns>
        public bool CheckIsReal (TxtSigma control, ErrorProvider error, string taula)
        {
            bool isReal = false;

            DataSet dts = db.PortarPerConsulta("SELECT * FROM " + taula + " WHERE " + control.DBReference + " = '" + control.Text + "'");

            if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0) {
                isReal = true;
            }

            if (!isReal)
            {
                error.SetError(control, "El usuario no existe");
            }

            return isReal;
        }

        /// <summary>
        /// Comprueba que los campos de password y repeatPassword sean correctos y iguales
        /// </summary>
        /// <param name="password">control donde se introduce la contraseña</param>
        /// <param name="repeatPassword">control donde hay que repetir la contraseña</param>
        /// <param name="username">textBox con el campo que se usa para encryptar y desencryptar contraseñas</param>
        /// <returns>boolean(true=las contraseñas coinciden/false=no coinciden)</returns>
        public bool CheckIfPasswordRepeatIsEqual (TxtSigma password, TxtSigma repeatPassword, TxtSigma username)
        {
            bool isEqual = false;
            string encryptedPassword = Cryptography.Cryptography.Encrypt(password.Text, username.Text);
            string encryptedRepeatPassword = Cryptography.Cryptography.Encrypt(repeatPassword.Text, username.Text);

            if (password.IsFieldCorrect())
            {
                if (encryptedPassword.Equals(encryptedRepeatPassword))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }

        /// <summary>
        /// compueba que los datos introducidos sean correctos
        /// </summary>
        /// <param name="Controls">Coleccion de controles</param>
        /// <param name="errorProvider">ErrorProvider donde se lanzaran los errores</param>
        /// <returns></returns>
        public bool CheckControlsFormat(ErrorProvider error, Control.ControlCollection Controls, TxtSigma username, TxtSigma password)
        {
            bool isCorrect = false;
            bool pass = true;

            foreach (Control control in Controls)
            {
                if (control.Name == "txbRepeatPassword")
                {
                    isCorrect = ControlsErrorsHelper.CheckControlsErrors(error, control, password, username);
                }
                else
                {
                    isCorrect = ControlsErrorsHelper.CheckControlsErrors(error, control);
                }

                if (!isCorrect)
                {
                    pass = isCorrect;
                }
            }

            return pass;
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
                    if (!String.IsNullOrWhiteSpace(cntrl.DBReference))
                    {
                        if (cntrl.DBReference == "password")
                        {
                            r[cntrl.DBReference] = Cryptography.Cryptography.Encrypt(cntrl.Text, controls.Find("tbxUsername", false)[0].Text);
                        }
                        else
                        {
                            r[cntrl.DBReference] = cntrl.Text;
                        }
                    }
                }
                else if (control is CheckBoxSigma)
                {
                    CheckBoxSigma cntrl = (CheckBoxSigma)control;
                    r[cntrl.DBReference] = cntrl.Enabled;
                }
            }
            return r;
        }


        /// <summary>
        /// Actualiza la BBDD con el nuevo usuario
        /// </summary>
        /// <param name="Controls">coleccion de controles donde conseguir los datos</param>
        /// <param name="edit">boolean que informa si se esta editando</param>
        /// <param name="errorProvider">ErrorProvider donde lanzar los errores</param>
        public bool SaveChanges(Control.ControlCollection Controls)
        {
            DBUtilities db = new DBUtilities();
            DataSet dts;
            DataRow r;
            TxtSigma userName = (TxtSigma)Controls.Find("tbxUsername", false)[0];

            bool correct = false;
            string query = "SELECT * FROM Seller WHERE username='" + userName.Text + "'";

            try
            {
                dts = db.PortarPerConsulta(query);
                r = dts.Tables[0].NewRow();
                r = CreateDataRowFromControls(r, Controls);
                dts.Tables["Taula"].Rows.Add(r);
                correct = db.Actualizar(query, "Taula", dts);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return correct;
        }
    }
}
