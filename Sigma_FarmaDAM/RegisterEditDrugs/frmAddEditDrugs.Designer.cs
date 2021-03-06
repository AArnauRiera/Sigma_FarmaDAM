﻿namespace RegisterEditDrugs
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
            this.components = new System.ComponentModel.Container();
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
            this.lblTechSheetDoc = new System.Windows.Forms.Label();
            this.lblProspect = new System.Windows.Forms.Label();
            this.btnBrowseTechSheetDoc = new System.Windows.Forms.Button();
            this.btnBrowseProspect = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.pnlAddEditDrugs = new System.Windows.Forms.Panel();
            this.chkRecipe = new Sigma_Controls.CheckBoxSigma();
            this.chkGeneric = new Sigma_Controls.CheckBoxSigma();
            this.chkReplaceable = new Sigma_Controls.CheckBoxSigma();
            this.cmbLabId = new System.Windows.Forms.ComboBox();
            this.cmbIVAId = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbIVA = new Sigma_Controls.cbxSigma();
            this.cmbPharmaceuticLab = new Sigma_Controls.cbxSigma();
            this.lblTitol = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddEditDrugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNRN
            // 
            this.txtNRN.DBReference = "Register_Number";
            this.txtNRN.FieldType = Sigma_Controls.TxtSigma.FieldTypes.MedRegNum;
            this.txtNRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtNRN.ForeColor = System.Drawing.Color.Gray;
            this.txtNRN.IsForeginKey = false;
            this.txtNRN.Location = new System.Drawing.Point(208, 37);
            this.txtNRN.Margin = new System.Windows.Forms.Padding(2);
            this.txtNRN.Name = "txtNRN";
            this.txtNRN.Size = new System.Drawing.Size(222, 20);
            this.txtNRN.TabIndex = 0;
            this.txtNRN.Table = null;
            this.txtNRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblNRN
            // 
            this.lblNRN.AutoSize = true;
            this.lblNRN.Location = new System.Drawing.Point(15, 37);
            this.lblNRN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNRN.Name = "lblNRN";
            this.lblNRN.Size = new System.Drawing.Size(185, 19);
            this.lblNRN.TabIndex = 1;
            this.lblNRN.Text = "Número de registro Nacional";
            // 
            // lblNRS
            // 
            this.lblNRS.AutoSize = true;
            this.lblNRS.Location = new System.Drawing.Point(34, 70);
            this.lblNRS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNRS.Name = "lblNRS";
            this.lblNRS.Size = new System.Drawing.Size(186, 19);
            this.lblNRS.TabIndex = 3;
            this.lblNRS.Text = "Número de registro Sanitario";
            // 
            // txtNRS
            // 
            this.txtNRS.DBReference = "Sanitary_Register_Num";
            this.txtNRS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.MedRegNum;
            this.txtNRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtNRS.ForeColor = System.Drawing.Color.Gray;
            this.txtNRS.IsForeginKey = false;
            this.txtNRS.Location = new System.Drawing.Point(208, 70);
            this.txtNRS.Margin = new System.Windows.Forms.Padding(2);
            this.txtNRS.Name = "txtNRS";
            this.txtNRS.Size = new System.Drawing.Size(222, 20);
            this.txtNRS.TabIndex = 2;
            this.txtNRS.Table = null;
            this.txtNRS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblActivePrinciple
            // 
            this.lblActivePrinciple.AutoSize = true;
            this.lblActivePrinciple.Location = new System.Drawing.Point(116, 137);
            this.lblActivePrinciple.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivePrinciple.Name = "lblActivePrinciple";
            this.lblActivePrinciple.Size = new System.Drawing.Size(93, 19);
            this.lblActivePrinciple.TabIndex = 7;
            this.lblActivePrinciple.Text = "Pricipio activo";
            // 
            // txtActivePrinciple
            // 
            this.txtActivePrinciple.DBReference = "ActivePrincipleID";
            this.txtActivePrinciple.FieldType = Sigma_Controls.TxtSigma.FieldTypes.MedRegNum;
            this.txtActivePrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtActivePrinciple.ForeColor = System.Drawing.Color.Gray;
            this.txtActivePrinciple.IsForeginKey = false;
            this.txtActivePrinciple.Location = new System.Drawing.Point(208, 138);
            this.txtActivePrinciple.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivePrinciple.Name = "txtActivePrinciple";
            this.txtActivePrinciple.Size = new System.Drawing.Size(222, 20);
            this.txtActivePrinciple.TabIndex = 6;
            this.txtActivePrinciple.Table = null;
            this.txtActivePrinciple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre comercial";
            // 
            // txtName
            // 
            this.txtName.DBReference = "CommercialName";
            this.txtName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.MedRegName;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.IsForeginKey = false;
            this.txtName.Location = new System.Drawing.Point(208, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Table = null;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(131, 249);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(78, 19);
            this.lblBasePrice.TabIndex = 13;
            this.lblBasePrice.Text = "Precio base";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DBReference = "Price";
            this.txtBasePrice.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtBasePrice.ForeColor = System.Drawing.Color.Gray;
            this.txtBasePrice.IsForeginKey = false;
            this.txtBasePrice.Location = new System.Drawing.Point(208, 250);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(222, 20);
            this.txtBasePrice.TabIndex = 12;
            this.txtBasePrice.Table = null;
            this.txtBasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblPharmaceuticLab
            // 
            this.lblPharmaceuticLab.AutoSize = true;
            this.lblPharmaceuticLab.Location = new System.Drawing.Point(46, 206);
            this.lblPharmaceuticLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPharmaceuticLab.Name = "lblPharmaceuticLab";
            this.lblPharmaceuticLab.Size = new System.Drawing.Size(162, 19);
            this.lblPharmaceuticLab.TabIndex = 11;
            this.lblPharmaceuticLab.Text = "Laboratorio farmacéutico";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(132, 174);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(73, 19);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "Contenido";
            // 
            // txtContent
            // 
            this.txtContent.DBReference = "Content";
            this.txtContent.FieldType = Sigma_Controls.TxtSigma.FieldTypes.MedRegContent;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtContent.ForeColor = System.Drawing.Color.Gray;
            this.txtContent.IsForeginKey = false;
            this.txtContent.Location = new System.Drawing.Point(208, 174);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(222, 20);
            this.txtContent.TabIndex = 8;
            this.txtContent.Table = null;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(170, 281);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(30, 19);
            this.lblIVA.TabIndex = 15;
            this.lblIVA.Text = "IVA";
            // 
            // lblTechSheetDoc
            // 
            this.lblTechSheetDoc.AutoSize = true;
            this.lblTechSheetDoc.Location = new System.Drawing.Point(12, 401);
            this.lblTechSheetDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTechSheetDoc.Name = "lblTechSheetDoc";
            this.lblTechSheetDoc.Size = new System.Drawing.Size(192, 19);
            this.lblTechSheetDoc.TabIndex = 19;
            this.lblTechSheetDoc.Text = "Documento de la ficha técnica";
            // 
            // lblProspect
            // 
            this.lblProspect.AutoSize = true;
            this.lblProspect.Location = new System.Drawing.Point(132, 445);
            this.lblProspect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProspect.Name = "lblProspect";
            this.lblProspect.Size = new System.Drawing.Size(70, 19);
            this.lblProspect.TabIndex = 20;
            this.lblProspect.Text = "Prospecto";
            // 
            // btnBrowseTechSheetDoc
            // 
            this.btnBrowseTechSheetDoc.BackColor = System.Drawing.Color.LightBlue;
            this.btnBrowseTechSheetDoc.Location = new System.Drawing.Point(208, 394);
            this.btnBrowseTechSheetDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseTechSheetDoc.Name = "btnBrowseTechSheetDoc";
            this.btnBrowseTechSheetDoc.Size = new System.Drawing.Size(100, 32);
            this.btnBrowseTechSheetDoc.TabIndex = 21;
            this.btnBrowseTechSheetDoc.Text = "Buscar...";
            this.btnBrowseTechSheetDoc.UseVisualStyleBackColor = false;
            // 
            // btnBrowseProspect
            // 
            this.btnBrowseProspect.BackColor = System.Drawing.Color.LightBlue;
            this.btnBrowseProspect.Location = new System.Drawing.Point(208, 438);
            this.btnBrowseProspect.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseProspect.Name = "btnBrowseProspect";
            this.btnBrowseProspect.Size = new System.Drawing.Size(100, 32);
            this.btnBrowseProspect.TabIndex = 22;
            this.btnBrowseProspect.Text = "Browse...";
            this.btnBrowseProspect.UseVisualStyleBackColor = false;
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditAdd.Location = new System.Drawing.Point(208, 492);
            this.btnEditAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(100, 32);
            this.btnEditAdd.TabIndex = 23;
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // pnlAddEditDrugs
            // 
            this.pnlAddEditDrugs.Controls.Add(this.chkRecipe);
            this.pnlAddEditDrugs.Controls.Add(this.chkGeneric);
            this.pnlAddEditDrugs.Controls.Add(this.txtBasePrice);
            this.pnlAddEditDrugs.Controls.Add(this.chkReplaceable);
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
            this.pnlAddEditDrugs.Controls.Add(this.txtActivePrinciple);
            this.pnlAddEditDrugs.Controls.Add(this.lblActivePrinciple);
            this.pnlAddEditDrugs.Controls.Add(this.txtContent);
            this.pnlAddEditDrugs.Controls.Add(this.lblIVA);
            this.pnlAddEditDrugs.Controls.Add(this.lblContent);
            this.pnlAddEditDrugs.Controls.Add(this.lblBasePrice);
            this.pnlAddEditDrugs.Controls.Add(this.lblPharmaceuticLab);
            this.pnlAddEditDrugs.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAddEditDrugs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddEditDrugs.Location = new System.Drawing.Point(172, 137);
            this.pnlAddEditDrugs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddEditDrugs.Name = "pnlAddEditDrugs";
            this.pnlAddEditDrugs.Size = new System.Drawing.Size(452, 568);
            this.pnlAddEditDrugs.TabIndex = 24;
            // 
            // chkRecipe
            // 
            this.chkRecipe.AutoSize = true;
            this.chkRecipe.DBReference = "NeedsRecipe";
            this.chkRecipe.Location = new System.Drawing.Point(208, 348);
            this.chkRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.chkRecipe.Name = "chkRecipe";
            this.chkRecipe.Size = new System.Drawing.Size(68, 23);
            this.chkRecipe.TabIndex = 17;
            this.chkRecipe.Table = null;
            this.chkRecipe.Text = "Receta";
            this.chkRecipe.UseVisualStyleBackColor = true;
            // 
            // chkGeneric
            // 
            this.chkGeneric.AutoSize = true;
            this.chkGeneric.DBReference = "IsGeneric";
            this.chkGeneric.Location = new System.Drawing.Point(208, 330);
            this.chkGeneric.Margin = new System.Windows.Forms.Padding(2);
            this.chkGeneric.Name = "chkGeneric";
            this.chkGeneric.Size = new System.Drawing.Size(82, 23);
            this.chkGeneric.TabIndex = 16;
            this.chkGeneric.Table = null;
            this.chkGeneric.Text = "Generico";
            this.chkGeneric.UseVisualStyleBackColor = true;
            // 
            // chkReplaceable
            // 
            this.chkReplaceable.AutoSize = true;
            this.chkReplaceable.DBReference = "Replaceable";
            this.chkReplaceable.Location = new System.Drawing.Point(208, 312);
            this.chkReplaceable.Margin = new System.Windows.Forms.Padding(2);
            this.chkReplaceable.Name = "chkReplaceable";
            this.chkReplaceable.Size = new System.Drawing.Size(104, 23);
            this.chkReplaceable.TabIndex = 15;
            this.chkReplaceable.Table = null;
            this.chkReplaceable.Text = "Remplazable";
            this.chkReplaceable.UseVisualStyleBackColor = true;
            // 
            // cmbLabId
            // 
            this.cmbLabId.FormattingEnabled = true;
            this.cmbLabId.Location = new System.Drawing.Point(460, 217);
            this.cmbLabId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLabId.Name = "cmbLabId";
            this.cmbLabId.Size = new System.Drawing.Size(8, 27);
            this.cmbLabId.TabIndex = 25;
            this.cmbLabId.UseWaitCursor = true;
            this.cmbLabId.Visible = false;
            // 
            // cmbIVAId
            // 
            this.cmbIVAId.FormattingEnabled = true;
            this.cmbIVAId.Location = new System.Drawing.Point(460, 266);
            this.cmbIVAId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIVAId.Name = "cmbIVAId";
            this.cmbIVAId.Size = new System.Drawing.Size(8, 27);
            this.cmbIVAId.TabIndex = 25;
            this.cmbIVAId.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(330, 171);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 18;
            // 
            // cmbIVA
            // 
            this.cmbIVA.DBReference = "IVA";
            this.cmbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIVA.ForeginData = null;
            this.cmbIVA.ForeginTable = null;
            this.cmbIVA.ForeginValue = null;
            this.cmbIVA.FormattingEnabled = true;
            this.cmbIVA.Location = new System.Drawing.Point(208, 275);
            this.cmbIVA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(135, 27);
            this.cmbIVA.TabIndex = 14;
            // 
            // cmbPharmaceuticLab
            // 
            this.cmbPharmaceuticLab.DBReference = "Laboratories";
            this.cmbPharmaceuticLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPharmaceuticLab.ForeginData = null;
            this.cmbPharmaceuticLab.ForeginTable = null;
            this.cmbPharmaceuticLab.ForeginValue = null;
            this.cmbPharmaceuticLab.FormattingEnabled = true;
            this.cmbPharmaceuticLab.Location = new System.Drawing.Point(208, 203);
            this.cmbPharmaceuticLab.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPharmaceuticLab.Name = "cmbPharmaceuticLab";
            this.cmbPharmaceuticLab.Size = new System.Drawing.Size(135, 27);
            this.cmbPharmaceuticLab.TabIndex = 10;
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.Location = new System.Drawing.Point(388, 7);
            this.lblTitol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(101, 39);
            this.lblTitol.TabIndex = 27;
            this.lblTitol.Text = "Titulo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 559);
            this.Controls.Add(this.lblTitol);
            this.Controls.Add(this.pnlAddEditDrugs);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddEditDrugs";
            this.Text = "frmRegisterEditDrugs";
            this.Load += new System.EventHandler(this.frmAddEditDrugs_Load);
            this.pnlAddEditDrugs.ResumeLayout(false);
            this.pnlAddEditDrugs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblTechSheetDoc;
        private System.Windows.Forms.Label lblProspect;
        private System.Windows.Forms.Button btnBrowseTechSheetDoc;
        private System.Windows.Forms.Button btnBrowseProspect;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.Panel pnlAddEditDrugs;
        private Sigma_Controls.cbxSigma cmbIVA;
        private Sigma_Controls.cbxSigma cmbPharmaceuticLab;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbIVAId;
        private System.Windows.Forms.ComboBox cmbLabId;
        private Sigma_Controls.CheckBoxSigma chkRecipe;
        private Sigma_Controls.CheckBoxSigma chkGeneric;
        private Sigma_Controls.CheckBoxSigma chkReplaceable;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}