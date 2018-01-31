namespace UserManagement
{
    partial class frmUserManagement
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
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = null;
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Password;
            this.txtSigma1.Location = new System.Drawing.Point(183, 68);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(100, 20);
            this.txtSigma1.TabIndex = 1;
            this.txtSigma1.TextChanged += new System.EventHandler(this.txtSigma1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSigma1);
            this.Name = "frmUserManagement";
            this.Text = "User Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sigma_Controls.TxtSigma txtSigma1;
        private System.Windows.Forms.Label label1;
    }
}

