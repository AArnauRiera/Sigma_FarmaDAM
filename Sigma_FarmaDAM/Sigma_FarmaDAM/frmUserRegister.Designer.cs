namespace UserRegister
{
    partial class frmUserRegister
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
            if(disposing && (components != null))
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
            this.tbxName = new Sigma_Controls.TxtSigma();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmail = new Sigma_Controls.TxtSigma();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxUsername = new Sigma_Controls.TxtSigma();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPassword = new Sigma_Controls.TxtSigma();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRepeatPassword = new Sigma_Controls.TxtSigma();
            this.chbAdmin = new Sigma_Controls.CheckBoxSigma();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.DBReference = "firstName";
            this.tbxName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(201, 95);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(182, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.Table = null;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(175, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1r Apellido";
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName1.Location = new System.Drawing.Point(201, 135);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Size = new System.Drawing.Size(182, 20);
            this.tbxLastName1.TabIndex = 3;
            this.tbxLastName1.Table = null;
            this.tbxLastName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2do Apellido";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName2.Location = new System.Drawing.Point(201, 178);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Size = new System.Drawing.Size(182, 20);
            this.tbxLastName2.TabIndex = 5;
            this.tbxLastName2.Table = null;
            this.tbxLastName2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "dni";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxDNI.ForeColor = System.Drawing.Color.Black;
            this.tbxDNI.Location = new System.Drawing.Point(201, 223);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(182, 20);
            this.tbxDNI.TabIndex = 7;
            this.tbxDNI.Table = null;
            this.tbxDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.DBReference = "email";
            this.tbxEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Email;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxEmail.ForeColor = System.Drawing.Color.Black;
            this.tbxEmail.Location = new System.Drawing.Point(201, 266);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(182, 20);
            this.tbxEmail.TabIndex = 9;
            this.tbxEmail.Table = null;
            this.tbxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario";
            // 
            // tbxUsername
            // 
            this.tbxUsername.DBReference = "username";
            this.tbxUsername.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxUsername.ForeColor = System.Drawing.Color.Black;
            this.tbxUsername.Location = new System.Drawing.Point(201, 311);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(182, 20);
            this.tbxUsername.TabIndex = 11;
            this.tbxUsername.Table = null;
            this.tbxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contraseña";
            // 
            // tbxPassword
            // 
            this.tbxPassword.DBReference = "password";
            this.tbxPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Password;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxPassword.Location = new System.Drawing.Point(201, 352);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(182, 20);
            this.tbxPassword.TabIndex = 13;
            this.tbxPassword.Table = null;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Añadir usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Repetir Contraseña";
            // 
            // tbxRepeatPassword
            // 
            this.tbxRepeatPassword.DBReference = "";
            this.tbxRepeatPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Password;
            this.tbxRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxRepeatPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxRepeatPassword.Location = new System.Drawing.Point(201, 394);
            this.tbxRepeatPassword.Name = "tbxRepeatPassword";
            this.tbxRepeatPassword.Size = new System.Drawing.Size(182, 20);
            this.tbxRepeatPassword.TabIndex = 18;
            this.tbxRepeatPassword.Table = null;
            this.tbxRepeatPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.DBReference = "rol";
            this.chbAdmin.Location = new System.Drawing.Point(201, 435);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(89, 17);
            this.chbAdmin.TabIndex = 20;
            this.chbAdmin.Text = "Administrador";
            this.chbAdmin.UseVisualStyleBackColor = true;
            this.chbAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 565);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRepeatPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxLastName1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxName);
            this.Name = "frmUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserRegister";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sigma_Controls.TxtSigma tbxName;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma tbxLastName1;
        private System.Windows.Forms.Label label3;
        private Sigma_Controls.TxtSigma tbxLastName2;
        private System.Windows.Forms.Label label4;
        private Sigma_Controls.TxtSigma tbxDNI;
        private System.Windows.Forms.Label label5;
        private Sigma_Controls.TxtSigma tbxEmail;
        private System.Windows.Forms.Label label6;
        private Sigma_Controls.TxtSigma tbxUsername;
        private System.Windows.Forms.Label label7;
        private Sigma_Controls.TxtSigma tbxPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma tbxRepeatPassword;
        private Sigma_Controls.CheckBoxSigma chbAdmin;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}