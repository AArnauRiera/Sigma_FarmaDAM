using DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLTools
{
    public partial class frmLoadDataXML : Form
    {
        protected int nodeCount;
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

        public virtual void btnUpload_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(UploadData); // Kick off a new thread
            t.Start();
        }
        public virtual void UploadData()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(txtbxXml.Text);

            DBUtilities db = new DBUtilities();

            DataSet ds = db.PortarPerConsulta("select * from Drugs where 1 = 2");

            XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("prescription");

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
                        case "cod_nacion":
                            value = child.InnerText;
                            dtr["Register_number"] = value;
                            break;
                        case "nro_definitivo":
                            value = child.InnerText;
                            dtr["Sanitary_Register_Num"] = value;
                            break;
                        case "des_nomco":
                            value = child.InnerText;
                            dtr["CommercialName"] = value;
                            break;
                        case "nro_conte":
                            value = child.InnerText;
                            dtr["Content"] = value;
                            break;
                        case "url_fictec":
                            value = child.InnerText;
                            dtr["Documentation"] = value;
                            break;
                        case "url_prosp":
                            value = child.InnerText;
                            dtr["Prospectus"] = value;
                            break;
                        case "sw_receta":
                            value = child.InnerText;
                            dtr["NeedsRecipe"] = ConvertTo(value);
                            break;
                        case "sw_generico":
                            value = child.InnerText;
                            dtr["IsGeneric"] = ConvertTo(value);
                            break;
                        case "sw_sustituible":
                            value = child.InnerText;
                            dtr["Replaceable"] = ConvertTo(value);
                            break;
                        case "laboratorio_titular":
                            value = child.InnerText;
                            dtr["LabId"] = value;
                            break;
                        case "formasfarmaceuticas":
                            bool found = false;
                            foreach(XmlNode item in child.ChildNodes)
                            {
                                switch(item.Name)
                                {
                                    case "composicion_pa":

                                        foreach(XmlNode cod in item.ChildNodes)
                                        {
                                            switch(cod.Name)
                                            {
                                                case "cod_principio_activo":
                                                    value = cod.InnerText;
                                                    dtr["ActivePrincipleID"] = value;
                                                    found = true;
                                                    break;
                                            }
                                        }

                                        break;
                                }

                                if(found)
                                {
                                    break;
                                }

                            }

                            break;
                    }
                }

                dtr["IVAId"] = 2;
                dtr["Price"] = 10;

                DataSet exist = db.PortarPerConsulta("select * from Drugs where Register_number = " + dtr["Register_number"]);

                if(exist.Tables["Taula"].Rows.Count == 0)
                {
                    ds.Tables["Taula"].Rows.Add(dtr);
                }

                count++;

                lblCounter.Text = count + " / " + nodeCount;
            }

            db.Actualizar("select * from Drugs where 1 = 2", "Taula", ds);
        }
        private bool ConvertTo(string value)
        {
            if (value.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
