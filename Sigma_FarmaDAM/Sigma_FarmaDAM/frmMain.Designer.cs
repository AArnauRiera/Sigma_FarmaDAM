namespace Sigma_FarmaDAM
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizacioMedicaments = new System.Windows.Forms.Button();
            this.btnProgramaFidelitzacioClients = new System.Windows.Forms.Button();
            this.btnGestioComandes = new System.Windows.Forms.Button();
            this.btnVendadeMedicaments = new System.Windows.Forms.Button();
            this.btnLaboratorisFarmaceutiques = new System.Windows.Forms.Button();
            this.btnMantenimentProductes = new System.Windows.Forms.Button();
            this.btnMantenimenPrincipiActius = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1116, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 778);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizacioMedicaments);
            this.panel1.Controls.Add(this.btnProgramaFidelitzacioClients);
            this.panel1.Controls.Add(this.btnGestioComandes);
            this.panel1.Controls.Add(this.btnVendadeMedicaments);
            this.panel1.Controls.Add(this.btnLaboratorisFarmaceutiques);
            this.panel1.Controls.Add(this.btnMantenimentProductes);
            this.panel1.Controls.Add(this.btnMantenimenPrincipiActius);
            this.panel1.Controls.Add(this.btnEditClient);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 729);
            this.panel1.TabIndex = 6;
            // 
            // btnActualizacioMedicaments
            // 
            this.btnActualizacioMedicaments.Location = new System.Drawing.Point(3, 651);
            this.btnActualizacioMedicaments.Name = "btnActualizacioMedicaments";
            this.btnActualizacioMedicaments.Size = new System.Drawing.Size(218, 66);
            this.btnActualizacioMedicaments.TabIndex = 9;
            this.btnActualizacioMedicaments.Text = "Actualització medicaments";
            this.btnActualizacioMedicaments.UseVisualStyleBackColor = true;
            this.btnActualizacioMedicaments.Click += new System.EventHandler(this.btnActualizacioMedicaments_Click);
            // 
            // btnProgramaFidelitzacioClients
            // 
            this.btnProgramaFidelitzacioClients.Location = new System.Drawing.Point(3, 579);
            this.btnProgramaFidelitzacioClients.Name = "btnProgramaFidelitzacioClients";
            this.btnProgramaFidelitzacioClients.Size = new System.Drawing.Size(218, 66);
            this.btnProgramaFidelitzacioClients.TabIndex = 8;
            this.btnProgramaFidelitzacioClients.Text = "Programa fidelització clients ";
            this.btnProgramaFidelitzacioClients.UseVisualStyleBackColor = true;
            // 
            // btnGestioComandes
            // 
            this.btnGestioComandes.Location = new System.Drawing.Point(3, 507);
            this.btnGestioComandes.Name = "btnGestioComandes";
            this.btnGestioComandes.Size = new System.Drawing.Size(218, 66);
            this.btnGestioComandes.TabIndex = 7;
            this.btnGestioComandes.Text = "Gestió de comandes ";
            this.btnGestioComandes.UseVisualStyleBackColor = true;
            // 
            // btnVendadeMedicaments
            // 
            this.btnVendadeMedicaments.Location = new System.Drawing.Point(3, 435);
            this.btnVendadeMedicaments.Name = "btnVendadeMedicaments";
            this.btnVendadeMedicaments.Size = new System.Drawing.Size(218, 66);
            this.btnVendadeMedicaments.TabIndex = 6;
            this.btnVendadeMedicaments.Text = "Venda Medicaments";
            this.btnVendadeMedicaments.UseVisualStyleBackColor = true;
            // 
            // btnLaboratorisFarmaceutiques
            // 
            this.btnLaboratorisFarmaceutiques.Location = new System.Drawing.Point(0, 363);
            this.btnLaboratorisFarmaceutiques.Name = "btnLaboratorisFarmaceutiques";
            this.btnLaboratorisFarmaceutiques.Size = new System.Drawing.Size(218, 66);
            this.btnLaboratorisFarmaceutiques.TabIndex = 5;
            this.btnLaboratorisFarmaceutiques.Text = "Laboratoris Farmacèutiques";
            this.btnLaboratorisFarmaceutiques.UseVisualStyleBackColor = true;
            // 
            // btnMantenimentProductes
            // 
            this.btnMantenimentProductes.Location = new System.Drawing.Point(0, 291);
            this.btnMantenimentProductes.Name = "btnMantenimentProductes";
            this.btnMantenimentProductes.Size = new System.Drawing.Size(218, 66);
            this.btnMantenimentProductes.TabIndex = 4;
            this.btnMantenimentProductes.Text = "Manteniment productes";
            this.btnMantenimentProductes.UseVisualStyleBackColor = true;
            // 
            // btnMantenimenPrincipiActius
            // 
            this.btnMantenimenPrincipiActius.Location = new System.Drawing.Point(3, 219);
            this.btnMantenimenPrincipiActius.Name = "btnMantenimenPrincipiActius";
            this.btnMantenimenPrincipiActius.Size = new System.Drawing.Size(218, 66);
            this.btnMantenimenPrincipiActius.TabIndex = 3;
            this.btnMantenimenPrincipiActius.Text = "Manteniment principis actius ";
            this.btnMantenimenPrincipiActius.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(0, 147);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(218, 66);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Editar Cliente";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(0, 75);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(218, 66);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Registro Cliente";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(0, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(218, 66);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 729);
            this.panel2.TabIndex = 8;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.Main);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(895, 729);
            this.tbMain.TabIndex = 5;
            this.tbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabControlMainMouseDown);
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(887, 703);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVendadeMedicaments;
        private System.Windows.Forms.Button btnLaboratorisFarmaceutiques;
        private System.Windows.Forms.Button btnMantenimentProductes;
        private System.Windows.Forms.Button btnMantenimenPrincipiActius;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnGestioComandes;
        private System.Windows.Forms.Button btnActualizacioMedicaments;
        private System.Windows.Forms.Button btnProgramaFidelitzacioClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage Main;
    }
}



