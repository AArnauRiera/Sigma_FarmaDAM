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
            this.pnlGW = new System.Windows.Forms.Panel();
            this.dgwBase = new System.Windows.Forms.DataGridView();
            this.pnlTextBox = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.bntNew = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.pnlMantein.SuspendLayout();
            this.pnlGW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMantein
            // 
            this.pnlMantein.Controls.Add(this.pnlGW);
            this.pnlMantein.Controls.Add(this.pnlTextBox);
            this.pnlMantein.Controls.Add(this.pnlButtons);
            this.pnlMantein.Location = new System.Drawing.Point(3, 0);
            this.pnlMantein.Name = "pnlMantein";
            this.pnlMantein.Size = new System.Drawing.Size(1065, 748);
            this.pnlMantein.TabIndex = 0;
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
            this.dgwBase.AllowUserToDeleteRows = false;
            this.dgwBase.BackgroundColor = System.Drawing.Color.White;
            this.dgwBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBase.GridColor = System.Drawing.Color.White;
            this.dgwBase.Location = new System.Drawing.Point(7, 5);
            this.dgwBase.Margin = new System.Windows.Forms.Padding(5);
            this.dgwBase.Name = "dgwBase";
            this.dgwBase.Size = new System.Drawing.Size(647, 622);
            this.dgwBase.TabIndex = 4;
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.Location = new System.Drawing.Point(18, 23);
            this.pnlTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Size = new System.Drawing.Size(371, 559);
            this.pnlTextBox.TabIndex = 5;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnEliminar);
            this.pnlButtons.Controls.Add(this.bntNew);
            this.pnlButtons.Controls.Add(this.btnQuery);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnGet);
            this.pnlButtons.Location = new System.Drawing.Point(17, 592);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(372, 78);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(82, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 41);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(308, 17);
            this.bntNew.Margin = new System.Windows.Forms.Padding(5);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(59, 41);
            this.bntNew.TabIndex = 14;
            this.bntNew.Text = "Nuevo";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(244, 17);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(59, 41);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Buscar";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(5, 17);
            this.btnGet.Margin = new System.Windows.Forms.Padding(5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(71, 41);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Obtener";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click_1);
            // 
            // frmManteinBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 760);
            this.Controls.Add(this.pnlMantein);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManteinBase";
            this.Text = "frmManteinBase";
            this.Load += new System.EventHandler(this.frmManteinBase_Load);
            this.pnlMantein.ResumeLayout(false);
            this.pnlGW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBase)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel pnlTextBox;
        protected System.Windows.Forms.Button btnQuery;
        protected System.Windows.Forms.Panel pnlButtons;
        protected System.Windows.Forms.Button btnUpdate;
        protected System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel pnlGW;
        protected System.Windows.Forms.Button bntNew;
        protected System.Windows.Forms.Panel pnlMantein;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.DataGridView dgwBase;
    }
}