﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DBUtils
{
    public class DBUtilities
    {
        #region Private Variables

        /// <summary>
        /// Cadena de conexion a la base de datos.
        /// </summary>
        private string _stringMySQL = ConfigurationManager.ConnectionStrings["sigma"].ConnectionString;

        /// <summary>
        /// Conexión a la base de datos.
        /// </summary>
        private MySqlConnection con;

        #endregion

        #region Public Variables
        #endregion

        #region OleDBMethods
        /// <summary>
        /// Conecta a la base de datos si la conexión no existe.
        /// </summary>
        public void Conexion()
        {
            if (con == null)
            {
                con = new MySqlConnection(_stringMySQL);
                con.Open();
                con.InitializeLifetimeService();
            }
        }
        /// <summary>
        /// Realiza una consulta MySQL a la base de datos.
        /// </summary>
        /// <param name="query">Consulta.</param>
        /// <returns>Devuelve la información en forma de DataSet.</returns>
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
        /// <summary>
        /// Actualiza la base de datos comparando la consulta en la base de datos con el DataSet.
        /// </summary>
        /// <param name="query">Consulta a la base de datos.</param>
        /// <param name="taula">Tabla del DataSet.</param>
        /// <param name="dts">DataSet.</param>
        /// <returns>RDevuelve si la actualización se ha realizado correctamente.</returns>
        public bool Actualizar(string query, string taula, DataSet dts)
        {
            bool correct = true;
            MySqlDataAdapter dta;
            MySqlCommandBuilder construct;

            try
            {
                Conexion();
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
