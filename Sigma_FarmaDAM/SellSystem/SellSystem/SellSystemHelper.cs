using System;
using System.Data;
using DBUtils;
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
        ///<param name="textboxSigma">Textbox del Cliente</param>
        public bool Client_exist(TxtSigma textBoxSigma)
        {
            Query = "select* from Clients  where NTS ='" + textBoxSigma.Text + "'";
            DataSet dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;
            
            return validate;
        }
        ///Devuelve la ID del cliente///
        ///<param name="textboxSigma">Textbox del cliente</param>
        public string Client_ID(string textBoxSigma)//la variable "id" no se usa en ningún momento
        {
            String ID;
            Query = "select id from Clients where NTS = '" + textBoxSigma + "'";
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
        ///<param name="drug">texbox del medicamento(register_number)</param>
        public bool drug_exist(String drug)
        {
            Query = "select* from Drugs  where Register_Number = '" + drug + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;//tst
            
            return validate;
        }
        ///Busca si el medicamento tiene stock///
        ///<param name="drug">ID del medicamento</param>
        public bool stock(String drug)
        {
            int stock = 0;
            
            Query = "select Quantity from Stock where ID_Drug='" + drug + "'and Quantity >'" + stock + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;

            return validate;
        }

        ///Busca si el medicamento tiene el stock solicitado por el usuario///
        ///<param name="drug">ID del medicamento</param>
        ///<param name="quantity">Cantidad solicitada</param>
        public bool stock(String drug, string quantity)
        {
            int stock = int.Parse(quantity);

            Query = "select Quantity from Stock where ID_Drug='" + drug + "'and Quantity >='" + stock + "'";
            dts = db.PortarPerConsulta(Query);

            bool validate = dts.Tables[0].Rows.Count > 0;

            return validate;
        }

        ///Devuelve un DataSet con los valores de la taula Clients donde NTS sea igual al valor introducido///
        ///<param name="textBoxSigma">NTS del cliente</param>
        public DataSet client(TxtSigma textBoxSigma)
        {
            Query = "select Name,lastName1,lastName2,DNI from Clients where NTS = '" + textBoxSigma.Text + "'";
            dts = db.PortarPerConsulta(Query);
            return dts;
        }
        ///Devuelve el nombre del producto///
        ///<param  name="textBoxSigma_txt">Register_Number text</param>
        public string name_product(string textBoxSigma_txt)
        {
            String Query = "select CommercialName from Drugs where Register_Number= '" + textBoxSigma_txt + "'";
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
        ///<param  name="ActivePrincipleStr">Register Number string</param>
        public string id_active(string ActivePrincipleStr)
        {
            DataSet dts;
            String Query = "select ActivePrincipleID from Drugs where Register_Number ='" + ActivePrincipleStr + "'";
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
        ///Devuelve la ID  de la tabla drugs a partir de el Register Number/// 
        ///<param  name="drug">Register Number Drug</param>
        public int Drug_ID(string drug)
        {
            DataSet dts;
            String Query = "select id from Drugs where Register_Number='" + drug + "'";
            dts = db.PortarPerConsulta(Query);
            string Drug = dts.Tables[0].Rows[0][0].ToString();
            int drug_id = Convert.ToInt32(Drug);
            return drug_id;
        }
        ///Devuelve la ID del medicamento  que esta en el Dataset///
        ///<param  name="data">Dataset con valores tabla Stock</param>
        public string getIdDrugsStock(DataSet data)
        {
            string idQuery = "";

            foreach (DataRow r in data.Tables["Taula"].Rows)
            {
                idQuery += " || ID_Drug = '" + Convert.ToInt32(r["ID_Drug"]) + "'";
            }

            return idQuery;
        }

    }
}
