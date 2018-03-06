using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mantein;
using Sigma_Controls;
using DBUtils;

namespace SearchSystem
{
    public partial class frmQueryDrugs : Mantein.frmQueryBase
    {

        private TxtSigma[] _txts;
        private bool _isSellSystem;
        public frmQueryDrugs()
        {
            InitializeComponent();
        }

        public frmQueryDrugs(DataGridView dgw, string table)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
        }

        public frmQueryDrugs(TxtSigma[] txts, string table, string conditon, string condition2)
        {
            InitializeComponent();
            _isSellSystem = true;
            _txts = txts;
            Table = table;
            GetQuery(conditon,condition2);
            BindingDate();
        }

        protected void GetQuery(string condition, string condition2)
        {
            DBUtilities db = new DBUtilities();

            query = "select * from " + Table + " where " + "ActivePrincipleID = " + condition + " and Register_Number !="+ condition2;

            dts = db.PortarPerConsulta(query);
        }

        protected override void btnSelect_Click(object sender, EventArgs e)
        {
            if (_isSellSystem)
            {
                for (int i = 0; i < dgwDB.SelectedRows[0].Cells.Count; i++)
                {
                    for (int j = 0; j < _txts.Length; j++)
                    {
                        if (_txts[j].DBReference.Equals(dgwDB.SelectedRows[0].Cells[i].OwningColumn.Name))
                        {
                            _txts[j].Text = dgwDB.SelectedRows[0].Cells[i].FormattedValue.ToString();
                        }
                    }
                }
                this.Close();
            }
            else
            {
                base.btnSelect_Click(sender,e);
            }

            
        }

    }
}
