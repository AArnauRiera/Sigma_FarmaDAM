namespace Manteniment
{
    partial class frmManteinUsers
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmail = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new Sigma_Controls.TxtSigma();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.label1);
            this.pnlTextBox.Controls.Add(this.txtSigma1);
            this.pnlTextBox.Controls.Add(this.tbxName);
            this.pnlTextBox.Controls.Add(this.lblName);
            this.pnlTextBox.Controls.Add(this.tbxLastName1);
            this.pnlTextBox.Controls.Add(this.label2);
            this.pnlTextBox.Controls.Add(this.tbxLastName2);
            this.pnlTextBox.Controls.Add(this.label3);
            this.pnlTextBox.Controls.Add(this.label5);
            this.pnlTextBox.Controls.Add(this.tbxDNI);
            this.pnlTextBox.Controls.Add(this.tbxEmail);
            this.pnlTextBox.Controls.Add(this.label4);
            // 
            // bntNew
            // 
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(-119, 7);
            this.pnlMantein.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.DBReference = "email";
            this.tbxEmail.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Email;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxEmail.ForeColor = System.Drawing.Color.Black;
            this.tbxEmail.Location = new System.Drawing.Point(255, 307);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(158, 23);
            this.tbxEmail.TabIndex = 29;
            this.tbxEmail.Table = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "DNI";
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "dni";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxDNI.ForeColor = System.Drawing.Color.Black;
            this.tbxDNI.Location = new System.Drawing.Point(255, 255);
            this.tbxDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(158, 23);
            this.tbxDNI.TabIndex = 27;
            this.tbxDNI.Table = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "2do Apellido";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName2.Location = new System.Drawing.Point(255, 201);
            this.tbxLastName2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Size = new System.Drawing.Size(158, 23);
            this.tbxLastName2.TabIndex = 25;
            this.tbxLastName2.Table = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "1r Apellido";
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName1.Location = new System.Drawing.Point(255, 149);
            this.tbxLastName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Size = new System.Drawing.Size(158, 23);
            this.tbxLastName1.TabIndex = 23;
            this.tbxLastName1.Table = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(101, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 23);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Nombre";
            // 
            // tbxName
            // 
            this.tbxName.DBReference = "firstName";
            this.tbxName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(255, 100);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(158, 23);
            this.tbxName.TabIndex = 21;
            this.tbxName.Table = null;
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "username";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Email;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSigma1.ForeColor = System.Drawing.Color.Black;
            this.txtSigma1.Location = new System.Drawing.Point(255, 351);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(158, 23);
            this.txtSigma1.TabIndex = 31;
            this.txtSigma1.Table = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuario";
            // 
            // frmManteinUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 920);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmManteinUsers";
            this.Text = "frmManteinUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sigma_Controls.TxtSigma tbxName;
        private System.Windows.Forms.Label lblName;
        private Sigma_Controls.TxtSigma tbxLastName1;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma tbxLastName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Sigma_Controls.TxtSigma tbxDNI;
        private Sigma_Controls.TxtSigma tbxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtSigma1;
    }
}