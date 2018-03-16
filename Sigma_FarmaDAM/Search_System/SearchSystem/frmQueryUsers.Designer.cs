namespace SearchSystem
{
    partial class frmQueryUsers
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
            this.components = new System.ComponentModel.Container();
            this.txtSigma1 = new Sigma_Controls.TxtSigma();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigma3 = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSigma4 = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSigma5 = new Sigma_Controls.TxtSigma();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSigma6 = new Sigma_Controls.TxtSigma();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.label6);
            this.pnlTB.Controls.Add(this.txtSigma6);
            this.pnlTB.Controls.Add(this.label4);
            this.pnlTB.Controls.Add(this.label5);
            this.pnlTB.Controls.Add(this.txtSigma4);
            this.pnlTB.Controls.Add(this.label2);
            this.pnlTB.Controls.Add(this.label3);
            this.pnlTB.Controls.Add(this.txtSigma5);
            this.pnlTB.Controls.Add(this.txtSigma3);
            this.pnlTB.Controls.Add(this.txtSigma2);
            this.pnlTB.Controls.Add(this.label1);
            this.pnlTB.Controls.Add(this.txtSigma1);
            // 
            // txtSigma1
            // 
            this.txtSigma1.DBReference = "firstName";
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtSigma1.Location = new System.Drawing.Point(167, 44);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(100, 20);
            this.txtSigma1.TabIndex = 0;
            this.txtSigma1.Table = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Apellido";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "lastName1";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtSigma2.Location = new System.Drawing.Point(167, 77);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(100, 20);
            this.txtSigma2.TabIndex = 2;
            this.txtSigma2.Table = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundo Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "lastName2";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtSigma3.Location = new System.Drawing.Point(167, 112);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Size = new System.Drawing.Size(100, 20);
            this.txtSigma3.TabIndex = 5;
            this.txtSigma3.Table = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // txtSigma4
            // 
            this.txtSigma4.DBReference = "dni";
            this.txtSigma4.FieldType = Sigma_Controls.TxtSigma.FieldTypes.DNI;
            this.txtSigma4.Location = new System.Drawing.Point(415, 44);
            this.txtSigma4.Name = "txtSigma4";
            this.txtSigma4.Size = new System.Drawing.Size(100, 20);
            this.txtSigma4.TabIndex = 7;
            this.txtSigma4.Table = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // txtSigma5
            // 
            this.txtSigma5.DBReference = "email";
            this.txtSigma5.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Email;
            this.txtSigma5.Location = new System.Drawing.Point(415, 80);
            this.txtSigma5.Name = "txtSigma5";
            this.txtSigma5.Size = new System.Drawing.Size(100, 20);
            this.txtSigma5.TabIndex = 9;
            this.txtSigma5.Table = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario";
            // 
            // txtSigma6
            // 
            this.txtSigma6.DBReference = "username";
            this.txtSigma6.FieldType = Sigma_Controls.TxtSigma.FieldTypes.Name;
            this.txtSigma6.Location = new System.Drawing.Point(415, 115);
            this.txtSigma6.Name = "txtSigma6";
            this.txtSigma6.Size = new System.Drawing.Size(100, 20);
            this.txtSigma6.TabIndex = 11;
            this.txtSigma6.Table = null;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmQueryUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueryUsers";
            this.Text = "Buscar Usuario";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sigma_Controls.TxtSigma txtSigma1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma2;
        private System.Windows.Forms.Label label5;
        private Sigma_Controls.TxtSigma txtSigma5;
        private System.Windows.Forms.Label label3;
        private Sigma_Controls.TxtSigma txtSigma3;
        private System.Windows.Forms.Label label4;
        private Sigma_Controls.TxtSigma txtSigma4;
        private System.Windows.Forms.Label label6;
        private Sigma_Controls.TxtSigma txtSigma6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}