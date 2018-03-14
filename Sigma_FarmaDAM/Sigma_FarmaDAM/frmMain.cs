using Mantein;
using Manteniment;
using RegisterEditDrugs;
using SellSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagament;
using UserRegister;
using XMLTools;

namespace Sigma_FarmaDAM
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        private int userId;

        public frmMain()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        public frmMain(int value)
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            userId = value;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AddNewTab(string title, Form form)
        {
            TabPage myTabPage = new TabPage(title);
            form.TopLevel = false;
            form.TopMost = true;
            myTabPage.Controls.Add(form);
            form.Show();
            tbMain.TabPages.Add(myTabPage);
            tbMain.SelectedTab = myTabPage;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void cerrarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMain.TabPages.Remove(tbMain.SelectedTab);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmLoginSellSystem loginSell = new frmLoginSellSystem();
            if (loginSell.ShowDialog() == DialogResult.OK)
            {
                AddNewTab("Nueva Venta", new frmSellsytem());
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddNewTab("Nuevo Cliente", new UserManagement());
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddNewTab("Editar Cliente", new frmManteinClients()
            {
                Table = "Clients"
            });
        }

        private void TabControlMainMouseDown(object sender, MouseEventArgs e)
        {
            var tabControl = sender as TabControl;
            TabPage tabPageCurrent = null;
            if (e.Button == MouseButtons.Middle)
            {
                for (var i = 0; i < tabControl.TabCount; i++)
                {
                    if (!tabControl.GetTabRect(i).Contains(e.Location))
                        continue;
                    tabPageCurrent = tabControl.TabPages[i];
                    break;
                }
                if (tabPageCurrent != null)
                    tabControl.TabPages.Remove(tabPageCurrent);
            }
        }

        private void btnActualizacioMedicaments_Click(object sender, EventArgs e)
        {
            AddNewTab("Añadir Medicamentos", new frmAddEditDrugs());
        }

        private void btnMantenimenPrincipiActius_Click(object sender, EventArgs e)
        {
            AddNewTab("Principios Activos", new frmManteinActivePrinciple() {
            Table = "Active_Principles"
            });
        }

        private void btnMantenimentProductes_Click(object sender, EventArgs e)
        {
            AddNewTab("Productos", new frmManteinDrugs() {Table = "Drugs" });
        }

        private void btnLaboratorisFarmaceutiques_Click(object sender, EventArgs e)
        {
            AddNewTab("Laboratorios", new frmManteinLaboratories()
            {
                Table = "Laboratories"
            });
        }

        private void btnGestioComandes_Click(object sender, EventArgs e)
        {
     
            AddNewTab("Gestio de Comandes", new frmGestionComandas());

        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewTab("Añadir Usuario", new frmManteinUsers()
            {
                Table = "Seller"
            });
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoginControl.LoginControl logControl = new LoginControl.LoginControl();

            if (!logControl.CheckIfUserIsAdmin(userId, btnUserManagement))
            {
                btnUserManagement.Hide();
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            AddNewTab("Xml", new frmLoadLabXml());
        }
    }
}
