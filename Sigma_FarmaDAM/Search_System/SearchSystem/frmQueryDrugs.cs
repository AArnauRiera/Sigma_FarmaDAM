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

        public frmQueryDrugs(DataGridView dgw, string table,string table2)
        {
            InitializeComponent();
            _dgw = dgw;
            Table = table;
            Table2 = table2;

        }

        public frmQueryDrugs(TxtSigma[] txts, string table, string conditon, string condition2,string table2)
        {
            InitializeComponent();
            _isSellSystem = true;
            _txts = txts;
            Table = table;
            Table2 = table2;
            GetQuery(conditon,condition2,table2);
            BindingDate();
        }

        protected void GetQuery(string condition, string condition2,string table2)
        {
            DBUtilities db = new DBUtilities();
            query = "select * from Drugs,Stock where Drugs.id  =  Stock.ID_Drug  and Drugs.ActivePrincipleID ='" + condition+ "' and Stock.Quantity>0 and Drugs.Register_Number!='"+condition2+"'";
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
