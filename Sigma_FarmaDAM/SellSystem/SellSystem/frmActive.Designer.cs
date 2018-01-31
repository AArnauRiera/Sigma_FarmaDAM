namespace SellSystem
{
    partial class frmActive
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgView_Drugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Drugs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(192, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(65, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Same Drugs";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(182, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgView_Drugs
            // 
            this.dgView_Drugs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgView_Drugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Drugs.Location = new System.Drawing.Point(1, 95);
            this.dgView_Drugs.Name = "dgView_Drugs";
            this.dgView_Drugs.Size = new System.Drawing.Size(483, 254);
            this.dgView_Drugs.TabIndex = 3;
            this.dgView_Drugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Drugs_CellClick);
            // 
            // frmActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 348);
            this.Controls.Add(this.dgView_Drugs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblText);
            this.Name = "frmActive";
            this.Text = "frmActive";
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Drugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgView_Drugs;
    }
}