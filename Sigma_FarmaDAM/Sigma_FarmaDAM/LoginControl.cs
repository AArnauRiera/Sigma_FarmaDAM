using System;
using System.Windows.Forms;
using DBUtils;
using System.Data;
using Sigma_Controls;

namespace LoginControl
{
    class LoginControl
    {
        DBUtilities db = new DBUtilities();
        DataSet dts = new DataSet();
        string query;

        public LoginControl(string userName)
        {
            query = "SELECT * FROM Seller WHERE username = '" + userName + "'";

            try
            {
                db.Conexion();
                dts = db.PortarPerConsulta(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public LoginControl()
        {

        }

        public bool CheckUserIsReal (TxtSigma userName, Label lblError, string errorMessage)
        {
            bool isReal = false;

            if (!String.IsNullOrEmpty(userName.Text))
            {
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0 && userName.Text == dts.Tables[0].Rows[0][userName.DBReference].ToString())
                {
                    isReal = true;
                }
                else
                {
                    lblError.Text = errorMessage + " ya existe";
                }
            } else
            {
                lblError.Text = errorMessage + " no puede dejarse vacío";
            }            

            return isReal;
        }

        public bool CheckCredentials (TxtSigma userName, TxtSigma password, Label lblError)
        {
            bool isCorrect = false;

            if (dts.Tables[0].Rows.Count > 0 && 
                userName.Text == dts.Tables[0].Rows[0][userName.DBReference].ToString() && 
                Cryptography.Cryptography.Encrypt(password.Text, userName.Text) == dts.Tables[0].Rows[0][password.DBReference].ToString())
            {
                isCorrect = true;
            }

            if (!isCorrect)
            {
                lblError.Text = "Contraseña incorrecta";
            }

            return isCorrect;
        }
        public bool CheckIfUserIsAdmin (TxtSigma userName, Label lblError)
        {
            bool isAdmin = false;

            if (dts.Tables[0].Rows[0]["rol"].Equals(true))
            {
                isAdmin = true;
            }
            if (!isAdmin)
            {
                lblError.Text = "El usuario debe ser administrador";
            }

            return isAdmin;
        }
        public bool CheckIfPasswordRepeatIsEqual (TxtSigma password, TxtSigma repeatPassword, TxtSigma username, Label lblError)
        {
            bool isEqual = false;
            string encryptedPassword = Cryptography.Cryptography.Encrypt(password.Text, username.Text);
            string encryptedRepeatPassword = Cryptography.Cryptography.Encrypt(repeatPassword.Text, username.Text);

            if (password.IsFieldCorrect())
            {
                if(encryptedPassword.Equals(encryptedRepeatPassword))
                {
                    isEqual = true;
                }
                else
                {
                    lblError.Text = "Las contraseñas deben ser iguales";
                }
            }
            else
            {
                lblError.Text = "La contraseña no es correcta";
            }

            return isEqual;
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

        public bool SaveChanges(Control.ControlCollection Controls)
        {
            DBUtilities db = new DBUtilities();
            DataSet dts;
            DataRow r;
            TxtSigma userName = (TxtSigma)Controls.Find("tbxUsername", false)[0];

            Label lblErrorText = (Label)Controls.Find("lblError", false)[0];

            bool errorMessage = false;
            bool correct = false;
            string query = "SELECT * FROM Seller WHERE username='" + userName.Text + "'";
            lblErrorText.Text = "";

            try
            {
                if (!CheckControlsFormat(Controls))
                {
                    dts = db.PortarPerConsulta(query);
                    r = dts.Tables[0].NewRow();
                    r = CreateDataRowFromControls(r, Controls);
                    dts.Tables["Taula"].Rows.Add(r);
                    correct = db.Actualizar(query, "Taula", dts);
                    lblErrorText.Text = "";
                }
                else
                {
                    errorMessage = true;
                }

                if (errorMessage)
                {
                    lblErrorText.Text = "Algun campo es incorrecto";
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return correct;
        }
    }
}
