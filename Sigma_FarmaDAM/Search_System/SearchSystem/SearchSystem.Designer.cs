namespace SearchSystem
{
    partial class SearchSystem
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
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDrug
            // 
            this.txtDrug.Location = new System.Drawing.Point(80, 34);
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(100, 20);
            this.txtDrug.TabIndex = 0;
            this.txtDrug.TextChanged += new System.EventHandler(this.txtDrug_TextChanged);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(80, 83);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 1;
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(12, 37);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(44, 13);
            this.lblDrug.TabIndex = 2;
            this.lblDrug.Text = "Drug ID";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 86);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(47, 13);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Client ID";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(2, 156);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 277);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(80, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 433);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtDrug);
            this.Name = "SearchSystem";
            this.Text = "SearchSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrug;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSearch;
    }
}

