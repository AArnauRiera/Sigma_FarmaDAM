namespace SearchSystem
{
    partial class frmQueryIVA
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
            this.txtId = new Sigma_Controls.TxtSigma();
            this.txtValue = new Sigma_Controls.TxtSigma();
            this.lblId = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Text = "Busca";
            // 
            // btnSelect
            // 
            this.btnSelect.Text = "Seleccionar";
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblValue);
            this.pnlTB.Controls.Add(this.lblId);
            this.pnlTB.Controls.Add(this.txtValue);
            this.pnlTB.Controls.Add(this.txtId);
            // 
            // txtId
            // 
            this.txtId.DBReference = "id";
            this.txtId.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtId.Location = new System.Drawing.Point(240, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Table = "IVA";
            // 
            // txtValue
            // 
            this.txtValue.DBReference = "value";
            this.txtValue.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtValue.Location = new System.Drawing.Point(240, 79);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 0;
            this.txtValue.Table = "IVA";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(199, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(199, 82);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(31, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Valor";
            // 
            // frmQueryIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryIVA";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtId;
        private Sigma_Controls.TxtSigma txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblId;
    }
}
