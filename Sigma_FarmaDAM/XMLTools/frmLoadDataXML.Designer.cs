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
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectXmlLab
            // 
            this.btnSelectXmlLab.Location = new System.Drawing.Point(266, 183);
            this.btnSelectXmlLab.Name = "btnSelectXmlLab";
            this.btnSelectXmlLab.Size = new System.Drawing.Size(105, 23);
            this.btnSelectXmlLab.TabIndex = 1;
            this.btnSelectXmlLab.Text = "Seleccionar Xml";
            this.btnSelectXmlLab.UseVisualStyleBackColor = true;
            this.btnSelectXmlLab.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtbxXmlLab
            // 
            this.txtbxXmlLab.Location = new System.Drawing.Point(15, 184);
            this.txtbxXmlLab.Name = "txtbxXmlLab";
            this.txtbxXmlLab.Size = new System.Drawing.Size(243, 20);
            this.txtbxXmlLab.TabIndex = 2;
            // 
            // btnUploadLab
            // 
            this.btnUploadLab.Location = new System.Drawing.Point(121, 102);
            this.btnUploadLab.Name = "btnUploadLab";
            this.btnUploadLab.Size = new System.Drawing.Size(75, 23);
            this.btnUploadLab.TabIndex = 3;
            this.btnUploadLab.Text = "Subir Xml";
            this.btnUploadLab.UseVisualStyleBackColor = true;
            this.btnUploadLab.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(135, 238);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(0, 13);
            this.lblLab.TabIndex = 4;
            // 
            // lblPa
            // 
            this.lblPa.AutoSize = true;
            this.lblPa.Location = new System.Drawing.Point(510, 238);
            this.lblPa.Name = "lblPa";
            this.lblPa.Size = new System.Drawing.Size(0, 13);
            this.lblPa.TabIndex = 8;
            // 
            // btnUploadPA
            // 
            this.btnUploadPA.Location = new System.Drawing.Point(496, 102);
            this.btnUploadPA.Name = "btnUploadPA";
            this.btnUploadPA.Size = new System.Drawing.Size(75, 23);
            this.btnUploadPA.TabIndex = 7;
            this.btnUploadPA.Text = "Subir Xml";
            this.btnUploadPA.UseVisualStyleBackColor = true;
            this.btnUploadPA.Click += new System.EventHandler(this.btnUploadPA_Click);
            // 
            // txbPA
            // 
            this.txbPA.Location = new System.Drawing.Point(390, 184);
            this.txbPA.Name = "txbPA";
            this.txbPA.Size = new System.Drawing.Size(243, 20);
            this.txbPA.TabIndex = 6;
            // 
            // btnSelectXmlPA
            // 
            this.btnSelectXmlPA.Location = new System.Drawing.Point(641, 183);
            this.btnSelectXmlPA.Name = "btnSelectXmlPA";
            this.btnSelectXmlPA.Size = new System.Drawing.Size(105, 23);
            this.btnSelectXmlPA.TabIndex = 5;
            this.btnSelectXmlPA.Text = "Seleccionar Xml";
            this.btnSelectXmlPA.UseVisualStyleBackColor = true;
            this.btnSelectXmlPA.Click += new System.EventHandler(this.btnSelectXmlPA_Click);
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(886, 238);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(0, 13);
            this.lblDrug.TabIndex = 12;
            // 
            // btnUploadDrug
            // 
            this.btnUploadDrug.Location = new System.Drawing.Point(872, 102);
            this.btnUploadDrug.Name = "btnUploadDrug";
            this.btnUploadDrug.Size = new System.Drawing.Size(75, 23);
            this.btnUploadDrug.TabIndex = 11;
            this.btnUploadDrug.Text = "Subir Xml";
            this.btnUploadDrug.UseVisualStyleBackColor = true;
            this.btnUploadDrug.Click += new System.EventHandler(this.btnUploadDrug_Click);
            // 
            // txbDrug
            // 
            this.txbDrug.Location = new System.Drawing.Point(766, 184);
            this.txbDrug.Name = "txbDrug";
            this.txbDrug.Size = new System.Drawing.Size(243, 20);
            this.txbDrug.TabIndex = 10;
            // 
            // btnSelectXmlDrug
            // 
            this.btnSelectXmlDrug.Location = new System.Drawing.Point(1014, 180);
            this.btnSelectXmlDrug.Name = "btnSelectXmlDrug";
            this.btnSelectXmlDrug.Size = new System.Drawing.Size(105, 23);
            this.btnSelectXmlDrug.TabIndex = 9;
            this.btnSelectXmlDrug.Text = "Seleccionar Xml";
            this.btnSelectXmlDrug.UseVisualStyleBackColor = true;
            this.btnSelectXmlDrug.Click += new System.EventHandler(this.btnSelectXmlDrug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Laboratorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Principios activos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(872, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Producto";
            // 
            // frmLoadDataXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 394);
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
    }
}