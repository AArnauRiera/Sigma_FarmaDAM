namespace Manteniment
{
    partial class frmManteinLaboratories
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
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDenomination = new System.Windows.Forms.Label();
            this.txtCIF = new Sigma_Controls.TxtSigma();
            this.txtAddress = new Sigma_Controls.TxtSigma();
            this.txtDenomination = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblCIF);
            this.pnlTextBox.Controls.Add(this.lblAddress);
            this.pnlTextBox.Controls.Add(this.lblDenomination);
            this.pnlTextBox.Controls.Add(this.txtCIF);
            this.pnlTextBox.Controls.Add(this.txtAddress);
            this.pnlTextBox.Controls.Add(this.txtDenomination);
            this.pnlTextBox.Controls.SetChildIndex(this.txtDenomination, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtAddress, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtCIF, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblDenomination, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblAddress, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblCIF, 0);
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(405, 108);
            this.lblCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(28, 17);
            this.lblCIF.TabIndex = 5;
            this.lblCIF.Text = "CIF";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(376, 76);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(340, 44);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(95, 17);
            this.lblDenomination.TabIndex = 7;
            this.lblDenomination.Text = "Denomination";
            // 
            // txtCIF
            // 
            this.txtCIF.DBReference = "CIF";
            this.txtCIF.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCIF.Location = new System.Drawing.Point(444, 100);
            this.txtCIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Placeholder = null;
            this.txtCIF.Size = new System.Drawing.Size(132, 22);
            this.txtCIF.TabIndex = 2;
            this.txtCIF.Table = "Laboratories";
            // 
            // txtAddress
            // 
            this.txtAddress.DBReference = "Address";
            this.txtAddress.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtAddress.Location = new System.Drawing.Point(444, 68);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Placeholder = null;
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Table = "Laboratories";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Location = new System.Drawing.Point(444, 36);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Placeholder = null;
            this.txtDenomination.Size = new System.Drawing.Size(132, 22);
            this.txtDenomination.TabIndex = 4;
            this.txtDenomination.Table = "Laboratories";
            // 
            // frmManteinLaboratories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinLaboratories";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDenomination;
        private Sigma_Controls.TxtSigma txtCIF;
        private Sigma_Controls.TxtSigma txtAddress;
        private Sigma_Controls.TxtSigma txtDenomination;
    }
}
