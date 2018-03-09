namespace Manteniment
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.webBrowser1);
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
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(4, 221);
            this.lblProspectus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(76, 19);
            this.lblProspectus.TabIndex = 34;
            this.lblProspectus.Text = "Prospectus";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(4, 194);
            this.lblDocumentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(104, 19);
            this.lblDocumentation.TabIndex = 33;
            this.lblDocumentation.Text = "Documentation";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(4, 167);
            this.lblObligatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(86, 19);
            this.lblObligatory.TabIndex = 32;
            this.lblObligatory.Text = "NeedsRecipe";
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(4, 141);
            this.lblGeneric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(55, 19);
            this.lblGeneric.TabIndex = 31;
            this.lblGeneric.Text = "Generic";
            // 
            // lblReplaceable
            // 
            this.lblReplaceable.AutoSize = true;
            this.lblReplaceable.Location = new System.Drawing.Point(4, 112);
            this.lblReplaceable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplaceable.Name = "lblReplaceable";
            this.lblReplaceable.Size = new System.Drawing.Size(80, 19);
            this.lblReplaceable.TabIndex = 30;
            this.lblReplaceable.Text = "Replaceable";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(4, 85);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(59, 19);
            this.lblContent.TabIndex = 35;
            this.lblContent.Text = "Content";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(4, 59);
            this.lblIdActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(62, 19);
            this.lblIdActive.TabIndex = 36;
            this.lblIdActive.Text = "Id Active";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(4, 31);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(96, 19);
            this.lblDenomination.TabIndex = 29;
            this.lblDenomination.Text = "Denomination";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(4, 4);
            this.lblSRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(34, 19);
            this.lblSRN.TabIndex = 28;
            this.lblSRN.Text = "SRN";
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentation.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentation.Location = new System.Drawing.Point(195, 194);
            this.txtDocumentation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Size = new System.Drawing.Size(132, 23);
            this.txtDocumentation.TabIndex = 26;
            this.txtDocumentation.Table = "Drugs";
            this.txtDocumentation.TextChanged += new System.EventHandler(this.txtDocumentation_TextChanged);
            // 
            // txtReplaceable
            // 
            this.txtReplaceable.DBReference = "Replaceable";
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplaceable.ForeColor = System.Drawing.Color.Black;
            this.txtReplaceable.Location = new System.Drawing.Point(195, 112);
            this.txtReplaceable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Size = new System.Drawing.Size(132, 23);
            this.txtReplaceable.TabIndex = 27;
            this.txtReplaceable.Table = "Drugs";
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "NeedsRecipe";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObligatory.ForeColor = System.Drawing.Color.Black;
            this.txtObligatory.Location = new System.Drawing.Point(195, 167);
            this.txtObligatory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Size = new System.Drawing.Size(132, 23);
            this.txtObligatory.TabIndex = 24;
            this.txtObligatory.Table = "Drugs";
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "ActivePrincipleID";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdActive.ForeColor = System.Drawing.Color.Black;
            this.txtIdActive.Location = new System.Drawing.Point(195, 59);
            this.txtIdActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Size = new System.Drawing.Size(132, 23);
            this.txtIdActive.TabIndex = 25;
            this.txtIdActive.Table = "Drugs";
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProspectus.ForeColor = System.Drawing.Color.Black;
            this.txtProspectus.Location = new System.Drawing.Point(195, 221);
            this.txtProspectus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Size = new System.Drawing.Size(132, 23);
            this.txtProspectus.TabIndex = 21;
            this.txtProspectus.Table = "Drugs";
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "CommercialName";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomination.ForeColor = System.Drawing.Color.Black;
            this.txtDenomination.Location = new System.Drawing.Point(195, 31);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(132, 23);
            this.txtDenomination.TabIndex = 23;
            this.txtDenomination.Table = "Drugs";
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "IsGeneric";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneric.ForeColor = System.Drawing.Color.Black;
            this.txtGeneric.Location = new System.Drawing.Point(195, 140);
            this.txtGeneric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(132, 23);
            this.txtGeneric.TabIndex = 20;
            this.txtGeneric.Table = "Drugs";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(195, 85);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(132, 23);
            this.txtContent.TabIndex = 22;
            this.txtContent.Table = "Drugs";
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSRN.ForeColor = System.Drawing.Color.Black;
            this.txtSRN.Location = new System.Drawing.Point(195, 4);
            this.txtSRN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(132, 23);
            this.txtSRN.TabIndex = 19;
            this.txtSRN.Table = "Drugs";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 253);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 17);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(364, 321);
            this.webBrowser1.TabIndex = 37;
            // 
            // frmManteinDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManteinDrugs";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
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
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
