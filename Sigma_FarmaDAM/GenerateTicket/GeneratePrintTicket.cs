using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace GenerateTicket
{
    public class GeneratePrintTicket
    {

        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings-and-configuration-files
        //https://msdn.microsoft.com/en-us/library/system.drawing.printing.printersettings.installedprinters(v=vs.110).aspx

        GenerateTicketHelper GenTicketHelp = new GenerateTicketHelper();
        ReportDocument cryRpt = new ReportDocument();

        public GeneratePrintTicket(int idTicket)
        {
            cryRpt = GenTicketHelp.generateTicket(cryRpt, idTicket);
            GenTicketHelp.PrintPDF(cryRpt);
        }

    }
}
