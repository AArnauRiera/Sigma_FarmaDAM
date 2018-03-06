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
            this.lblClient = new System.Windows.Forms.Label();
            this.pnltxt = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProd = new Sigma_Controls.TxtSigma();
            this.txtCod = new Sigma_Controls.TxtSigma();
            this.lblCant = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgView_Sell = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtClient = new Sigma_Controls.TxtSigma();
            this.txtCantidad = new Sigma_Controls.TxtSigma();
            this.pnltxt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Sell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(63, 54);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(29, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "NTS";
            // 
            // pnltxt
            // 
            this.pnltxt.Controls.Add(this.txtCantidad);
            this.pnltxt.Controls.Add(this.txtClient);
            this.pnltxt.Controls.Add(this.label6);
            this.pnltxt.Controls.Add(this.label5);
            this.pnltxt.Controls.Add(this.txtProd);
            this.pnltxt.Controls.Add(this.txtCod);
            this.pnltxt.Controls.Add(this.lblCant);
            this.pnltxt.Controls.Add(this.label7);
            this.pnltxt.Controls.Add(this.lblSegundo);
            this.pnltxt.Controls.Add(this.lblApellido);
            this.pnltxt.Controls.Add(this.lblNombre);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Controls.Add(this.btnAdd);
            this.pnltxt.Controls.Add(this.lblClient);
            this.pnltxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltxt.Location = new System.Drawing.Point(0, 0);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(768, 177);
            this.pnltxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Producto";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Codigo";
            // 
            // txtProd
            // 
            this.txtProd.DBReference = "CommercialName";
            this.txtProd.Enabled = false;
            this.txtProd.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtProd.ForeColor = System.Drawing.Color.Gray;
            this.txtProd.Location = new System.Drawing.Point(359, 112);
            this.txtProd.Name = "txtProd";
            this.txtProd.Placeholder = null;
            this.txtProd.Size = new System.Drawing.Size(206, 20);
            this.txtProd.TabIndex = 26;
            this.txtProd.Table = null;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.DBReference = "Register_Number";
            this.txtCod.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(104, 112);
            this.txtCod.Name = "txtCod";
            this.txtCod.Placeholder = null;
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 25;
            this.txtCod.Table = null;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // lblCant
            // 
            this.lblCant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(571, 115);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 23;
            this.lblCant.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product";
            // 
            // lblSegundo
            // 
            this.lblSegundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Enabled = false;
            this.lblSegundo.Location = new System.Drawing.Point(335, 58);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(90, 13);
            this.lblSegundo.TabIndex = 16;
            this.lblSegundo.Text = "Segundo Apellido";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Enabled = false;
            this.lblApellido.Location = new System.Drawing.Point(274, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Location = new System.Drawing.Point(215, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(327, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgView_Sell);
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 274);
            this.panel2.TabIndex = 11;
            // 
            // dgView_Sell
            // 
            this.dgView_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Sell.Location = new System.Drawing.Point(3, 3);
            this.dgView_Sell.Name = "dgView_Sell";
            this.dgView_Sell.Size = new System.Drawing.Size(765, 226);
            this.dgView_Sell.TabIndex = 13;
            this.dgView_Sell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Sell_CellClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Location = new System.Drawing.Point(310, 239);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(133, 23);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.White;
            this.txtClient.DBReference = "NTS";
            this.txtClient.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtClient.ForeColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(116, 51);
            this.txtClient.Name = "txtClient";
            this.txtClient.Placeholder = null;
            this.txtClient.Size = new System.Drawing.Size(69, 20);
            this.txtClient.TabIndex = 29;
            this.txtClient.Table = null;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClient_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.DBReference = "Quantity";
            this.txtCantidad.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtCantidad.Location = new System.Drawing.Point(651, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Placeholder = null;
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 30;
            this.txtCantidad.Table = null;
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
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

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnltxt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgView_Sell;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCant;
        private Sigma_Controls.TxtSigma txtCod;
        private Sigma_Controls.TxtSigma txtProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Sigma_Controls.TxtSigma txtCantidad;
        private Sigma_Controls.TxtSigma txtClient;
    }
}

