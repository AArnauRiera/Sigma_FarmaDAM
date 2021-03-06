﻿using System;
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
    public partial class frmManteinBase : CentredForm
    {
        protected DataSet dts;

        protected string query;

        /// <summary>
        /// Tabla de mantenimiento.
        /// </summary>
        public string Table { get; set; }

        public frmManteinBase()
        {
            InitializeComponent();
            dts = new DataSet();            
        }
        
        /// <summary>
        /// Relaciona el DataSet con los textBox.
        /// </summary>
        protected void BindingDate()
        {
            dgwBase.DataSource = dts.Tables["Taula"];

            foreach (Control control in pnlTextBox.Controls)
            {
                if (control is TxtSigma)
                {
                    TxtSigma txt = control as TxtSigma;
                    txt.DataBindings.Clear();
                }
                else if (control is cbxSigma)
                {
                    cbxSigma cbx = control as cbxSigma;
                    cbx.Items.Clear();
                    cbx.DataBindings.Clear();
                }
            }
            foreach (Control control in pnlTextBox.Controls)
            {
                if (control is TxtSigma)
                {
                    TxtSigma txt = control as TxtSigma;
                    txt.DataBindings.Add(new Binding("Text", dgwBase.DataSource, txt.DBReference, true));
                }
                if (control is cbxSigma)
                {
                    DBUtilities db = new DBUtilities();
                    DataSet newdts = new DataSet();
                    cbxSigma cbx = control as cbxSigma;
                    newdts = db.PortarPerConsulta("SELECT * FROM " + cbx.ForeginTable);

                    cbx.Items.Add("Selecciona...");
                    foreach (DataRow row in newdts.Tables[0].Rows)
                    {
                        cbx.Items.Add(row[cbx.ForeginData].ToString());
                    }
                    //dgwBase.Columns[cbx.DBReference].Visible = false;
                    cbx.DataBindings.Add(new Binding("IndexDB", dgwBase.DataSource, cbx.DBReference, true));
                }
            }                  
        }

        /// <summary>
        /// Recoge el DataSet de la base de datos.
        /// </summary>
        protected void GetQuery()
        {
            DBUtilities db = new DBUtilities();
            query = "select * from " + Table;
            dts = db.PortarPerConsulta(query);

            try
            {
                TxtSigma cell = null;
                bool find = true;
                for(int i = pnlTextBox.Controls.Count - 1; i >= 0 && find; i--)
                {
                    if(pnlTextBox.Controls[i] is TxtSigma)
                    {
                        cell = pnlTextBox.Controls[i] as TxtSigma;
                        find = false;
                    }
                }
                dgwBase.CurrentCell = dgwBase.Rows[0].Cells[cell.DBReference];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// Refresca el DataSet para cuando se hace una busqueda.
        /// </summary>
        /// <param name="newQuery">Nueva Query.</param>
        public void RefreshQuery(string newQuery)
        {
            query = newQuery;
            DBUtilities db = new DBUtilities();
            dts = db.PortarPerConsulta(query);
            BindingDate();
            DisableColumns();
        }

        /// <summary>
        /// Actualiza el DataSet.
        /// </summary>
        protected void UpdateQuery()
        {
            try
            {
                TxtSigma cell = null;

                bool find = true;

                for(int i = pnlTextBox.Controls.Count - 1; i >= 0 && find; i--)
                {

                    if(pnlTextBox.Controls[i] is TxtSigma)
                    {
                        cell = pnlTextBox.Controls[i] as TxtSigma;
                        find = false;
                    }

                }

                Random r = new Random();
                int count = dgwBase.Rows.Count - 2;
                int index = 0;
               index = r.Next(count);
                dgwBase.CurrentCell = dgwBase.Rows[index].Cells[cell.DBReference];

                DBUtilities db = new DBUtilities();
            db.Actualizar(query, "Taula", dts);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateQuery();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            //Open new queryTab
            OpenQuery();
        }

        /// <summary>
        /// Abre la ventana de busqueda.
        /// </summary>
        protected virtual void OpenQuery()
        {

        }

        private void btnGet_Click_1(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
            DisableColumns();
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            OpenQuery();
        }

        /// <summary>
        /// Selecciona la ultima row ya que esta esta vacia y asi es como añadir una nueva row.
        /// </summary>
        public virtual void AddNewRow()
        {

            if (dts == null)
            {
                GetQuery();

                BindingDate();
            }

            DataRow row = dts.Tables["Taula"].NewRow();

            dts.Tables["Taula"].Rows.Add(row);

            TxtSigma cell = null;

            bool find = true;

            for(int i = pnlTextBox.Controls.Count - 1; i >= 0 && find; i--)
            {

                if(pnlTextBox.Controls[i] is TxtSigma)
                {
                    cell = pnlTextBox.Controls[i] as TxtSigma;
                    find = false;
                }

            }

            dgwBase.CurrentCell = dgwBase.Rows[dgwBase.Rows.Count - 2].Cells[cell.DBReference];
        }

        public void resetCombobox()
        {
            foreach (Control item in pnlTextBox.Controls)
            {
                if (item is cbxSigma)
                {
                    cbxSigma cbx = item as cbxSigma;
                    cbx.SelectedIndex = 0;
                }
            }
        }

        public virtual void bntNew_Click(object sender, EventArgs e)
        {
            AddNewRow();
            resetCombobox();
        }

        /*
        public virtual void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateQuery();
        }
        */

        private void frmManteinBase_Load(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
            DisableColumns();
        }

        /// <summary>
        /// Desactiva las columnas que no se quieren modificar.
        /// </summary>
        public void DisableColumns()
        {
            for (int i = 0; i < dgwBase.Columns.Count; i++)
            {
                dgwBase.Columns[i].Visible = false;
            }
            for (int i = 0; i < dgwBase.Columns.Count; i++)
            {
                for (int q = pnlTextBox.Controls.Count - 1; q >= 0; q--)
                {
                    if (pnlTextBox.Controls[q] is TxtSigma)
                    {
                        TxtSigma t = pnlTextBox.Controls[q] as TxtSigma;
                        if (!String.IsNullOrWhiteSpace(t.DBReference))
                        {
                            if (dgwBase.Columns[i].Name.Equals(t.DBReference) && !t.IsForeginKey)
                            {
                                dgwBase.Columns[i].Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteRows();
        }

        /// <summary>
        /// Elminina las columnas seleccionadas
        /// </summary>
        protected virtual void DeleteRows()
        {
            try
            {
                for(int i = dgwBase.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dgwBase.Rows.Remove(dgwBase.SelectedRows[i]);
                }
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
