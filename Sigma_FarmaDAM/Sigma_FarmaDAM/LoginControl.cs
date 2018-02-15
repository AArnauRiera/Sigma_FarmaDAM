using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography;
using DBUtils;
using System.Data;
using Sigma_Controls;

namespace LoginControl
{
    class LoginControl
    {
        DBUtilities db = new DBUtilities();
        DataSet dts = new DataSet();
        string query = "SELECT * FROM Seller";

        public LoginControl()
        {
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

        public bool CheckUserIsReal (TxtSigma userName, Label lblError)
        {
            bool isReal = false;

            foreach (DataRow r in dts.Tables["Taula"].Rows)
            {
                if (userName.Text == r[userName.DBReference].ToString())
                {
                    isReal = true;
                    break;
                }
            }
            if (!isReal)
            {
                lblError.Text = "Usuario incorrecto";
            }

            return isReal;
        }

        public bool CheckCredentials (TxtSigma userName, TxtSigma password, Label lblError)
        {
            bool isCorrect = false;

            foreach (DataRow r in dts.Tables["Taula"].Rows)
            {
                if (userName.Text == r[userName.DBReference].ToString() && Cryptography.Cryptography.Encrypt(password.Text, userName.Text) == r[password.DBReference].ToString())
                {
                    isCorrect = true;
                    break;
                }
            }

            if (!isCorrect)
            {
                lblError.Text = "Contraseña incorrecta";
            }

            return isCorrect;
        }
        
    }
}
