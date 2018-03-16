using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace XMLTools
{
    struct Article
    {
        public string Name;
        public string Quantity;
        public string Reference;
        public bool Receipt;
    }
    public class XMLGenerator
    {

        public bool GenerateCommand(DataSet dataSet, string date)
        {
            try
            {
                XmlWriterSettings settingsWriter = new XmlWriterSettings();
                settingsWriter.ConformanceLevel = ConformanceLevel.Auto;
                settingsWriter.Indent = true;
                settingsWriter.IndentChars = "    ";

                using (XmlWriter writer = XmlWriter.Create("Comanda_"+date+".xml", settingsWriter))
                {
                    writer.WriteStartDocument();
                    writer.WriteDocType("comanda", null, "comandes.dtd", null);
                    List<Article> articles = new List<Article>();
                    DataTable table = dataSet.Tables["Taula"];

                    foreach (DataRow row in table.Rows)
                    {
                        Article article = new Article()
                        {
                            Name = Convert.ToString(row["CommercialName"]),
                            Quantity = Convert.ToString(row["Quantity"]),
                            Reference = Convert.ToString(row["Sanitary_Register_Num"]),
                            Receipt = Convert.ToBoolean(row["NeedsRecipe"])
                        };

                        articles.Add(article);
                    }

                    writer.WriteStartElement("comanda");
                    writer.WriteElementString("client", "SigmaCoders");
                    writer.WriteElementString("dataComanda", date);
                    writer.WriteElementString("num", "1");
                    writer.WriteStartElement("articles");

                    for (int i = 0; i < articles.Count; i++)
                    {
                        writer.WriteStartElement("article");
                        writer.WriteAttributeString("lin", Convert.ToString(i));
                        writer.WriteElementString("referencia", articles[i].Reference);
                        writer.WriteElementString("quantitat", articles[i].Quantity);
                        if (articles[i].Receipt)
                        {
                            writer.WriteElementString("recepta", " ");
                        }
                        writer.WriteEndElement();

                    }

                    int total = articles.Count;
                    int recepta = articles.Where(a => a.Receipt == true).ToList().Count();
                    int norecepta = total - recepta;
                    int totalrecepta = articles.Where(a => a.Receipt == false).ToList().Sum(b => Convert.ToInt32(b.Quantity));
                    int totalnorecepta = articles.Where(a => a.Receipt == true).ToList().Sum(b => Convert.ToInt32(b.Quantity));

                    writer.WriteStartElement("resum");
                    writer.WriteElementString("totallin", Convert.ToString(total));
                    writer.WriteElementString("receptalin", Convert.ToString(recepta));
                    writer.WriteElementString("noreceptalin", Convert.ToString(norecepta));
                    writer.WriteElementString("totalrecepta", Convert.ToString(totalrecepta));
                    writer.WriteElementString("totalnorecepta", Convert.ToString(totalnorecepta));

                    writer.Flush();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
