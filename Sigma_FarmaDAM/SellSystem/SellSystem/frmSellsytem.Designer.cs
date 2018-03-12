namespace SellSystem
{
    partial class frmSellsytem
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
            this.pnltxt = new System.Windows.Forms.Panel();
            this.txtCantidad = new Sigma_Controls.TxtSigma();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClient = new Sigma_Controls.TxtSigma();
            this.NTS = new System.Windows.Forms.Label();
            this.txtProd = new Sigma_Controls.TxtSigma();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgView_Sell = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnltxt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltxt
            // 
            this.pnltxt.Controls.Add(this.txtCantidad);
            this.pnltxt.Controls.Add(this.label6);
            this.pnltxt.Controls.Add(this.label4);
            this.pnltxt.Controls.Add(this.txtCod);
            this.pnltxt.Controls.Add(this.label3);
            this.pnltxt.Controls.Add(this.label2);
            this.pnltxt.Controls.Add(this.txtClient);
            this.pnltxt.Controls.Add(this.NTS);
            this.pnltxt.Controls.Add(this.txtProd);
            this.pnltxt.Controls.Add(this.lblName);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Controls.Add(this.btnAdd);
            this.pnltxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltxt.Location = new System.Drawing.Point(0, 0);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(974, 170);
            this.pnltxt.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(750, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.Table = null;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 36;
            // 
            // txtCod
            // 
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(88, 115);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 25;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numero de Registro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Producto";
            // 
            // txtClient
            // 
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.ForeColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(124, 51);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(106, 20);
            this.txtClient.TabIndex = 30;
            this.txtClient.Table = null;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClient_KeyDown);
            // 
            // NTS
            // 
            this.NTS.AutoSize = true;
            this.NTS.Location = new System.Drawing.Point(126, 36);
            this.NTS.Name = "NTS";
            this.NTS.Size = new System.Drawing.Size(29, 13);
            this.NTS.TabIndex = 27;
            this.NTS.Text = "NTS";
            // 
            // txtProd
            // 
            this.txtProd.AllowDrop = true;
            this.txtProd.DBReference = "CommercialName";
            this.txtProd.Enabled = false;
            this.txtProd.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtProd.ForeColor = System.Drawing.Color.Gray;
            this.txtProd.Location = new System.Drawing.Point(359, 112);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(206, 20);
            this.txtProd.TabIndex = 26;
            this.txtProd.Table = null;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(310, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(430, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 285);
            this.panel2.TabIndex = 11;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Location = new System.Drawing.Point(413, 244);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(133, 23);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgView_Sell
            // 
            this.dgView_Sell.Location = new System.Drawing.Point(0, 0);
            this.dgView_Sell.Name = "dgView_Sell";
            this.dgView_Sell.Size = new System.Drawing.Size(240, 150);
            this.dgView_Sell.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 125);
            this.panel1.TabIndex = 13;
            // 
            // txtClient
            // 
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtClient.Location = new System.Drawing.Point(185, 33);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 28;
            this.txtClient.Table = null;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClient_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numero de Registro";
            // 
            // txtCod
            // 
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(88, 115);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 25;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // label4
            // 
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.ForeColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(124, 51);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(106, 20);
            this.txtClient.TabIndex = 30;
            this.txtClient.Table = null;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtCantidad.Location = new System.Drawing.Point(750, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.Table = null;
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnltxt);
            this.Name = "frmSellsytem";
            this.Text = "SellSystem";
            this.Load += new System.EventHandler(this.frmSellsytem_Load);
            this.pnltxt.ResumeLayout(false);
            this.pnltxt.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnltxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgView_Sell;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtClient;
        private System.Windows.Forms.Label NTS;
        private Sigma_Controls.TxtSigma txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Sigma_Controls.TxtSigma txtCod;
        private System.Windows.Forms.Panel panel1;
    }
}

