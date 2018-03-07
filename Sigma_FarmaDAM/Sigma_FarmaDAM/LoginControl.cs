using System;
using System.Windows.Forms;
using DBUtils;
using System.Data;
using Sigma_Controls;
using System.Threading.Tasks;
using Helpers;

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

        public bool CheckCredentials (TxtSigma userName, TxtSigma password, ErrorProvider error)
        {
            bool isCorrect = false;

            Console.WriteLine(Cryptography.Cryptography.Encrypt(password.Text, userName.Text));
            Console.WriteLine(dts.Tables[0].Rows[0]["password"].ToString());

            if (dts.Tables[0].Rows.Count > 0 && 
                userName.Text == dts.Tables[0].Rows[0][userName.DBReference].ToString() && 
                Cryptography.Cryptography.Encrypt(password.Text, userName.Text) == dts.Tables[0].Rows[0][password.DBReference].ToString())
            {
                isCorrect = true;
            }

            if (!isCorrect)
            {
                error.SetError(password, "Contraseña incorrecta");
            }

            return isCorrect;
        }

        public bool CheckIfUserIsAdmin (TxtSigma userName, ErrorProvider errorProvider)
        {
            bool isAdmin = false;

            if (dts.Tables[0].Rows[0]["rol"].Equals(true))
            {
                isAdmin = true;
            }
            if (!isAdmin)
            {
                errorProvider.SetError(userName, "El usuario debe ser administrador");
            }

            return isAdmin;
        }

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

        public bool CheckControlsFormat (ErrorProvider error, Control.ControlCollection Controls)
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
