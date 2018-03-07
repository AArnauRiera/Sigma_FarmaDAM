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

            _isPlaceholder = true;
            LostFocus += SetPlaceHolder;
            GotFocus += RemovePlaceHolder; 
        }

        #region public variables


        public enum FieldTypes
        {
            None,
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

        private bool _isPlaceholder;

        private bool _disablePaceholder = true;

        public bool DisablePaceholder
        {
            get { return _disablePaceholder; }
            set { _disablePaceholder = value; }
        }


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

        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set
            {
                _placeholder = value;

                if (!_disablePaceholder)
                {
                    Text = Placeholder;
                    ForeColor = Color.Gray;
                    Font = new Font(Font, FontStyle.Italic);
                }

            }
        }

        #endregion


        /// <summary>
        /// Regular expresion.
        /// </summary>
        /// <returns>Regular expresion</returns>
        private string GerRegularExpresion()
        {
            string regularExpresion;

            switch (_fieldType)
            {

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

            BackColor = DefaultBackColor;

        }

        private void SetPlaceHolder()
        {
            if (!_disablePaceholder)
            {
                if (String.IsNullOrWhiteSpace(Text))
                {
                    Text = Placeholder;
                    ForeColor = Color.Gray;
                    Font = new Font(Font, FontStyle.Italic);
                    _isPlaceholder = true;
                }
                else
                {
                    _isPlaceholder = false;
                }
            }
        }


        public void SetText()
        {
            _isPlaceholder = false;
            ForeColor = SystemColors.WindowText;
            Font = new Font(Font, FontStyle.Regular);
        }

        private void RemovePlaceHolder()
        {
            if (!_disablePaceholder)
            {
                if (_isPlaceholder)
                {
                    Text = "";
                    ForeColor = SystemColors.WindowText;
                    Font = new Font(Font, FontStyle.Regular);
                }
            }
        }

        private void SetPlaceHolder(object sender, EventArgs e)
        {
            SetPlaceHolder();
        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            RemovePlaceHolder();
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
