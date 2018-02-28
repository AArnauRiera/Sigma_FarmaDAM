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
            form.Location = new Point(this.ClientSize.Width / 2 - form.Size.Width / 2, this.ClientSize.Height / 2 - form.Size.Height / 2);
            form.Anchor = AnchorStyles.None;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CentredForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CentredForm";
            this.ResumeLayout(false);

            this.BackgroundImage = Image.FromFile("logoSigma2.png");

        }
    }

}
