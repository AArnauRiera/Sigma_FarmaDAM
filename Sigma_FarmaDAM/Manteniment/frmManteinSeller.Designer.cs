namespace Manteniment
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
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 208);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(4, 174);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(4, 106);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 23);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "DNI";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(4, 73);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(105, 23);
            this.lblLastName2.TabIndex = 13;
            this.lblLastName2.Text = "Last Name 2";
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(4, 39);
            this.lblLastName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(105, 23);
            this.lblLastName1.TabIndex = 14;
            this.lblLastName1.Text = "Last Name 1";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(4, 6);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 23);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.DBReference = "email";
            this.txtEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(219, 142);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Table = "Seller";
            // 
            // txtPassword
            // 
            this.txtPassword.DBReference = "password";
            this.txtPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(219, 210);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Table = "Seller";
            // 
            // txtUsername
            // 
            this.txtUsername.DBReference = "username";
            this.txtUsername.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(219, 176);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Table = "Seller";
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "dni";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtDNI.ForeColor = System.Drawing.Color.Gray;
            this.txtDNI.Location = new System.Drawing.Point(219, 108);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 22);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.Table = "Seller";
            // 
            // txtLastName2
            // 
            this.txtLastName2.DBReference = "lastName2";
            this.txtLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtLastName2.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName2.Location = new System.Drawing.Point(219, 74);
            this.txtLastName2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(148, 22);
            this.txtLastName2.TabIndex = 6;
            this.txtLastName2.Table = "Seller";
            // 
            // txtLastName1
            // 
            this.txtLastName1.DBReference = "lastName1";
            this.txtLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtLastName1.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName1.Location = new System.Drawing.Point(219, 40);
            this.txtLastName1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(148, 22);
            this.txtLastName1.TabIndex = 7;
            this.txtLastName1.Table = "Seller";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DBReference = "firstName";
            this.txtFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(219, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 22);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Table = "Seller";
            // 
            // frmManteinSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmManteinSeller";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
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
    }
}
