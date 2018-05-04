using DBUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigma_Controls
{
    public class cbxSigma : ComboBox
    {
        private string _DBReference;
        private string _ForeginData;
        private string _ForeginTable;
        private string _ForeginValue;
        private int _indexDB;

        Dictionary<string, int> principAct = new Dictionary<string, int>();

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            try
            {
                IndexDB = principAct[SelectedItem.ToString()];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            
        }       

        public int IndexDB
        {
            get { return _indexDB; }
            set {
                _indexDB = value;
                SelectedIndex = GetItemSelected(_indexDB);
            }
        }

        int GetItemSelected(int id)
        {
            if (principAct.Count == 0)
            {
                FillDictionary(ForeginTable, ForeginData, ForeginValue);
            }

            var value = principAct.FirstOrDefault(v => v.Value == id).Key;
            if (value != null)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].ToString().Equals(value.ToString()))
                    {
                        return i;
                    }
                }
            }
            return -1;

        }

        public void FillDictionary(string table, string key, string value)
        {
            DBUtilities db = new DBUtilities();
            DataSet Dict_dts = db.PortarPerConsulta("SELECT "+ value + "," + key + " FROM "+ table);

            principAct.Clear();

            foreach (DataRow row in Dict_dts.Tables[0].Rows)
            {
                principAct.Add(row[key].ToString(), int.Parse(row[value].ToString()));
            }
        }

        public string DBReference
        {
            get { return _DBReference; }
            set { _DBReference = value; }
        }
        public string ForeginTable
        {
            get { return _ForeginTable; }
            set { _ForeginTable = value; }
        }
        public string ForeginData
        {
            get { return _ForeginData; }
            set { _ForeginData = value; }
        }
        public string ForeginValue
        {
            get { return _ForeginValue; }
            set { _ForeginValue = value; }
        }
    }
}
