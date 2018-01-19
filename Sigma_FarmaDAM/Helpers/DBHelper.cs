using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Sigma_Controls;
using static System.Windows.Forms.Control;

namespace Helpers
{
    public static class DBHelper
    {

        public static DataSet GetQuery(string table, ControlCollection controls, string delimeter = "and", string condition = "=")
        {
            DBUtils db = new DBUtils();

            string conditions = Conditions(condition, delimeter, controls);

            string query = "select * from " + table;

            if (!String.IsNullOrWhiteSpace(conditions))
            {
                query = query + " where " + conditions;
            }

            return db.PortarPerConsulta(query);
        }

        public static DataSet GetQuery(string table, TxtSigma[] controls, string delimeter = "and", string condition = "=")
        {
            DBUtils db = new DBUtils();

            string conditions = Conditions(condition, delimeter, controls);

            string query = "select * from " + table;

            if (!String.IsNullOrWhiteSpace(conditions))
            {
                query = query + " where " + conditions;
            }

            return db.PortarPerConsulta(query);
        }

        private static string Conditions(string condition, string delimeter, TxtSigma[] controls)
        {
            string[] txts = GetAllTxtSigma(controls, condition);
            string con = string.Join(delimeter, txts);
            return con;
        }

        private static string[] GetAllTxtSigma(TxtSigma[] controls, string condition)
        {
            List<string> txtb = new List<string>();

            foreach (var txt in controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma t = (TxtSigma)txt;
                    if (!String.IsNullOrWhiteSpace(t.Text))
                    {
                        txtb.Add(t.DBReference + " " + condition + " '" + t.Text + "'");
                    }
                }
            }
            return txtb.ToArray();
        }

        private static string Conditions(string condition, string delimeter, ControlCollection controls)
        {
            string[] txts = GetAllTxtSigma(controls, condition);
            string con = string.Join(delimeter, txts);
            return con;
        }

        private static string[] GetAllTxtSigma(ControlCollection controls, string condition)
        {
            List<string> txtb = new List<string>();

            foreach (var txt in controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma t = (TxtSigma)txt;
                    if (!String.IsNullOrWhiteSpace(t.Text))
                    {
                        txtb.Add(t.DBReference + " " + condition + " '" + t.Text + "'");
                    }
                }
            }
            return txtb.ToArray();
        }

        public static void BindingTextBox(ControlCollection controls, DataSet dataSet)
        {
            foreach (var txt in controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma text = (TxtSigma)txt;
                    text.DataBindings.Clear();
                    text.DataBindings.Add("Text", dataSet.Tables["Taula"], text.DBReference);
                }
            }
        }
        public static void BindingTextBox(TxtSigma[] controls, DataSet dataSet)
        {
            foreach (var txt in controls)
            {
                if (txt is TxtSigma)
                {
                    TxtSigma text = (TxtSigma)txt;
                    text.DataBindings.Clear();
                    text.DataBindings.Add("Text", dataSet.Tables["Taula"], text.DBReference);
                }
            }
        }

    }
}
