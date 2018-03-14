using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtils;

namespace XMLTools
{
    public partial class frmGestionComandas : Form
    {
    public frmGestionComandas()
    {
    InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
    GetCommanndByDate();
    }

    private void GetCommanndByDate()
    {

            DataSet ds;
            XMLGenerator xmlGenerator = new XMLGenerator();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            DBUtils.DBUtilities dbUtilities = new DBUtilities();

            ds = dbUtilities.PortarPerConsulta(
            "SELECT Drugs.CommercialName, Drugs.Sanitary_Register_Num, SUM(Order_Content.Quantity) AS Quantity, Drugs.NeedsRecipe FROM Order_Header, Order_Content, Drugs WHERE Order_Header.Id_Header = Order_Content.Id_Header AND Drugs.id = Order_Content.Id_Drug AND Date LIKE '%" + dateTimePicker1.AccessibilityObject.Value + "%' GROUP BY Order_Content.Id_Drug, Drugs.CommercialName, Drugs.Sanitary_Register_Num");

            xmlGenerator.GenerateCommand(ds, dateTimePicker1.Text);

        }

    }
}