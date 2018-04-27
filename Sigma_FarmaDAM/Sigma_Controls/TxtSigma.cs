using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigma_Controls
{
    public class TxtSigma : TextBox
    {

        public TxtSigma() : base ()
        {            

        }

        #region public variables


        public enum FieldTypes
        {
            None,
            RN_Drugs,
            RN_AP,
            Number,
            Double,
            IVAid,
            Price,
            CIF,
            NSS,
            DNI,
            Name,
            LastName,   
            Email,
            Phone,
            Password,
            Date,
            MedRegNum,
            MedRegName,
            MedRegContent

        }

        #endregion

        #region private variables

        private FieldTypes _fieldType;

        private string _table;

        private string _dBReference;

        private bool _isForeginKey = false;


        #endregion
        

        #region Properties

        public string Table
        {
            get { return _table; }
            set { _table = value; }
        }

        public string DBReference
        {
            get { return _dBReference; }
            set { _dBReference = value; }
        }

        public FieldTypes FieldType
        {
            get { return _fieldType; }
            set { _fieldType = value; }
        }
        public bool IsForeginKey
        {
            get { return _isForeginKey; }
            set { _isForeginKey = value; }
        }

        #endregion


        public void ExecuteOnExit()
        {
            OnLeave(EventArgs.Empty);
        }

        /// <summary>
        /// Regular expresion.
        /// </summary>
        /// <returns>Regular expresion</returns>
        private string GerRegularExpresion()
        {
            string regularExpresion;

            switch (_fieldType)
            {
                case FieldTypes.RN_Drugs:
                    regularExpresion = @"^\d{6}";
                    break;
                case FieldTypes.Number:
                    regularExpresion = @"^\d{1,}";
                    break;
                case FieldTypes.Double:
                    regularExpresion = @"^(\d{1,})(.|,)(\d{1,})";
                    break;
                case FieldTypes.CIF:
                    regularExpresion = @"^[A-Z]\d{9}";
                    break;
                case FieldTypes.RN_AP:
                    regularExpresion = @"^\d{1,}[A-Z]{1,}";
                    break;
                case FieldTypes.DNI:
                    regularExpresion = @"^[0-9]{8,8}[A-Z]$";
                    break;
                case FieldTypes.NSS:
                    regularExpresion = @"[A-Z]{4}\d{10}";
                    break;
                case FieldTypes.Name:
                    regularExpresion = @"[a-zA-Z]{1,15}$";
                    break;
                case FieldTypes.LastName:
                    regularExpresion = @"[a-zA-Z]{1,15}$";
                    break;

                case FieldTypes.Email:
                    regularExpresion = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                    break;
                case FieldTypes.Phone:
                    regularExpresion = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
                    break;
                case FieldTypes.Password:
                    regularExpresion = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,15}$"; // The conditions are string must be between 8 and 15 characters long. string must contain at least one number. string must contain at least one uppercase letter. string must contain at least one lowercase letter.
                    break;
                case FieldTypes.Date:
                    regularExpresion = @"([0][1-9]|[1][0-9|][2][0-9]|[3][0-1])\/([0][1-9]|[1][0-2])\/[1-2][0-9][0-9][0-9]";
                    break;
                case FieldTypes.MedRegNum:
                    regularExpresion = @"^[0-9]{1,5}$";
                    break;
                case FieldTypes.MedRegName:
                    regularExpresion = @"^[a-zA-Z0-9]{1,100}$";
                    break;
                case FieldTypes.MedRegContent:
                    regularExpresion = @"^[a-zA-Z0-9]{0,100}$";
                    break;
                default:
                    regularExpresion = "";
                    break;
            }

            return regularExpresion;
        }

        /// <summary>
        /// Check Field is correct
        /// </summary>
        /// <returns>Correct.</returns>
        public bool IsFieldCorrect()
        {

            Regex regex = new Regex(GerRegularExpresion());

            Match match = regex.Match(Text);

            return match.Success;

        }


        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            BackColor = Color.White;

        }

        protected override void OnGotFocus(EventArgs e)
        {

            base.OnGotFocus(e);

            // Logic onFocus
            if (IsPassword())
            {
                PasswordChar = '*';
            }

            BackColor = GetFocusColor();
        }

        private bool IsPassword()
        {

            bool ispassword = false;

            if (_fieldType == FieldTypes.Password)
            {
                ispassword = true;
            }

            return ispassword;

        }

        private Color GetFocusColor()
        {

            Color color = new Color();

            color = Color.LightBlue;
            /*
            switch (_fieldType)
            {
                case FieldTypes.Name:
                    color = Color.Red;
                    break;
                case FieldTypes.LastName:
                    color = Color.Blue;
                    break;
                case FieldTypes.Email:
                    color = Color.Green;
                    break;
                case FieldTypes.Phone:
                    color = Color.Yellow;
                    break;
                case FieldTypes.Password:
                    color = Color.Orange;
                    break;
                case FieldTypes.Date:
                    color = Color.Purple;
                    break;
                default:
                    color = Color.Pink;
                    break;
            }*/

            return color;

        }


    }

}
