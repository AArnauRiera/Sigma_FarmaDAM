namespace Manteniment
{
    partial class frmManteinStock
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
            this.cbxMed = new Sigma_Controls.cbxSigma();
            this.cbxLab = new Sigma_Controls.cbxSigma();
            this.tbxCant = new Sigma_Controls.TxtSigma();
            this.cbxMedId = new Sigma_Controls.cbxSigma();
            this.cbxSigma1 = new Sigma_Controls.cbxSigma();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxMed
            // 
            this.cbxMed.DBReference = "CommercialName";
            this.cbxMed.ForeginData = "Register_Number";
            this.cbxMed.ForeginTable = "Drugs";
            this.cbxMed.ForeginValue = null;
            this.cbxMed.FormattingEnabled = true;
            this.cbxMed.Location = new System.Drawing.Point(168, 46);
            this.cbxMed.Name = "cbxMed";
            this.cbxMed.Size = new System.Drawing.Size(384, 21);
            this.cbxMed.TabIndex = 0;
            this.cbxMed.SelectedIndexChanged += new System.EventHandler(this.cbxMed_SelectedIndexChanged);
            // 
            // cbxLab
            // 
            this.cbxLab.DBReference = "LabName";
            this.cbxLab.ForeginData = "id";
            this.cbxLab.ForeginTable = "Laboratories";
            this.cbxLab.ForeginValue = null;
            this.cbxLab.FormattingEnabled = true;
            this.cbxLab.Location = new System.Drawing.Point(168, 82);
            this.cbxLab.Name = "cbxLab";
            this.cbxLab.Size = new System.Drawing.Size(384, 21);
            this.cbxLab.TabIndex = 1;
            this.cbxLab.SelectedIndexChanged += new System.EventHandler(this.cbxMed_SelectedIndexChanged);
            // 
            // tbxCant
            // 
            this.tbxCant.DBReference = "Quantity";
            this.tbxCant.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxCant.IsForeginKey = false;
            this.tbxCant.Location = new System.Drawing.Point(168, 119);
            this.tbxCant.Name = "tbxCant";
            this.tbxCant.Size = new System.Drawing.Size(154, 20);
            this.tbxCant.TabIndex = 2;
            this.tbxCant.Table = "Stock";
            // 
            // cbxMedId
            // 
            this.cbxMedId.DBReference = "Register_Number";
            this.cbxMedId.ForeginData = null;
            this.cbxMedId.ForeginTable = "Drugs";
            this.cbxMedId.ForeginValue = null;
            this.cbxMedId.FormattingEnabled = true;
            this.cbxMedId.Location = new System.Drawing.Point(608, 46);
            this.cbxMedId.Name = "cbxMedId";
            this.cbxMedId.Size = new System.Drawing.Size(94, 21);
            this.cbxMedId.TabIndex = 3;
            // 
            // cbxSigma1
            // 
            this.cbxSigma1.DBReference = "id";
            this.cbxSigma1.ForeginData = "";
            this.cbxSigma1.ForeginTable = "Laboratories";
            this.cbxSigma1.ForeginValue = null;
            this.cbxSigma1.FormattingEnabled = true;
            this.cbxSigma1.Location = new System.Drawing.Point(608, 82);
            this.cbxSigma1.Name = "cbxSigma1";
            this.cbxSigma1.Size = new System.Drawing.Size(94, 21);
            this.cbxSigma1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmManteinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 579);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxSigma1);
            this.Controls.Add(this.cbxMedId);
            this.Controls.Add(this.tbxCant);
            this.Controls.Add(this.cbxLab);
            this.Controls.Add(this.cbxMed);
            this.Name = "frmManteinStock";
            this.Text = "frmManteinStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sigma_Controls.cbxSigma cbxMed;
        private Sigma_Controls.cbxSigma cbxLab;
        private Sigma_Controls.TxtSigma tbxCant;
        private Sigma_Controls.cbxSigma cbxMedId;
        private Sigma_Controls.cbxSigma cbxSigma1;
        private System.Windows.Forms.Button btnSave;
    }
}