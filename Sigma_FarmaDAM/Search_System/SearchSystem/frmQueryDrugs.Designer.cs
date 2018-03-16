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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.label1);
            this.pnlTB.Controls.Add(this.label2);
            this.pnlTB.Controls.Add(this.txtSigma1);
            this.pnlTB.Controls.Add(this.txtSigma2);
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
            this.lblReplaceable.Location = new System.Drawing.Point(172, 156);
            this.lblReplaceable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplaceable.Name = "lblReplaceable";
            this.lblReplaceable.Size = new System.Drawing.Size(90, 17);
            this.lblReplaceable.TabIndex = 16;
            this.lblReplaceable.Text = "Remplazable";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(192, 121);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(72, 17);
            this.lblContent.TabIndex = 17;
            this.lblContent.Text = "Contenido";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(196, 89);
            this.lblIdActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(61, 17);
            this.lblIdActive.TabIndex = 18;
            this.lblIdActive.Text = "Id Active";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(165, 62);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(98, 17);
            this.lblDenomination.TabIndex = 15;
            this.lblDenomination.Text = "Denominacion";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(221, 25);
            this.lblSRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(37, 17);
            this.lblSRN.TabIndex = 14;
            this.lblSRN.Text = "SRN";
            // 
            // txtReplaceable
            // 
            this.txtReplaceable.DBReference = "Replaceable";
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtReplaceable.ForeColor = System.Drawing.Color.Gray;
            this.txtReplaceable.Location = new System.Drawing.Point(272, 153);
            this.txtReplaceable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Size = new System.Drawing.Size(132, 23);
            this.txtReplaceable.TabIndex = 13;
            this.txtReplaceable.Table = "Drugs";
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "id_active";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtIdActive.ForeColor = System.Drawing.Color.Gray;
            this.txtIdActive.Location = new System.Drawing.Point(272, 85);
            this.txtIdActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Size = new System.Drawing.Size(132, 23);
            this.txtIdActive.TabIndex = 12;
            this.txtIdActive.Table = "Drugs";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDenomination.ForeColor = System.Drawing.Color.Gray;
            this.txtDenomination.Location = new System.Drawing.Point(272, 53);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(132, 23);
            this.txtDenomination.TabIndex = 11;
            this.txtDenomination.Table = "Drugs";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtContent.ForeColor = System.Drawing.Color.Gray;
            this.txtContent.Location = new System.Drawing.Point(272, 117);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(132, 23);
            this.txtContent.TabIndex = 10;
            this.txtContent.Table = "Drugs";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSRN.ForeColor = System.Drawing.Color.Gray;
            this.txtSRN.Location = new System.Drawing.Point(272, 21);
            this.txtSRN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(132, 23);
            this.txtSRN.TabIndex = 9;
            this.txtSRN.Table = "Drugs";
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(455, 16);
            this.lblGeneric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(66, 17);
            this.lblGeneric.TabIndex = 16;
            this.lblGeneric.Text = "Generico";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(441, 45);
            this.lblObligatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(77, 17);
            this.lblObligatory.TabIndex = 16;
            this.lblObligatory.Text = "Obligatorio";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(408, 77);
            this.lblDocumentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(106, 17);
            this.lblDocumentation.TabIndex = 16;
            this.lblDocumentation.Text = "Documentacion";
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(433, 109);
            this.lblProspectus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(79, 17);
            this.lblProspectus.TabIndex = 16;
            this.lblProspectus.Text = "Prospectos";
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "Generic";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtGeneric.ForeColor = System.Drawing.Color.Gray;
            this.txtGeneric.Location = new System.Drawing.Point(521, 13);
            this.txtGeneric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(132, 23);
            this.txtGeneric.TabIndex = 9;
            this.txtGeneric.Table = "Drugs";
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtProspectus.ForeColor = System.Drawing.Color.Gray;
            this.txtProspectus.Location = new System.Drawing.Point(521, 109);
            this.txtProspectus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Size = new System.Drawing.Size(132, 23);
            this.txtProspectus.TabIndex = 10;
            this.txtProspectus.Table = "Drugs";
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "Obligatory";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtObligatory.ForeColor = System.Drawing.Color.Gray;
            this.txtObligatory.Location = new System.Drawing.Point(521, 45);
            this.txtObligatory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Size = new System.Drawing.Size(132, 23);
            this.txtObligatory.TabIndex = 11;
            this.txtObligatory.Table = "Drugs";
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtDocumentation.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentation.Location = new System.Drawing.Point(521, 77);
            this.txtDocumentation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Size = new System.Drawing.Size(132, 23);
            this.txtDocumentation.TabIndex = 12;
            this.txtDocumentation.Table = "Drugs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Precio";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "Price";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSigma1.ForeColor = System.Drawing.Color.Gray;
            this.txtSigma1.Location = new System.Drawing.Point(521, 139);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(132, 23);
            this.txtSigma1.TabIndex = 20;
            this.txtSigma1.Table = "Drugs";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "IVAId";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSigma2.ForeColor = System.Drawing.Color.Gray;
            this.txtSigma2.Location = new System.Drawing.Point(521, 171);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(132, 23);
            this.txtSigma2.TabIndex = 19;
            this.txtSigma2.Table = "Drugs";
            // 
            // frmQueryDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(793, 617);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma1;
        private Sigma_Controls.TxtSigma txtSigma2;
    }
}
