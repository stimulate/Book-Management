namespace BookManagement
{
    partial class VendorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintVendors = new System.Windows.Forms.Button();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.prvReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(236, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 21);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintVendors
            // 
            this.btnPrintVendors.Location = new System.Drawing.Point(48, 12);
            this.btnPrintVendors.Name = "btnPrintVendors";
            this.btnPrintVendors.Size = new System.Drawing.Size(101, 21);
            this.btnPrintVendors.TabIndex = 5;
            this.btnPrintVendors.Text = "Print Vendors";
            this.btnPrintVendors.UseVisualStyleBackColor = true;
            this.btnPrintVendors.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // prvReport
            // 
            this.prvReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prvReport.Document = this.printReport;
            this.prvReport.Enabled = true;
            this.prvReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prvReport.Icon")));
            this.prvReport.Name = "prvInvoices";
            this.prvReport.Visible = false;
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 71);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintVendors);
            this.Name = "VendorsForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Vendors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintVendors;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog prvReport;
    }
}