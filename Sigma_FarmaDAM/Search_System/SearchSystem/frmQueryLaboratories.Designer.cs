namespace SearchSystem
{
    partial class frmQueryLaboratories
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
            if(disposing && (components != null))
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
            this.txtDenomination = new Sigma_Controls.TxtSigma();
            this.txtAddress = new Sigma_Controls.TxtSigma();
            this.txtCIF = new Sigma_Controls.TxtSigma();
            this.lblDenomination = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.label2);
            this.pnlTB.Controls.Add(this.txtSigma2);
            this.pnlTB.Controls.Add(this.label1);
            this.pnlTB.Controls.Add(this.txtSigma1);
            this.pnlTB.Controls.Add(this.lblCIF);
            this.pnlTB.Controls.Add(this.lblAddress);
            this.pnlTB.Controls.Add(this.lblDenomination);
            this.pnlTB.Controls.Add(this.txtCIF);
            this.pnlTB.Controls.Add(this.txtAddress);
            this.pnlTB.Controls.Add(this.txtDenomination);
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Location = new System.Drawing.Point(341, 27);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(132, 22);
            this.txtDenomination.TabIndex = 0;
            this.txtDenomination.Table = "Laboratories";
            // 
            // txtAddress
            // 
            this.txtAddress.DBReference = "Address";
            this.txtAddress.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtAddress.Location = new System.Drawing.Point(341, 59);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Table = "Laboratories";
            // 
            // txtCIF
            // 
            this.txtCIF.DBReference = "CIF";
            this.txtCIF.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCIF.Location = new System.Drawing.Point(341, 91);
            this.txtCIF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Size = new System.Drawing.Size(132, 22);
            this.txtCIF.TabIndex = 0;
            this.txtCIF.Table = "Laboratories";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(237, 35);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(98, 17);
            this.lblDenomination.TabIndex = 1;
            this.lblDenomination.Text = "Denominacion";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(263, 67);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Direccion";
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(302, 99);
            this.lblCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(28, 17);
            this.lblCIF.TabIndex = 1;
            this.lblCIF.Text = "CIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código postal";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "cp";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma1.Location = new System.Drawing.Point(341, 121);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(132, 22);
            this.txtSigma1.TabIndex = 2;
            this.txtSigma1.Table = "Laboratories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localización";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Location";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Location = new System.Drawing.Point(341, 151);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(132, 22);
            this.txtSigma2.TabIndex = 4;
            this.txtSigma2.Table = "Laboratories";
            // 
            // frmQueryLaboratories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(793, 617);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmQueryLaboratories";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtDenomination;
        private Sigma_Controls.TxtSigma txtCIF;
        private Sigma_Controls.TxtSigma txtAddress;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDenomination;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma2;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtSigma1;
    }
}
