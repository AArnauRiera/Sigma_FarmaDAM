namespace Mantein
{
    partial class frmManteinDrugs
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
            this.lblProspectus = new System.Windows.Forms.Label();
            this.lblDocumentation = new System.Windows.Forms.Label();
            this.lblObligatory = new System.Windows.Forms.Label();
            this.lblGeneric = new System.Windows.Forms.Label();
            this.lblReplaceable = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblIdActive = new System.Windows.Forms.Label();
            this.lblDenomination = new System.Windows.Forms.Label();
            this.lblSRN = new System.Windows.Forms.Label();
            this.txtDocumentation = new Sigma_Controls.TxtSigma();
            this.txtReplaceable = new Sigma_Controls.TxtSigma();
            this.txtObligatory = new Sigma_Controls.TxtSigma();
            this.txtIdActive = new Sigma_Controls.TxtSigma();
            this.txtProspectus = new Sigma_Controls.TxtSigma();
            this.txtDenomination = new Sigma_Controls.TxtSigma();
            this.txtGeneric = new Sigma_Controls.TxtSigma();
            this.txtContent = new Sigma_Controls.TxtSigma();
            this.txtSRN = new Sigma_Controls.TxtSigma();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblProspectus);
            this.pnlTextBox.Controls.Add(this.lblDocumentation);
            this.pnlTextBox.Controls.Add(this.lblObligatory);
            this.pnlTextBox.Controls.Add(this.lblGeneric);
            this.pnlTextBox.Controls.Add(this.lblReplaceable);
            this.pnlTextBox.Controls.Add(this.lblContent);
            this.pnlTextBox.Controls.Add(this.lblIdActive);
            this.pnlTextBox.Controls.Add(this.lblDenomination);
            this.pnlTextBox.Controls.Add(this.lblSRN);
            this.pnlTextBox.Controls.Add(this.txtDocumentation);
            this.pnlTextBox.Controls.Add(this.txtReplaceable);
            this.pnlTextBox.Controls.Add(this.txtObligatory);
            this.pnlTextBox.Controls.Add(this.txtIdActive);
            this.pnlTextBox.Controls.Add(this.txtProspectus);
            this.pnlTextBox.Controls.Add(this.txtDenomination);
            this.pnlTextBox.Controls.Add(this.txtGeneric);
            this.pnlTextBox.Controls.Add(this.txtContent);
            this.pnlTextBox.Controls.Add(this.txtSRN);
            this.pnlTextBox.Controls.SetChildIndex(this.btnQuery, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtSRN, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtContent, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtGeneric, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtDenomination, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtProspectus, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtIdActive, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtObligatory, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtReplaceable, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.txtDocumentation, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblSRN, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblDenomination, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblIdActive, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblContent, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblReplaceable, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblGeneric, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblObligatory, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblDocumentation, 0);
            this.pnlTextBox.Controls.SetChildIndex(this.lblProspectus, 0);
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(362, 84);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(60, 13);
            this.lblProspectus.TabIndex = 34;
            this.lblProspectus.Text = "Prospectus";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(346, 58);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(79, 13);
            this.lblDocumentation.TabIndex = 33;
            this.lblDocumentation.Text = "Documentation";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(353, 32);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(72, 13);
            this.lblObligatory.TabIndex = 32;
            this.lblObligatory.Text = "NeedsRecipe";
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(378, 8);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(44, 13);
            this.lblGeneric.TabIndex = 31;
            this.lblGeneric.Text = "Generic";
            // 
            // lblReplaceable
            // 
            this.lblReplaceable.AutoSize = true;
            this.lblReplaceable.Location = new System.Drawing.Point(166, 112);
            this.lblReplaceable.Name = "lblReplaceable";
            this.lblReplaceable.Size = new System.Drawing.Size(67, 13);
            this.lblReplaceable.TabIndex = 30;
            this.lblReplaceable.Text = "Replaceable";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(189, 84);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 13);
            this.lblContent.TabIndex = 35;
            this.lblContent.Text = "Content";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(184, 58);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(49, 13);
            this.lblIdActive.TabIndex = 36;
            this.lblIdActive.Text = "Id Active";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(160, 36);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(72, 13);
            this.lblDenomination.TabIndex = 29;
            this.lblDenomination.Text = "Denomination";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(202, 6);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(30, 13);
            this.lblSRN.TabIndex = 28;
            this.lblSRN.Text = "SRN";
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDocumentation.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentation.Location = new System.Drawing.Point(428, 58);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Placeholder = null;
            this.txtDocumentation.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentation.TabIndex = 26;
            this.txtDocumentation.Table = "Drugs";
            // 
            // txtReplaceable
            // 
            this.txtReplaceable.DBReference = "Replaceable";
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtReplaceable.ForeColor = System.Drawing.Color.Gray;
            this.txtReplaceable.Location = new System.Drawing.Point(241, 110);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Placeholder = null;
            this.txtReplaceable.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceable.TabIndex = 27;
            this.txtReplaceable.Table = "Drugs";
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "NeedsRecipe";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtObligatory.ForeColor = System.Drawing.Color.Gray;
            this.txtObligatory.Location = new System.Drawing.Point(428, 32);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Placeholder = null;
            this.txtObligatory.Size = new System.Drawing.Size(100, 20);
            this.txtObligatory.TabIndex = 24;
            this.txtObligatory.Table = "Drugs";
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "id_active";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtIdActive.ForeColor = System.Drawing.Color.Gray;
            this.txtIdActive.Location = new System.Drawing.Point(241, 54);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Placeholder = null;
            this.txtIdActive.Size = new System.Drawing.Size(100, 20);
            this.txtIdActive.TabIndex = 25;
            this.txtIdActive.Table = "Drugs";
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtProspectus.ForeColor = System.Drawing.Color.Gray;
            this.txtProspectus.Location = new System.Drawing.Point(428, 84);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Placeholder = null;
            this.txtProspectus.Size = new System.Drawing.Size(100, 20);
            this.txtProspectus.TabIndex = 21;
            this.txtProspectus.Table = "Drugs";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "CommercialName";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDenomination.ForeColor = System.Drawing.Color.Gray;
            this.txtDenomination.Location = new System.Drawing.Point(241, 28);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Placeholder = null;
            this.txtDenomination.Size = new System.Drawing.Size(100, 20);
            this.txtDenomination.TabIndex = 23;
            this.txtDenomination.Table = "Drugs";
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "IsGeneric";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtGeneric.ForeColor = System.Drawing.Color.Gray;
            this.txtGeneric.Location = new System.Drawing.Point(428, 6);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Placeholder = null;
            this.txtGeneric.Size = new System.Drawing.Size(100, 20);
            this.txtGeneric.TabIndex = 20;
            this.txtGeneric.Table = "Drugs";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtContent.ForeColor = System.Drawing.Color.Gray;
            this.txtContent.Location = new System.Drawing.Point(241, 80);
            this.txtContent.Name = "txtContent";
            this.txtContent.Placeholder = null;
            this.txtContent.Size = new System.Drawing.Size(100, 20);
            this.txtContent.TabIndex = 22;
            this.txtContent.Table = "Drugs";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSRN.ForeColor = System.Drawing.Color.Gray;
            this.txtSRN.Location = new System.Drawing.Point(241, 2);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Placeholder = null;
            this.txtSRN.Size = new System.Drawing.Size(100, 20);
            this.txtSRN.TabIndex = 19;
            this.txtSRN.Table = "Drugs";
            // 
            // frmManteinDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManteinDrugs";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProspectus;
        private System.Windows.Forms.Label lblDocumentation;
        private System.Windows.Forms.Label lblObligatory;
        private System.Windows.Forms.Label lblGeneric;
        private System.Windows.Forms.Label lblReplaceable;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblIdActive;
        private System.Windows.Forms.Label lblDenomination;
        private System.Windows.Forms.Label lblSRN;
        private Sigma_Controls.TxtSigma txtDocumentation;
        private Sigma_Controls.TxtSigma txtReplaceable;
        private Sigma_Controls.TxtSigma txtObligatory;
        private Sigma_Controls.TxtSigma txtIdActive;
        private Sigma_Controls.TxtSigma txtProspectus;
        private Sigma_Controls.TxtSigma txtDenomination;
        private Sigma_Controls.TxtSigma txtGeneric;
        private Sigma_Controls.TxtSigma txtContent;
        private Sigma_Controls.TxtSigma txtSRN;
    }
}
