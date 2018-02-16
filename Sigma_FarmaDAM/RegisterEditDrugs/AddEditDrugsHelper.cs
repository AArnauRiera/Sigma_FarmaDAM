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
                    //comboBox.Items.Add(r.ItemArray[0].ToString());

                    ////////////////////////////////////////////////////////
                    System.Windows.Controls.ComboBoxItem item = new System.Windows.Controls.ComboBoxItem();

                    int item_index = int.Parse(r.ItemArray[0].ToString());
                    String content = r.ItemArray[1].ToString();

                    item.Tag = r.ItemArray[0];
                    item.Content = r.ItemArray[1];

                    cmbId.Items.Add(r.ItemArray[0].ToString());

                    comboBox.Items.Add(r.ItemArray[1].ToString());

                    //MessageBox.Show(content);
                    //MessageBox.Show(item_index.ToString());

                    //int index = comboBox.FindString(textBox2.Text);
                    //comboBox.SelectedIndex = index;
                    //comboBox.Items.Insert(item_index, r.ItemArray[0]);
                    //comboBox.Items.Add(item);
                    ////////////////////////////////////////////////////////

                }
            }

        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
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
