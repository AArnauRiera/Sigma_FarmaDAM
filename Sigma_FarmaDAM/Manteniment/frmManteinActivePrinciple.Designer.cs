namespace Manteniment
{
    partial class frmManteinActivePrinciple
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSRN = new System.Windows.Forms.Label();
            this.txtName = new Sigma_Controls.TxtSigma();
            this.txtSRN = new Sigma_Controls.TxtSigma();
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
            this.pnlTextBox.Controls.Add(this.lblName);
            this.pnlTextBox.Controls.Add(this.lblSRN);
            this.pnlTextBox.Controls.Add(this.txtName);
            this.pnlTextBox.Controls.Add(this.txtSRN);
            // 
            // btnQuery
            // 
            this.btnQuery.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnGet
            // 
            this.btnGet.TabIndex = 2;
            // 
            // bntNew
            // 
            this.bntNew.TabIndex = 5;
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(15, 6);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(4, 4);
            this.lblSRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(34, 19);
            this.lblSRN.TabIndex = 5;
            this.lblSRN.Text = "SRN";
            // 
            // txtName
            // 
            this.txtName.DBReference = "Name";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(195, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Table = "Active_Principles";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Number";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSRN.ForeColor = System.Drawing.Color.Black;
            this.txtSRN.Location = new System.Drawing.Point(195, 4);
            this.txtSRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(132, 20);
            this.txtSRN.TabIndex = 0;
            this.txtSRN.Table = "Active_Principles";
            this.txtSRN.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtSRN.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmManteinActivePrinciple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(1011, 749);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmManteinActivePrinciple";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSRN;
        private Sigma_Controls.TxtSigma txtName;
        private Sigma_Controls.TxtSigma txtSRN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
