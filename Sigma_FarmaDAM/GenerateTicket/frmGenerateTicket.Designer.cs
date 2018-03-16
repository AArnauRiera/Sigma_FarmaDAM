namespace GenerateTicket
{
    partial class frmGenerateTicket
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
            this.cmdVisor = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.lblIdHeader = new System.Windows.Forms.Label();
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TicketSigmaFarmaDAM1 = new GenerateTicket.TicketSigmaFarmaDAM();
            this.SuspendLayout();
            // 
            // cmdVisor
            // 
            this.cmdVisor.Location = new System.Drawing.Point(12, 78);
            this.cmdVisor.Name = "cmdVisor";
            this.cmdVisor.Size = new System.Drawing.Size(98, 23);
            this.cmdVisor.TabIndex = 21;
            this.cmdVisor.Text = "Generar Ticket";
            this.cmdVisor.UseVisualStyleBackColor = true;
            this.cmdVisor.Click += new System.EventHandler(this.cmdVisor_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(71, 52);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(39, 20);
            this.txtTicket.TabIndex = 20;
            // 
            // lblIdHeader
            // 
            this.lblIdHeader.AutoSize = true;
            this.lblIdHeader.Location = new System.Drawing.Point(12, 55);
            this.lblIdHeader.Name = "lblIdHeader";
            this.lblIdHeader.Size = new System.Drawing.Size(57, 13);
            this.lblIdHeader.TabIndex = 23;
            this.lblIdHeader.Text = "Id_Header";
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.Location = new System.Drawing.Point(12, 107);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(98, 23);
            this.btnGenPDF.TabIndex = 22;
            this.btnGenPDF.Text = "Generate PDF";
            this.btnGenPDF.UseVisualStyleBackColor = true;
            this.btnGenPDF.Click += new System.EventHandler(this.btnGenPDF_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(116, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.TicketSigmaFarmaDAM1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1129, 667);
            this.crystalReportViewer1.TabIndex = 24;
            // 
            // frmGenerateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 682);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmdVisor);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.lblIdHeader);
            this.Controls.Add(this.btnGenPDF);
            this.Name = "frmGenerateTicket";
            this.Text = "frmGenerateTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdVisor;
        internal System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label lblIdHeader;
        private System.Windows.Forms.Button btnGenPDF;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TicketSigmaFarmaDAM TicketSigmaFarmaDAM1;
    }
}