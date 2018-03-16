namespace Manteniment
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
            this.components = new System.ComponentModel.Container();
            this.lblIvaType = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSigma3 = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.txtQuantity = new Sigma_Controls.TxtSigma();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(-14, 6);
            // 
            // lblIvaType
            // 
            this.lblIvaType.AutoSize = true;
            this.lblIvaType.Location = new System.Drawing.Point(4, 61);
            this.lblIvaType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIvaType.Name = "lblIvaType";
            this.lblIvaType.Size = new System.Drawing.Size(60, 19);
            this.lblIvaType.TabIndex = 10;
            this.lblIvaType.Text = "Tipo IVA";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(4, 32);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(78, 19);
            this.lblBasePrice.TabIndex = 9;
            this.lblBasePrice.Text = "Precio base";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(4, 5);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 19);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Cantidad";
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "iva_type";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtSigma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtSigma3.ForeColor = System.Drawing.Color.Gray;
            this.txtSigma3.Location = new System.Drawing.Point(195, 61);
            this.txtSigma3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Size = new System.Drawing.Size(132, 19);
            this.txtSigma3.TabIndex = 6;
            this.txtSigma3.Table = "Stock";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Base_Price";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Double;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtSigma2.ForeColor = System.Drawing.Color.Gray;
            this.txtSigma2.Location = new System.Drawing.Point(195, 33);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(132, 19);
            this.txtSigma2.TabIndex = 7;
            this.txtSigma2.Table = "Stock";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DBReference = "Quantity";
            this.txtQuantity.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtQuantity.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.Location = new System.Drawing.Point(195, 5);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 19);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Table = "Stock";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmManteinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinStock";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIvaType;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblQuantity;
        private Sigma_Controls.TxtSigma txtSigma3;
        private Sigma_Controls.TxtSigma txtSigma2;
        private Sigma_Controls.TxtSigma txtQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
