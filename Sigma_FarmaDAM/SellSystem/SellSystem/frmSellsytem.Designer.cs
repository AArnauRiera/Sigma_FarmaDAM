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
            this.lblDrug = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lswDrugs = new System.Windows.Forms.ListView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(153, 55);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client ";
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(153, 99);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(44, 13);
            this.lblDrug.TabIndex = 1;
            this.lblDrug.Text = "Product";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(221, 55);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 2;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(221, 96);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lswDrugs
            // 
            this.lswDrugs.Location = new System.Drawing.Point(156, 198);
            this.lswDrugs.Name = "lswDrugs";
            this.lswDrugs.Size = new System.Drawing.Size(227, 190);
            this.lswDrugs.TabIndex = 8;
            this.lswDrugs.UseCompatibleStateImageBehavior = false;
            this.lswDrugs.View = System.Windows.Forms.View.List;
            this.lswDrugs.Layout += new System.Windows.Forms.LayoutEventHandler(this.lswDrugs_Layout);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(221, 404);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 23);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmSellsytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lswDrugs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.lblClient);
            this.Name = "frmSellsytem";
            this.Text = "SellSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lswDrugs;
        private System.Windows.Forms.Button btnBuy;
    }
}

