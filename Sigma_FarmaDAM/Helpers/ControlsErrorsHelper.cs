using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;

namespace Helpers
{
    public class ControlsErrorsHelper
    {
        public static bool CheckControlsErrors(ErrorProvider error, Control control, TxtSigma password, TxtSigma username)
        {
            var isCorrect = false;

            if (control is TxtSigma)
            {
                TxtSigma cntrl = (TxtSigma)control;
                if (String.IsNullOrWhiteSpace(cntrl.Text))
                {
                    error.SetError(cntrl, "Este campo no puede estar vacío");
                    isCorrect = false;
                }
                else if (cntrl.IsFieldCorrect())
                {
                    error.SetError(cntrl, "Formato incorrecto");
                    isCorrect = false;
                }
                else if (cntrl.Name == "tbxRepeatPassword" && CheckIfPasswordRepeatIsEqual(cntrl, password, username))
                {
                    error.SetError(cntrl, "Las contraseñas tienen que ser iguales");
                    isCorrect = false;
                }
            }
            else if (control is cbxSigma)
            {
                cbxSigma cntrl = (cbxSigma)control;
                if (cntrl.SelectedIndex == 0)
                {
                    error.SetError(cntrl, "No se ha seleccionado un campo valido");
                    isCorrect = false;
                }
            }

            return isCorrect;
        }

        public static bool CheckControlsErrors(ErrorProvider error, Control control)
        {
            var isCorrect = true;

            if (control is TxtSigma)
            {
                TxtSigma cntrl = (TxtSigma)control;
                if (String.IsNullOrWhiteSpace(cntrl.Text))
                {
                    error.SetError(cntrl, "Este campo no puede estar vacío");
                    isCorrect = false;
                }
                else if (!cntrl.IsFieldCorrect())
                {
                    error.SetError(cntrl, "Formato incorrecto");
                    isCorrect = false;
                }
            }
            else if (control is cbxSigma)
            {
                cbxSigma cntrl = (cbxSigma)control;
                if (cntrl.SelectedIndex == 0)
                {
                    error.SetError(cntrl, "No se ha seleccionado un campo valido");
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                error.SetError(control, "");
            }

            return isCorrect;
        }

        private static bool CheckIfPasswordRepeatIsEqual(TxtSigma password, TxtSigma repeatPassword, TxtSigma username)
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
    }
}
