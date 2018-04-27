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
    public class cbxSigma : ComboBox
    {
        private string _DBReference;
        private string _ForeginData;
        private string _ForeginTable;
        private string _ForeginValue;

        public string DBReference
        {
            get { return _DBReference; }
            set { _DBReference = value; }
        }
        public string ForeginTable
        {
            get { return _ForeginTable; }
            set { _ForeginTable = value; }
        }
        public string ForeginData
        {
            get { return _ForeginData; }
            set { _ForeginData = value; }
        }
        public string ForeginValue
        {
            get { return _ForeginValue; }
            set { _ForeginValue = value; }
        }
    }
}
