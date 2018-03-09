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
            GetQuery();
            BindingDate();
        }
        
        protected void BindingDate()
        {
            dgwBase.DataSource = dts.Tables["Taula"];

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
            query = "select "+ cols + " from " + Table;
            dts = db.PortarPerConsulta(query);
        }

        protected void UpdateQuery()
        {
            DBUtilities db = new DBUtilities();
            db.Actualizar(query,Table,dts);
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

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
        }

        private void btnGet_Click_1(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
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

            DataRow row = dts.Tables["Taula"].NewRow();

            dts.Tables["Taula"].Rows.Add(row);

            foreach (DataGridViewRow item in dgwBase.SelectedRows)
            {
                item.Selected = false;
            }
             
            dgwBase.Rows[dgwBase.Rows.Count - 1].Selected = true;
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }
    }
}
