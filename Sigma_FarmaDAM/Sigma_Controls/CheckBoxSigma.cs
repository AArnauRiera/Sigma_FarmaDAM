using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigma_Controls
{
    public partial class CheckBoxSigma : Control
    {
        public CheckBoxSigma()
        {
            InitializeComponent();
        }

        private string _dBReference;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public string DBReference
        {
            get { return _dBReference; }
            set { _dBReference = value; }
        }
        
    }
}
