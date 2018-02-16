namespace UserManagament
{
    partial class UserManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.cbxNTS_Type = new Sigma_Controls.cbxSigma();
            this.tbxNTS = new Sigma_Controls.TxtSigma();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.tbxFirstName = new Sigma_Controls.TxtSigma();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1r Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2ndo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "NSS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo NSS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 26);
            this.lblTitle.TabIndex = 16;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(128, 108);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 18;
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(128, 320);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(0, 13);
            this.lblErrorText.TabIndex = 20;
            // 
            // cbxNTS_Type
            // 
            this.cbxNTS_Type.DBReference = "Type_NTS";
            this.cbxNTS_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNTS_Type.FormattingEnabled = true;
            this.cbxNTS_Type.Location = new System.Drawing.Point(131, 168);
            this.cbxNTS_Type.Name = "cbxNTS_Type";
            this.cbxNTS_Type.Size = new System.Drawing.Size(142, 21);
            this.cbxNTS_Type.TabIndex = 21;
            // 
            // tbxNTS
            // 
            this.tbxNTS.DBReference = "NTS";
            this.tbxNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.tbxNTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbxNTS.ForeColor = System.Drawing.Color.Gray;
            this.tbxNTS.Location = new System.Drawing.Point(131, 79);
            this.tbxNTS.Name = "tbxNTS";
            this.tbxNTS.Placeholder = "";
            this.tbxNTS.Size = new System.Drawing.Size(142, 20);
            this.tbxNTS.TabIndex = 0;
            this.tbxNTS.Table = null;
            this.tbxNTS.TextChanged += new System.EventHandler(this.tbxNTS_TextChanged);
            this.tbxNTS.Leave += new System.EventHandler(this.tbxNTS_Leave);
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "DNI";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbxDNI.ForeColor = System.Drawing.Color.Gray;
            this.tbxDNI.Location = new System.Drawing.Point(131, 128);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Placeholder = "";
            this.tbxDNI.Size = new System.Drawing.Size(142, 20);
            this.tbxDNI.TabIndex = 1;
            this.tbxDNI.Table = null;
            this.tbxDNI.Tag = "";
            this.tbxDNI.TextChanged += new System.EventHandler(this.tbxDNI_TextChanged);
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbxLastName2.ForeColor = System.Drawing.Color.Gray;
            this.tbxLastName2.Location = new System.Drawing.Point(131, 286);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Placeholder = "";
            this.tbxLastName2.Size = new System.Drawing.Size(142, 20);
            this.tbxLastName2.TabIndex = 5;
            this.tbxLastName2.Table = null;
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbxLastName1.ForeColor = System.Drawing.Color.Gray;
            this.tbxLastName1.Location = new System.Drawing.Point(131, 246);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Placeholder = "";
            this.tbxLastName1.Size = new System.Drawing.Size(142, 20);
            this.tbxLastName1.TabIndex = 4;
            this.tbxLastName1.Table = null;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DBReference = "Name";
            this.tbxFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.tbxFirstName.Location = new System.Drawing.Point(131, 208);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Placeholder = "";
            this.tbxFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbxFirstName.TabIndex = 3;
            this.tbxFirstName.Table = null;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 404);
            this.Controls.Add(this.cbxNTS_Type);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxNTS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxLastName1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFirstName);
            this.Name = "UserManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblError;
        public Sigma_Controls.TxtSigma tbxFirstName;
        public Sigma_Controls.TxtSigma tbxLastName1;
        public Sigma_Controls.TxtSigma tbxLastName2;
        public Sigma_Controls.TxtSigma tbxDNI;
        public Sigma_Controls.TxtSigma tbxNTS;
        private Sigma_Controls.cbxSigma cbxNTS_Type;
        private System.Windows.Forms.Label lblErrorText;
    }
}

