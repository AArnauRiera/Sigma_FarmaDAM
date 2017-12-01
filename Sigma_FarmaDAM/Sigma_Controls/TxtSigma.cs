﻿using System;
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

        #region public variables

        public enum FieldTypes
        {
            Name,
            LastName,
            Email,
            Phone,
            Password,
            Date
        }

        #endregion

        #region private variables

        private FieldTypes _fieldType;

        private string _dBReference;

        #endregion


        #region Properties

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
                    regularExpresion = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"; // The conditions are string must be between 8 and 15 characters long. string must contain at least one number. string must contain at least one uppercase letter. string must contain at least one lowercase letter.
                    break;
                case FieldTypes.Date:
                    regularExpresion = @"([0][1-9]|[1][0-9|][2][0-9]|[3][0-1])\/([0][1-9]|[1][0-2])\/[1-2][0-9][0-9][0-9]";
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


        protected override void OnGotFocus(EventArgs e)
        {

            base.OnGotFocus(e);

            // Logic onFocus
            BackColor = GetFocusColor();

        }

        private Color GetFocusColor()
        {

            Color color = new Color();

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
            }

            return color;

        }


    }

}
