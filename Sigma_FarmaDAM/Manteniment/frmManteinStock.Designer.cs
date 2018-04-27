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
            this.cbxSigma1 = new Sigma_Controls.cbxSigma();
            this.cbxSigma2 = new Sigma_Controls.cbxSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.cbxSigma2);
            this.pnlTextBox.Controls.Add(this.cbxSigma1);
            this.pnlTextBox.Controls.Add(this.lblIvaType);
            this.pnlTextBox.Controls.Add(this.lblBasePrice);
            this.pnlTextBox.Controls.Add(this.lblQuantity);
            this.pnlTextBox.Controls.Add(this.txtSigma3);
            this.pnlTextBox.Controls.Add(this.txtSigma2);
            this.pnlTextBox.Controls.Add(this.txtQuantity);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(-14, 6);
            // 
            // lblIvaType
            // 
            this.lblIvaType.AutoSize = true;
            this.lblIvaType.Location = new System.Drawing.Point(4, 66);
            this.lblIvaType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIvaType.Name = "lblIvaType";
            this.lblIvaType.Size = new System.Drawing.Size(109, 19);
            this.lblIvaType.TabIndex = 10;
            this.lblIvaType.Text = "Id Medicamento";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(4, 4);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(96, 19);
            this.lblBasePrice.TabIndex = 9;
            this.lblBasePrice.Text = "Id Laboratorio";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(4, 38);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 19);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Cantidad";
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "ID_Drug";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSigma3.ForeColor = System.Drawing.Color.Black;
            this.txtSigma3.IsForeginKey = true;
            this.txtSigma3.Location = new System.Drawing.Point(164, 61);
            this.txtSigma3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Size = new System.Drawing.Size(23, 20);
            this.txtSigma3.TabIndex = 2;
            this.txtSigma3.Table = "Stock";
            this.txtSigma3.Visible = false;
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Id_lab";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSigma2.ForeColor = System.Drawing.Color.Black;
            this.txtSigma2.IsForeginKey = true;
            this.txtSigma2.Location = new System.Drawing.Point(164, 5);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(23, 20);
            this.txtSigma2.TabIndex = 0;
            this.txtSigma2.Table = "Stock";
            this.txtSigma2.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DBReference = "Quantity";
            this.txtQuantity.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.IsForeginKey = false;
            this.txtQuantity.Location = new System.Drawing.Point(195, 38);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Table = "Stock";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cbxSigma1
            // 
            this.cbxSigma1.DBReference = "Id_lab";
            this.cbxSigma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigma1.ForeginData = "LabName";
            this.cbxSigma1.ForeginTable = "Laboratories";
            this.cbxSigma1.ForeginValue = null;
            this.cbxSigma1.FormattingEnabled = true;
            this.cbxSigma1.Location = new System.Drawing.Point(195, 3);
            this.cbxSigma1.Name = "cbxSigma1";
            this.cbxSigma1.Size = new System.Drawing.Size(132, 27);
            this.cbxSigma1.TabIndex = 11;
            // 
            // cbxSigma2
            // 
            this.cbxSigma2.DBReference = "ID_Drug";
            this.cbxSigma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigma2.ForeginData = "CommercialName";
            this.cbxSigma2.ForeginTable = "Drugs";
            this.cbxSigma2.ForeginValue = null;
            this.cbxSigma2.FormattingEnabled = true;
            this.cbxSigma2.Location = new System.Drawing.Point(195, 67);
            this.cbxSigma2.Name = "cbxSigma2";
            this.cbxSigma2.Size = new System.Drawing.Size(132, 27);
            this.cbxSigma2.TabIndex = 12;
            // 
            // frmManteinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinStock";
            this.Text = "0";
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
        private Sigma_Controls.cbxSigma cbxSigma2;
        private Sigma_Controls.cbxSigma cbxSigma1;
    }
}
