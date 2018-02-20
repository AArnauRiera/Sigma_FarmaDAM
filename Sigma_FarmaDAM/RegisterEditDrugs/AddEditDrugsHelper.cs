using System;
using DBUtils;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma_Controls;
using Helpers;

namespace RegisterEditDrugs
{
    class AddEditDrugsHelper
    {
        public void AddComboBoxData(DataTable t, cmbSigma comboBox, ComboBox cmbId)
        {

            comboBox.Items.Add("Selecciona...");
            comboBox.SelectedIndex = 0;
            for (var i = 0; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];
                if (r.ItemArray[0] != null && r.ItemArray[1] != null)
                {
                    cmbId.Items.Add(r.ItemArray[0].ToString());

                    comboBox.Items.Add(r.ItemArray[1].ToString());

                }
            }

        }

        public void DataBindingComboBox(DataSet dts, Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is cmbSigma)
                {
                    cmbSigma text = (cmbSigma)control;
                    text.DataBindings.Clear();
                    foreach (DataColumn c in dts.Tables["Taula"].Columns)
                    {
                        if (c.ColumnName == text.DBReference)
                        {
                            text.SelectedIndex = (int)dts.Tables["Taula"].Rows[0].ItemArray[c.Ordinal];
                        }
                    }
                }
            }
        }
    }
}
