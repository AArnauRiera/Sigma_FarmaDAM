namespace Sigma_FarmaDAM
{
    partial class frmLogin
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
            this.txtUsername = new Sigma_Controls.TxtSigma();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Sigma_Controls.TxtSigma();
            this.btnLogin = new System.Windows.Forms.Button();
            this.palLogin = new System.Windows.Forms.Panel();
            this.palLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.DBReference = null;
            this.txtUsername.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtUsername.Location = new System.Drawing.Point(82, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 33);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.DBReference = null;
            this.txtPassword.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Password;
            this.txtPassword.Location = new System.Drawing.Point(82, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(82, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // palLogin
            // 
            this.palLogin.Controls.Add(this.lblUsername);
            this.palLogin.Controls.Add(this.btnLogin);
            this.palLogin.Controls.Add(this.txtUsername);
            this.palLogin.Controls.Add(this.lblPassword);
            this.palLogin.Controls.Add(this.txtPassword);
            this.palLogin.Location = new System.Drawing.Point(151, 66);
            this.palLogin.Name = "palLogin";
            this.palLogin.Size = new System.Drawing.Size(288, 183);
            this.palLogin.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 408);
            this.Controls.Add(this.palLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.palLogin.ResumeLayout(false);
            this.palLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Sigma_Controls.TxtSigma txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel palLogin;
    }
}