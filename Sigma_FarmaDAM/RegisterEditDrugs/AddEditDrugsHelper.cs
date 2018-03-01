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
    /// <summary>
    /// Contiene funciones para el formulario frmAddEditDrugs.
    /// </summary>
    class AddEditDrugsHelper
    {

        /// <summary>
        /// Llena una comboBox de información de una base de datos.
        /// </summary>
        /// <param name="t">Base de datos de la que recogemos la información</param>
        /// <param name="comboBox">Almacena los registros del campo "Nombre" de la tabla</param>
        /// <param name="cmbId">Almacena IDs de la tabla</param>
        public void AddComboBoxData(DataTable t, cbxSigma comboBox, ComboBox cmbId)
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

        /// <summary>
        /// Coge los datos del DataSet y los enlaza a los comoBox del formulario.
        /// </summary>
        /// <param name="dts">DataSet para los datos</param>
        /// <param name="Controls">Lista de controles</param>
        public void DataBindingComboBox(DataSet dts, Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is cbxSigma)
                {
                    cbxSigma text = (cbxSigma)control;
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
