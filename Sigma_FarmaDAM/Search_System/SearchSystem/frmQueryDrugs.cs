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
using Helpers;

namespace SearchSystem
{
    public partial class frmQueryDrugs : Mantein.frmQueryBase
    {
        bool error;
        bool updated;
        private TxtSigma[] _txts;
        private bool _isSellSystem;
        Form _form = null;
        public frmQueryDrugs()
        {
            InitializeComponent();
        }

        public frmQueryDrugs(frmManteinBase frm, string table)
        {
            InitializeComponent();
            _frm = frm;
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

        public frmQueryDrugs(TxtSigma[] txts, string table, string conditon, string condition2, string quantity)
        {
            InitializeComponent();
            _isSellSystem = true;
            _txts = txts;
            Table = table;
            GetQueryQuantity(conditon, condition2, quantity);
            BindingDate();
        }

        public frmQueryDrugs(TxtSigma[] txts, string table, Form form)
        {
            InitializeComponent();
            _isSellSystem = true;
            _txts = txts;
            Table = table;
            _form = form;
        }

        protected void GetQuery(string condition, string condition2)
        {
            DBUtilities db = new DBUtilities();

            query = "select * from Drugs,Stock where Drugs.Register_Number = Stock.ID_Drug and Drugs.ActivePrincipleID='" + condition+ "' and Drugs.Register_Number!='" + condition2+"'and Stock.Quantity>0";

            dts = db.PortarPerConsulta(query);
        }

        protected void GetQueryQuantity(string condition, string condition2, string quantity)
        {
            DBUtilities db = new DBUtilities();

            query = "select * from Drugs,Stock where Drugs.Register_Number = Stock.ID_Drug and Drugs.ActivePrincipleID='" + condition + "' and Drugs.Register_Number!='" + condition2 + "'and Stock.Quantity>="+ quantity;

            dts = db.PortarPerConsulta(query);
        }

        protected override void btnSelect_Click(object sender, EventArgs e)
        {
            try
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
                    if (_form != null)
                    {
                        //_form.GetType().GetMethod("CheckProduct").Invoke(this, null);
                    }
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    base.btnSelect_Click(sender, e);
                }

            }
            catch {

                MessageBox.Show("Se ha seleccionado un registro vacío");

            }
            

            
        }

    }
}
