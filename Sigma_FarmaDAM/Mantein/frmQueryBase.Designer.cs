namespace Mantein
{
    partial class frmQueryBase
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
        protected void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwDB = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlTB = new System.Windows.Forms.Panel();
            this.txtDNI = new Sigma_Controls.TxtSigma();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new Sigma_Controls.TxtSigma();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigma2 = new Sigma_Controls.TxtSigma();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigma3 = new Sigma_Controls.TxtSigma();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSigma4 = new Sigma_Controls.TxtSigma();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSigma5 = new Sigma_Controls.TxtSigma();
            this.lblNTS_Type = new System.Windows.Forms.Label();
            this.txtSigma6 = new Sigma_Controls.TxtSigma();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDB)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 297);
            this.panel1.TabIndex = 1;
            // 
            // dgwDB
            // 
            this.dgwDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDB.Location = new System.Drawing.Point(3, 6);
            this.dgwDB.Name = "dgwDB";
            this.dgwDB.Size = new System.Drawing.Size(589, 288);
            this.dgwDB.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(164, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(345, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSelect);
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 171);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(595, 33);
            this.pnlButtons.TabIndex = 3;
            // 
            // pnlTB
            // 
            this.pnlTB.Controls.Add(this.lblNTS_Type);
            this.pnlTB.Controls.Add(this.txtSigma6);
            this.pnlTB.Controls.Add(this.label5);
            this.pnlTB.Controls.Add(this.txtSigma5);
            this.pnlTB.Controls.Add(this.label4);
            this.pnlTB.Controls.Add(this.txtSigma4);
            this.pnlTB.Controls.Add(this.label3);
            this.pnlTB.Controls.Add(this.txtSigma3);
            this.pnlTB.Controls.Add(this.label2);
            this.pnlTB.Controls.Add(this.txtSigma2);
            this.pnlTB.Controls.Add(this.lblid);
            this.pnlTB.Controls.Add(this.txtid);
            this.pnlTB.Controls.Add(this.lblDNI);
            this.pnlTB.Controls.Add(this.txtDNI);
            this.pnlTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTB.Location = new System.Drawing.Point(0, 0);
            this.pnlTB.Name = "pnlTB";
            this.pnlTB.Size = new System.Drawing.Size(595, 171);
            this.pnlTB.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.DBReference = "DNI";
            this.txtDNI.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtDNI.Location = new System.Drawing.Point(95, 12);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Placeholder = null;
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.Table = "Clients";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(13, 18);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(13, 44);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "id";
            // 
            // txtid
            // 
            this.txtid.DBReference = "id";
            this.txtid.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtid.Location = new System.Drawing.Point(95, 38);
            this.txtid.Name = "txtid";
            this.txtid.Placeholder = null;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            this.txtid.Table = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName1";
            // 
            // txtSigma2
            // 
            this.txtSigma2.DBReference = "lastName1";
            this.txtSigma2.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma2.Location = new System.Drawing.Point(95, 64);
            this.txtSigma2.Name = "txtSigma2";
            this.txtSigma2.Placeholder = null;
            this.txtSigma2.Size = new System.Drawing.Size(100, 20);
            this.txtSigma2.TabIndex = 4;
            this.txtSigma2.Table = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName2";
            // 
            // txtSigma3
            // 
            this.txtSigma3.DBReference = "lastName2";
            this.txtSigma3.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma3.Location = new System.Drawing.Point(95, 90);
            this.txtSigma3.Name = "txtSigma3";
            this.txtSigma3.Placeholder = null;
            this.txtSigma3.Size = new System.Drawing.Size(100, 20);
            this.txtSigma3.TabIndex = 6;
            this.txtSigma3.Table = "Clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // txtSigma4
            // 
            this.txtSigma4.DBReference = "Name";
            this.txtSigma4.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma4.Location = new System.Drawing.Point(320, 12);
            this.txtSigma4.Name = "txtSigma4";
            this.txtSigma4.Placeholder = null;
            this.txtSigma4.Size = new System.Drawing.Size(100, 20);
            this.txtSigma4.TabIndex = 8;
            this.txtSigma4.Table = "Clients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NTS";
            // 
            // txtSigma5
            // 
            this.txtSigma5.DBReference = "NTS";
            this.txtSigma5.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma5.Location = new System.Drawing.Point(320, 38);
            this.txtSigma5.Name = "txtSigma5";
            this.txtSigma5.Placeholder = null;
            this.txtSigma5.Size = new System.Drawing.Size(100, 20);
            this.txtSigma5.TabIndex = 10;
            this.txtSigma5.Table = "Clients";
            // 
            // lblNTS_Type
            // 
            this.lblNTS_Type.AutoSize = true;
            this.lblNTS_Type.Location = new System.Drawing.Point(238, 70);
            this.lblNTS_Type.Name = "lblNTS_Type";
            this.lblNTS_Type.Size = new System.Drawing.Size(59, 13);
            this.lblNTS_Type.TabIndex = 13;
            this.lblNTS_Type.Text = "NTS_Type";
            // 
            // txtSigma6
            // 
            this.txtSigma6.DBReference = "NTS_Type";
            this.txtSigma6.FieldType = Sigma_Controls.TxtSigma.FieldTypes.NSS;
            this.txtSigma6.Location = new System.Drawing.Point(320, 64);
            this.txtSigma6.Name = "txtSigma6";
            this.txtSigma6.Placeholder = null;
            this.txtSigma6.Size = new System.Drawing.Size(100, 20);
            this.txtSigma6.TabIndex = 12;
            this.txtSigma6.Table = "Clients";
            // 
            // frmQueryBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Controls.Add(this.pnlTB);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel1);
            this.Name = "frmQueryBase";
            this.Text = "frmQueryBase";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDB)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlTB.ResumeLayout(false);
            this.pnlTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwDB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlTB;
        private System.Windows.Forms.Label lblDNI;
        private Sigma_Controls.TxtSigma txtDNI;
        private System.Windows.Forms.Label lblNTS_Type;
        private Sigma_Controls.TxtSigma txtSigma6;
        private System.Windows.Forms.Label label5;
        private Sigma_Controls.TxtSigma txtSigma5;
        private System.Windows.Forms.Label label4;
        private Sigma_Controls.TxtSigma txtSigma4;
        private System.Windows.Forms.Label label3;
        private Sigma_Controls.TxtSigma txtSigma3;
        private System.Windows.Forms.Label label2;
        private Sigma_Controls.TxtSigma txtSigma2;
        private System.Windows.Forms.Label lblid;
        private Sigma_Controls.TxtSigma txtid;
    }
}