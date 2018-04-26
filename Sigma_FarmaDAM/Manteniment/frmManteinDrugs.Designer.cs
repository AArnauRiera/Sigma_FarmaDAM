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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRegisterNumber = new Sigma_Controls.TxtSigma();
            this.lblRegNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblRegNum);
            this.pnlTextBox.Controls.Add(this.txtRegisterNumber);
            this.pnlTextBox.Controls.Add(this.label2);
            this.pnlTextBox.Controls.Add(this.txtSigma2);
            this.pnlTextBox.Controls.Add(this.label1);
            this.pnlTextBox.Controls.Add(this.txtSigma1);
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
            this.pnlTextBox.Location = new System.Drawing.Point(17, 23);
            this.pnlTextBox.Size = new System.Drawing.Size(372, 559);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(1, 6);
            this.pnlMantein.Size = new System.Drawing.Size(1049, 748);
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(23, 219);
            this.lblProspectus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(70, 19);
            this.lblProspectus.TabIndex = 34;
            this.lblProspectus.Text = "Prospecto";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(23, 196);
            this.lblDocumentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(105, 19);
            this.lblDocumentation.TabIndex = 33;
            this.lblDocumentation.Text = "Documentacion";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(23, 174);
            this.lblObligatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(101, 19);
            this.lblObligatory.TabIndex = 32;
            this.lblObligatory.Text = "Necesita receta";
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(23, 152);
            this.lblGeneric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(63, 19);
            this.lblGeneric.TabIndex = 31;
            this.lblGeneric.Text = "Generico";
            // 
            // lblReplaceable
            // 
            this.lblReplaceable.AutoSize = true;
            this.lblReplaceable.Location = new System.Drawing.Point(23, 129);
            this.lblReplaceable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplaceable.Name = "lblReplaceable";
            this.lblReplaceable.Size = new System.Drawing.Size(85, 19);
            this.lblReplaceable.TabIndex = 30;
            this.lblReplaceable.Text = "Remplazable";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(23, 106);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(73, 19);
            this.lblContent.TabIndex = 35;
            this.lblContent.Text = "Contenido";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(23, 85);
            this.lblIdActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(63, 19);
            this.lblIdActive.TabIndex = 36;
            this.lblIdActive.Text = "Id Activo";
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Location = new System.Drawing.Point(23, 62);
            this.lblDenomination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(97, 19);
            this.lblDenomination.TabIndex = 29;
            this.lblDenomination.Text = "Denominacion";
            // 
            // lblSRN
            // 
            this.lblSRN.AutoSize = true;
            this.lblSRN.Location = new System.Drawing.Point(23, 41);
            this.lblSRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSRN.Name = "lblSRN";
            this.lblSRN.Size = new System.Drawing.Size(34, 19);
            this.lblSRN.TabIndex = 28;
            this.lblSRN.Text = "SRN";
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentation.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentation.Location = new System.Drawing.Point(173, 197);
            this.txtDocumentation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Size = new System.Drawing.Size(118, 20);
            this.txtDocumentation.TabIndex = 8;
            this.txtDocumentation.Table = "Drugs";
            this.txtDocumentation.TextChanged += new System.EventHandler(this.txtDocumentation_TextChanged);
            this.txtDocumentation.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtReplaceable
            // 
            this.txtReplaceable.DBReference = "Replaceable";
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplaceable.ForeColor = System.Drawing.Color.Black;
            this.txtReplaceable.Location = new System.Drawing.Point(173, 130);
            this.txtReplaceable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Size = new System.Drawing.Size(118, 20);
            this.txtReplaceable.TabIndex = 5;
            this.txtReplaceable.Table = "Drugs";
            this.txtReplaceable.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtReplaceable.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "NeedsRecipe";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObligatory.ForeColor = System.Drawing.Color.Black;
            this.txtObligatory.Location = new System.Drawing.Point(173, 175);
            this.txtObligatory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Size = new System.Drawing.Size(118, 20);
            this.txtObligatory.TabIndex = 7;
            this.txtObligatory.Table = "Drugs";
            this.txtObligatory.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtObligatory.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "ActivePrincipleID";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdActive.ForeColor = System.Drawing.Color.Black;
            this.txtIdActive.Location = new System.Drawing.Point(173, 86);
            this.txtIdActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Size = new System.Drawing.Size(118, 20);
            this.txtIdActive.TabIndex = 3;
            this.txtIdActive.Table = "Drugs";
            this.txtIdActive.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtIdActive.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProspectus.ForeColor = System.Drawing.Color.Black;
            this.txtProspectus.Location = new System.Drawing.Point(173, 220);
            this.txtProspectus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Size = new System.Drawing.Size(118, 20);
            this.txtProspectus.TabIndex = 9;
            this.txtProspectus.Table = "Drugs";
            this.txtProspectus.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "CommercialName";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomination.ForeColor = System.Drawing.Color.Black;
            this.txtDenomination.Location = new System.Drawing.Point(173, 63);
            this.txtDenomination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(118, 20);
            this.txtDenomination.TabIndex = 2;
            this.txtDenomination.Table = "Drugs";
            this.txtDenomination.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtDenomination.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "IsGeneric";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneric.ForeColor = System.Drawing.Color.Black;
            this.txtGeneric.Location = new System.Drawing.Point(173, 153);
            this.txtGeneric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(118, 20);
            this.txtGeneric.TabIndex = 6;
            this.txtGeneric.Table = "Drugs";
            this.txtGeneric.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtGeneric.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(173, 108);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(118, 20);
            this.txtContent.TabIndex = 4;
            this.txtContent.Table = "Drugs";
            this.txtContent.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtContent.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSRN.ForeColor = System.Drawing.Color.Black;
            this.txtSRN.Location = new System.Drawing.Point(173, 40);
            this.txtSRN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(118, 20);
            this.txtSRN.TabIndex = 1;
            this.txtSRN.Table = "Drugs";
            this.txtSRN.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtSRN.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(31, 336);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(16, 14);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(324, 221);
            this.webBrowser1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Precio";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "Price";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma1.ForeColor = System.Drawing.Color.Black;
            this.txtSigma1.Location = new System.Drawing.Point(173, 244);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(118, 20);
            this.txtSigma1.TabIndex = 10;
            this.txtSigma1.Table = "Drugs";
            this.txtSigma1.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtSigma1.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "IVA";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "IVAId";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma2.ForeColor = System.Drawing.Color.Black;
            this.txtSigma2.Location = new System.Drawing.Point(173, 268);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(118, 20);
            this.txtSigma2.TabIndex = 11;
            this.txtSigma2.Table = "Drugs";
            this.txtSigma2.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtSigma2.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.DBReference = "Register_Number";
            this.txtRegisterNumber.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtRegisterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRegisterNumber.Location = new System.Drawing.Point(173, 17);
            this.txtRegisterNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(118, 20);
            this.txtRegisterNumber.TabIndex = 0;
            this.txtRegisterNumber.Table = "Drugs";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(23, 17);
            this.lblRegNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(113, 19);
            this.lblRegNum.TabIndex = 43;
            this.lblRegNum.Text = "Número nacional";
            // 
            // frmManteinDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmManteinDrugs";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma2;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtSigma1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRegNum;
        private Sigma_Controls.TxtSigma txtRegisterNumber;
    }
}
