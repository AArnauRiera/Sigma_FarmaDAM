namespace Manteniment
{
    partial class frmManteinUsers
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
            this.tbxAddress2 = new Sigma_Controls.TxtSigma();
            this.tbxAddress1 = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNTS_Type = new Sigma_Controls.cbxSigma();
            this.tbxFirstName = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbxLastName1 = new Sigma_Controls.TxtSigma();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName2 = new Sigma_Controls.TxtSigma();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDNI = new Sigma_Controls.TxtSigma();
            this.tbxNTS = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dts)).BeginInit();
            this.pnlTextBox.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMantein.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.tbxAddress2);
            this.pnlTextBox.Controls.Add(this.tbxAddress1);
            this.pnlTextBox.Controls.Add(this.label5);
            this.pnlTextBox.Controls.Add(this.cbxNTS_Type);
            this.pnlTextBox.Controls.Add(this.tbxFirstName);
            this.pnlTextBox.Controls.Add(this.label1);
            this.pnlTextBox.Controls.Add(this.lblError);
            this.pnlTextBox.Controls.Add(this.tbxLastName1);
            this.pnlTextBox.Controls.Add(this.label2);
            this.pnlTextBox.Controls.Add(this.tbxLastName2);
            this.pnlTextBox.Controls.Add(this.label7);
            this.pnlTextBox.Controls.Add(this.label3);
            this.pnlTextBox.Controls.Add(this.label6);
            this.pnlTextBox.Controls.Add(this.tbxDNI);
            this.pnlTextBox.Controls.Add(this.tbxNTS);
            this.pnlTextBox.Controls.Add(this.label4);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(0, 0);
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.DBReference = "address2";
            this.tbxAddress2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress2.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress2.Location = new System.Drawing.Point(156, 157);
            this.tbxAddress2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(211, 23);
            this.tbxAddress2.TabIndex = 43;
            this.tbxAddress2.Table = null;
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.DBReference = "address1";
            this.tbxAddress1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress1.Location = new System.Drawing.Point(156, 124);
            this.tbxAddress1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(211, 23);
            this.tbxAddress1.TabIndex = 42;
            this.tbxAddress1.Table = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Direccion";
            // 
            // cbxNTS_Type
            // 
            this.cbxNTS_Type.DBReference = "Type_NTS";
            this.cbxNTS_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNTS_Type.FormattingEnabled = true;
            this.cbxNTS_Type.Location = new System.Drawing.Point(156, 76);
            this.cbxNTS_Type.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxNTS_Type.Name = "cbxNTS_Type";
            this.cbxNTS_Type.Size = new System.Drawing.Size(211, 31);
            this.cbxNTS_Type.TabIndex = 41;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DBReference = "Name";
            this.tbxFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.Location = new System.Drawing.Point(157, 189);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(211, 23);
            this.tbxFirstName.TabIndex = 45;
            this.tbxFirstName.Table = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(134, 97);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 23);
            this.lblError.TabIndex = 53;
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName1.Location = new System.Drawing.Point(157, 224);
            this.tbxLastName1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Size = new System.Drawing.Size(211, 23);
            this.tbxLastName1.TabIndex = 46;
            this.tbxLastName1.Table = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Primer Apellido";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName2.Location = new System.Drawing.Point(156, 259);
            this.tbxLastName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Size = new System.Drawing.Size(211, 23);
            this.tbxLastName2.TabIndex = 47;
            this.tbxLastName2.Table = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tipo NSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "NSS";
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "DNI";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNI.ForeColor = System.Drawing.Color.Black;
            this.tbxDNI.Location = new System.Drawing.Point(156, 41);
            this.tbxDNI.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(211, 23);
            this.tbxDNI.TabIndex = 39;
            this.tbxDNI.Table = null;
            this.tbxDNI.Tag = "";
            // 
            // tbxNTS
            // 
            this.tbxNTS.DBReference = "NTS";
            this.tbxNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.tbxNTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNTS.ForeColor = System.Drawing.Color.Black;
            this.tbxNTS.Location = new System.Drawing.Point(155, 6);
            this.tbxNTS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxNTS.Name = "tbxNTS";
            this.tbxNTS.Size = new System.Drawing.Size(211, 23);
            this.tbxNTS.TabIndex = 38;
            this.tbxNTS.Table = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "DNI";
            // 
            // frmManteinUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Name = "frmManteinUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sigma_Controls.TxtSigma tbxAddress2;
        public Sigma_Controls.TxtSigma tbxAddress1;
        private System.Windows.Forms.Label label5;
        private Sigma_Controls.cbxSigma cbxNTS_Type;
        public Sigma_Controls.TxtSigma tbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        public Sigma_Controls.TxtSigma tbxLastName1;
        private System.Windows.Forms.Label label2;
        public Sigma_Controls.TxtSigma tbxLastName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public Sigma_Controls.TxtSigma tbxDNI;
        public Sigma_Controls.TxtSigma tbxNTS;
        private System.Windows.Forms.Label label4;
    }
}
