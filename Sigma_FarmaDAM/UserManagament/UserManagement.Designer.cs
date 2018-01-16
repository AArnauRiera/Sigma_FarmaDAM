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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxNTS = new Sigma_Controls.TxtSigma();
            this.tbxEmail = new Sigma_Controls.TxtSigma();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.tbxFirstName = new Sigma_Controls.TxtSigma();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "NTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "NTS Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(142, 374);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(75, 23);
            this.btnUserManagement.TabIndex = 15;
            this.btnUserManagement.Text = "Save";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 26);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "User";
            // 
            // tbxNTS
            // 
            this.tbxNTS.DBReference = null;
            this.tbxNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxNTS.Location = new System.Drawing.Point(131, 116);
            this.tbxNTS.Name = "tbxNTS";
            this.tbxNTS.Placeholder = "NTS";
            this.tbxNTS.Size = new System.Drawing.Size(142, 20);
            this.tbxNTS.TabIndex = 10;
            // 
            // tbxEmail
            // 
            this.tbxEmail.DBReference = null;
            this.tbxEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Email;
            this.tbxEmail.Location = new System.Drawing.Point(132, 327);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Placeholder = "Email";
            this.tbxEmail.Size = new System.Drawing.Size(142, 20);
            this.tbxEmail.TabIndex = 8;
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = null;
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Location = new System.Drawing.Point(131, 78);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Placeholder = "DNI";
            this.tbxDNI.Size = new System.Drawing.Size(142, 20);
            this.tbxDNI.TabIndex = 6;
            this.tbxDNI.Tag = "";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = null;
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxLastName2.Location = new System.Drawing.Point(131, 286);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Placeholder = "LastName";
            this.tbxLastName2.Size = new System.Drawing.Size(142, 20);
            this.tbxLastName2.TabIndex = 4;
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = null;
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName1.Location = new System.Drawing.Point(131, 246);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Placeholder = "LastName";
            this.tbxLastName1.Size = new System.Drawing.Size(142, 20);
            this.tbxLastName1.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DBReference = null;
            this.tbxFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxFirstName.Location = new System.Drawing.Point(131, 208);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Placeholder = "First Name";
            this.tbxFirstName.Size = new System.Drawing.Size(142, 20);
            this.tbxFirstName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Q";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(129, 139);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 18;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 429);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxNTS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxEmail);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnUserManagement;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblError;
        public Sigma_Controls.TxtSigma tbxFirstName;
        public Sigma_Controls.TxtSigma tbxLastName1;
        public Sigma_Controls.TxtSigma tbxLastName2;
        public Sigma_Controls.TxtSigma tbxDNI;
        public Sigma_Controls.TxtSigma tbxEmail;
        public Sigma_Controls.TxtSigma tbxNTS;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

