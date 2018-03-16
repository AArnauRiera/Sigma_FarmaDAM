namespace SearchSystem
{
    partial class frmQueryActivePrinciple
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
            this.components = new System.ComponentModel.Container();
            this.txtSRN = new Sigma_Controls.TxtSigma();
            this.txtName = new Sigma_Controls.TxtSigma();
            this.lblSRN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Text = "Selccionar";
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblName);
            this.pnlTB.Controls.Add(this.lblSRN);
            this.pnlTB.Controls.Add(this.txtName);
            this.pnlTB.Controls.Add(this.txtSRN);
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Number";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.RN_AP;
            this.txtSRN.Location = new System.Drawing.Point(243, 59);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(100, 20);
            this.txtSRN.TabIndex = 0;
            this.txtSRN.Table = "Active_Principles";
            // 
            // txtName
            // 
            this.txtName.DBReference = "Name";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtName.Location = new System.Drawing.Point(243, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Table = "Active_Principles";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(202, 62);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(30, 13);
            this.lblSRN.TabIndex = 1;
            this.lblSRN.Text = "SRN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(195, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmQueryActivePrinciple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryActivePrinciple";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtSRN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSRN;
        private Sigma_Controls.TxtSigma txtName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
