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
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
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
            this.txtSigma1.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma1.Location = new System.Drawing.Point(223, 54);
            this.txtSigma1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigma1.Name = "txtSigma1";
            this.txtSigma1.Size = new System.Drawing.Size(132, 22);
            this.txtSigma1.TabIndex = 0;
            this.txtSigma1.Table = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Apellido";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "lastName1";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma2.Location = new System.Drawing.Point(223, 95);
            this.txtSigma2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Size = new System.Drawing.Size(132, 22);
            this.txtSigma2.TabIndex = 2;
            this.txtSigma2.Table = null;
            this.txtSigma2.TextChanged += new System.EventHandler(this.txtSigma2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundo Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "lastName2";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma3.Location = new System.Drawing.Point(223, 138);
            this.txtSigma3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Size = new System.Drawing.Size(132, 22);
            this.txtSigma3.TabIndex = 5;
            this.txtSigma3.Table = null;
            this.txtSigma3.TextChanged += new System.EventHandler(this.txtSigma3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // txtSigma4
            // 
            this.txtSigma4.DBReference = "dni";
            this.txtSigma4.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma4.Location = new System.Drawing.Point(553, 54);
            this.txtSigma4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigma4.Name = "txtSigma4";
            this.txtSigma4.Size = new System.Drawing.Size(132, 22);
            this.txtSigma4.TabIndex = 7;
            this.txtSigma4.Table = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // txtSigma5
            // 
            this.txtSigma5.DBReference = "email";
            this.txtSigma5.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma5.Location = new System.Drawing.Point(553, 98);
            this.txtSigma5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigma5.Name = "txtSigma5";
            this.txtSigma5.Size = new System.Drawing.Size(132, 22);
            this.txtSigma5.TabIndex = 9;
            this.txtSigma5.Table = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario";
            // 
            // txtSigma6
            // 
            this.txtSigma6.DBReference = "username";
            this.txtSigma6.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtSigma6.Location = new System.Drawing.Point(553, 142);
            this.txtSigma6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigma6.Name = "txtSigma6";
            this.txtSigma6.Size = new System.Drawing.Size(132, 22);
            this.txtSigma6.TabIndex = 11;
            this.txtSigma6.Table = null;
            // 
            // frmQueryUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 617);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmQueryUsers";
            this.Text = "Buscar Usuario";
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
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
    }
}