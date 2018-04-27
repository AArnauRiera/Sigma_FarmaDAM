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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new Sigma_Controls.TxtSigma();
            this.pnlDgw = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgView_Sell = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.pnltxt.SuspendLayout();
            this.pnlDgw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltxt
            // 
            this.pnltxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnltxt.Controls.Add(this.btnSearchProduct);
            this.pnltxt.Controls.Add(this.btn);
            this.pnltxt.Controls.Add(this.label3);
            this.pnltxt.Controls.Add(this.btnAdd);
            this.pnltxt.Controls.Add(this.txtClient);
            this.pnltxt.Controls.Add(this.txtProd);
            this.pnltxt.Controls.Add(this.txtCantidad);
            this.pnltxt.Controls.Add(this.NTS);
            this.pnltxt.Controls.Add(this.label2);
            this.pnltxt.Controls.Add(this.lblPrice);
            this.pnltxt.Controls.Add(this.lblName);
            this.pnltxt.Controls.Add(this.label4);
            this.pnltxt.Controls.Add(this.label6);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Controls.Add(this.txtCod);
            this.pnltxt.Location = new System.Drawing.Point(3, 3);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(455, 512);
            this.pnltxt.TabIndex = 10;
            this.pnltxt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltxt_Paint);
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn.Location = new System.Drawing.Point(376, 45);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 37);
            this.btn.TabIndex = 1;
            this.btn.Text = "Buscar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(2, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre del Producto";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(145, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtClient.IsForeginKey = false;
            this.txtClient.Location = new System.Drawing.Point(145, 51);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(221, 26);
            this.txtClient.TabIndex = 0;
            this.txtClient.Table = null;
            this.txtClient.Leave += new System.EventHandler(this.txtClient_Leave);
            // 
            // txtProd
            // 
            this.txtProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProd.DBReference = "CommercialName";
            this.txtProd.Enabled = false;
            this.txtProd.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtProd.IsForeginKey = false;
            this.txtProd.Location = new System.Drawing.Point(145, 250);
            this.txtProd.Multiline = true;
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(295, 74);
            this.txtProd.TabIndex = 26;
            this.txtProd.Table = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCantidad.IsForeginKey = false;
            this.txtCantidad.Location = new System.Drawing.Point(145, 329);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 26);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Table = null;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumKeyPress);
            // 
            // NTS
            // 
            this.NTS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NTS.AutoSize = true;
            this.NTS.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.NTS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NTS.Location = new System.Drawing.Point(2, 54);
            this.NTS.Name = "NTS";
            this.NTS.Size = new System.Drawing.Size(33, 19);
            this.NTS.TabIndex = 27;
            this.NTS.Text = "NTS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(2, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Código del Producto";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Location = new System.Drawing.Point(141, 358);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(128, 19);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Precio del producto";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(141, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 19);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Datos del Cliente";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(2, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(2, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(2, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtCod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCod.IsForeginKey = false;
            this.txtCod.Location = new System.Drawing.Point(145, 209);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(221, 26);
            this.txtCod.TabIndex = 2;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // pnlDgw
            // 
            this.pnlDgw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlDgw.Controls.Add(this.lblTotal);
            this.pnlDgw.Controls.Add(this.lblTotalPrice);
            this.pnlDgw.Controls.Add(this.dgView_Sell);
            this.pnlDgw.Controls.Add(this.btnBuy);
            this.pnlDgw.Location = new System.Drawing.Point(464, 3);
            this.pnlDgw.Name = "pnlDgw";
            this.pnlDgw.Size = new System.Drawing.Size(483, 614);
            this.pnlDgw.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(8, 454);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 19);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(55, 454);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(214, 25);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.Text = "Precio total de la compra";
            // 
            // dgView_Sell
            // 
            this.dgView_Sell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgView_Sell.BackgroundColor = System.Drawing.Color.White;
            this.dgView_Sell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgView_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sell.GridColor = System.Drawing.Color.White;
            this.dgView_Sell.Location = new System.Drawing.Point(12, 35);
            this.dgView_Sell.Name = "dgView_Sell";
            this.dgView_Sell.Size = new System.Drawing.Size(451, 303);
            this.dgView_Sell.TabIndex = 13;
            this.dgView_Sell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Sell_CellContentClick);
            this.dgView_Sell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Sell_CellValueChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnBuy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBuy.Location = new System.Drawing.Point(197, 581);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(133, 33);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnltxt);
            this.panel1.Controls.Add(this.pnlDgw);
            this.panel1.Location = new System.Drawing.Point(70, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 620);
            this.panel1.TabIndex = 36;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchProduct.Location = new System.Drawing.Point(372, 203);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 37);
            this.btnSearchProduct.TabIndex = 35;
            this.btnSearchProduct.Text = "Buscar";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 706);
            this.Controls.Add(this.panel1);
            this.Name = "frmSellsytem";
            this.Text = "SellSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellsytem_FormClosing);
            this.Load += new System.EventHandler(this.frmSellsytem_Load);
            this.pnltxt.ResumeLayout(false);
            this.pnltxt.PerformLayout();
            this.pnlDgw.ResumeLayout(false);
            this.pnlDgw.PerformLayout();
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
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSearchProduct;
    }
}

