namespace Manteniment
{
    partial class frmManteinClients
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
            this.tbxAddress1 = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
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
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
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
            this.pnlTextBox.Controls.Add(this.txtSigma1);
            this.pnlTextBox.Controls.Add(this.tbxAddress1);
            this.pnlTextBox.Controls.Add(this.label5);
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
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // pnlMantein
            // 
            this.pnlMantein.Location = new System.Drawing.Point(5, 23);
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.DBReference = "address1";
            this.tbxAddress1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.tbxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress1.Location = new System.Drawing.Point(139, 92);
            this.tbxAddress1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(188, 20);
            this.tbxAddress1.TabIndex = 3;
            this.tbxAddress1.Table = null;
            this.tbxAddress1.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.tbxAddress1.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dirección";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.DBReference = "Name";
            this.tbxFirstName.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.Location = new System.Drawing.Point(139, 122);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(188, 20);
            this.tbxFirstName.TabIndex = 4;
            this.tbxFirstName.Table = null;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.tbxFirstName.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(134, -19);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 52;
            // 
            // tbxLastName1
            // 
            this.tbxLastName1.DBReference = "lastName1";
            this.tbxLastName1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName1.Location = new System.Drawing.Point(139, 151);
            this.tbxLastName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLastName1.Name = "tbxLastName1";
            this.tbxLastName1.Size = new System.Drawing.Size(188, 20);
            this.tbxLastName1.TabIndex = 5;
            this.tbxLastName1.Table = null;
            this.tbxLastName1.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.tbxLastName1.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Primer apellido";
            // 
            // tbxLastName2
            // 
            this.tbxLastName2.DBReference = "lastName2";
            this.tbxLastName2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.LastName;
            this.tbxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName2.Location = new System.Drawing.Point(138, 180);
            this.tbxLastName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLastName2.Name = "tbxLastName2";
            this.tbxLastName2.Size = new System.Drawing.Size(188, 20);
            this.tbxLastName2.TabIndex = 6;
            this.tbxLastName2.Table = null;
            this.tbxLastName2.TextChanged += new System.EventHandler(this.tbxEmpty_Leave);
            this.tbxLastName2.Leave += new System.EventHandler(this.tbxEmpty_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tipo NSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Segundo apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "NSS";
            // 
            // tbxDNI
            // 
            this.tbxDNI.DBReference = "DNI";
            this.tbxDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNI.ForeColor = System.Drawing.Color.Black;
            this.tbxDNI.Location = new System.Drawing.Point(139, 34);
            this.tbxDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(188, 20);
            this.tbxDNI.TabIndex = 1;
            this.tbxDNI.Table = null;
            this.tbxDNI.Tag = "";
            this.tbxDNI.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.tbxDNI.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // tbxNTS
            // 
            this.tbxNTS.DBReference = "NTS";
            this.tbxNTS.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.tbxNTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNTS.ForeColor = System.Drawing.Color.Black;
            this.tbxNTS.Location = new System.Drawing.Point(138, 5);
            this.tbxNTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxNTS.Name = "tbxNTS";
            this.tbxNTS.Size = new System.Drawing.Size(188, 20);
            this.tbxNTS.TabIndex = 0;
            this.tbxNTS.Table = null;
            this.tbxNTS.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.tbxNTS.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "DNI";
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "Type_NTS";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma1.ForeColor = System.Drawing.Color.Black;
            this.txtSigma1.Location = new System.Drawing.Point(138, 63);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(188, 20);
            this.txtSigma1.TabIndex = 2;
            this.txtSigma1.Table = null;
            this.txtSigma1.TextChanged += new System.EventHandler(this.tbx_Leave);
            this.txtSigma1.Leave += new System.EventHandler(this.tbx_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmManteinClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(957, 662);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmManteinClients";
            ((System.ComponentModel.ISupportInitialize)(this.dts)).EndInit();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMantein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Sigma_Controls.TxtSigma tbxAddress1;
        private System.Windows.Forms.Label label5;
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
        public Sigma_Controls.TxtSigma txtSigma1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
