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
            this.pnlMantein = new System.Windows.Forms.Panel();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.pnlGW = new System.Windows.Forms.Panel();
            this.dgwBase = new System.Windows.Forms.DataGridView();
            this.pnlMantein.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMantein
            // 
            this.pnlMantein.Controls.Add(this.pnlGW);
            this.pnlMantein.Controls.Add(this.pnlTextBox);
            this.pnlMantein.Controls.Add(this.pnlButtons);
            this.pnlMantein.Location = new System.Drawing.Point(2, 0);
            this.pnlMantein.Name = "pnlMantein";
            this.pnlMantein.Size = new System.Drawing.Size(1053, 748);
            this.pnlMantein.TabIndex = 0;
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Location = new System.Drawing.Point(18, 23);
            this.pnlTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(371, 559);
            this.pnlTextBox.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(251, 17);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(113, 41);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Search";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnQuery);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnGet);
            this.pnlButtons.Location = new System.Drawing.Point(17, 592);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(372, 78);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(5, 17);
            this.btnGet.Margin = new System.Windows.Forms.Padding(5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(113, 41);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click_1);
            // 
            // pnlGW
            // 
            this.pnlGW.Controls.Add(this.dgwBase);
            this.pnlGW.Location = new System.Drawing.Point(397, 23);
            this.pnlGW.Name = "pnlGW";
            this.pnlGW.Size = new System.Drawing.Size(659, 647);
            this.pnlGW.TabIndex = 6;
            // 
            // dgwBase
            // 
            this.dgwBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBase.Location = new System.Drawing.Point(7, 5);
            this.dgwBase.Margin = new System.Windows.Forms.Padding(5);
            this.dgwBase.Name = "dgwBase";
            this.dgwBase.Size = new System.Drawing.Size(647, 622);
            this.dgwBase.TabIndex = 4;
            // 
            // frmManteinBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 760);
            this.Controls.Add(this.pnlMantein);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManteinBase";
            this.Text = "frmManteinBase";
            this.pnlMantein.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlGW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMantein;
        protected System.Windows.Forms.Panel pnlTextBox;
        protected System.Windows.Forms.Button btnQuery;
        protected System.Windows.Forms.Panel pnlButtons;
        protected System.Windows.Forms.Button btnUpdate;
        protected System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel pnlGW;
        protected System.Windows.Forms.DataGridView dgwBase;
    }
}