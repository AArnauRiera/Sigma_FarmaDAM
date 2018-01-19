namespace Mantein
{
    partial class frmQueryProviders
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
            this.txtIdLaboratories = new Sigma_Controls.TxtSigma();
            this.txtId_Stock = new Sigma_Controls.TxtSigma();
            this.lblIdLaboratories = new System.Windows.Forms.Label();
            this.lblIdStock = new System.Windows.Forms.Label();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblIdStock);
            this.pnlTB.Controls.Add(this.lblIdLaboratories);
            this.pnlTB.Controls.Add(this.txtId_Stock);
            this.pnlTB.Controls.Add(this.txtIdLaboratories);
            // 
            // txtIdLaboratories
            // 
            this.txtIdLaboratories.DBReference = "id_laboratories";
            this.txtIdLaboratories.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdLaboratories.Location = new System.Drawing.Point(257, 54);
            this.txtIdLaboratories.Name = "txtIdLaboratories";
            this.txtIdLaboratories.Placeholder = null;
            this.txtIdLaboratories.Size = new System.Drawing.Size(100, 20);
            this.txtIdLaboratories.TabIndex = 0;
            this.txtIdLaboratories.Table = "Providers";
            // 
            // txtId_Stock
            // 
            this.txtId_Stock.DBReference = "id_stock";
            this.txtId_Stock.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtId_Stock.Location = new System.Drawing.Point(257, 80);
            this.txtId_Stock.Name = "txtId_Stock";
            this.txtId_Stock.Placeholder = null;
            this.txtId_Stock.Size = new System.Drawing.Size(100, 20);
            this.txtId_Stock.TabIndex = 0;
            this.txtId_Stock.Table = "Providers";
            // 
            // lblIdLaboratories
            // 
            this.lblIdLaboratories.AutoSize = true;
            this.lblIdLaboratories.Location = new System.Drawing.Point(174, 57);
            this.lblIdLaboratories.Name = "lblIdLaboratories";
            this.lblIdLaboratories.Size = new System.Drawing.Size(77, 13);
            this.lblIdLaboratories.TabIndex = 1;
            this.lblIdLaboratories.Text = "Id Laboratories";
            // 
            // lblIdStock
            // 
            this.lblIdStock.AutoSize = true;
            this.lblIdStock.Location = new System.Drawing.Point(204, 83);
            this.lblIdStock.Name = "lblIdStock";
            this.lblIdStock.Size = new System.Drawing.Size(47, 13);
            this.lblIdStock.TabIndex = 1;
            this.lblIdStock.Text = "Id Stock";
            // 
            // frmQueryProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryProviders";
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtIdLaboratories;
        private System.Windows.Forms.Label lblIdStock;
        private System.Windows.Forms.Label lblIdLaboratories;
        private Sigma_Controls.TxtSigma txtId_Stock;
    }
}
