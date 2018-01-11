namespace SearchSystem
{
    partial class frmSearchSystem
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
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.lblSearch1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgView_List = new System.Windows.Forms.DataGridView();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.lblSearch3 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.txtSearch3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(225, 36);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(100, 20);
            this.txtSearch1.TabIndex = 0;
            // 
            // lblSearch1
            // 
            this.lblSearch1.AutoSize = true;
            this.lblSearch1.Location = new System.Drawing.Point(66, 39);
            this.lblSearch1.Name = "lblSearch1";
            this.lblSearch1.Size = new System.Drawing.Size(57, 13);
            this.lblSearch1.TabIndex = 2;
            this.lblSearch1.Text = "Add Query";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(380, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgView_List
            // 
            this.dgView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView_List.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_List.Location = new System.Drawing.Point(-2, 143);
            this.dgView_List.Name = "dgView_List";
            this.dgView_List.Size = new System.Drawing.Size(853, 437);
            this.dgView_List.TabIndex = 6;
            this.dgView_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_List_CellClick);
            // 
            // lblSearch2
            // 
            this.lblSearch2.AutoSize = true;
            this.lblSearch2.Location = new System.Drawing.Point(66, 77);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(57, 13);
            this.lblSearch2.TabIndex = 7;
            this.lblSearch2.Text = "Add Query";
            // 
            // lblSearch3
            // 
            this.lblSearch3.AutoSize = true;
            this.lblSearch3.Location = new System.Drawing.Point(66, 120);
            this.lblSearch3.Name = "lblSearch3";
            this.lblSearch3.Size = new System.Drawing.Size(57, 13);
            this.lblSearch3.TabIndex = 8;
            this.lblSearch3.Text = "Add Query";
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(225, 74);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(100, 20);
            this.txtSearch2.TabIndex = 9;
            // 
            // txtSearch3
            // 
            this.txtSearch3.Location = new System.Drawing.Point(225, 117);
            this.txtSearch3.Name = "txtSearch3";
            this.txtSearch3.Size = new System.Drawing.Size(100, 20);
            this.txtSearch3.TabIndex = 10;
            // 
            // frmSearchSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 580);
            this.Controls.Add(this.txtSearch3);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.lblSearch3);
            this.Controls.Add(this.lblSearch2);
            this.Controls.Add(this.dgView_List);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch1);
            this.Controls.Add(this.txtSearch1);
            this.Name = "frmSearchSystem";
            this.Text = "SearchSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dgView_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label lblSearch1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgView_List;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.Label lblSearch3;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.TextBox txtSearch3;
    }
}

