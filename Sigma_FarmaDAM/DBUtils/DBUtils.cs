﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ClassLibrary1
{
    public class DBUtils
    {
        #region Private Variables
        private string _stringMySQL = "Server = g1s2am.sdslab.cat; Database=g1s2am_FarmaDAM;Uid=g1s2am_Admin;PASSWORD=12345aA";
        private MySqlConnection con;
        #endregion

        #region Public Variables
        public string StringSQLOLEDB
        {
            get { return _stringMySQL; }
            set { _stringMySQL = value; }
        }
        #endregion

        #region OleDBMethods
        public void Conexion()
        {
            MySqlConnection con = new MySqlConnection(_stringMySQL);
            con.Open();
            con.InitializeLifetimeService();
            MessageBox.Show("HEHEHE");
        }

        public DataSet PortarPerConsulta(string query)
        {

            MySqlDataAdapter dta;
            MySqlCommandBuilder construct;
            DataSet dts = null;
            try
            {
                Conexion();
                dta = new MySqlDataAdapter(query, con);
                construct = new MySqlCommandBuilder(dta);
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
            MySqlDataAdapter dta;
            MySqlCommandBuilder construct;

            try
            {
                dta = new MySqlDataAdapter(query, con);
                construct = new MySqlCommandBuilder(dta);

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
