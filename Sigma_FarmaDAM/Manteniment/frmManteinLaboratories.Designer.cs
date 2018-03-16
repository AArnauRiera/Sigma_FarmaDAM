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
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.label2);
            this.pnlTextBox.Controls.Add(this.label1);
            this.pnlTextBox.Controls.Add(this.txtSigma2);
            this.pnlTextBox.Controls.Add(this.txtSigma1);
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
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(-21, 7);
            this.pnlMantein.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(4, 71);
            this.lblCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(34, 23);
            this.lblCIF.TabIndex = 5;
            this.lblCIF.Text = "CIF";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 39);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Dirección";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(4, 5);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(73, 23);
            this.lblDenomination.TabIndex = 7;
            this.lblDenomination.Text = "Nombre";
            // 
            // txtCIF
            // 
            this.txtCIF.DBReference = "CIF";
            this.txtCIF.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIF.ForeColor = System.Drawing.Color.Black;
            this.txtCIF.Location = new System.Drawing.Point(219, 74);
            this.txtCIF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Size = new System.Drawing.Size(148, 23);
            this.txtCIF.TabIndex = 6;
            this.txtCIF.Table = "Laboratories";
            // 
            // txtAddress
            // 
            this.txtAddress.DBReference = "Address";
            this.txtAddress.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(219, 40);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 23);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Table = "Laboratories";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "LabName";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomination.ForeColor = System.Drawing.Color.Black;
            this.txtDenomination.Location = new System.Drawing.Point(219, 6);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(148, 23);
            this.txtDenomination.TabIndex = 4;
            this.txtDenomination.Table = "Laboratories";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "cp";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma1.ForeColor = System.Drawing.Color.Black;
            this.txtSigma1.Location = new System.Drawing.Point(219, 109);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(148, 23);
            this.txtSigma1.TabIndex = 8;
            this.txtSigma1.Table = "Laboratories";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Location";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma2.ForeColor = System.Drawing.Color.Black;
            this.txtSigma2.Location = new System.Drawing.Point(219, 144);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(148, 23);
            this.txtSigma2.TabIndex = 9;
            this.txtSigma2.Table = "Laboratories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Localización";
            // 
            // frmManteinLaboratories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmManteinLaboratories";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDenomination;
        private Sigma_Controls.TxtSigma txtCIF;
        private Sigma_Controls.TxtSigma txtAddress;
        private Sigma_Controls.TxtSigma txtDenomination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtSigma2;
        private Sigma_Controls.TxtSigma txtSigma1;
    }
}
