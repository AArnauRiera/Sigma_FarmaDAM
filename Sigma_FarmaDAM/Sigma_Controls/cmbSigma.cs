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
    public class cmbSigma : ComboBox
    {
        private string _DBReference;

        public string DBReference
        {
            get { return _DBReference; }
            set { _DBReference = value; }
        }
    }
}
