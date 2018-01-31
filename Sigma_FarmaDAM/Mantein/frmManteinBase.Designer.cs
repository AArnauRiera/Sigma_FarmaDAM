namespace Mantein
{
    partial class frmManteinBase
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
            this.dgwBase = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBase
            // 
            this.dgwBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBase.Location = new System.Drawing.Point(16, 247);
            this.dgwBase.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBase.Name = "dgwBase";
            this.dgwBase.Size = new System.Drawing.Size(917, 267);
            this.dgwBase.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnGet);
            this.pnlButtons.Location = new System.Drawing.Point(16, 185);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(917, 55);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(551, 14);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(268, 14);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 28);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Controls.Add(this.btnQuery);
            this.pnlTextBox.Location = new System.Drawing.Point(17, 16);
            this.pnlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(916, 161);
            this.pnlTextBox.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(799, 15);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 28);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Shearch";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // frmManteinBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.pnlTextBox);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgwBase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManteinBase";
            this.Text = "frmManteinBase";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlTextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBase;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnQuery;
        protected System.Windows.Forms.Panel pnlTextBox;
    }
}