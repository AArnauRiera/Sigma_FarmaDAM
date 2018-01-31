namespace Mantein
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSRN = new System.Windows.Forms.Label();
            this.txtName = new Sigma_Controls.TxtSigma();
            this.txtSRN = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.label1);
            this.pnlTextBox.Controls.Add(this.label2);
            this.pnlTextBox.Controls.Add(this.txtSigma1);
            this.pnlTextBox.Controls.Add(this.txtSigma2);
            this.pnlTextBox.Controls.Add(this.lblName);
            this.pnlTextBox.Controls.Add(this.lblSRN);
            this.pnlTextBox.Controls.Add(this.txtName);
            this.pnlTextBox.Controls.Add(this.txtSRN);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSRN, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtName, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblSRN, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblName, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSigma2, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSigma1, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.label2, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.label1, 0);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(365, 88);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(365, 56);
            this.lblSRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(37, 17);
            this.lblSRN.TabIndex = 5;
            this.lblSRN.Text = "SRN";
            // 
            // txtName
            // 
            this.txtName.DBReference = "Name";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtName.Location = new System.Drawing.Point(420, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = null;
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Table = "Active_Principles";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Number";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSRN.Location = new System.Drawing.Point(420, 53);
            this.txtSRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Placeholder = null;
            this.txtSRN.Size = new System.Drawing.Size(132, 22);
            this.txtSRN.TabIndex = 3;
            this.txtSRN.Table = "Active_Principles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "SRN";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "Name";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma1.Location = new System.Drawing.Point(428, 93);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Placeholder = null;
            this.txtSigma1.Size = new System.Drawing.Size(132, 22);
            this.txtSigma1.TabIndex = 6;
            this.txtSigma1.Table = "Active_Principles";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "Sanitary_Register_Number";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Location = new System.Drawing.Point(428, 61);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Placeholder = null;
            this.txtSigma2.Size = new System.Drawing.Size(132, 22);
            this.txtSigma2.TabIndex = 7;
            this.txtSigma2.Table = "Active_Principles";
            // 
            // frmManteinActivePrinciple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Name = "frmManteinActivePrinciple";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSRN;
        private Sigma_Controls.TxtSigma txtName;
        private Sigma_Controls.TxtSigma txtSRN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma1;
        private Sigma_Controls.TxtSigma txtSigma2;
    }
}
