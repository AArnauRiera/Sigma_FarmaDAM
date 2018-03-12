namespace SearchSystem
{
    partial class frmQueryDrugs
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
            this.lblReplaceable = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblIdActive = new System.Windows.Forms.Label();
            this.lblDenomination = new System.Windows.Forms.Label();
            this.lblSRN = new System.Windows.Forms.Label();
            this.txtReplaceable = new Sigma_Controls.TxtSigma();
            this.txtIdActive = new Sigma_Controls.TxtSigma();
            this.txtDenomination = new Sigma_Controls.TxtSigma();
            this.txtContent = new Sigma_Controls.TxtSigma();
            this.txtSRN = new Sigma_Controls.TxtSigma();
            this.lblGeneric = new System.Windows.Forms.Label();
            this.lblObligatory = new System.Windows.Forms.Label();
            this.lblDocumentation = new System.Windows.Forms.Label();
            this.lblProspectus = new System.Windows.Forms.Label();
            this.txtGeneric = new Sigma_Controls.TxtSigma();
            this.txtProspectus = new Sigma_Controls.TxtSigma();
            this.txtObligatory = new Sigma_Controls.TxtSigma();
            this.txtDocumentation = new Sigma_Controls.TxtSigma();
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblProspectus);
            this.pnlTB.Controls.Add(this.lblDocumentation);
            this.pnlTB.Controls.Add(this.lblObligatory);
            this.pnlTB.Controls.Add(this.lblGeneric);
            this.pnlTB.Controls.Add(this.lblReplaceable);
            this.pnlTB.Controls.Add(this.lblContent);
            this.pnlTB.Controls.Add(this.lblIdActive);
            this.pnlTB.Controls.Add(this.lblDenomination);
            this.pnlTB.Controls.Add(this.lblSRN);
            this.pnlTB.Controls.Add(this.txtDocumentation);
            this.pnlTB.Controls.Add(this.txtReplaceable);
            this.pnlTB.Controls.Add(this.txtObligatory);
            this.pnlTB.Controls.Add(this.txtIdActive);
            this.pnlTB.Controls.Add(this.txtProspectus);
            this.pnlTB.Controls.Add(this.txtDenomination);
            this.pnlTB.Controls.Add(this.txtGeneric);
            this.pnlTB.Controls.Add(this.txtContent);
            this.pnlTB.Controls.Add(this.txtSRN);
            // 
            // lblReplaceable
            // 
            this.lblReplaceable.AutoSize = true;
            this.lblReplaceable.Location = new System.Drawing.Point(129, 127);
            this.lblReplaceable.Name = "lblReplaceable";
            this.lblReplaceable.Size = new System.Drawing.Size(68, 13);
            this.lblReplaceable.TabIndex = 16;
            this.lblReplaceable.Text = "Remplazable";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(144, 98);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(55, 13);
            this.lblContent.TabIndex = 17;
            this.lblContent.Text = "Contenido";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(147, 72);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(49, 13);
            this.lblIdActive.TabIndex = 18;
            this.lblIdActive.Text = "Id Active";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(124, 50);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(75, 13);
            this.lblDenomination.TabIndex = 15;
            this.lblDenomination.Text = "Denominacion";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(166, 20);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(30, 13);
            this.lblSRN.TabIndex = 14;
            this.lblSRN.Text = "SRN";
            // 
            // txtReplaceable
            // 
            this.txtReplaceable.DBReference = "Replaceable";
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtReplaceable.ForeColor = System.Drawing.Color.Gray;
            this.txtReplaceable.Location = new System.Drawing.Point(204, 124);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceable.TabIndex = 13;
            this.txtReplaceable.Table = "Drugs";
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "id_active";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtIdActive.ForeColor = System.Drawing.Color.Gray;
            this.txtIdActive.Location = new System.Drawing.Point(204, 69);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Size = new System.Drawing.Size(100, 20);
            this.txtIdActive.TabIndex = 12;
            this.txtIdActive.Table = "Drugs";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDenomination.ForeColor = System.Drawing.Color.Gray;
            this.txtDenomination.Location = new System.Drawing.Point(204, 43);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(100, 20);
            this.txtDenomination.TabIndex = 11;
            this.txtDenomination.Table = "Drugs";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtContent.ForeColor = System.Drawing.Color.Gray;
            this.txtContent.Location = new System.Drawing.Point(204, 95);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(100, 20);
            this.txtContent.TabIndex = 10;
            this.txtContent.Table = "Drugs";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSRN.ForeColor = System.Drawing.Color.Gray;
            this.txtSRN.Location = new System.Drawing.Point(204, 17);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(100, 20);
            this.txtSRN.TabIndex = 9;
            this.txtSRN.Table = "Drugs";
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(341, 23);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(50, 13);
            this.lblGeneric.TabIndex = 16;
            this.lblGeneric.Text = "Generico";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(331, 46);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(57, 13);
            this.lblObligatory.TabIndex = 16;
            this.lblObligatory.Text = "Obligatorio";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(306, 72);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(82, 13);
            this.lblDocumentation.TabIndex = 16;
            this.lblDocumentation.Text = "Documentacion";
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(325, 98);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(60, 13);
            this.lblProspectus.TabIndex = 16;
            this.lblProspectus.Text = "Prospectos";
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "Generic";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtGeneric.ForeColor = System.Drawing.Color.Gray;
            this.txtGeneric.Location = new System.Drawing.Point(391, 20);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(100, 20);
            this.txtGeneric.TabIndex = 9;
            this.txtGeneric.Table = "Drugs";
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtProspectus.ForeColor = System.Drawing.Color.Gray;
            this.txtProspectus.Location = new System.Drawing.Point(391, 98);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Size = new System.Drawing.Size(100, 20);
            this.txtProspectus.TabIndex = 10;
            this.txtProspectus.Table = "Drugs";
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "Obligatory";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtObligatory.ForeColor = System.Drawing.Color.Gray;
            this.txtObligatory.Location = new System.Drawing.Point(391, 46);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Size = new System.Drawing.Size(100, 20);
            this.txtObligatory.TabIndex = 11;
            this.txtObligatory.Table = "Drugs";
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDocumentation.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentation.Location = new System.Drawing.Point(391, 72);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentation.TabIndex = 12;
            this.txtDocumentation.Table = "Drugs";
            // 
            // frmQueryDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQueryDrugs";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReplaceable;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblIdActive;
        private System.Windows.Forms.Label lblDenomination;
        private System.Windows.Forms.Label lblSRN;
        private Sigma_Controls.TxtSigma txtReplaceable;
        private Sigma_Controls.TxtSigma txtIdActive;
        private Sigma_Controls.TxtSigma txtDenomination;
        private Sigma_Controls.TxtSigma txtContent;
        private Sigma_Controls.TxtSigma txtSRN;
        private System.Windows.Forms.Label lblProspectus;
        private System.Windows.Forms.Label lblDocumentation;
        private System.Windows.Forms.Label lblObligatory;
        private System.Windows.Forms.Label lblGeneric;
        private Sigma_Controls.TxtSigma txtDocumentation;
        private Sigma_Controls.TxtSigma txtObligatory;
        private Sigma_Controls.TxtSigma txtProspectus;
        private Sigma_Controls.TxtSigma txtGeneric;
    }
}
