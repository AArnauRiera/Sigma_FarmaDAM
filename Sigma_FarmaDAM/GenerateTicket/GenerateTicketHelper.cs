using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateTicket
{
    public class GenerateTicketHelper
    {

        public ReportDocument generateTicket(ReportDocument crystalRepDoc, int idTicket)
        {

            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            crystalRepDoc.Load("C:\\Users\\anbit\\Documents\\FarmaDAM\\Sigma_FarmaDAM\\GenerateTicket\\TicketSigmaFarmaDAM.rpt");//mod
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

            crystalRepDoc.ExportToDisk(ExportFormatType.PortableDocFormat, exportPath);

        }

    }
}
