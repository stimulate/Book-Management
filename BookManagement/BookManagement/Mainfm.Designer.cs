namespace BookManagement
{
    partial class Mainfm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAddB2CO = new System.Windows.Forms.Button();
            this.btnClientOrder = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnAddB2CO);
            this.grpMaintenance.Controls.Add(this.btnClientOrder);
            this.grpMaintenance.Controls.Add(this.btnBook);
            this.grpMaintenance.Controls.Add(this.btnBookInfo);
            this.grpMaintenance.Controls.Add(this.btnClient);
            this.grpMaintenance.Controls.Add(this.btnVendor);
            this.grpMaintenance.Location = new System.Drawing.Point(40, 39);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(268, 373);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnAddB2CO
            // 
            this.btnAddB2CO.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAddB2CO.Location = new System.Drawing.Point(26, 309);
            this.btnAddB2CO.Name = "btnAddB2CO";
            this.btnAddB2CO.Size = new System.Drawing.Size(213, 27);
            this.btnAddB2CO.TabIndex = 0;
            this.btnAddB2CO.Text = "Add Book to a Client Order ";
            this.btnAddB2CO.UseVisualStyleBackColor = false;
            this.btnAddB2CO.Click += new System.EventHandler(this.btnAddB2CO_Click);
            // 
            // btnClientOrder
            // 
            this.btnClientOrder.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnClientOrder.Location = new System.Drawing.Point(26, 255);
            this.btnClientOrder.Name = "btnClientOrder";
            this.btnClientOrder.Size = new System.Drawing.Size(213, 27);
            this.btnClientOrder.TabIndex = 0;
            this.btnClientOrder.Text = "Client Order Maintenance";
            this.btnClientOrder.UseVisualStyleBackColor = false;
            this.btnClientOrder.Click += new System.EventHandler(this.btnClientOrder_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBook.Location = new System.Drawing.Point(26, 200);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(213, 27);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book Maintenance";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBookInfo.Location = new System.Drawing.Point(26, 146);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(213, 27);
            this.btnBookInfo.TabIndex = 0;
            this.btnBookInfo.Text = "Book Info Maintenance";
            this.btnBookInfo.UseVisualStyleBackColor = false;
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnClient.Location = new System.Drawing.Point(26, 91);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(213, 27);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client Maintenance";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendor.Location = new System.Drawing.Point(26, 37);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(213, 27);
            this.btnVendor.TabIndex = 0;
            this.btnVendor.Text = "Vendor Maintenance";
            this.btnVendor.UseVisualStyleBackColor = false;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnVendors);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(353, 39);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(268, 373);
            this.grpReport.TabIndex = 0;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            this.grpReport.Enter += new System.EventHandler(this.grpReport_Enter);
            // 
            // btnVendors
            // 
            this.btnVendors.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnVendors.Location = new System.Drawing.Point(26, 91);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(213, 27);
            this.btnVendors.TabIndex = 3;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(26, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnInvoices.Location = new System.Drawing.Point(26, 37);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(213, 27);
            this.btnInvoices.TabIndex = 1;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // Mainfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(650, 479);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "Mainfm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Mainfm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnAddB2CO;
        private System.Windows.Forms.Button btnClientOrder;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnVendors;
    }
}

