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
            dgwBase.DataSource = dts.Tables[Table];
        }

        protected void GetQuery()
        {
            DBUtilities db = new DBUtilities();
            query = "select * from " + Table;
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

    }
}
