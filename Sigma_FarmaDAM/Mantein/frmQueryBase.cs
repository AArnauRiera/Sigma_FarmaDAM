using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtils;
using Sigma_Controls;

namespace Mantein
{
    public partial class frmQueryBase : Form
    {

        protected DataSet dts;
        protected string query;
        protected frmManteinBase _frm;


        public string Table { get; set; }

        public frmQueryBase(frmManteinBase frm, string table)
        {
            InitializeComponent();
            _frm = frm;
            Table = table;

        }

        public frmQueryBase()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Relaciona el dataSet con el DataGridView.
        /// </summary>
        protected void BindingDate()
        {
            dgwDB.DataSource = dts.Tables["Taula"];
        }

        /// <summary>
        /// Rellena el DataSet.
        /// </summary>
        protected void GetQuery()
        {
            DBUtilities db = new DBUtilities();

            string conditions = Conditions();

            query = "select * from " + Table;

            if (!String.IsNullOrWhiteSpace(conditions))
            {
                query = query + " where " + conditions;
            }

            dts = db.PortarPerConsulta(query);
        }

        /// <summary>
        /// Une las columnas.
        /// </summary>
        /// <returns>cosulta personalizada.</returns>
        protected string Conditions()
        {
            string[] txts = GetAllTxtSigma();
            string delimeter = " and ";
            string con = string.Join(delimeter,txts);
            return con;
        }


        /// <summary>
        /// Recoge todos los txtSigma del control.
        /// </summary>
        /// <returns>Consulta personalizada.</returns>
        protected string[] GetAllTxtSigma()
        {
            List<string> txtb = new List<string>();
            foreach (var txt in pnlTB.Controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma t = (TxtSigma)txt;
                    if (!String.IsNullOrWhiteSpace(t.Text))
                    {
                        txtb.Add(t.DBReference + " = '" + t.Text + "'");
                    }
                }
            }
            return txtb.ToArray();
        }

        /// <summary>
        /// Recoge la información de la base de datos para hacer la consulta.
        /// </summary>
        /// <returns>Conjunto de columnas de la base de datos.</returns>
        public string GetColumns()
        {
            string columns = "*";

            List<string> col = new List<string>();

            for (int i = pnlTB.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlTB.Controls[i] is TxtSigma)
                {
                    TxtSigma t = pnlTB.Controls[i] as TxtSigma;

                    if (!String.IsNullOrWhiteSpace(t.DBReference))
                    {
                        col.Add(t.DBReference);
                    }
                }
            }

            columns = string.Join(",", col);

            return columns;
        }

        protected virtual void btnSelect_Click(object sender, EventArgs e)
        {
            SelectRows();
        }

        /// <summary>
        /// Selecciona las filas y las manda al forms de mantenimiento.
        /// </summary>
        protected void SelectRows()
        {
            if(dgwDB.SelectedRows.Count > 0)
            {
                DataSet ds = null;

                string selected = "";

                List<string> conditions = new List<string>();

                for(int i = 0; i < dgwDB.SelectedRows.Count; i++)
                {
                    //for(int q = 0; q < dgwDB.SelectedRows[i].Cells.Count; q++)
                    //{
                    //    conditions.Add(dgwDB.SelectedRows[i].Cells[q].OwningColumn.Name + " = " + "'" + dgwDB.SelectedRows[i].Cells[q].FormattedValue.ToString() + "'");
                    //}
                    conditions.Add(dgwDB.SelectedRows[i].Cells[0].OwningColumn.Name + " = " + "'" + dgwDB.SelectedRows[i].Cells[0].FormattedValue.ToString() + "'");

                }

                selected = "select * from " + Table + " where " + string.Join(" or ", conditions);

                _frm.RefreshQuery(selected);

                this.Close();
            }
        }

        /// <summary>
        /// Desactiva las columnas que no se quieren mostrar.
        /// </summary>
        public void DisableColumns()
        {
            for (int i = 0; i < dgwDB.Columns.Count; i++)
            {
                dgwDB.Columns[i].Visible = false;
            }
            for (int i = 0; i < dgwDB.Columns.Count; i++)
            {
                for (int q = pnlTB.Controls.Count - 1; q >= 0; q--)
                {
                    if (pnlTB.Controls[q] is TxtSigma)
                    {
                        TxtSigma t = pnlTB.Controls[q] as TxtSigma;
                        if (!String.IsNullOrWhiteSpace(t.DBReference))
                        {
                            if (dgwDB.Columns[i].Name.Equals(t.DBReference))
                            {
                                dgwDB.Columns[i].Visible = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
