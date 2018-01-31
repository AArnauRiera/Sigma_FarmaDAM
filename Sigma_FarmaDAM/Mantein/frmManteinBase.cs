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

namespace Mantein
{
    public partial class frmManteinBase : Form
    {
        protected DataSet dts;

        protected string query;

        public string Table { get; set; }

        public frmManteinBase()
        {
            InitializeComponent();
            dts = new DataSet();
        }

        protected void BindingDate()
        {
            foreach (var txt in pnlTextBox.Controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma text = (TxtSigma)txt;
                    text.DataBindings.Clear();
                    text.DataBindings.Add("Text", dts.Tables["Taula"], text.DBReference);
                }
            }
            dgwBase.DataSource = dts.Tables[Table];
        }

        protected void GetQuery()
        {
            DBUtils db = new DBUtils();
            query = "select * from " + Table;
            dts = db.PortarPerConsulta(query);
        }

        protected void UpdateQuery()
        {
            DBUtils db = new DBUtils();
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //Open new queryTab

        }

        private void btnGet_Click(object sender, EventArgs e)
        {

        }
    }
}
