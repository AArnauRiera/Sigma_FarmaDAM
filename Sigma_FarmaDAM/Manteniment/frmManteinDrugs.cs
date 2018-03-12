using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;

namespace Manteniment
{
    public partial class frmManteinDrugs : frmManteinBase
    {
        public frmManteinDrugs()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryDrugs query = new frmQueryDrugs(this, "Drugs");
            query.Show();
        }

        private void txtDocumentation_TextChanged(object sender, EventArgs e)
        {
            Navigate(txtDocumentation.Text);
        }

        private void Navigate(string address)
        {

            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }

        }
    }
}
