using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Mantein;
using Helpers;

namespace SearchSystem
{
    public class frmQueryClients : frmQueryBase
    {
        bool error;
        bool updated;
        private Label lblNTS;
        private Label lblDNI;
        private Label lblLastName2;
        private Label lblLastName1;
        private Label lblName;
        private Sigma_Controls.TxtSigma txtNTS;
        private Sigma_Controls.TxtSigma txtLastName2;
        private Sigma_Controls.TxtSigma txtLastName1;
        private Sigma_Controls.TxtSigma txtDNI;
        private ErrorProvider errorProvider;
        private System.ComponentModel.IContainer components;
        private Sigma_Controls.TxtSigma txtName;

        public frmQueryClients(frmManteinBase frm, string table) : base(frm, table)
        {
            InitializeComponent();
            _frm = frm;
            Table = table;
        }

        public frmQueryClients()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new Sigma_Controls.TxtSigma();
            this.txtDNI = new Sigma_Controls.TxtSigma();
            this.txtLastName1 = new Sigma_Controls.TxtSigma();
            this.txtLastName2 = new Sigma_Controls.TxtSigma();
            this.txtNTS = new Sigma_Controls.TxtSigma();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNTS = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblNTS);
            this.pnlTB.Controls.Add(this.lblDNI);
            this.pnlTB.Controls.Add(this.lblLastName2);
            this.pnlTB.Controls.Add(this.lblLastName1);
            this.pnlTB.Controls.Add(this.lblName);
            this.pnlTB.Controls.Add(this.txtNTS);
            this.pnlTB.Controls.Add(this.txtLastName2);
            this.pnlTB.Controls.Add(this.txtLastName1);
            this.pnlTB.Controls.Add(this.txtDNI);
            this.pnlTB.Controls.Add(this.txtName);
            // 
            // txtName
            // 
            this.txtName.DBReference = "Name";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtName.Location = new System.Drawing.Point(280, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Table = "Clients";
            this.txtName.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtName.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "DNI";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.txtDNI.Location = new System.Drawing.Point(280, 94);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.Table = "Clients";
            this.txtDNI.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtDNI.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtLastName1
            // 
            this.txtLastName1.DBReference = "lastName1";
            this.txtLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtLastName1.Location = new System.Drawing.Point(280, 42);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(100, 20);
            this.txtLastName1.TabIndex = 3;
            this.txtLastName1.Table = "Clients";
            this.txtLastName1.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtLastName1.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtLastName2
            // 
            this.txtLastName2.DBReference = "lastName2";
            this.txtLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtLastName2.Location = new System.Drawing.Point(280, 68);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(100, 20);
            this.txtLastName2.TabIndex = 4;
            this.txtLastName2.Table = "Clients";
            this.txtLastName2.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtLastName2.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtNTS
            // 
            this.txtNTS.DBReference = "NTS";
            this.txtNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtNTS.Location = new System.Drawing.Point(280, 120);
            this.txtNTS.Name = "txtNTS";
            this.txtNTS.Size = new System.Drawing.Size(100, 20);
            this.txtNTS.TabIndex = 5;
            this.txtNTS.Table = "Clients";
            this.txtNTS.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtNTS.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(195, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(171, 42);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(75, 13);
            this.lblLastName1.TabIndex = 7;
            this.lblLastName1.Text = "Primer apellido";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(153, 68);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(89, 13);
            this.lblLastName2.TabIndex = 8;
            this.lblLastName2.Text = "Segundo apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(219, 94);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // lblNTS
            // 
            this.lblNTS.AutoSize = true;
            this.lblNTS.Location = new System.Drawing.Point(216, 120);
            this.lblNTS.Name = "lblNTS";
            this.lblNTS.Size = new System.Drawing.Size(29, 13);
            this.lblNTS.TabIndex = 8;
            this.lblNTS.Text = "NTS";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmQueryClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryClients";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        private void checkControls()
        {
            error = false;
            foreach (Control cntrl in pnlTB.Controls)
            {
                cntrl.Focus();
            }
        }

        private void tbxEmpty_Leave(object sender, EventArgs e)
        {
            updated = false;
            if (!ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)sender, true))
            {
                error = true;
            }
        }
        private void tbx_Leave(object sender, EventArgs e)
        {
            updated = false;
            if (!ControlsErrorsHelper.CheckControlsErrors(errorProvider, (Control)sender))
            {
                error = true;
            }
        }

        public void btnUpdate_Click_1(object sender, EventArgs e)
        {
            checkControls();
            if (!error && !updated)
            {
                GetQuery();
                BindingDate();
                DisableColumns();
                updated = true;
            }
        }
    }
}
