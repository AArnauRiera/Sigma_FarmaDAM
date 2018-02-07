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
        protected DataGridView _dgw;


        public string Table { get; set; }

        public frmQueryBase(DataGridView dgw, string table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;

        }

        public frmQueryBase()
        {
            InitializeComponent();

        }
        protected void BindingDate()
        {
            dgwDB.DataSource = dts.Tables["Taula"];
        }

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


        private string Conditions()
        {
            string[] txts = GetAllTxtSigma();
            string delimeter = " and ";
            string con = string.Join(delimeter,txts);
            return con;
        }

        private string[] GetAllTxtSigma()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetQuery();
            BindingDate();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            string selected = "";

            List<string> conditions = new List<string>();

            for (int i = 0; i < dgwDB.SelectedRows.Count; i++)
            {
                conditions.Add(dgwDB.SelectedRows[i].Cells[0].OwningColumn.Name + " = " + "'" + dgwDB.SelectedRows[i].Cells[0].FormattedValue.ToString() + "'");
            }

            DBUtilities db = new DBUtilities();
            
            selected = "select * from " + Table + " where " + string.Join(" or ", conditions); ;

            ds = db.PortarPerConsulta(selected);

            _dgw.DataSource = ds.Tables["Taula"];         

            this.Close();

        }
    }
}
