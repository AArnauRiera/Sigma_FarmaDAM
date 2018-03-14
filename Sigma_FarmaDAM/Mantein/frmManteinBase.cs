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
    public partial class frmManteinBase : CentredForm
    {
        protected DataSet dts;

        protected string query;

        public string Table { get; set; }

        public frmManteinBase()
        {
            InitializeComponent();
            dts = new DataSet();
            CenterPanel(pnlMantein);
        }
        
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
            }

            foreach (Control control in pnlTextBox.Controls)
            {
                if (control is TxtSigma)
                {
                    TxtSigma txt = control as TxtSigma;
                    txt.DataBindings.Add(new Binding("Text", dgwBase.DataSource, txt.DBReference, true));
                }
            }                  
        }
        public string GetColumns()
        {
            string columns = "*";
            List<string> col = new List<string>();

            for (int i = pnlTextBox.Controls.Count - 1; i >= 0; i--)
            {

                if (pnlTextBox.Controls[i] is TxtSigma)
                {
                    TxtSigma t = pnlTextBox.Controls[i] as TxtSigma;
                    if (!String.IsNullOrWhiteSpace(t.DBReference))
                    {
                        col.Add(t.DBReference);
                    }
                }

            }

            columns = string.Join(",", col);

            return columns;
        }

        protected void GetQuery()
        {
            DBUtilities db = new DBUtilities();
            string cols = GetColumns();
            query = "select * from " + Table;
            dts = db.PortarPerConsulta(query);
        }

        public void RefreshQuery(string newQuery)
        {
            query = newQuery;
            DBUtilities db = new DBUtilities();
            dts = db.PortarPerConsulta(query);
            BindingDate();
            DisableColumns();
        }

        protected void UpdateQuery()
        {
            DBUtilities db = new DBUtilities();
            db.Actualizar(query, "Taula",dts);
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

        public void AddNewRow()
        {
            if (dts == null)
            {
                GetQuery();

                BindingDate();
            }

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
            dgwBase.CurrentCell = dgwBase.Rows[dgwBase.Rows.Count - 1].Cells[cell.DBReference];
        }
        public virtual void bntNew_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateQuery();
        }

        private void frmManteinBase_Load(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
            DisableColumns();
        }

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
                            if (dgwBase.Columns[i].Name.Equals(t.DBReference))
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
            for(int i = dgwBase.SelectedRows.Count - 1; i >= 0; i--)
            {
                dgwBase.Rows.Remove(dgwBase.SelectedRows[i]);                
            }
        }
    }
}
