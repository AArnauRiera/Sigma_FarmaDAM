﻿namespace Manteniment
{
    partial class frmManteinSeller
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
            this.components = new System.ComponentModel.Container();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new Sigma_Controls.TxtSigma();
            this.txtPassword = new Sigma_Controls.TxtSigma();
            this.txtUsername = new Sigma_Controls.TxtSigma();
            this.txtDNI = new Sigma_Controls.TxtSigma();
            this.txtLastName2 = new Sigma_Controls.TxtSigma();
            this.txtLastName1 = new Sigma_Controls.TxtSigma();
            this.txtFirstName = new Sigma_Controls.TxtSigma();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.lblPassword);
            this.pnlTextBox.Controls.Add(this.lblUsername);
            this.pnlTextBox.Controls.Add(this.lblEmail);
            this.pnlTextBox.Controls.Add(this.lblDNI);
            this.pnlTextBox.Controls.Add(this.lblLastName2);
            this.pnlTextBox.Controls.Add(this.lblLastName1);
            this.pnlTextBox.Controls.Add(this.lblFirstName);
            this.pnlTextBox.Controls.Add(this.txtEmail);
            this.pnlTextBox.Controls.Add(this.txtPassword);
            this.pnlTextBox.Controls.Add(this.txtUsername);
            this.pnlTextBox.Controls.Add(this.txtDNI);
            this.pnlTextBox.Controls.Add(this.txtLastName2);
            this.pnlTextBox.Controls.Add(this.txtLastName1);
            this.pnlTextBox.Controls.Add(this.txtFirstName);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(1, 6);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 172);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(4, 144);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 19);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Usuario";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 116);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(4, 88);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 19);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "DNI";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(4, 60);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(114, 19);
            this.lblLastName2.TabIndex = 13;
            this.lblLastName2.Text = "Segundo apellido";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(4, 32);
            this.lblLastName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(100, 19);
            this.lblLastName1.TabIndex = 14;
            this.lblLastName1.Text = "Primer apellido";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(4, 5);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(59, 19);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.DBReference = "email";
            this.txtEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.IsForeginKey = false;
            this.txtEmail.Location = new System.Drawing.Point(195, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 19);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Table = "Seller";
            this.txtEmail.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtEmail.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.DBReference = "password";
            this.txtPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.IsForeginKey = false;
            this.txtPassword.Location = new System.Drawing.Point(195, 173);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 19);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Table = "Seller";
            this.txtPassword.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtPassword.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.DBReference = "username";
            this.txtUsername.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.IsForeginKey = false;
            this.txtUsername.Location = new System.Drawing.Point(195, 145);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 19);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Table = "Seller";
            this.txtUsername.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtUsername.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "dni";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtDNI.ForeColor = System.Drawing.Color.Gray;
            this.txtDNI.IsForeginKey = false;
            this.txtDNI.Location = new System.Drawing.Point(195, 89);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(132, 19);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Table = "Seller";
            this.txtDNI.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtDNI.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtLastName2
            // 
            this.txtLastName2.DBReference = "lastName2";
            this.txtLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtLastName2.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName2.IsForeginKey = false;
            this.txtLastName2.Location = new System.Drawing.Point(195, 61);
            this.txtLastName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(132, 19);
            this.txtLastName2.TabIndex = 2;
            this.txtLastName2.Table = "Seller";
            this.txtLastName2.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.txtLastName2.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // txtLastName1
            // 
            this.txtLastName1.DBReference = "lastName1";
            this.txtLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtLastName1.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName1.IsForeginKey = false;
            this.txtLastName1.Location = new System.Drawing.Point(195, 33);
            this.txtLastName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(132, 19);
            this.txtLastName1.TabIndex = 1;
            this.txtLastName1.Table = "Seller";
            this.txtLastName1.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtLastName1.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DBReference = "firstName";
            this.txtFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.IsForeginKey = false;
            this.txtFirstName.Location = new System.Drawing.Point(195, 5);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 19);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Table = "Seller";
            this.txtFirstName.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtFirstName.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmManteinSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(949, 628);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinSeller";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.Label lblLastName1;
        private System.Windows.Forms.Label lblFirstName;
        private Sigma_Controls.TxtSigma txtEmail;
        private Sigma_Controls.TxtSigma txtPassword;
        private Sigma_Controls.TxtSigma txtUsername;
        private Sigma_Controls.TxtSigma txtDNI;
        private Sigma_Controls.TxtSigma txtLastName2;
        private Sigma_Controls.TxtSigma txtLastName1;
        private Sigma_Controls.TxtSigma txtFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
