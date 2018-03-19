using DBUtils;
using System;
using System.Data;
using System.Threading;
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
                txtbxXmlLab.Text = openFileDialog1.FileName;
                sr.Close();
                sr.Dispose();
            }
        }

        public virtual void btnUpload_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(UploadDataLab);
            t.Start();
        }
        public virtual void UploadDataDrugs()
        {

            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load(txbDrug.Text);

                DBUtilities db = new DBUtilities();

                DataSet ds = db.PortarPerConsulta("select * from Drugs where 1 = 2");

                XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("prescription");

                int count = 0;

                int nodeCount = nodeList.Count;

                Invoke((MethodInvoker)delegate { lblDrug.Text = count + " / " + nodeCount; });

                Invoke((MethodInvoker)delegate {
                    pgbDrugs.Step = 1;
                    pgbDrugs.Minimum = 1;
                    pgbDrugs.Maximum = nodeCount;
                    pgbDrugs.Value = 1;
                });

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

                    try
                    {
                        DataSet exist = db.PortarPerConsulta("select * from Drugs where Register_number = " + dtr["Register_number"]);

                        if(exist.Tables["Taula"].Rows.Count == 0)
                        {
                            ds.Tables["Taula"].Rows.Add(dtr);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }                    

                    count++;

                    Invoke((MethodInvoker)delegate { lblDrug.Text = count + " / " + nodeCount; });

                    Invoke((MethodInvoker)delegate {
                        pgbDrugs.PerformStep();
                    });
                }

                db.Actualizar("select * from Drugs where 1 = 2", "Taula", ds);

                Invoke((MethodInvoker)delegate { lblDrug.Text = "Finalizado!"; });

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        public virtual void UploadDataLab()
        {
            try
            {
                XmlDocument reader = new XmlDocument();

                reader.Load(txtbxXmlLab.Text);

                DBUtilities db = new DBUtilities();

                DataSet ds = db.PortarPerConsulta("select * from Laboratories where 1 = 2");

                XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("laboratorios");

                int count = 0;

                int nodeCount = nodeList.Count;

                Invoke((MethodInvoker)delegate {
                    pgbLab.Step = 1;
                    pgbLab.Minimum = 1;
                    pgbLab.Maximum = nodeCount;
                    pgbLab.Value = 1;
                });

                Invoke((MethodInvoker)delegate { lblLab.Text = count + " / " + nodeCount; });

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

                    try
                    {
                        string query = "select * from Laboratories where id = " + "'" + dtr["id"] + "'";

                        DataSet exist = db.PortarPerConsulta(query);

                        if(exist.Tables["Taula"].Rows.Count == 0)
                        {
                            ds.Tables["Taula"].Rows.Add(dtr);
                        }
                    }
                    catch(Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                    count++;

                    Invoke((MethodInvoker)delegate { lblLab.Text = count + " / " + nodeCount; });

                    Invoke((MethodInvoker)delegate {
                        pgbLab.PerformStep();
                    });


                }

                db.Actualizar("select * from Laboratories where 1 = 2", "Taula", ds);

                Invoke((MethodInvoker)delegate { lblLab.Text = "Finalizado!"; });
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public virtual void UploadDataPA()
        {
            try
            {
                XmlDocument reader = new XmlDocument();

                reader.Load(txbPA.Text);

                DBUtilities db = new DBUtilities();

                DataSet ds = db.PortarPerConsulta("select * from Active_Principles where 1 = 2");

                XmlNodeList nodeList = reader.DocumentElement.GetElementsByTagName("principiosactivos");

                int count = 0;

                int nodeCount = nodeList.Count;

                Invoke((MethodInvoker)delegate { lblPa.Text = count + " / " + nodeCount; });

                Invoke((MethodInvoker)delegate {
                    pgbPA.Step = 1;
                    pgbPA.Minimum = 1;
                    pgbPA.Maximum = nodeCount;
                    pgbPA.Value = 1;
                });

                foreach(XmlNode node in nodeList)
                {
                    DataRow dtr = ds.Tables["Taula"].NewRow();

                    foreach(XmlNode child in node.ChildNodes)
                    {
                        string value;

                        switch(child.Name)
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

                    try
                    {
                        string query = "select * from Active_Principles where Sanitary_Register_Number = " + "'" + dtr["Sanitary_Register_Number"] + "'";

                        DataSet exist = db.PortarPerConsulta(query);

                        if(exist.Tables["Taula"].Rows.Count == 0)
                        {
                            ds.Tables["Taula"].Rows.Add(dtr);
                        }

                    }
                    catch(Exception e)
                    {

                        Console.WriteLine(e);
                    }

                    count++;

                    Invoke((MethodInvoker)delegate { lblPa.Text = count + " / " + nodeCount; });

                }

                db.Actualizar("select * from Active_Principles where 1 = 2", "Taula", ds);

                Invoke((MethodInvoker)delegate { lblPa.Text = "Finalizado!"; });

                Invoke((MethodInvoker)delegate {
                    pgbPA.PerformStep();
                });

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnUploadPA_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(UploadDataPA);
            t.Start();
        }

        private void btnUploadDrug_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(UploadDataDrugs);
            t.Start();
        }

        private void btnSelectXmlPA_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Xml file";

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                txbPA.Text = openFileDialog1.FileName;
                sr.Close();
                sr.Dispose();
            }

        }

        private void btnSelectXmlDrug_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Xml file";

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                txbDrug.Text = openFileDialog1.FileName;
                sr.Close();
                sr.Dispose();
            }
        }
    }
}
