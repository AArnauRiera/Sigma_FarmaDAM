namespace Mantein
{
    partial class frmManteinIVA
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtValue = new Sigma_Controls.TxtSigma();
            this.txtId = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblValue);
            this.pnlTextBox.Controls.Add(this.lblId);
            this.pnlTextBox.Controls.Add(this.txtValue);
            this.pnlTextBox.Controls.Add(this.txtId);
            this.pnlTextBox.Controls.SetChildIndex(this.txtId, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtValue, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblId, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblValue, 0);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(365, 89);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 17);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(365, 61);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // txtValue
            // 
            this.txtValue.DBReference = "value";
            this.txtValue.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtValue.Location = new System.Drawing.Point(420, 85);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Placeholder = null;
            this.txtValue.Size = new System.Drawing.Size(132, 22);
            this.txtValue.TabIndex = 2;
            this.txtValue.Table = "IVA";
            // 
            // txtId
            // 
            this.txtId.DBReference = "id";
            this.txtId.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtId.Location = new System.Drawing.Point(420, 53);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Placeholder = null;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 3;
            this.txtId.Table = "IVA";
            // 
            // frmManteinIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinIVA";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblId;
        private Sigma_Controls.TxtSigma txtValue;
        private Sigma_Controls.TxtSigma txtId;
    }
}
