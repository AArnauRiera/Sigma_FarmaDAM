namespace Mantein
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
            this.lblIdStock = new System.Windows.Forms.Label();
            this.lblIdLaboratories = new System.Windows.Forms.Label();
            this.txtId_Stock = new Sigma_Controls.TxtSigma();
            this.txtIdLaboratories = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblIdStock);
            this.pnlTextBox.Controls.Add(this.lblIdLaboratories);
            this.pnlTextBox.Controls.Add(this.txtId_Stock);
            this.pnlTextBox.Controls.Add(this.txtIdLaboratories);
            this.pnlTextBox.Controls.SetChildIndex(this.txtIdLaboratories, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtId_Stock, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblIdLaboratories, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblIdStock, 0);
            // 
            // lblIdStock
            // 
            this.lblIdStock.AutoSize = true;
            this.lblIdStock.Location = new System.Drawing.Point(377, 89);
            this.lblIdStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdStock.Name = "lblIdStock";
            this.lblIdStock.Size = new System.Drawing.Size(58, 17);
            this.lblIdStock.TabIndex = 4;
            this.lblIdStock.Text = "Id Stock";
            // 
            // lblIdLaboratories
            // 
            this.lblIdLaboratories.AutoSize = true;
            this.lblIdLaboratories.Location = new System.Drawing.Point(337, 57);
            this.lblIdLaboratories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdLaboratories.Name = "lblIdLaboratories";
            this.lblIdLaboratories.Size = new System.Drawing.Size(103, 17);
            this.lblIdLaboratories.TabIndex = 5;
            this.lblIdLaboratories.Text = "Id Laboratories";
            // 
            // txtId_Stock
            // 
            this.txtId_Stock.DBReference = "id_stock";
            this.txtId_Stock.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtId_Stock.Location = new System.Drawing.Point(448, 85);
            this.txtId_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Stock.Name = "txtId_Stock";
            this.txtId_Stock.Placeholder = null;
            this.txtId_Stock.Size = new System.Drawing.Size(132, 22);
            this.txtId_Stock.TabIndex = 2;
            this.txtId_Stock.Table = "Providers";
            // 
            // txtIdLaboratories
            // 
            this.txtIdLaboratories.DBReference = "id_laboratories";
            this.txtIdLaboratories.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdLaboratories.Location = new System.Drawing.Point(448, 53);
            this.txtIdLaboratories.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdLaboratories.Name = "txtIdLaboratories";
            this.txtIdLaboratories.Placeholder = null;
            this.txtIdLaboratories.Size = new System.Drawing.Size(132, 22);
            this.txtIdLaboratories.TabIndex = 3;
            this.txtIdLaboratories.Table = "Providers";
            // 
            // frmManteinProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinProviders";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdStock;
        private System.Windows.Forms.Label lblIdLaboratories;
        private Sigma_Controls.TxtSigma txtId_Stock;
        private Sigma_Controls.TxtSigma txtIdLaboratories;
    }
}
