namespace BookManagement
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintInvoices = new System.Windows.Forms.Button();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(234, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 21);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintInvoices
            // 
            this.btnPrintInvoices.Location = new System.Drawing.Point(44, 30);
            this.btnPrintInvoices.Name = "btnPrintInvoices";
            this.btnPrintInvoices.Size = new System.Drawing.Size(101, 21);
            this.btnPrintInvoices.TabIndex = 5;
            this.btnPrintInvoices.Text = "Print Invoices";
            this.btnPrintInvoices.UseVisualStyleBackColor = true;
            this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "prvInvoices";
            this.prvInvoices.Visible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 74);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoices);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintInvoices;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
    }
}