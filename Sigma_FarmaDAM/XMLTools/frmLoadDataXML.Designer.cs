namespace XMLTools
{
    partial class frmLoadDataXML
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectXmlLab = new System.Windows.Forms.Button();
            this.txtbxXmlLab = new System.Windows.Forms.TextBox();
            this.btnUploadLab = new System.Windows.Forms.Button();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblPa = new System.Windows.Forms.Label();
            this.btnUploadPA = new System.Windows.Forms.Button();
            this.txbPA = new System.Windows.Forms.TextBox();
            this.btnSelectXmlPA = new System.Windows.Forms.Button();
            this.lblDrug = new System.Windows.Forms.Label();
            this.btnUploadDrug = new System.Windows.Forms.Button();
            this.txbDrug = new System.Windows.Forms.TextBox();
            this.btnSelectXmlDrug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pgbLab = new System.Windows.Forms.ProgressBar();
            this.pgbPA = new System.Windows.Forms.ProgressBar();
            this.pgbDrugs = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectXmlLab
            // 
            this.btnSelectXmlLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSelectXmlLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSelectXmlLab.Location = new System.Drawing.Point(417, 61);
            this.btnSelectXmlLab.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlLab.Name = "btnSelectXmlLab";
            this.btnSelectXmlLab.Size = new System.Drawing.Size(151, 35);
            this.btnSelectXmlLab.TabIndex = 1;
            this.btnSelectXmlLab.Text = "Seleccionar XML";
            this.btnSelectXmlLab.UseVisualStyleBackColor = true;
            this.btnSelectXmlLab.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtbxXmlLab
            // 
            this.txtbxXmlLab.Location = new System.Drawing.Point(86, 67);
            this.txtbxXmlLab.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxXmlLab.Name = "txtbxXmlLab";
            this.txtbxXmlLab.Size = new System.Drawing.Size(323, 22);
            this.txtbxXmlLab.TabIndex = 2;
            // 
            // btnUploadLab
            // 
            this.btnUploadLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUploadLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUploadLab.Location = new System.Drawing.Point(417, 97);
            this.btnUploadLab.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadLab.Name = "btnUploadLab";
            this.btnUploadLab.Size = new System.Drawing.Size(151, 35);
            this.btnUploadLab.TabIndex = 3;
            this.btnUploadLab.Text = "Subir XML";
            this.btnUploadLab.UseVisualStyleBackColor = true;
            this.btnUploadLab.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLab.Location = new System.Drawing.Point(83, 129);
            this.lblLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(0, 19);
            this.lblLab.TabIndex = 4;
            // 
            // lblPa
            // 
            this.lblPa.AutoSize = true;
            this.lblPa.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPa.Location = new System.Drawing.Point(83, 298);
            this.lblPa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPa.Name = "lblPa";
            this.lblPa.Size = new System.Drawing.Size(0, 19);
            this.lblPa.TabIndex = 8;
            // 
            // btnUploadPA
            // 
            this.btnUploadPA.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUploadPA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUploadPA.Location = new System.Drawing.Point(417, 261);
            this.btnUploadPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPA.Name = "btnUploadPA";
            this.btnUploadPA.Size = new System.Drawing.Size(151, 35);
            this.btnUploadPA.TabIndex = 7;
            this.btnUploadPA.Text = "Subir XML";
            this.btnUploadPA.UseVisualStyleBackColor = true;
            this.btnUploadPA.Click += new System.EventHandler(this.btnUploadPA_Click);
            // 
            // txbPA
            // 
            this.txbPA.Location = new System.Drawing.Point(86, 230);
            this.txbPA.Margin = new System.Windows.Forms.Padding(4);
            this.txbPA.Name = "txbPA";
            this.txbPA.Size = new System.Drawing.Size(323, 22);
            this.txbPA.TabIndex = 6;
            // 
            // btnSelectXmlPA
            // 
            this.btnSelectXmlPA.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSelectXmlPA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSelectXmlPA.Location = new System.Drawing.Point(417, 225);
            this.btnSelectXmlPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlPA.Name = "btnSelectXmlPA";
            this.btnSelectXmlPA.Size = new System.Drawing.Size(151, 35);
            this.btnSelectXmlPA.TabIndex = 5;
            this.btnSelectXmlPA.Text = "Seleccionar XML";
            this.btnSelectXmlPA.UseVisualStyleBackColor = true;
            this.btnSelectXmlPA.Click += new System.EventHandler(this.btnSelectXmlPA_Click);
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDrug.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDrug.Location = new System.Drawing.Point(83, 458);
            this.lblDrug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(0, 19);
            this.lblDrug.TabIndex = 12;
            // 
            // btnUploadDrug
            // 
            this.btnUploadDrug.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUploadDrug.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUploadDrug.Location = new System.Drawing.Point(417, 429);
            this.btnUploadDrug.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadDrug.Name = "btnUploadDrug";
            this.btnUploadDrug.Size = new System.Drawing.Size(151, 35);
            this.btnUploadDrug.TabIndex = 11;
            this.btnUploadDrug.Text = "Subir XML";
            this.btnUploadDrug.UseVisualStyleBackColor = true;
            this.btnUploadDrug.Click += new System.EventHandler(this.btnUploadDrug_Click);
            // 
            // txbDrug
            // 
            this.txbDrug.Location = new System.Drawing.Point(86, 396);
            this.txbDrug.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrug.Name = "txbDrug";
            this.txbDrug.Size = new System.Drawing.Size(323, 22);
            this.txbDrug.TabIndex = 10;
            // 
            // btnSelectXmlDrug
            // 
            this.btnSelectXmlDrug.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSelectXmlDrug.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSelectXmlDrug.Location = new System.Drawing.Point(417, 393);
            this.btnSelectXmlDrug.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlDrug.Name = "btnSelectXmlDrug";
            this.btnSelectXmlDrug.Size = new System.Drawing.Size(151, 35);
            this.btnSelectXmlDrug.TabIndex = 9;
            this.btnSelectXmlDrug.Text = "Seleccionar XML";
            this.btnSelectXmlDrug.UseVisualStyleBackColor = true;
            this.btnSelectXmlDrug.Click += new System.EventHandler(this.btnSelectXmlDrug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(82, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Laboratorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(82, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Principios activos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(82, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Producto";
            // 
            // pgbLab
            // 
            this.pgbLab.Location = new System.Drawing.Point(86, 97);
            this.pgbLab.Margin = new System.Windows.Forms.Padding(4);
            this.pgbLab.Name = "pgbLab";
            this.pgbLab.Size = new System.Drawing.Size(323, 28);
            this.pgbLab.TabIndex = 16;
            // 
            // pgbPA
            // 
            this.pgbPA.Location = new System.Drawing.Point(86, 260);
            this.pgbPA.Margin = new System.Windows.Forms.Padding(4);
            this.pgbPA.Name = "pgbPA";
            this.pgbPA.Size = new System.Drawing.Size(323, 28);
            this.pgbPA.TabIndex = 17;
            // 
            // pgbDrugs
            // 
            this.pgbDrugs.Location = new System.Drawing.Point(86, 426);
            this.pgbDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.pgbDrugs.Name = "pgbDrugs";
            this.pgbDrugs.Size = new System.Drawing.Size(323, 28);
            this.pgbDrugs.TabIndex = 18;
            // 
            // frmLoadDataXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 659);
            this.Controls.Add(this.pgbDrugs);
            this.Controls.Add(this.pgbPA);
            this.Controls.Add(this.pgbLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.btnUploadDrug);
            this.Controls.Add(this.txbDrug);
            this.Controls.Add(this.btnSelectXmlDrug);
            this.Controls.Add(this.lblPa);
            this.Controls.Add(this.btnUploadPA);
            this.Controls.Add(this.txbPA);
            this.Controls.Add(this.btnSelectXmlPA);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.btnUploadLab);
            this.Controls.Add(this.txtbxXmlLab);
            this.Controls.Add(this.btnSelectXmlLab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoadDataXML";
            this.Text = "frmLoadDataXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectXmlLab;
        protected System.Windows.Forms.TextBox txtbxXmlLab;
        protected System.Windows.Forms.Button btnUploadLab;
        public System.Windows.Forms.Label lblLab;
        public System.Windows.Forms.Label lblPa;
        protected System.Windows.Forms.Button btnUploadPA;
        protected System.Windows.Forms.TextBox txbPA;
        private System.Windows.Forms.Button btnSelectXmlPA;
        public System.Windows.Forms.Label lblDrug;
        protected System.Windows.Forms.Button btnUploadDrug;
        protected System.Windows.Forms.TextBox txbDrug;
        private System.Windows.Forms.Button btnSelectXmlDrug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pgbLab;
        private System.Windows.Forms.ProgressBar pgbPA;
        private System.Windows.Forms.ProgressBar pgbDrugs;
    }
}