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
            this.txtCod = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClient = new Sigma_Controls.TxtSigma();
            this.NTS = new System.Windows.Forms.Label();
            this.txtProd = new Sigma_Controls.TxtSigma();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.pnltxt.Controls.Add(this.btnAdd);
            this.pnltxt.Controls.Add(this.txtCantidad);
            this.pnltxt.Controls.Add(this.label6);
            this.pnltxt.Controls.Add(this.txtCod);
            this.pnltxt.Controls.Add(this.label3);
            this.pnltxt.Controls.Add(this.label2);
            this.pnltxt.Controls.Add(this.txtClient);
            this.pnltxt.Controls.Add(this.NTS);
            this.pnltxt.Controls.Add(this.txtProd);
            this.pnltxt.Controls.Add(this.lblName);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Location = new System.Drawing.Point(4, 4);
            this.pnltxt.Margin = new System.Windows.Forms.Padding(4);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(462, 589);
            this.pnltxt.TabIndex = 10;
            this.pnltxt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltxt_Paint);
            // 
            // txtCantidad
            // 
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.None;
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(143, 175);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 22);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.Table = null;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-394, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cantidad";
            // 
            // txtCod
            // 
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(16, 133);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(132, 23);
            this.txtCod.TabIndex = 25;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numero de Registro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-340, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Producto";
            // 
            // txtClient
            // 
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.ForeColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(65, 37);
            this.txtClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(140, 22);
            this.txtClient.TabIndex = 30;
            this.txtClient.Table = null;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClient_KeyDown);
            // 
            // NTS
            // 
            this.NTS.AutoSize = true;
            this.NTS.Location = new System.Drawing.Point(13, 40);
            this.NTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NTS.Name = "NTS";
            this.NTS.Size = new System.Drawing.Size(36, 17);
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
            this.txtProd.Location = new System.Drawing.Point(166, 133);
            this.txtProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(273, 23);
            this.txtProd.TabIndex = 26;
            this.txtProd.Table = null;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(-163, 205);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-326, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(16, 269);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDgw
            // 
            this.pnlDgw.Controls.Add(this.dgView_Sell);
            this.pnlDgw.Controls.Add(this.btnBuy);
            this.pnlDgw.Location = new System.Drawing.Point(474, 4);
            this.pnlDgw.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDgw.Name = "pnlDgw";
            this.pnlDgw.Size = new System.Drawing.Size(494, 589);
            this.pnlDgw.TabIndex = 11;
            // 
            // dgView_Sell
            // 
            this.dgView_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sell.Location = new System.Drawing.Point(4, 0);
            this.dgView_Sell.Margin = new System.Windows.Forms.Padding(4);
            this.dgView_Sell.Name = "dgView_Sell";
            this.dgView_Sell.Size = new System.Drawing.Size(490, 547);
            this.dgView_Sell.TabIndex = 13;
            this.dgView_Sell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Sell_CellContentClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Location = new System.Drawing.Point(158, 550);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Location = new System.Drawing.Point(94, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 605);
            this.panel1.TabIndex = 36;
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 678);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSellsytem";
            this.Text = "SellSystem";
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
    }
}

