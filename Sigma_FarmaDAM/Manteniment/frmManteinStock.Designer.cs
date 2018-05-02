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
            this.lblLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMed
            // 
            this.cbxMed.DBReference = "CommercialName";
            this.cbxMed.ForeginData = "Register_Number";
            this.cbxMed.ForeginTable = "Drugs";
            this.cbxMed.ForeginValue = null;
            this.cbxMed.FormattingEnabled = true;
            this.cbxMed.Location = new System.Drawing.Point(119, 46);
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
            this.cbxLab.Location = new System.Drawing.Point(119, 82);
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
            this.tbxCant.Location = new System.Drawing.Point(119, 119);
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
            this.cbxMedId.Visible = false;
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
            this.cbxSigma1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(119, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.BackColor = System.Drawing.Color.White;
            this.lblLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLab.Location = new System.Drawing.Point(25, 48);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(80, 19);
            this.lblLab.TabIndex = 6;
            this.lblLab.Text = "Laboratorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // frmManteinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLab);
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
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}