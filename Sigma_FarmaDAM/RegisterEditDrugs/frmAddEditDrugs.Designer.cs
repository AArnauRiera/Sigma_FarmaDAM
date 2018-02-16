namespace RegisterEditDrugs
{
    partial class frmAddEditDrugs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNRN = new Sigma_Controls.TxtSigma();
            this.lblNRN = new System.Windows.Forms.Label();
            this.lblNRS = new System.Windows.Forms.Label();
            this.txtNRS = new Sigma_Controls.TxtSigma();
            this.lblActivePrinciple = new System.Windows.Forms.Label();
            this.txtActivePrinciple = new Sigma_Controls.TxtSigma();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new Sigma_Controls.TxtSigma();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new Sigma_Controls.TxtSigma();
            this.lblPharmaceuticLab = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new Sigma_Controls.TxtSigma();
            this.lblIVA = new System.Windows.Forms.Label();
            this.chkReplaceable = new System.Windows.Forms.CheckBox();
            this.chkGeneric = new System.Windows.Forms.CheckBox();
            this.chkRecipe = new System.Windows.Forms.CheckBox();
            this.lblTechSheetDoc = new System.Windows.Forms.Label();
            this.lblProspect = new System.Windows.Forms.Label();
            this.btnBrowseTechSheetDoc = new System.Windows.Forms.Button();
            this.btnBrowseProspect = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.pnlAddEditDrugs = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbIVA = new Sigma_Controls.cmbSigma();
            this.cmbPharmaceuticLab = new Sigma_Controls.cmbSigma();
            this.cmbIVAId = new System.Windows.Forms.ComboBox();
            this.cmbLabId = new System.Windows.Forms.ComboBox();
            this.pnlAddEditDrugs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNRN
            // 
            this.txtNRN.DBReference = "Register_Number";
            this.txtNRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtNRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtNRN.ForeColor = System.Drawing.Color.Gray;
            this.txtNRN.Location = new System.Drawing.Point(165, 24);
            this.txtNRN.Margin = new System.Windows.Forms.Padding(2);
            this.txtNRN.Name = "txtNRN";
            this.txtNRN.Placeholder = "";
            this.txtNRN.Size = new System.Drawing.Size(179, 20);
            this.txtNRN.TabIndex = 0;
            this.txtNRN.Table = null;
            // 
            // lblNRN
            // 
            this.lblNRN.AutoSize = true;
            this.lblNRN.Location = new System.Drawing.Point(20, 27);
            this.lblNRN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNRN.Name = "lblNRN";
            this.lblNRN.Size = new System.Drawing.Size(141, 13);
            this.lblNRN.TabIndex = 1;
            this.lblNRN.Text = "Número de registre Nacional";
            // 
            // lblNRS
            // 
            this.lblNRS.AutoSize = true;
            this.lblNRS.Location = new System.Drawing.Point(24, 60);
            this.lblNRS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNRS.Name = "lblNRS";
            this.lblNRS.Size = new System.Drawing.Size(137, 13);
            this.lblNRS.TabIndex = 3;
            this.lblNRS.Text = "Número de registre Sanitari ";
            // 
            // txtNRS
            // 
            this.txtNRS.DBReference = "Sanitary_Register_Num";
            this.txtNRS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtNRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtNRS.ForeColor = System.Drawing.Color.Gray;
            this.txtNRS.Location = new System.Drawing.Point(165, 57);
            this.txtNRS.Margin = new System.Windows.Forms.Padding(2);
            this.txtNRS.Name = "txtNRS";
            this.txtNRS.Placeholder = null;
            this.txtNRS.Size = new System.Drawing.Size(179, 20);
            this.txtNRS.TabIndex = 2;
            this.txtNRS.Table = null;
            // 
            // lblActivePrinciple
            // 
            this.lblActivePrinciple.AutoSize = true;
            this.lblActivePrinciple.Location = new System.Drawing.Point(92, 125);
            this.lblActivePrinciple.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivePrinciple.Name = "lblActivePrinciple";
            this.lblActivePrinciple.Size = new System.Drawing.Size(67, 13);
            this.lblActivePrinciple.TabIndex = 7;
            this.lblActivePrinciple.Text = "Principi actiu";
            // 
            // txtActivePrinciple
            // 
            this.txtActivePrinciple.DBReference = "ActivePrincipleID";
            this.txtActivePrinciple.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtActivePrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtActivePrinciple.ForeColor = System.Drawing.Color.Gray;
            this.txtActivePrinciple.Location = new System.Drawing.Point(165, 125);
            this.txtActivePrinciple.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivePrinciple.Name = "txtActivePrinciple";
            this.txtActivePrinciple.Placeholder = null;
            this.txtActivePrinciple.Size = new System.Drawing.Size(179, 20);
            this.txtActivePrinciple.TabIndex = 6;
            this.txtActivePrinciple.Table = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(82, 92);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nom comercial";
            // 
            // txtName
            // 
            this.txtName.DBReference = "CommercialName";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(165, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = null;
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Table = null;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(98, 232);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(58, 13);
            this.lblBasePrice.TabIndex = 13;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DBReference = "Price";
            this.txtBasePrice.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBasePrice.ForeColor = System.Drawing.Color.Gray;
            this.txtBasePrice.Location = new System.Drawing.Point(165, 229);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Placeholder = null;
            this.txtBasePrice.Size = new System.Drawing.Size(179, 20);
            this.txtBasePrice.TabIndex = 12;
            this.txtBasePrice.Table = null;
            // 
            // lblPharmaceuticLab
            // 
            this.lblPharmaceuticLab.AutoSize = true;
            this.lblPharmaceuticLab.Location = new System.Drawing.Point(31, 197);
            this.lblPharmaceuticLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmaceuticLab.Name = "lblPharmaceuticLab";
            this.lblPharmaceuticLab.Size = new System.Drawing.Size(125, 13);
            this.lblPharmaceuticLab.TabIndex = 11;
            this.lblPharmaceuticLab.Text = "Pharmaceutic Laboratory";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(104, 164);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(52, 13);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "Contingut";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtContent.ForeColor = System.Drawing.Color.Gray;
            this.txtContent.Location = new System.Drawing.Point(165, 161);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Placeholder = null;
            this.txtContent.Size = new System.Drawing.Size(179, 20);
            this.txtContent.TabIndex = 8;
            this.txtContent.Table = null;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(132, 257);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 15;
            this.lblIVA.Text = "IVA";
            // 
            // chkReplaceable
            // 
            this.chkReplaceable.AutoSize = true;
            this.chkReplaceable.Location = new System.Drawing.Point(170, 297);
            this.chkReplaceable.Margin = new System.Windows.Forms.Padding(2);
            this.chkReplaceable.Name = "chkReplaceable";
            this.chkReplaceable.Size = new System.Drawing.Size(86, 17);
            this.chkReplaceable.TabIndex = 16;
            this.chkReplaceable.Text = "Replaceable";
            this.chkReplaceable.UseVisualStyleBackColor = true;
            // 
            // chkGeneric
            // 
            this.chkGeneric.AutoSize = true;
            this.chkGeneric.Location = new System.Drawing.Point(170, 319);
            this.chkGeneric.Margin = new System.Windows.Forms.Padding(2);
            this.chkGeneric.Name = "chkGeneric";
            this.chkGeneric.Size = new System.Drawing.Size(63, 17);
            this.chkGeneric.TabIndex = 17;
            this.chkGeneric.Text = "Generic";
            this.chkGeneric.UseVisualStyleBackColor = true;
            // 
            // chkRecipe
            // 
            this.chkRecipe.AutoSize = true;
            this.chkRecipe.Location = new System.Drawing.Point(170, 341);
            this.chkRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.chkRecipe.Name = "chkRecipe";
            this.chkRecipe.Size = new System.Drawing.Size(60, 17);
            this.chkRecipe.TabIndex = 18;
            this.chkRecipe.Text = "Recipe";
            this.chkRecipe.UseVisualStyleBackColor = true;
            // 
            // lblTechSheetDoc
            // 
            this.lblTechSheetDoc.AutoSize = true;
            this.lblTechSheetDoc.Location = new System.Drawing.Point(12, 384);
            this.lblTechSheetDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTechSheetDoc.Name = "lblTechSheetDoc";
            this.lblTechSheetDoc.Size = new System.Drawing.Size(156, 13);
            this.lblTechSheetDoc.TabIndex = 19;
            this.lblTechSheetDoc.Text = "Technical sheet documentation";
            // 
            // lblProspect
            // 
            this.lblProspect.AutoSize = true;
            this.lblProspect.Location = new System.Drawing.Point(118, 413);
            this.lblProspect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProspect.Name = "lblProspect";
            this.lblProspect.Size = new System.Drawing.Size(49, 13);
            this.lblProspect.TabIndex = 20;
            this.lblProspect.Text = "Prospect";
            // 
            // btnBrowseTechSheetDoc
            // 
            this.btnBrowseTechSheetDoc.Location = new System.Drawing.Point(170, 384);
            this.btnBrowseTechSheetDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseTechSheetDoc.Name = "btnBrowseTechSheetDoc";
            this.btnBrowseTechSheetDoc.Size = new System.Drawing.Size(56, 19);
            this.btnBrowseTechSheetDoc.TabIndex = 21;
            this.btnBrowseTechSheetDoc.Text = "Browse...";
            this.btnBrowseTechSheetDoc.UseVisualStyleBackColor = true;
            // 
            // btnBrowseProspect
            // 
            this.btnBrowseProspect.Location = new System.Drawing.Point(170, 408);
            this.btnBrowseProspect.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseProspect.Name = "btnBrowseProspect";
            this.btnBrowseProspect.Size = new System.Drawing.Size(56, 19);
            this.btnBrowseProspect.TabIndex = 22;
            this.btnBrowseProspect.Text = "Browse...";
            this.btnBrowseProspect.UseVisualStyleBackColor = true;
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Location = new System.Drawing.Point(174, 466);
            this.btnEditAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(56, 19);
            this.btnEditAdd.TabIndex = 23;
            this.btnEditAdd.UseVisualStyleBackColor = true;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // pnlAddEditDrugs
            // 
            this.pnlAddEditDrugs.Controls.Add(this.cmbLabId);
            this.pnlAddEditDrugs.Controls.Add(this.cmbIVAId);
            this.pnlAddEditDrugs.Controls.Add(this.lblError);
            this.pnlAddEditDrugs.Controls.Add(this.cmbIVA);
            this.pnlAddEditDrugs.Controls.Add(this.cmbPharmaceuticLab);
            this.pnlAddEditDrugs.Controls.Add(this.lblNRN);
            this.pnlAddEditDrugs.Controls.Add(this.btnEditAdd);
            this.pnlAddEditDrugs.Controls.Add(this.txtNRN);
            this.pnlAddEditDrugs.Controls.Add(this.btnBrowseProspect);
            this.pnlAddEditDrugs.Controls.Add(this.txtNRS);
            this.pnlAddEditDrugs.Controls.Add(this.btnBrowseTechSheetDoc);
            this.pnlAddEditDrugs.Controls.Add(this.lblNRS);
            this.pnlAddEditDrugs.Controls.Add(this.lblProspect);
            this.pnlAddEditDrugs.Controls.Add(this.txtName);
            this.pnlAddEditDrugs.Controls.Add(this.lblTechSheetDoc);
            this.pnlAddEditDrugs.Controls.Add(this.lblName);
            this.pnlAddEditDrugs.Controls.Add(this.chkRecipe);
            this.pnlAddEditDrugs.Controls.Add(this.txtActivePrinciple);
            this.pnlAddEditDrugs.Controls.Add(this.chkGeneric);
            this.pnlAddEditDrugs.Controls.Add(this.lblActivePrinciple);
            this.pnlAddEditDrugs.Controls.Add(this.chkReplaceable);
            this.pnlAddEditDrugs.Controls.Add(this.txtContent);
            this.pnlAddEditDrugs.Controls.Add(this.lblIVA);
            this.pnlAddEditDrugs.Controls.Add(this.lblContent);
            this.pnlAddEditDrugs.Controls.Add(this.lblBasePrice);
            this.pnlAddEditDrugs.Controls.Add(this.lblPharmaceuticLab);
            this.pnlAddEditDrugs.Controls.Add(this.txtBasePrice);
            this.pnlAddEditDrugs.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAddEditDrugs.Location = new System.Drawing.Point(35, 10);
            this.pnlAddEditDrugs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddEditDrugs.Name = "pnlAddEditDrugs";
            this.pnlAddEditDrugs.Size = new System.Drawing.Size(400, 517);
            this.pnlAddEditDrugs.TabIndex = 24;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(171, 441);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 18;
            // 
            // cmbIVA
            // 
            this.cmbIVA.DBReference = "IVA";
            this.cmbIVA.FormattingEnabled = true;
            this.cmbIVA.Location = new System.Drawing.Point(165, 254);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(179, 21);
            this.cmbIVA.TabIndex = 24;
            // 
            // cmbPharmaceuticLab
            // 
            this.cmbPharmaceuticLab.DBReference = "Laboratories";
            this.cmbPharmaceuticLab.FormattingEnabled = true;
            this.cmbPharmaceuticLab.Location = new System.Drawing.Point(165, 194);
            this.cmbPharmaceuticLab.Name = "cmbPharmaceuticLab";
            this.cmbPharmaceuticLab.Size = new System.Drawing.Size(179, 21);
            this.cmbPharmaceuticLab.TabIndex = 24;
            // 
            // cmbIVAId
            // 
            this.cmbIVAId.FormattingEnabled = true;
            this.cmbIVAId.Location = new System.Drawing.Point(387, 254);
            this.cmbIVAId.Name = "cmbIVAId";
            this.cmbIVAId.Size = new System.Drawing.Size(10, 21);
            this.cmbIVAId.TabIndex = 25;
            this.cmbIVAId.Visible = false;
            // 
            // cmbLabId
            // 
            this.cmbLabId.FormattingEnabled = true;
            this.cmbLabId.Location = new System.Drawing.Point(387, 194);
            this.cmbLabId.Name = "cmbLabId";
            this.cmbLabId.Size = new System.Drawing.Size(10, 21);
            this.cmbLabId.TabIndex = 25;
            this.cmbLabId.UseWaitCursor = true;
            this.cmbLabId.Visible = false;
            // 
            // frmAddEditDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 559);
            this.Controls.Add(this.pnlAddEditDrugs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddEditDrugs";
            this.Text = "frmRegisterEditDrugs";
            this.Load += new System.EventHandler(this.frmAddEditDrugs_Load);
            this.pnlAddEditDrugs.ResumeLayout(false);
            this.pnlAddEditDrugs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtNRN;
        private System.Windows.Forms.Label lblNRN;
        private System.Windows.Forms.Label lblNRS;
        private Sigma_Controls.TxtSigma txtNRS;
        private System.Windows.Forms.Label lblActivePrinciple;
        private Sigma_Controls.TxtSigma txtActivePrinciple;
        private System.Windows.Forms.Label lblName;
        private Sigma_Controls.TxtSigma txtName;
        private System.Windows.Forms.Label lblBasePrice;
        private Sigma_Controls.TxtSigma txtBasePrice;
        private System.Windows.Forms.Label lblPharmaceuticLab;
        private System.Windows.Forms.Label lblContent;
        private Sigma_Controls.TxtSigma txtContent;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.CheckBox chkReplaceable;
        private System.Windows.Forms.CheckBox chkGeneric;
        private System.Windows.Forms.CheckBox chkRecipe;
        private System.Windows.Forms.Label lblTechSheetDoc;
        private System.Windows.Forms.Label lblProspect;
        private System.Windows.Forms.Button btnBrowseTechSheetDoc;
        private System.Windows.Forms.Button btnBrowseProspect;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.Panel pnlAddEditDrugs;
        private Sigma_Controls.cmbSigma cmbIVA;
        private Sigma_Controls.cmbSigma cmbPharmaceuticLab;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbIVAId;
        private System.Windows.Forms.ComboBox cmbLabId;
    }
}