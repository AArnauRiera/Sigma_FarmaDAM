﻿namespace SearchSystem
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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnUpdate_Click_1);
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
            this.txtReplaceable.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtReplaceable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtReplaceable.ForeColor = System.Drawing.Color.Black;
            this.txtReplaceable.Location = new System.Drawing.Point(204, 124);
            this.txtReplaceable.Name = "txtReplaceable";
            this.txtReplaceable.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceable.TabIndex = 13;
            this.txtReplaceable.Table = "Drugs";
            this.txtReplaceable.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtReplaceable.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtIdActive
            // 
            this.txtIdActive.DBReference = "id_active";
            this.txtIdActive.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtIdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIdActive.ForeColor = System.Drawing.Color.Black;
            this.txtIdActive.Location = new System.Drawing.Point(204, 69);
            this.txtIdActive.Name = "txtIdActive";
            this.txtIdActive.Size = new System.Drawing.Size(100, 20);
            this.txtIdActive.TabIndex = 12;
            this.txtIdActive.Table = "Drugs";
            this.txtIdActive.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtIdActive.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtDenomination
            // 
            this.txtDenomination.DBReference = "Denomination";
            this.txtDenomination.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDenomination.ForeColor = System.Drawing.Color.Black;
            this.txtDenomination.Location = new System.Drawing.Point(204, 43);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(100, 20);
            this.txtDenomination.TabIndex = 11;
            this.txtDenomination.Table = "Drugs";
            this.txtDenomination.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtDenomination.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(204, 95);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(100, 20);
            this.txtContent.TabIndex = 10;
            this.txtContent.Table = "Drugs";
            this.txtContent.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtContent.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtSRN
            // 
            this.txtSRN.DBReference = "Sanitary_Register_Num";
            this.txtSRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtSRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSRN.ForeColor = System.Drawing.Color.Black;
            this.txtSRN.Location = new System.Drawing.Point(204, 17);
            this.txtSRN.Name = "txtSRN";
            this.txtSRN.Size = new System.Drawing.Size(100, 20);
            this.txtSRN.TabIndex = 9;
            this.txtSRN.Table = "Drugs";
            this.txtSRN.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtSRN.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // lblGeneric
            // 
            this.lblGeneric.AutoSize = true;
            this.lblGeneric.Location = new System.Drawing.Point(341, 13);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(50, 13);
            this.lblGeneric.TabIndex = 16;
            this.lblGeneric.Text = "Generico";
            // 
            // lblObligatory
            // 
            this.lblObligatory.AutoSize = true;
            this.lblObligatory.Location = new System.Drawing.Point(331, 37);
            this.lblObligatory.Name = "lblObligatory";
            this.lblObligatory.Size = new System.Drawing.Size(57, 13);
            this.lblObligatory.TabIndex = 16;
            this.lblObligatory.Text = "Obligatorio";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(306, 63);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(82, 13);
            this.lblDocumentation.TabIndex = 16;
            this.lblDocumentation.Text = "Documentacion";
            // 
            // lblProspectus
            // 
            this.lblProspectus.AutoSize = true;
            this.lblProspectus.Location = new System.Drawing.Point(325, 89);
            this.lblProspectus.Name = "lblProspectus";
            this.lblProspectus.Size = new System.Drawing.Size(60, 13);
            this.lblProspectus.TabIndex = 16;
            this.lblProspectus.Text = "Prospectos";
            // 
            // txtGeneric
            // 
            this.txtGeneric.DBReference = "Generic";
            this.txtGeneric.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtGeneric.ForeColor = System.Drawing.Color.Black;
            this.txtGeneric.Location = new System.Drawing.Point(391, 11);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(100, 20);
            this.txtGeneric.TabIndex = 9;
            this.txtGeneric.Table = "Drugs";
            this.txtGeneric.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtGeneric.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtProspectus
            // 
            this.txtProspectus.DBReference = "Prospectus";
            this.txtProspectus.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtProspectus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtProspectus.ForeColor = System.Drawing.Color.Black;
            this.txtProspectus.Location = new System.Drawing.Point(391, 89);
            this.txtProspectus.Name = "txtProspectus";
            this.txtProspectus.Size = new System.Drawing.Size(100, 20);
            this.txtProspectus.TabIndex = 10;
            this.txtProspectus.Table = "Drugs";
            this.txtProspectus.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtProspectus.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtObligatory
            // 
            this.txtObligatory.DBReference = "Obligatory";
            this.txtObligatory.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtObligatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtObligatory.ForeColor = System.Drawing.Color.Black;
            this.txtObligatory.Location = new System.Drawing.Point(391, 37);
            this.txtObligatory.Name = "txtObligatory";
            this.txtObligatory.Size = new System.Drawing.Size(100, 20);
            this.txtObligatory.TabIndex = 11;
            this.txtObligatory.Table = "Drugs";
            this.txtObligatory.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtObligatory.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtDocumentation
            // 
            this.txtDocumentation.DBReference = "Documentation";
            this.txtDocumentation.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtDocumentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDocumentation.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentation.Location = new System.Drawing.Point(391, 63);
            this.txtDocumentation.Name = "txtDocumentation";
            this.txtDocumentation.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentation.TabIndex = 12;
            this.txtDocumentation.Table = "Drugs";
            this.txtDocumentation.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtDocumentation.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Precio";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "Price";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Number;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSigma1.ForeColor = System.Drawing.Color.Black;
            this.txtSigma1.Location = new System.Drawing.Point(391, 113);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(100, 20);
            this.txtSigma1.TabIndex = 20;
            this.txtSigma1.Table = "Drugs";
            this.txtSigma1.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtSigma1.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "IVAId";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.IVAid;
            this.txtSigma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSigma2.ForeColor = System.Drawing.Color.Black;
            this.txtSigma2.Location = new System.Drawing.Point(391, 139);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(100, 20);
            this.txtSigma2.TabIndex = 19;
            this.txtSigma2.Table = "Drugs";
            this.txtSigma2.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtSigma2.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmQueryDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQueryDrugs";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
