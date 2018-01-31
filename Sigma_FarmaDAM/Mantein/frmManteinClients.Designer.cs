namespace Mantein
{
    partial class frmManteinClients
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
            this.lblNTS = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNTS = new Sigma_Controls.TxtSigma();
            this.txtLastName2 = new Sigma_Controls.TxtSigma();
            this.txtLastName1 = new Sigma_Controls.TxtSigma();
            this.txtDNI = new Sigma_Controls.TxtSigma();
            this.txtName = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblNTS);
            this.pnlTextBox.Controls.Add(this.lblDNI);
            this.pnlTextBox.Controls.Add(this.lblLastName2);
            this.pnlTextBox.Controls.Add(this.lblLastName1);
            this.pnlTextBox.Controls.Add(this.lblName);
            this.pnlTextBox.Controls.Add(this.txtNTS);
            this.pnlTextBox.Controls.Add(this.txtLastName2);
            this.pnlTextBox.Controls.Add(this.txtLastName1);
            this.pnlTextBox.Controls.Add(this.txtDNI);
            this.pnlTextBox.Controls.Add(this.txtName);
            this.pnlTextBox.Controls.SetChildIndex(this.txtName, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtDNI, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtLastName1, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtLastName2, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtNTS, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblName, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblLastName1, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblLastName2, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblDNI, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblNTS, 0);
            // 
            // lblNTS
            // 
            this.lblNTS.AutoSize = true;
            this.lblNTS.Location = new System.Drawing.Point(392, 133);
            this.lblNTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNTS.Name = "lblNTS";
            this.lblNTS.Size = new System.Drawing.Size(36, 17);
            this.lblNTS.TabIndex = 16;
            this.lblNTS.Text = "NTS";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(396, 101);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.TabIndex = 17;
            this.lblDNI.Text = "DNI";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(308, 69);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(121, 17);
            this.lblLastName2.TabIndex = 18;
            this.lblLastName2.Text = "Second last name";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(332, 37);
            this.lblLastName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(100, 17);
            this.lblLastName1.TabIndex = 15;
            this.lblLastName1.Text = "First last name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(384, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtNTS
            // 
            this.txtNTS.DBReference = "NTS";
            this.txtNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtNTS.Location = new System.Drawing.Point(477, 133);
            this.txtNTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNTS.Name = "txtNTS";
            this.txtNTS.Placeholder = null;
            this.txtNTS.Size = new System.Drawing.Size(132, 22);
            this.txtNTS.TabIndex = 13;
            this.txtNTS.Table = "Clients";
            // 
            // txtLastName2
            // 
            this.txtLastName2.DBReference = "lastName2";
            this.txtLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName2.Location = new System.Drawing.Point(477, 69);
            this.txtLastName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Placeholder = null;
            this.txtLastName2.Size = new System.Drawing.Size(132, 22);
            this.txtLastName2.TabIndex = 12;
            this.txtLastName2.Table = "Clients";
            // 
            // txtLastName1
            // 
            this.txtLastName1.DBReference = "lastName1";
            this.txtLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName1.Location = new System.Drawing.Point(477, 37);
            this.txtLastName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Placeholder = null;
            this.txtLastName1.Size = new System.Drawing.Size(132, 22);
            this.txtLastName1.TabIndex = 11;
            this.txtLastName1.Table = "Clients";
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "DNI";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDNI.Location = new System.Drawing.Point(477, 101);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Placeholder = null;
            this.txtDNI.Size = new System.Drawing.Size(132, 22);
            this.txtDNI.TabIndex = 10;
            this.txtDNI.Table = "Clients";
            // 
            // txtName
            // 
            this.txtName.DBReference = "Name";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtName.Location = new System.Drawing.Point(477, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = null;
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 9;
            this.txtName.Table = "Clients";
            // 
            // frmManteinClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinClients";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNTS;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.Label lblLastName1;
        private System.Windows.Forms.Label lblName;
        private Sigma_Controls.TxtSigma txtNTS;
        private Sigma_Controls.TxtSigma txtLastName2;
        private Sigma_Controls.TxtSigma txtLastName1;
        private Sigma_Controls.TxtSigma txtDNI;
        private Sigma_Controls.TxtSigma txtName;
    }
}
