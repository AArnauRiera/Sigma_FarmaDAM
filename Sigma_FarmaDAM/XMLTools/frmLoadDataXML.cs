using DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLTools
{
    public partial class frmLoadDataXML : Form
    {

        public frmLoadDataXML()
        {
            InitializeComponent();
        }

        private void btnSelectXml_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Xml file";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                txtbxXml.Text = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(txtbxXml.Text);

            DBUtilities db = new DBUtilities();

            DataSet ds = db.PortarPerConsulta("select * from Drugs where 1 = 2");

            XmlNodeList nodeList = reader.SelectNodes("//prescription");

            foreach (XmlNode node in nodeList)
            {
                DataRow dtr =  ds.Tables[0].NewRow();               

                foreach (XmlNode child in node.ChildNodes)
                {
                    string value;

                    switch (child.Name)
                    {
                        case "des_nomco":
                            value = child.Value;
                            dtr["des_nomco"] = value;
                            break;
                        case "cod_nacion":
                            value = child.Value;
                            dtr["cod_nacion"] = value;
                            break;
                        case "nro_conte":
                            value = child.Value;
                            dtr["nro_conte"] = value;
                            break;
                        case "url_fictec":
                            value = child.Value;
                            dtr["url_fictec"] = value;
                            break;
                        case "sw_receta":
                            value = child.Value;
                            dtr["sw_receta"] = value;
                            break;
                        case "sw_generico":
                            value = child.Value;
                            dtr["sw_generico"] = value;
                            break;
                        case "sw_sustituible":
                            value = child.Value;
                            dtr["sw_sustituible"] = value;
                            break;
                        case "laboratorio_titular":
                            value = child.Value;
                            dtr["laboratorio_titular"] = value;
                            break;
                        case "composicion_pa":
                            XmlNodeList nodeListprin = child.SelectNodes("//cod_principio_activo");
                            value = nodeListprin[0].Value;
                            dtr["cod_principio_activo"] = value;
                            break;
                    }
                }

                ds.Tables[0].Rows.Add(dtr);
            }

            db.Actualizar("select * from Drugs where 1 = 2", "Taula", ds);
        }
    }
}
