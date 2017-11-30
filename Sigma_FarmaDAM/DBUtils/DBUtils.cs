using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class DBUtils
    {
        #region Private Variables
        private string _stringSQLOLEDB;
        private OleDbConnection con;
        #endregion

        #region Public Variables
        public string StringSQLOLEDB
        {
            get { return _stringSQLOLEDB; }
            set { _stringSQLOLEDB = value; }
        }
        #endregion

        #region OleDBMethods
        public void Conexion()
        {
            OleDbConnection con = new OleDbConnection(_stringSQLOLEDB);
            con.Open();
            con.InitializeLifetimeService();
        }

        public DataSet PortarPerConsulta(string query)
        {

            OleDbDataAdapter dta;
            OleDbCommandBuilder construct;
            DataSet dts = null;
            try
            {
                Conexion();
                dta = new OleDbDataAdapter(query, con);
                construct = new OleDbCommandBuilder(dta);
                dts = new DataSet();
                dta.Fill(dts, "Taula");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (con != null)
            {
                con.Close();
                con.Dispose();
            }

            return dts;

        }

        public bool Actualizar(string query, string taula, DataSet dts)
        {
            bool correct = true;
            OleDbDataAdapter dta;
            OleDbCommandBuilder construct;

            try
            {
                dta = new OleDbDataAdapter(query, con);
                construct = new OleDbCommandBuilder(dta);

                if (dts.HasChanges())
                {
                    dta.Update(dts, taula);
                }
            }
            catch (Exception e)
            {
                correct = false;
                Console.WriteLine(e);
            }

            if (con != null)
            {
                con.Close();
                con.Dispose();
            }

            return correct;
        }
        #endregion

    }
}
