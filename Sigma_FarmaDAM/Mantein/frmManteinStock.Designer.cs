namespace Mantein
{
    partial class frmManteinStock
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
            this.lblIvaType = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSigma3 = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.txtQuantity = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblIvaType);
            this.pnlTextBox.Controls.Add(this.lblBasePrice);
            this.pnlTextBox.Controls.Add(this.lblQuantity);
            this.pnlTextBox.Controls.Add(this.txtSigma3);
            this.pnlTextBox.Controls.Add(this.txtSigma2);
            this.pnlTextBox.Controls.Add(this.txtQuantity);
            this.pnlTextBox.Controls.SetChildIndex(this.txtQuantity, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSigma2, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSigma3, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblQuantity, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblBasePrice, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblIvaType, 0);
            // 
            // lblIvaType
            // 
            this.lblIvaType.AutoSize = true;
            this.lblIvaType.Location = new System.Drawing.Point(359, 108);
            this.lblIvaType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIvaType.Name = "lblIvaType";
            this.lblIvaType.Size = new System.Drawing.Size(65, 17);
            this.lblIvaType.TabIndex = 10;
            this.lblIvaType.Text = "IVA Type";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(350, 76);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(76, 17);
            this.lblBasePrice.TabIndex = 9;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(366, 44);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "iva_type";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma3.Location = new System.Drawing.Point(435, 99);
            this.txtSigma3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Placeholder = null;
            this.txtSigma3.Size = new System.Drawing.Size(132, 22);
            this.txtSigma3.TabIndex = 6;
            this.txtSigma3.Table = "Stock";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Base_Price";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Location = new System.Drawing.Point(435, 67);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Placeholder = null;
            this.txtSigma2.Size = new System.Drawing.Size(132, 22);
            this.txtSigma2.TabIndex = 7;
            this.txtSigma2.Table = "Stock";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DBReference = "Quantity";
            this.txtQuantity.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtQuantity.Location = new System.Drawing.Point(435, 35);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Placeholder = null;
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Table = "Stock";
            // 
            // frmManteinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinStock";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIvaType;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblQuantity;
        private Sigma_Controls.TxtSigma txtSigma3;
        private Sigma_Controls.TxtSigma txtSigma2;
        private Sigma_Controls.TxtSigma txtQuantity;
    }
}
