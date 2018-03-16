using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace GenerateTicket
{
    public partial class frmGenerateTicket : Form
    {

        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings-and-configuration-files
        //https://msdn.microsoft.com/en-us/library/system.drawing.printing.printersettings.installedprinters(v=vs.110).aspx

        GenerateTicketHelper GenTicketHelp = new GenerateTicketHelper();
        ReportDocument cryRpt = new ReportDocument();

        public frmGenerateTicket()
        {
            InitializeComponent();
        }

        public frmGenerateTicket(int idTicket)
        {
            InitializeComponent();

            cmdVisor.Hide();
            txtTicket.Hide();

            cryRpt = GenTicketHelp.generateTicket(cryRpt, idTicket);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void cmdVisor_Click(System.Object sender, System.EventArgs e)
        {

            cryRpt = GenTicketHelp.generateTicket(cryRpt, int.Parse(txtTicket.Text));

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            string exportPath = "C:\\Users\\anbit\\Desktop\\report.pdf";
            GenTicketHelp.exportTicketPDF(cryRpt, exportPath);

        }
    }
}
