namespace Manteniment
{
    partial class frmManteinProviders
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
            this.lblIdStock = new System.Windows.Forms.Label();
            this.lblIdLaboratories = new System.Windows.Forms.Label();
            this.txtId_Stock = new Sigma_Controls.TxtSigma();
            this.txtIdLaboratories = new Sigma_Controls.TxtSigma();
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
            this.pnlTextBox.Controls.Add(this.lblIdStock);
            this.pnlTextBox.Controls.Add(this.lblIdLaboratories);
            this.pnlTextBox.Controls.Add(this.txtId_Stock);
            this.pnlTextBox.Controls.Add(this.txtIdLaboratories);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(1, 6);
            // 
            // lblIdStock
            // 
            this.lblIdStock.AutoSize = true;
            this.lblIdStock.Location = new System.Drawing.Point(4, 31);
            this.lblIdStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdStock.Name = "lblIdStock";
            this.lblIdStock.Size = new System.Drawing.Size(58, 19);
            this.lblIdStock.TabIndex = 4;
            this.lblIdStock.Text = "Id Stock";
            // 
            // lblIdLaboratories
            // 
            this.lblIdLaboratories.AutoSize = true;
            this.lblIdLaboratories.Location = new System.Drawing.Point(4, 3);
            this.lblIdLaboratories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdLaboratories.Name = "lblIdLaboratories";
            this.lblIdLaboratories.Size = new System.Drawing.Size(102, 19);
            this.lblIdLaboratories.TabIndex = 5;
            this.lblIdLaboratories.Text = "Id Laboratorios";
            // 
            // txtId_Stock
            // 
            this.txtId_Stock.DBReference = "id_stock";
            this.txtId_Stock.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtId_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtId_Stock.ForeColor = System.Drawing.Color.Gray;
            this.txtId_Stock.Location = new System.Drawing.Point(195, 33);
            this.txtId_Stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId_Stock.Name = "txtId_Stock";
            this.txtId_Stock.Size = new System.Drawing.Size(132, 19);
            this.txtId_Stock.TabIndex = 2;
            this.txtId_Stock.Table = "Providers";
            this.txtId_Stock.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtId_Stock.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtIdLaboratories
            // 
            this.txtIdLaboratories.DBReference = "id_laboratories";
            this.txtIdLaboratories.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtIdLaboratories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtIdLaboratories.ForeColor = System.Drawing.Color.Gray;
            this.txtIdLaboratories.Location = new System.Drawing.Point(195, 5);
            this.txtIdLaboratories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdLaboratories.Name = "txtIdLaboratories";
            this.txtIdLaboratories.Size = new System.Drawing.Size(132, 19);
            this.txtIdLaboratories.TabIndex = 3;
            this.txtIdLaboratories.Table = "Providers";
            this.txtIdLaboratories.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtIdLaboratories.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmManteinProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinProviders";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdStock;
        private System.Windows.Forms.Label lblIdLaboratories;
        private Sigma_Controls.TxtSigma txtId_Stock;
        private Sigma_Controls.TxtSigma txtIdLaboratories;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
