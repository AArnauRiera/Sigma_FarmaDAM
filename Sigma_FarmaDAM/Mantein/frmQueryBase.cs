using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
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
            DBUtils db = new DBUtils();

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
                        txtb.Add(t.Tag + " = '" + t.Text + "'");
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
            _dgw.DataSource = dgwDB.SelectedColumns;
            this.Close();
        }
    }
}
