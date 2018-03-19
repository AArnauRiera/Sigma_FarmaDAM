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
        /// <summary>
        /// Controla el formato del control segun su tipo, si el control es para repetir una contraseña comprueba que esta sea igual al campo de password. Si el control es un combobox comprueba que no tenga seleccionado el primer campo
        /// </summary>
        /// <param name="error">ErrorProvider donde se lanzaran los errores</param>
        /// <param name="control">Control a revisar</param>
        /// <param name="password">Textbox con la contraseña</param>
        /// <param name="username">Textbox con el usuario</param>
        /// <returns></returns>
        public static bool CheckControlsErrors(ErrorProvider error, Control control, TxtSigma password, TxtSigma username)
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

        /// <summary>
        /// Comprueba que el control tenga el formato correcto segun su tipo, si el control es un combobox comprueba que este no tenga la primera opcion seleccionada
        /// </summary>
        /// <param name="error">ErrorProvider donde se lanzaran los errores</param>
        /// <param name="control">Control que hay que revisar</param>
        /// <returns></returns>
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

        public static bool CheckControlsErrors(ErrorProvider error, Control control, bool empty)
        {
            var isCorrect = true;

            if (control is TxtSigma)
            {
                TxtSigma cntrl = (TxtSigma)control;

                if (!cntrl.IsFieldCorrect() && cntrl.Text != "")
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

        /// <summary>
        /// Comprueba que los campos de password y repeatPassword sean correctos y iguales
        /// </summary>
        /// <param name="password">control donde se introduce la contraseña</param>
        /// <param name="repeatPassword">control donde hay que repetir la contraseña</param>
        /// <param name="username">textBox con el campo que se usa para encryptar y desencryptar contraseñas</param>
        /// <returns></returns>
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
