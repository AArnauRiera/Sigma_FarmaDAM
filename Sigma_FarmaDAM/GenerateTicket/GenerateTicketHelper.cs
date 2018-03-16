using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
