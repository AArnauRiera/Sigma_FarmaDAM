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

            if (dts.Tables[0].Rows.Count > 0 && userName.Text == dts.Tables[0].Rows[0][userName.DBReference].ToString())
            {
                isReal = true;
            }
            
            if (!isReal)
            {
                lblError.Text = errorMessage + " ya existe";
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
    }
}
