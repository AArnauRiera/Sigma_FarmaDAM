using DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLTools
{
    public partial class frmLoadPAXml : XMLTools.frmLoadDataXML
    {
        public frmLoadPAXml()
        {
            InitializeComponent();
        }

        public override void btnUpload_Click(object sender, EventArgs e)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(txtbxXml.Text);

            DBUtilities db = new DBUtilities();

            DataSet ds = db.PortarPerConsulta("select * from Active_Principles where 1 = 2");

            XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("principiosactivos");

            foreach (XmlNode node in nodeList)
            {
                DataRow dtr = ds.Tables["Taula"].NewRow();

                foreach (XmlNode child in node.ChildNodes)
                {
                    string value;

                    switch (child.Name)
                    {
                        case "nroprincipioactivo":
                            value = child.InnerText;
                            dtr["id"] = value;
                            break;
                        case "codigoprincipioactivo":
                            value = child.InnerText;
                            dtr["Sanitary_Register_Number"] = value;
                            break;
                        case "principioactivo":
                            value = child.InnerText;
                            dtr["Name"] = value;
                            break;                      
                    }
                }

                ds.Tables["Taula"].Rows.Add(dtr);
            }

            db.Actualizar("select * from Active_Principles where 1 = 2", "Taula", ds);
        }
    }
}
