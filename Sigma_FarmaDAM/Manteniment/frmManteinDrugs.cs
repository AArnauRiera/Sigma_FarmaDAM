using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SearchSystem;
using Helpers;
using DBUtils;

namespace Manteniment
{
    public partial class frmManteinDrugs : frmManteinBase
    {
        bool error;
        bool updated;



        public frmManteinDrugs()
        {
            InitializeComponent();
            cbxSigma1.FillDictionary("Active_Principles", "Name", "Id");
            cbxSigma2.FillDictionary("IVA", "value", "id");
        }

        private void fillDictionary(Dictionary<string, int> dicctionary)
        {
            DBUtilities db = new DBUtilities();
            DataSet Dict_dts = db.PortarPerConsulta("SELECT Id, Name FROM Active_Principles");

            foreach (DataRow row in Dict_dts.Tables[0].Rows)
            {
                dicctionary.Add(row["Name"].ToString(), int.Parse(row["Id"].ToString()));
            }

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
        private void checkControls()
        {
            error = false;
            foreach (Control cntrl in pnlTextBox.Controls)
            {
                cntrl.Focus();
            }
        }

        private void tbx_Leave(object sender, EventArgs e)
        {
            updated = false;
            if (!ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)sender) && !((Control)sender).Name.Equals("txtDocumentation") && !((Control)sender).Name.Equals("txtProspectus"))
            {
                error = true;
            }
        }

        public void btnUpdate_Click_1(object sender, EventArgs e)
        {
            checkControls();
            if (!error && !updated)
            {
                MessageBox.Show("Actualizado");
                base.UpdateQuery();
                updated = true;
            }
            else
            {
                MessageBox.Show("Algun campo no es correcto");
            }
        }
    }
}
