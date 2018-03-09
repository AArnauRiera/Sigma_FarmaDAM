namespace Manteniment
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
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblValue);
            this.pnlTextBox.Controls.Add(this.lblId);
            this.pnlTextBox.Controls.Add(this.txtValue);
            this.pnlTextBox.Controls.Add(this.txtId);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(4, 40);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(52, 23);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 6);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 23);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // txtValue
            // 
            this.txtValue.DBReference = "value";
            this.txtValue.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtValue.ForeColor = System.Drawing.Color.Gray;
            this.txtValue.Location = new System.Drawing.Point(219, 40);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(148, 22);
            this.txtValue.TabIndex = 2;
            this.txtValue.Table = "IVA";
            // 
            // txtId
            // 
            this.txtId.DBReference = "id";
            this.txtId.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.Location = new System.Drawing.Point(219, 6);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 22);
            this.txtId.TabIndex = 3;
            this.txtId.Table = "IVA";
            // 
            // frmManteinIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmManteinIVA";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblId;
        private Sigma_Controls.TxtSigma txtValue;
        private Sigma_Controls.TxtSigma txtId;
    }
}
