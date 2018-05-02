using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;
using DBUtils;

namespace Manteniment
{
    public partial class frmManteinStock : Form
    {
        DBUtilities db = new DBUtilities();
        DataSet dts = new DataSet();
        DataRow r;
        public frmManteinStock()
        {
            InitializeComponent();
            GetData(cbxLab);
            GetData(cbxMed);
            GetData(cbxMedId);
            GetData(cbxSigma1);
            dts = db.PortarPerConsulta("SELECT * FROM Stock");
        }

        private void cbxMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is cbxSigma)
            {
                cbxSigma cbx = sender as cbxSigma;
                changeBindCbx(cbx.ForeginData, cbx.SelectedIndex);
                if (cbx.Name == "cbxMed")
                {
                    modifyControls();
                }
            }
        }

        private void changeBindCbx(string cbxReference, int newIndex)
        {
            foreach (Control item in Controls)
            {
                if (item is cbxSigma)
                {
                    cbxSigma cbx = item as cbxSigma;
                    if (cbx.DBReference == cbxReference)
                    {
                        cbx.SelectedIndex = newIndex;
                    }
                }
            }
        }
        private void GetData(cbxSigma cbx)
        {
            dts = db.PortarPerConsulta("SELECT " + cbx.DBReference + " FROM " + cbx.ForeginTable);
            BindDataToCombobox(cbx);
        }
        private void BindDataToCombobox(cbxSigma cbx)
        {
            foreach (DataRow r in dts.Tables["Taula"].Rows)
            {
                cbx.Items.Add(r[0]);
            }
        }
        private void modifyControls()
        {
            try
            {
                r = db.PortarPerConsulta("SELECT * FROM Stock WHERE ID_Drug = " + cbxMedId.SelectedItem).Tables[0].Rows[0];
                cbxSigma1.SelectedIndex = cbxSigma1.FindStringExact(r["id_lab"].ToString());
                cbxLab.SelectedIndex = cbxSigma1.SelectedIndex;
                tbxCant.Text = r["Quantity"].ToString();
            } catch
            {
                tbxCant.Text = "0";
                cbxLab.SelectedIndex = -1;
                cbxSigma1.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow searchStock = db.PortarPerConsulta("SELECT * FROM Stock WHERE ID_Drug = " + cbxMedId.SelectedItem).Tables[0].Rows[0];

                foreach (DataRow row in dts.Tables[0].Rows)
                {
                    if (row["ID_Drug"].ToString() == cbxMedId.SelectedItem.ToString())
                    {
                        row["ID_Drug"] = r["ID_Drug"];
                        row["Id_lab"] = cbxSigma1.SelectedItem;
                        row["Quantity"] = int.Parse(tbxCant.Text);
                    }
                }

            } catch
            {
                try
                {
                    DataRow newRow = dts.Tables[0].NewRow();
                    newRow["ID_Drug"] = cbxMedId.SelectedItem;
                    newRow["Id_lab"] = cbxSigma1.SelectedItem;
                    newRow["Quantity"] = int.Parse(tbxCant.Text);

                    dts.Tables[0].Rows.Add(newRow);

                }
                catch {
                    MessageBox.Show("Asegurese de que los campos estén rellenados e inténtelo de nuevo", "Error");
                }
            }
            db.Actualizar("SELECT * FROM Stock", "Taula", dts);
        }
    }
}
