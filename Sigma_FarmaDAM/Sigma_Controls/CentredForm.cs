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
    public class CentredForm : Form
    {

        #region public variables

        #endregion

        #region private variables

        #endregion

        #region Properties

        #endregion

        protected virtual void CenterPanel(Panel form)
        {
            form.Location = new Point(0 - form.Size.Width/10, ClientSize.Height / 2 - form.Size.Height / 2);
            form.Anchor = AnchorStyles.None;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // CentredForm
            // 
            ClientSize = new System.Drawing.Size(282, 253);
            Name = "CentredForm";
            ResumeLayout(false);

        }
    }

}
