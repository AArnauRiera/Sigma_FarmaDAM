using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GenerateTicket
{
    public class GenerateTicketHelper
    {
        /// <summary>
        /// Accede a los datos de la Base de Datos y rellena el documento en función de la ID 
        /// que recibe la función, que corresponde a la del ticket de compra
        /// </summary>
        /// <param name="crystalRepDoc">Documento Crystal Reports</param>
        /// <param name="idTicket">Id del ticket a imprimir</param>
        /// <returns></returns>
        public ReportDocument generateTicket(ReportDocument crystalRepDoc, int idTicket)
        {

            ConnectionInfo crConnectionInfo = new ConnectionInfo();


            crystalRepDoc.Load(Application.StartupPath + "\\TicketSigmaFarmaDAM.rpt");
            crystalRepDoc.RecordSelectionFormula = "{Order_Header1.Id_Header} = " + idTicket;

            crConnectionInfo.ServerName = "FarmaDAM";
            crConnectionInfo.DatabaseName = "g1s2am_FarmaDAM";
            crConnectionInfo.UserID = "g1s2am_SigmaCode";
            crConnectionInfo.Password = "12345aA";

            return crystalRepDoc;

        }
        /// <summary>
        /// Genera un PDF a partir del documento de Crystal Reports y lo exporta a la ruta definida
        /// </summary>
        /// <param name="crystalRepDoc">Documento Crystal Reports</param>
        /// <param name="exportPath">Ruta a la que se exporta el PDF</param>
        public void exportTicketPDF(ReportDocument crystalRepDoc, string exportPath) {

            try
            {

                crystalRepDoc.ExportToDisk(ExportFormatType.PortableDocFormat, exportPath);

                MessageBox.Show("El Ticket Se ha generado correctamente en la ruta:" + "\n" + exportPath);
            }
            catch
            {
                MessageBox.Show("Error en la generación de ticket");
            }

        }

        /// <summary>
        /// Genera un archivo PDF del documento a partir de la impresora.
        /// </summary>
        /// <param name="crystalRepDoc">Documento Crystal Reports</param>
        public void PrintPDF(ReportDocument crystalRepDoc){

            Print(crystalRepDoc, "Microsoft Print to PDF");

        }

        /// <summary>
        /// Lleva a cabo la impresión del informe entrante.
        /// </summary>
        /// <param name="crystalRepDoc"></param>
        /// <param name="printerName"></param>
        public void Print(ReportDocument crystalRepDoc, string printerName)
        {

            int i;
            string pkInstalledPrinters;
            try
            {
                for (i = 0; i <= PrinterSettings.InstalledPrinters.Count - 1; i++)
                {
                    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                    if (pkInstalledPrinters.Equals(printerName))
                    {
                        crystalRepDoc.PrintOptions.PrinterName = pkInstalledPrinters;
                        crystalRepDoc.PrintToPrinter(1, true, 0, 0);

                    }
                }

                MessageBox.Show("La impresión se ha realizado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error durante la impresión: " + e);
            }

        }

    }
}
