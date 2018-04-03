using System;
using System.Data;
using System.Windows.Forms;
using DBUtils;
using Sigma_Controls;

namespace XMLTools
{
    public partial class frmGestionComandas : CentredForm
    {
        public frmGestionComandas()
        {
            InitializeComponent();
            CenterPanel(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCommanndByDate();
        }

        private void btnSelectXmlLab_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Xml file";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                txtbxXmlLab.Text = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void btnUploadLab_Click(object sender, EventArgs e)
        {

            FTPHelper.UploadFile(txtbxXmlLab.Text);

            SMTPHelper.SendEmail();

        }

        private void GetCommanndByDate()
        {

            DataSet ds;
            XMLGenerator xmlGenerator = new XMLGenerator();
			bool correct;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            DBUtils.DBUtilities dbUtilities = new DBUtilities();

            ds = dbUtilities.PortarPerConsulta(
                "SELECT Drugs.CommercialName, Drugs.Sanitary_Register_Num, SUM(Order_Content.Quantity) AS Quantity, Drugs.NeedsRecipe FROM Order_Header, Order_Content, Drugs WHERE Order_Header.Id_Header = Order_Content.Id_Header AND Drugs.id = Order_Content.Id_Drug AND Date LIKE '%" + dateTimePicker1.AccessibilityObject.Value + "%' GROUP BY Order_Content.Id_Drug, Drugs.CommercialName, Drugs.Sanitary_Register_Num");

            xmlGenerator.GenerateCommand(ds, dateTimePicker1.Text);

            correct = FTPHelper.UploadFile("Comanda_" + dateTimePicker1.Text + ".xml");
			if (correct)
			{
				SMTPHelper.SendEmail();
			}

        }

    }
}