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
            this.btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClient = new Sigma_Controls.TxtSigma();
            this.txtProd = new Sigma_Controls.TxtSigma();
            this.txtCantidad = new Sigma_Controls.TxtSigma();
            this.NTS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new Sigma_Controls.TxtSigma();
            this.pnlDgw = new System.Windows.Forms.Panel();
            this.dgView_Sell = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnltxt.SuspendLayout();
            this.pnlDgw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltxt
            // 
            this.pnltxt.Controls.Add(this.btn);
            this.pnltxt.Controls.Add(this.label3);
            this.pnltxt.Controls.Add(this.btnAdd);
            this.pnltxt.Controls.Add(this.txtClient);
            this.pnltxt.Controls.Add(this.txtProd);
            this.pnltxt.Controls.Add(this.txtCantidad);
            this.pnltxt.Controls.Add(this.NTS);
            this.pnltxt.Controls.Add(this.label2);
            this.pnltxt.Controls.Add(this.lblName);
            this.pnltxt.Controls.Add(this.label6);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Controls.Add(this.txtCod);
            this.pnltxt.Location = new System.Drawing.Point(4, 4);
            this.pnltxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(461, 752);
            this.pnltxt.TabIndex = 10;
            this.pnltxt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltxt_Paint);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn.Location = new System.Drawing.Point(357, 42);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 28);
            this.btn.TabIndex = 36;
            this.btn.Text = "Buscar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(5, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numero de Registro";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(317, 712);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClient
            // 
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtClient.Location = new System.Drawing.Point(317, 4);
            this.txtClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(140, 30);
            this.txtClient.TabIndex = 30;
            this.txtClient.Table = null;
            this.txtClient.Leave += new System.EventHandler(this.txtClient_Leave);
            // 
            // txtProd
            // 
            this.txtProd.AllowDrop = true;
            this.txtProd.DBReference = "CommercialName";
            this.txtProd.Enabled = false;
            this.txtProd.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtProd.Location = new System.Drawing.Point(108, 182);
            this.txtProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(349, 30);
            this.txtProd.TabIndex = 26;
            this.txtProd.Table = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCantidad.Location = new System.Drawing.Point(416, 220);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(41, 30);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.Table = null;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumKeyPress);
            // 
            // NTS
            // 
            this.NTS.AutoSize = true;
            this.NTS.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.NTS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NTS.Location = new System.Drawing.Point(4, 4);
            this.NTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NTS.Name = "NTS";
            this.NTS.Size = new System.Drawing.Size(41, 23);
            this.NTS.TabIndex = 27;
            this.NTS.Text = "NTS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(5, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Producto";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(317, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 23);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Datos del Cliente";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(4, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(5, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente:";
            // 
            // txtCod
            // 
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtCod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCod.Location = new System.Drawing.Point(325, 144);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(132, 30);
            this.txtCod.TabIndex = 25;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // pnlDgw
            // 
            this.pnlDgw.Controls.Add(this.dgView_Sell);
            this.pnlDgw.Controls.Add(this.btnBuy);
            this.pnlDgw.Location = new System.Drawing.Point(475, 4);
            this.pnlDgw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDgw.Name = "pnlDgw";
            this.pnlDgw.Size = new System.Drawing.Size(788, 756);
            this.pnlDgw.TabIndex = 11;
            // 
            // dgView_Sell
            // 
            this.dgView_Sell.BackgroundColor = System.Drawing.Color.White;
            this.dgView_Sell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgView_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sell.GridColor = System.Drawing.Color.White;
            this.dgView_Sell.Location = new System.Drawing.Point(4, 0);
            this.dgView_Sell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgView_Sell.Name = "dgView_Sell";
            this.dgView_Sell.Size = new System.Drawing.Size(780, 716);
            this.dgView_Sell.TabIndex = 13;
            this.dgView_Sell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Sell_CellContentClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Location = new System.Drawing.Point(335, 724);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(177, 28);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnltxt);
            this.panel1.Controls.Add(this.pnlDgw);
            this.panel1.Location = new System.Drawing.Point(93, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 763);
            this.panel1.TabIndex = 36;
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 812);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSellsytem";
            this.Text = "SellSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellsytem_FormClosing);
            this.Load += new System.EventHandler(this.frmSellsytem_Load);
            this.pnltxt.ResumeLayout(false);
            this.pnltxt.PerformLayout();
            this.pnlDgw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnltxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlDgw;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private Sigma_Controls.TxtSigma txtProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtClient;
        private System.Windows.Forms.Label NTS;
        private Sigma_Controls.TxtSigma txtCantidad;
        private System.Windows.Forms.Label label6;
        private Sigma_Controls.TxtSigma txtCod;
        private System.Windows.Forms.DataGridView dgView_Sell;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn;
    }
}

