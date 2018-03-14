using DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace XMLTools
{
    public partial class frmLoadLabXml : XMLTools.frmLoadDataXML
    {
        
        public frmLoadLabXml()
        {
            InitializeComponent();
        }
        public override void UploadData()
        {
            try
            {
                XmlDocument reader = new XmlDocument();

                reader.Load(txtbxXml.Text);

                DBUtilities db = new DBUtilities();

                DataSet ds = db.PortarPerConsulta("select * from Laboratories where 1 = 2");

                XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("laboratorios");

                int count = 0;

                nodeCount = nodeList.Count;

                lblCounter.Text = count + " / " + nodeCount;

                foreach(XmlNode node in nodeList)
                {
                    DataRow dtr = ds.Tables["Taula"].NewRow();

                    foreach(XmlNode child in node.ChildNodes)
                    {
                        string value;

                        switch(child.Name)
                        {
                            case "codigolaboratorio":
                                value = child.InnerText;
                                dtr["id"] = value;
                                break;
                            case "laboratorio":
                                value = child.InnerText;
                                dtr["LabName"] = value;
                                break;
                            case "direccion":
                                value = child.InnerText;
                                dtr["Address"] = value;
                                break;
                            case "codigopostal":
                                value = child.InnerText;
                                dtr["cp"] = value;
                                break;
                            case "localidad":
                                value = child.InnerText;
                                dtr["Location"] = value;
                                break;
                            case "cif":
                                value = child.InnerText;
                                dtr["CIF"] = value;
                                break;
                        }
                    }
                    string query = "select * from Laboratories where id = " + "'" + dtr["id"] + "'";

                    DataSet exist = db.PortarPerConsulta(query);

                    if(exist.Tables["Taula"].Rows.Count == 0)
                    {
                        ds.Tables["Taula"].Rows.Add(dtr);
                    }

                    count++;

                    lblCounter.Text = count + " / " + nodeCount;
                }

                db.Actualizar("select * from Laboratories where 1 = 2", "Taula", ds);

            }
            catch(Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
