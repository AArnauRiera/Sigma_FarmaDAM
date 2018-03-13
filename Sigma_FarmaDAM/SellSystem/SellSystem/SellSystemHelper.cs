﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtils;
using SearchSystem;
using Sigma_Controls;

namespace SellSystem
{
    class SellSystemHelper
    {
        DBUtilities db = new DBUtilities();
        DataTable dt = new DataTable();
        public DataSet dts;
        public DataRow dr;

        string Query;
        ///***FUNCTIONS***///
   
        ///Busca si el cliente existe///
        private bool Client_exist(TxtSigma textBoxSigma, DataSet dts)
        {
            Query = "select* from Clients  where NTS ='" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;
            
            return validate;
        }
        ///Devuelve la ID del cliente///
        private string Client_ID(TxtSigma textBoxSigma)//la variable "id" no se usa en ningún momento
        {
            String ID;
            Query = "select NTS  from Clients  where NTS ='" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);
            try
            {
                ID = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                ID = "";
            }
            return ID;
        }
        ///Busca si el medicamento existe///
        private bool drug_exist(String drug)
        {
            Query = "select* from Drugs  where Register_Number = '" + drug + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;//tst
            
            return validate;
        }
        ///Busca si el medicamento tiene stock///
        private bool stock(String drug)
        {
            int stock = 0;
            String ID_Drug = "select id from Drugs where where Register_Number = '" + drug + "";
            String Drug = dts.Tables[0].Rows[0][0].ToString();
            Query = "select * from Stock where ID_Drug='" + Drug + "'and Quantity >'" + stock + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;

            return validate;
        }

        ///Devuelve un DataSet con los valores de la taula Clients donde NTS sea igual al valor introducido///
        private DataSet client(TxtSigma textBoxSigma)
        {
            Query = "select Name,lastName1,lastName2,DNI from Clients where NTS = '" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);
            return dts;
        }
        ///Devuelve el nombre del producto///
        private string name_product(TxtSigma textBoxSigma)
        {
            String Query = "select CommercialName from Drugs where Register_Number= '" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);
            string Name;
            try
            {
                Name = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                Name = "";
            }
            return Name;
        }
        ///Devuelve la ID  del principio activo de la tabla drugs///
        private string id_active(TxtSigma textBoxSigma)
        {
            DataSet dts;
            String Query = "select ActivePrincipleID from Drugs where Register_Number ='" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);
            string active;
            try
            {
                active = dts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                active = "";
            }
            return active;
        }
        private void Stock_Update(string Register_Number)
        {
            String Query = "Select  Stock.Quantity from Drugs,Stock where Drugs.id = Stock.ID_Drug and Drugs.Register_Number ='" + Register_Number + "'";

        }

    }
}
