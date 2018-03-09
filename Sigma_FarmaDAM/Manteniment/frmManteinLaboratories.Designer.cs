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
            this.pnlButtons.SuspendLayout();
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
            // 
            // btnQuery
            // 
            this.btnQuery.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.TabIndex = 1;
            // 
            // bntNew
            // 
            this.bntNew.TabIndex = 3;
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(4, 59);
            this.lblCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(29, 19);
            this.lblCIF.TabIndex = 5;
            this.lblCIF.Text = "CIF";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 32);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(4, 4);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(96, 19);
            this.lblDenomination.TabIndex = 7;
            this.lblDenomination.Text = "Denomination";
            // 
            // txtCIF
            // 
            this.txtCIF.DBReference = "CIF";
            this.txtCIF.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtCIF.ForeColor = System.Drawing.Color.Gray;
            this.txtCIF.Location = new System.Drawing.Point(195, 61);
            this.txtCIF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Size = new System.Drawing.Size(132, 19);
            this.txtCIF.TabIndex = 6;
            this.txtCIF.Table = "Laboratories";
            // 
            // txtAddress
            // 
            this.txtAddress.DBReference = "Address";
            this.txtAddress.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(195, 33);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 19);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Table = "Laboratories";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtDenomination.ForeColor = System.Drawing.Color.Gray;
            this.txtDenomination.Location = new System.Drawing.Point(195, 5);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(132, 19);
            this.txtDenomination.TabIndex = 4;
            this.txtDenomination.Table = "Laboratories";
            // 
            // frmManteinLaboratories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinLaboratories";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
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
