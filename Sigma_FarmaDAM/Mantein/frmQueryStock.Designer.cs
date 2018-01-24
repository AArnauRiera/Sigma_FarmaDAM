namespace Mantein
{
    partial class frmQueryStock
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
            this.txtQuantity = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.txtSigma3 = new Sigma_Controls.TxtSigma();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblIvaType = new System.Windows.Forms.Label();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblIvaType);
            this.pnlTB.Controls.Add(this.lblBasePrice);
            this.pnlTB.Controls.Add(this.lblQuantity);
            this.pnlTB.Controls.Add(this.txtSigma3);
            this.pnlTB.Controls.Add(this.txtSigma2);
            this.pnlTB.Controls.Add(this.txtQuantity);
            // 
            // txtQuantity
            // 
            this.txtQuantity.DBReference = "Quantity";
            this.txtQuantity.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtQuantity.Location = new System.Drawing.Point(243, 36);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Placeholder = null;
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Table = "Stock";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Base_Price";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Location = new System.Drawing.Point(243, 62);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Placeholder = null;
            this.txtSigma2.Size = new System.Drawing.Size(100, 20);
            this.txtSigma2.TabIndex = 1;
            this.txtSigma2.Table = "Stock";
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "iva_type";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma3.Location = new System.Drawing.Point(243, 88);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Placeholder = null;
            this.txtSigma3.Size = new System.Drawing.Size(100, 20);
            this.txtSigma3.TabIndex = 1;
            this.txtSigma3.Table = "Stock";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(191, 43);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(179, 69);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(58, 13);
            this.lblBasePrice.TabIndex = 3;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblIvaType
            // 
            this.lblIvaType.AutoSize = true;
            this.lblIvaType.Location = new System.Drawing.Point(186, 95);
            this.lblIvaType.Name = "lblIvaType";
            this.lblIvaType.Size = new System.Drawing.Size(51, 13);
            this.lblIvaType.TabIndex = 4;
            this.lblIvaType.Text = "IVA Type";
            // 
            // frmQueryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryStock";
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtQuantity;
        private Sigma_Controls.TxtSigma txtSigma3;
        private Sigma_Controls.TxtSigma txtSigma2;
        private System.Windows.Forms.Label lblIvaType;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblQuantity;
    }
}
