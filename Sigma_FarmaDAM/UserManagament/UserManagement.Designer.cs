﻿namespace UserManagament
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
            this.components = new System.ComponentModel.Container();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.pnlUserManagmnet = new System.Windows.Forms.Panel();
            this.tbxAddress1 = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxNTS_Type = new Sigma_Controls.cbxSigma();
            this.tbxFirstName = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.tbxNTS = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlUserManagmnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(192, 566);
            this.lblErrorText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(0, 19);
            this.lblErrorText.TabIndex = 20;
            // 
            // pnlUserManagmnet
            // 
            this.pnlUserManagmnet.Controls.Add(this.tbxAddress1);
            this.pnlUserManagmnet.Controls.Add(this.label5);
            this.pnlUserManagmnet.Controls.Add(this.btnGuardar);
            this.pnlUserManagmnet.Controls.Add(this.cbxNTS_Type);
            this.pnlUserManagmnet.Controls.Add(this.tbxFirstName);
            this.pnlUserManagmnet.Controls.Add(this.label1);
            this.pnlUserManagmnet.Controls.Add(this.lblError);
            this.pnlUserManagmnet.Controls.Add(this.tbxLastName1);
            this.pnlUserManagmnet.Controls.Add(this.lblTitle);
            this.pnlUserManagmnet.Controls.Add(this.label2);
            this.pnlUserManagmnet.Controls.Add(this.tbxLastName2);
            this.pnlUserManagmnet.Controls.Add(this.label7);
            this.pnlUserManagmnet.Controls.Add(this.label3);
            this.pnlUserManagmnet.Controls.Add(this.label6);
            this.pnlUserManagmnet.Controls.Add(this.tbxDNI);
            this.pnlUserManagmnet.Controls.Add(this.tbxNTS);
            this.pnlUserManagmnet.Controls.Add(this.label4);
            this.pnlUserManagmnet.Location = new System.Drawing.Point(41, 49);
            this.pnlUserManagmnet.Name = "pnlUserManagmnet";
            this.pnlUserManagmnet.Size = new System.Drawing.Size(415, 461);
            this.pnlUserManagmnet.TabIndex = 22;
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.DBReference = "address1";
            this.tbxAddress1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress1.IsForeginKey = false;
            this.tbxAddress1.Location = new System.Drawing.Point(159, 219);
            this.tbxAddress1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(211, 20);
            this.tbxAddress1.TabIndex = 25;
            this.tbxAddress1.Table = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Direccion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(157, 363);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 40);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxNTS_Type
            // 
            this.cbxNTS_Type.DBReference = "Type_NTS";
            this.cbxNTS_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNTS_Type.ForeginData = null;
            this.cbxNTS_Type.ForeginTable = null;
            this.cbxNTS_Type.ForeginValue = null;
            this.cbxNTS_Type.FormattingEnabled = true;
            this.cbxNTS_Type.Location = new System.Drawing.Point(159, 171);
            this.cbxNTS_Type.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxNTS_Type.Name = "cbxNTS_Type";
            this.cbxNTS_Type.Size = new System.Drawing.Size(211, 27);
            this.cbxNTS_Type.TabIndex = 24;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DBReference = "Name";
            this.tbxFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.IsForeginKey = false;
            this.tbxFirstName.Location = new System.Drawing.Point(159, 251);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(211, 20);
            this.tbxFirstName.TabIndex = 27;
            this.tbxFirstName.Table = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(154, 72);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 35;
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName1.IsForeginKey = false;
            this.tbxLastName1.Location = new System.Drawing.Point(159, 286);
            this.tbxLastName1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Size = new System.Drawing.Size(211, 20);
            this.tbxLastName1.TabIndex = 28;
            this.tbxLastName1.Table = null;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(152, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 26);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Primer apellido";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName2.IsForeginKey = false;
            this.tbxLastName2.Location = new System.Drawing.Point(158, 321);
            this.tbxLastName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Size = new System.Drawing.Size(211, 20);
            this.tbxLastName2.TabIndex = 29;
            this.tbxLastName2.Table = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tipo NSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Segundo apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "NSS";
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "DNI";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNI.ForeColor = System.Drawing.Color.Black;
            this.tbxDNI.IsForeginKey = false;
            this.tbxDNI.Location = new System.Drawing.Point(159, 136);
            this.tbxDNI.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(211, 20);
            this.tbxDNI.TabIndex = 23;
            this.tbxDNI.Table = null;
            this.tbxDNI.Tag = "";
            // 
            // tbxNTS
            // 
            this.tbxNTS.DBReference = "NTS";
            this.tbxNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.tbxNTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNTS.ForeColor = System.Drawing.Color.Black;
            this.tbxNTS.IsForeginKey = false;
            this.tbxNTS.Location = new System.Drawing.Point(158, 101);
            this.tbxNTS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxNTS.Name = "tbxNTS";
            this.tbxNTS.Size = new System.Drawing.Size(211, 20);
            this.tbxNTS.TabIndex = 22;
            this.tbxNTS.Table = null;
            this.tbxNTS.TextChanged += new System.EventHandler(this.tbxNTS_TextChanged);
            this.tbxNTS.Leave += new System.EventHandler(this.tbxNTS_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "DNI";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 714);
            this.Controls.Add(this.pnlUserManagmnet);
            this.Controls.Add(this.lblErrorText);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.pnlUserManagmnet.ResumeLayout(false);
            this.pnlUserManagmnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Panel pnlUserManagmnet;
        public System.Windows.Forms.Button btnGuardar;
        private Sigma_Controls.cbxSigma cbxNTS_Type;
        public Sigma_Controls.TxtSigma tbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        public Sigma_Controls.TxtSigma tbxLastName1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        public Sigma_Controls.TxtSigma tbxLastName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public Sigma_Controls.TxtSigma tbxDNI;
        public Sigma_Controls.TxtSigma tbxNTS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public Sigma_Controls.TxtSigma tbxAddress1;
        private System.Windows.Forms.Label label5;
    }
}

