﻿namespace Mantein
{
    partial class frmQuerySeller
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
            if(disposing && (components != null))
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
            this.txtFirstName = new Sigma_Controls.TxtSigma();
            this.txtLastName1 = new Sigma_Controls.TxtSigma();
            this.txtLastName2 = new Sigma_Controls.TxtSigma();
            this.txtDNI = new Sigma_Controls.TxtSigma();
            this.txtUsername = new Sigma_Controls.TxtSigma();
            this.txtPassword = new Sigma_Controls.TxtSigma();
            this.txtEmail = new Sigma_Controls.TxtSigma();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblPassword);
            this.pnlTB.Controls.Add(this.lblUsername);
            this.pnlTB.Controls.Add(this.lblEmail);
            this.pnlTB.Controls.Add(this.lblDNI);
            this.pnlTB.Controls.Add(this.lblLastName2);
            this.pnlTB.Controls.Add(this.lblLastName1);
            this.pnlTB.Controls.Add(this.lblFirstName);
            this.pnlTB.Controls.Add(this.txtEmail);
            this.pnlTB.Controls.Add(this.txtPassword);
            this.pnlTB.Controls.Add(this.txtUsername);
            this.pnlTB.Controls.Add(this.txtDNI);
            this.pnlTB.Controls.Add(this.txtLastName2);
            this.pnlTB.Controls.Add(this.txtLastName1);
            this.pnlTB.Controls.Add(this.txtFirstName);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DBReference = "firstName";
            this.txtFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtFirstName.Location = new System.Drawing.Point(139, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Placeholder = null;
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Table = "Seller";
            // 
            // txtLastName1
            // 
            this.txtLastName1.DBReference = "lastName1";
            this.txtLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName1.Location = new System.Drawing.Point(139, 47);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Placeholder = null;
            this.txtLastName1.Size = new System.Drawing.Size(100, 20);
            this.txtLastName1.TabIndex = 0;
            this.txtLastName1.Table = "Seller";
            // 
            // txtLastName2
            // 
            this.txtLastName2.DBReference = "lastName2";
            this.txtLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName2.Location = new System.Drawing.Point(139, 73);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Placeholder = null;
            this.txtLastName2.Size = new System.Drawing.Size(100, 20);
            this.txtLastName2.TabIndex = 0;
            this.txtLastName2.Table = "Seller";
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "dni";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDNI.Location = new System.Drawing.Point(139, 99);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Placeholder = null;
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.Table = "Seller";
            // 
            // txtUsername
            // 
            this.txtUsername.DBReference = "username";
            this.txtUsername.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtUsername.Location = new System.Drawing.Point(345, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Placeholder = null;
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Table = "Seller";
            // 
            // txtPassword
            // 
            this.txtPassword.DBReference = "password";
            this.txtPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtPassword.Location = new System.Drawing.Point(345, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Placeholder = null;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Table = "Seller";
            // 
            // txtEmail
            // 
            this.txtEmail.DBReference = "email";
            this.txtEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtEmail.Location = new System.Drawing.Point(345, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = null;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Table = "Seller";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(76, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(66, 47);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(67, 13);
            this.lblLastName1.TabIndex = 1;
            this.lblLastName1.Text = "Last Name 1";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(66, 73);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(67, 13);
            this.lblLastName2.TabIndex = 1;
            this.lblLastName2.Text = "Last Name 2";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(107, 99);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(307, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(284, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(286, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // frmQuerySeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Name = "frmQuerySeller";
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtFirstName;
        private Sigma_Controls.TxtSigma txtEmail;
        private Sigma_Controls.TxtSigma txtPassword;
        private Sigma_Controls.TxtSigma txtUsername;
        private Sigma_Controls.TxtSigma txtDNI;
        private Sigma_Controls.TxtSigma txtLastName2;
        private Sigma_Controls.TxtSigma txtLastName1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.Label lblLastName1;
        private System.Windows.Forms.Label lblFirstName;
    }
}