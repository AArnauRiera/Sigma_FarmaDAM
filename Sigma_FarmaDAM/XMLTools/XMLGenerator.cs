using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool GenerateCommand(DataSet dataSet)
        {
            try
            {
                XmlWriterSettings settingsWriter = new XmlWriterSettings();
                settingsWriter.ConformanceLevel = ConformanceLevel.Auto;
                settingsWriter.Indent = true;
                settingsWriter.IndentChars = "    ";

                using (XmlWriter writer = XmlWriter.Create("comandes.xml", settingsWriter))
                {
                    writer.WriteStartDocument();
                    writer.WriteDocType("comanda", null, "comandes.dtd", null);
                    List<Article> articles = new List<Article>();
                    DataTable table = dataSet.Tables[0];

                    foreach (DataRow row in table.Rows)
                    {
                        Article article = new Article()
                        {
                            Name = Convert.ToString(row["Name"]),
                            Quantity = Convert.ToString(row["quantity"]),
                            Reference = Convert.ToString(row["ID_Stock"]),
                            Receipt = Convert.ToBoolean(row["receipt"])
                        };

                        articles.Add(article);
                    }

                    writer.WriteStartElement("comanda");
                    writer.WriteElementString("client", Convert.ToString(table.Rows[0]["ID_Client"]));
                    writer.WriteElementString("dataComanda", Convert.ToString(table.Rows[0]["dataCamanda"]));
                    writer.WriteElementString("num", Convert.ToString(table.Rows[0]["num"]));
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
            catch
            {
                return false;
            }
        }
    }
}
