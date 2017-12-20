namespace SearchSystem
{
    partial class frmTest
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
            this.btnDrugs = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrugs
            // 
            this.btnDrugs.Location = new System.Drawing.Point(12, 78);
            this.btnDrugs.Name = "btnDrugs";
            this.btnDrugs.Size = new System.Drawing.Size(75, 23);
            this.btnDrugs.TabIndex = 0;
            this.btnDrugs.Text = "Drugs";
            this.btnDrugs.UseVisualStyleBackColor = true;
            this.btnDrugs.Click += new System.EventHandler(this.btnDrugs_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(153, 78);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(275, 78);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(100, 23);
            this.btnActive.TabIndex = 2;
            this.btnActive.Text = "Active_Principles";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 335);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnDrugs);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrugs;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnActive;
    }
}