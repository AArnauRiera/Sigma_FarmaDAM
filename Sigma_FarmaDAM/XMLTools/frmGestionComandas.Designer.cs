namespace XMLTools
{
    partial class frmGestionComandas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSelectXmlLab = new System.Windows.Forms.Button();
            this.txtbxXmlLab = new System.Windows.Forms.TextBox();
            this.btnUploadLab = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(340, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar y enviar"; 
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1 
            //  
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 30);
            this.dateTimePicker1.TabIndex = 3;
            //  
            // btnSelectXmlLab 
            //  
            this.btnSelectXmlLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSelectXmlLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSelectXmlLab.Location = new System.Drawing.Point(340, 134);
            this.btnSelectXmlLab.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectXmlLab.Name = "btnSelectXmlLab";
            this.btnSelectXmlLab.Size = new System.Drawing.Size(174, 35);
            this.btnSelectXmlLab.TabIndex = 17;
            this.btnSelectXmlLab.Text = "Seleccionar XML";
            this.btnSelectXmlLab.UseVisualStyleBackColor = true;
            this.btnSelectXmlLab.Click += new System.EventHandler(this.btnSelectXmlLab_Click);
            //  
            // txtbxXmlLab 
            //  
            this.txtbxXmlLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbxXmlLab.ForeColor = System.Drawing.Color.Black;
            this.txtbxXmlLab.Location = new System.Drawing.Point(3, 139);
            this.txtbxXmlLab.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxXmlLab.Name = "txtbxXmlLab";
            this.txtbxXmlLab.Size = new System.Drawing.Size(323, 30);
            this.txtbxXmlLab.TabIndex = 18;
            //  
            // btnUploadLab 
            //  
            this.btnUploadLab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUploadLab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUploadLab.Location = new System.Drawing.Point(340, 177);
            this.btnUploadLab.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadLab.Name = "btnUploadLab";
            this.btnUploadLab.Size = new System.Drawing.Size(174, 35);
            this.btnUploadLab.TabIndex = 19;
            this.btnUploadLab.Text = "Subir XML";
            this.btnUploadLab.UseVisualStyleBackColor = true;
            this.btnUploadLab.Click += new System.EventHandler(this.btnUploadLab_Click);
            //  
            // openFileDialog1 
            //  
            this.openFileDialog1.FileName = "openFileDialog1";
            //  
            // panel1 
            //  
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnUploadLab);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbxXmlLab);
            this.panel1.Controls.Add(this.btnSelectXmlLab);
            this.panel1.Location = new System.Drawing.Point(93, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 304);
            this.panel1.TabIndex = 20;
            //  
            // frmGestionComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 417);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionComandas";
            this.Text = "frmGestionComandas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSelectXmlLab;
        protected System.Windows.Forms.TextBox txtbxXmlLab;
        protected System.Windows.Forms.Button btnUploadLab;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}