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
            this.txtbxXml = new System.Windows.Forms.TextBox();
            this.btnUploadLab = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadPA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelectXmlPA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUploadDrug = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.btnSelectXmlLab.Location = new System.Drawing.Point(355, 225);
            this.btnSelectXmlLab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectXmlLab.Name = "btnSelectXmlLab";
            this.btnSelectXmlLab.Size = new System.Drawing.Size(140, 28);
            this.btnSelectXmlLab.TabIndex = 1;
            this.btnSelectXmlLab.Text = "Seleccionar Xml";
            this.btnSelectXmlLab.UseVisualStyleBackColor = true;
            this.btnSelectXmlLab.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtbxXml
            // 
            this.txtbxXml.Location = new System.Drawing.Point(20, 227);
            this.txtbxXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxXml.Name = "txtbxXml";
            this.txtbxXml.Size = new System.Drawing.Size(323, 22);
            this.txtbxXml.TabIndex = 2;
            // 
            // btnUploadLab
            // 
            this.btnUploadLab.Location = new System.Drawing.Point(161, 126);
            this.btnUploadLab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadLab.Name = "btnUploadLab";
            this.btnUploadLab.Size = new System.Drawing.Size(100, 28);
            this.btnUploadLab.TabIndex = 3;
            this.btnUploadLab.Text = "Subir Xml";
            this.btnUploadLab.UseVisualStyleBackColor = true;
            this.btnUploadLab.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(180, 293);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 17);
            this.lblCounter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // btnUploadPA
            // 
            this.btnUploadPA.Location = new System.Drawing.Point(661, 126);
            this.btnUploadPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPA.Name = "btnUploadPA";
            this.btnUploadPA.Size = new System.Drawing.Size(100, 28);
            this.btnUploadPA.TabIndex = 7;
            this.btnUploadPA.Text = "Subir Xml";
            this.btnUploadPA.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 227);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 22);
            this.textBox1.TabIndex = 6;
            // 
            // btnSelectXmlPA
            // 
            this.btnSelectXmlPA.Location = new System.Drawing.Point(855, 225);
            this.btnSelectXmlPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlPA.Name = "btnSelectXmlPA";
            this.btnSelectXmlPA.Size = new System.Drawing.Size(140, 28);
            this.btnSelectXmlPA.TabIndex = 5;
            this.btnSelectXmlPA.Text = "Seleccionar Xml";
            this.btnSelectXmlPA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1181, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // btnUploadDrug
            // 
            this.btnUploadDrug.Location = new System.Drawing.Point(1162, 126);
            this.btnUploadDrug.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadDrug.Name = "btnUploadDrug";
            this.btnUploadDrug.Size = new System.Drawing.Size(100, 28);
            this.btnUploadDrug.TabIndex = 11;
            this.btnUploadDrug.Text = "Subir Xml";
            this.btnUploadDrug.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1021, 227);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 22);
            this.textBox2.TabIndex = 10;
            // 
            // btnSelectXmlDrug
            // 
            this.btnSelectXmlDrug.Location = new System.Drawing.Point(1352, 221);
            this.btnSelectXmlDrug.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlDrug.Name = "btnSelectXmlDrug";
            this.btnSelectXmlDrug.Size = new System.Drawing.Size(140, 28);
            this.btnSelectXmlDrug.TabIndex = 9;
            this.btnSelectXmlDrug.Text = "Seleccionar Xml";
            this.btnSelectXmlDrug.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Laboratorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Principios activos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1162, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Producto";
            // 
            // frmLoadDataXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUploadDrug);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSelectXmlDrug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadPA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectXmlPA);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnUploadLab);
            this.Controls.Add(this.txtbxXml);
            this.Controls.Add(this.btnSelectXmlLab);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoadDataXML";
            this.Text = "frmLoadDataXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectXmlLab;
        protected System.Windows.Forms.TextBox txtbxXml;
        protected System.Windows.Forms.Button btnUploadLab;
        public System.Windows.Forms.Label lblCounter;
        public System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnUploadPA;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelectXmlPA;
        public System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnUploadDrug;
        protected System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSelectXmlDrug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}