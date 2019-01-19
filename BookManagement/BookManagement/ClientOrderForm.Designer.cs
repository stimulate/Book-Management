namespace BookManagement
{
    partial class ClientOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlAddClientOrder = new System.Windows.Forms.Panel();
            this.dtpClientOrder = new System.Windows.Forms.DateTimePicker();
            this.cbxAddFirstName = new System.Windows.Forms.ComboBox();
            this.lblAddClientOrderDate = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveClientOrder = new System.Windows.Forms.Button();
            this.cbxAddClientID = new System.Windows.Forms.ComboBox();
            this.cbxAddLastName = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteClientOrder = new System.Windows.Forms.Button();
            this.btnUpdateClientOrder = new System.Windows.Forms.Button();
            this.btnAddClientOrder = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.lstClientOrders = new System.Windows.Forms.ListBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientOrderDate = new System.Windows.Forms.Label();
            this.txtClientOrderDate = new System.Windows.Forms.TextBox();
            this.btnMOPaid = new System.Windows.Forms.Button();
            this.btnMOShipped = new System.Windows.Forms.Button();
            this.pnlUpClientOrder = new System.Windows.Forms.Panel();
            this.btnUpCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dtpUpClientOrder = new System.Windows.Forms.DateTimePicker();
            this.lblUpClientOrderDate = new System.Windows.Forms.Label();
            this.lblUpClientID = new System.Windows.Forms.Label();
            this.txtUpClientID = new System.Windows.Forms.TextBox();
            this.lblUpStatus = new System.Windows.Forms.Label();
            this.txtUpStatus = new System.Windows.Forms.TextBox();
            this.txtUpFirstName = new System.Windows.Forms.TextBox();
            this.txtUpLastName = new System.Windows.Forms.TextBox();
            this.lblUpFirstName = new System.Windows.Forms.Label();
            this.lblUpLastName = new System.Windows.Forms.Label();
            this.lblUpClientOrderID = new System.Windows.Forms.Label();
            this.txtUpClientOrderID = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlAddClientOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            this.pnlUpClientOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(16, 263);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 21);
            this.btnPrevious.TabIndex = 89;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(247, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 88;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(300, 212);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(64, 21);
            this.txtStatus.TabIndex = 87;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(300, 176);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 21);
            this.txtFirstName.TabIndex = 85;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(300, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 21);
            this.txtLastName.TabIndex = 86;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(181, 179);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblFirstName.TabIndex = 81;
            this.lblFirstName.Text = "Client First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(187, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(107, 12);
            this.lblLastName.TabIndex = 82;
            this.lblLastName.Text = "Client Last Name:";
            // 
            // pnlAddClientOrder
            // 
            this.pnlAddClientOrder.Controls.Add(this.dtpClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.cbxAddFirstName);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClientOrderDate);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClient);
            this.pnlAddClientOrder.Controls.Add(this.btnAddCancel);
            this.pnlAddClientOrder.Controls.Add(this.btnSaveClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.cbxAddClientID);
            this.pnlAddClientOrder.Controls.Add(this.cbxAddLastName);
            this.pnlAddClientOrder.Location = new System.Drawing.Point(396, 12);
            this.pnlAddClientOrder.Name = "pnlAddClientOrder";
            this.pnlAddClientOrder.Size = new System.Drawing.Size(350, 221);
            this.pnlAddClientOrder.TabIndex = 74;
            this.pnlAddClientOrder.Visible = false;
            // 
            // dtpClientOrder
            // 
            this.dtpClientOrder.Location = new System.Drawing.Point(122, 15);
            this.dtpClientOrder.Name = "dtpClientOrder";
            this.dtpClientOrder.Size = new System.Drawing.Size(200, 21);
            this.dtpClientOrder.TabIndex = 99;
            // 
            // cbxAddFirstName
            // 
            this.cbxAddFirstName.FormattingEnabled = true;
            this.cbxAddFirstName.Location = new System.Drawing.Point(261, 56);
            this.cbxAddFirstName.Name = "cbxAddFirstName";
            this.cbxAddFirstName.Size = new System.Drawing.Size(85, 20);
            this.cbxAddFirstName.TabIndex = 98;
            // 
            // lblAddClientOrderDate
            // 
            this.lblAddClientOrderDate.AutoSize = true;
            this.lblAddClientOrderDate.Location = new System.Drawing.Point(3, 21);
            this.lblAddClientOrderDate.Name = "lblAddClientOrderDate";
            this.lblAddClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblAddClientOrderDate.TabIndex = 97;
            this.lblAddClientOrderDate.Text = "Client Order Date:";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Location = new System.Drawing.Point(51, 59);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(47, 12);
            this.lblAddClient.TabIndex = 95;
            this.lblAddClient.Text = "Client:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(234, 88);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(112, 21);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveClientOrder
            // 
            this.btnSaveClientOrder.Location = new System.Drawing.Point(18, 88);
            this.btnSaveClientOrder.Name = "btnSaveClientOrder";
            this.btnSaveClientOrder.Size = new System.Drawing.Size(138, 21);
            this.btnSaveClientOrder.TabIndex = 22;
            this.btnSaveClientOrder.Text = "Save Client Order";
            this.btnSaveClientOrder.UseVisualStyleBackColor = false;
            this.btnSaveClientOrder.Click += new System.EventHandler(this.btnSaveClientOrder_Click);
            // 
            // cbxAddClientID
            // 
            this.cbxAddClientID.FormattingEnabled = true;
            this.cbxAddClientID.Location = new System.Drawing.Point(122, 56);
            this.cbxAddClientID.Name = "cbxAddClientID";
            this.cbxAddClientID.Size = new System.Drawing.Size(45, 20);
            this.cbxAddClientID.TabIndex = 12;
            // 
            // cbxAddLastName
            // 
            this.cbxAddLastName.FormattingEnabled = true;
            this.cbxAddLastName.Location = new System.Drawing.Point(170, 56);
            this.cbxAddLastName.Name = "cbxAddLastName";
            this.cbxAddLastName.Size = new System.Drawing.Size(85, 20);
            this.cbxAddLastName.TabIndex = 11;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.dsBookBrokers;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "dsBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(493, 300);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 21);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteClientOrder
            // 
            this.btnDeleteClientOrder.Location = new System.Drawing.Point(477, 263);
            this.btnDeleteClientOrder.Name = "btnDeleteClientOrder";
            this.btnDeleteClientOrder.Size = new System.Drawing.Size(128, 21);
            this.btnDeleteClientOrder.TabIndex = 70;
            this.btnDeleteClientOrder.Text = "Delete Client Order";
            this.btnDeleteClientOrder.UseVisualStyleBackColor = false;
            this.btnDeleteClientOrder.Click += new System.EventHandler(this.btnDeleteClientOrder_Click);
            // 
            // btnUpdateClientOrder
            // 
            this.btnUpdateClientOrder.Location = new System.Drawing.Point(334, 263);
            this.btnUpdateClientOrder.Name = "btnUpdateClientOrder";
            this.btnUpdateClientOrder.Size = new System.Drawing.Size(128, 21);
            this.btnUpdateClientOrder.TabIndex = 71;
            this.btnUpdateClientOrder.Text = "Update Client Order";
            this.btnUpdateClientOrder.UseVisualStyleBackColor = false;
            this.btnUpdateClientOrder.Click += new System.EventHandler(this.btnUpdateClientOrder_Click);
            // 
            // btnAddClientOrder
            // 
            this.btnAddClientOrder.Location = new System.Drawing.Point(189, 263);
            this.btnAddClientOrder.Name = "btnAddClientOrder";
            this.btnAddClientOrder.Size = new System.Drawing.Size(128, 21);
            this.btnAddClientOrder.TabIndex = 72;
            this.btnAddClientOrder.Text = "Add Client Order";
            this.btnAddClientOrder.UseVisualStyleBackColor = false;
            this.btnAddClientOrder.Click += new System.EventHandler(this.btnAddClientOrder_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(103, 263);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 21);
            this.btnNext.TabIndex = 73;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(193, 27);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(101, 12);
            this.lblClientOrderID.TabIndex = 75;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(300, 24);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(52, 21);
            this.txtClientOrderID.TabIndex = 67;
            this.txtClientOrderID.TextChanged += new System.EventHandler(this.txtClientOrderID_TextChanged);
            // 
            // lstClientOrders
            // 
            this.lstClientOrders.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstClientOrders.FormattingEnabled = true;
            this.lstClientOrders.ItemHeight = 12;
            this.lstClientOrders.Location = new System.Drawing.Point(12, 12);
            this.lstClientOrders.Name = "lstClientOrders";
            this.lstClientOrders.Size = new System.Drawing.Size(166, 208);
            this.lstClientOrders.TabIndex = 64;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(229, 103);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(65, 12);
            this.lblClientID.TabIndex = 91;
            this.lblClientID.Text = "Client ID:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(300, 100);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(52, 21);
            this.txtClientID.TabIndex = 90;
            // 
            // lblClientOrderDate
            // 
            this.lblClientOrderDate.AutoSize = true;
            this.lblClientOrderDate.Location = new System.Drawing.Point(181, 65);
            this.lblClientOrderDate.Name = "lblClientOrderDate";
            this.lblClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblClientOrderDate.TabIndex = 93;
            this.lblClientOrderDate.Text = "Client Order Date:";
            // 
            // txtClientOrderDate
            // 
            this.txtClientOrderDate.Location = new System.Drawing.Point(300, 62);
            this.txtClientOrderDate.Name = "txtClientOrderDate";
            this.txtClientOrderDate.Size = new System.Drawing.Size(90, 21);
            this.txtClientOrderDate.TabIndex = 92;
            // 
            // btnMOPaid
            // 
            this.btnMOPaid.Location = new System.Drawing.Point(260, 300);
            this.btnMOPaid.Name = "btnMOPaid";
            this.btnMOPaid.Size = new System.Drawing.Size(227, 21);
            this.btnMOPaid.TabIndex = 94;
            this.btnMOPaid.Text = "Mark Client Order as Paid";
            this.btnMOPaid.UseVisualStyleBackColor = false;
            this.btnMOPaid.Click += new System.EventHandler(this.btnMOPaid_Click);
            // 
            // btnMOShipped
            // 
            this.btnMOShipped.Location = new System.Drawing.Point(16, 300);
            this.btnMOShipped.Name = "btnMOShipped";
            this.btnMOShipped.Size = new System.Drawing.Size(227, 21);
            this.btnMOShipped.TabIndex = 95;
            this.btnMOShipped.Text = "Mark Client Order as Shipped";
            this.btnMOShipped.UseVisualStyleBackColor = false;
            this.btnMOShipped.Click += new System.EventHandler(this.btnMOShipped_Click);
            // 
            // pnlUpClientOrder
            // 
            this.pnlUpClientOrder.Controls.Add(this.btnUpCancel);
            this.pnlUpClientOrder.Controls.Add(this.btnSaveChanges);
            this.pnlUpClientOrder.Controls.Add(this.dtpUpClientOrder);
            this.pnlUpClientOrder.Controls.Add(this.lblUpClientOrderDate);
            this.pnlUpClientOrder.Controls.Add(this.lblUpClientID);
            this.pnlUpClientOrder.Controls.Add(this.txtUpClientID);
            this.pnlUpClientOrder.Controls.Add(this.lblUpStatus);
            this.pnlUpClientOrder.Controls.Add(this.txtUpStatus);
            this.pnlUpClientOrder.Controls.Add(this.txtUpFirstName);
            this.pnlUpClientOrder.Controls.Add(this.txtUpLastName);
            this.pnlUpClientOrder.Controls.Add(this.lblUpFirstName);
            this.pnlUpClientOrder.Controls.Add(this.lblUpLastName);
            this.pnlUpClientOrder.Controls.Add(this.lblUpClientOrderID);
            this.pnlUpClientOrder.Controls.Add(this.txtUpClientOrderID);
            this.pnlUpClientOrder.Location = new System.Drawing.Point(764, 12);
            this.pnlUpClientOrder.Name = "pnlUpClientOrder";
            this.pnlUpClientOrder.Size = new System.Drawing.Size(277, 290);
            this.pnlUpClientOrder.TabIndex = 100;
            this.pnlUpClientOrder.Visible = false;
            // 
            // btnUpCancel
            // 
            this.btnUpCancel.Location = new System.Drawing.Point(161, 251);
            this.btnUpCancel.Name = "btnUpCancel";
            this.btnUpCancel.Size = new System.Drawing.Size(112, 21);
            this.btnUpCancel.TabIndex = 106;
            this.btnUpCancel.Text = "Cancel";
            this.btnUpCancel.UseVisualStyleBackColor = false;
            this.btnUpCancel.Click += new System.EventHandler(this.btnUpCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(0, 251);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 21);
            this.btnSaveChanges.TabIndex = 107;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dtpUpClientOrder
            // 
            this.dtpUpClientOrder.Location = new System.Drawing.Point(123, 56);
            this.dtpUpClientOrder.Name = "dtpUpClientOrder";
            this.dtpUpClientOrder.Size = new System.Drawing.Size(140, 21);
            this.dtpUpClientOrder.TabIndex = 100;
            // 
            // lblUpClientOrderDate
            // 
            this.lblUpClientOrderDate.AutoSize = true;
            this.lblUpClientOrderDate.Location = new System.Drawing.Point(4, 59);
            this.lblUpClientOrderDate.Name = "lblUpClientOrderDate";
            this.lblUpClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblUpClientOrderDate.TabIndex = 105;
            this.lblUpClientOrderDate.Text = "Client Order Date:";
            // 
            // lblUpClientID
            // 
            this.lblUpClientID.AutoSize = true;
            this.lblUpClientID.Location = new System.Drawing.Point(52, 97);
            this.lblUpClientID.Name = "lblUpClientID";
            this.lblUpClientID.Size = new System.Drawing.Size(65, 12);
            this.lblUpClientID.TabIndex = 103;
            this.lblUpClientID.Text = "Client ID:";
            // 
            // txtUpClientID
            // 
            this.txtUpClientID.Location = new System.Drawing.Point(123, 94);
            this.txtUpClientID.Name = "txtUpClientID";
            this.txtUpClientID.Size = new System.Drawing.Size(52, 21);
            this.txtUpClientID.TabIndex = 102;
            // 
            // lblUpStatus
            // 
            this.lblUpStatus.AutoSize = true;
            this.lblUpStatus.Location = new System.Drawing.Point(70, 209);
            this.lblUpStatus.Name = "lblUpStatus";
            this.lblUpStatus.Size = new System.Drawing.Size(47, 12);
            this.lblUpStatus.TabIndex = 101;
            this.lblUpStatus.Text = "Status:";
            // 
            // txtUpStatus
            // 
            this.txtUpStatus.Location = new System.Drawing.Point(123, 206);
            this.txtUpStatus.Name = "txtUpStatus";
            this.txtUpStatus.Size = new System.Drawing.Size(64, 21);
            this.txtUpStatus.TabIndex = 100;
            // 
            // txtUpFirstName
            // 
            this.txtUpFirstName.Location = new System.Drawing.Point(123, 170);
            this.txtUpFirstName.Name = "txtUpFirstName";
            this.txtUpFirstName.Size = new System.Drawing.Size(133, 21);
            this.txtUpFirstName.TabIndex = 98;
            // 
            // txtUpLastName
            // 
            this.txtUpLastName.Location = new System.Drawing.Point(123, 132);
            this.txtUpLastName.Name = "txtUpLastName";
            this.txtUpLastName.Size = new System.Drawing.Size(133, 21);
            this.txtUpLastName.TabIndex = 99;
            // 
            // lblUpFirstName
            // 
            this.lblUpFirstName.AutoSize = true;
            this.lblUpFirstName.Location = new System.Drawing.Point(4, 173);
            this.lblUpFirstName.Name = "lblUpFirstName";
            this.lblUpFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblUpFirstName.TabIndex = 96;
            this.lblUpFirstName.Text = "Client First Name:";
            // 
            // lblUpLastName
            // 
            this.lblUpLastName.AutoSize = true;
            this.lblUpLastName.Location = new System.Drawing.Point(10, 135);
            this.lblUpLastName.Name = "lblUpLastName";
            this.lblUpLastName.Size = new System.Drawing.Size(107, 12);
            this.lblUpLastName.TabIndex = 97;
            this.lblUpLastName.Text = "Client Last Name:";
            // 
            // lblUpClientOrderID
            // 
            this.lblUpClientOrderID.AutoSize = true;
            this.lblUpClientOrderID.Location = new System.Drawing.Point(16, 21);
            this.lblUpClientOrderID.Name = "lblUpClientOrderID";
            this.lblUpClientOrderID.Size = new System.Drawing.Size(101, 12);
            this.lblUpClientOrderID.TabIndex = 95;
            this.lblUpClientOrderID.Text = "Client Order ID:";
            // 
            // txtUpClientOrderID
            // 
            this.txtUpClientOrderID.Location = new System.Drawing.Point(123, 18);
            this.txtUpClientOrderID.Name = "txtUpClientOrderID";
            this.txtUpClientOrderID.Size = new System.Drawing.Size(52, 21);
            this.txtUpClientOrderID.TabIndex = 94;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(332, 103);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(11, 12);
            this.lblC.TabIndex = 101;
            this.lblC.Text = "C";
            // 
            // ClientOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 361);
            this.Controls.Add(this.pnlUpClientOrder);
            this.Controls.Add(this.pnlAddClientOrder);
            this.Controls.Add(this.btnMOShipped);
            this.Controls.Add(this.btnMOPaid);
            this.Controls.Add(this.lblClientOrderDate);
            this.Controls.Add(this.txtClientOrderDate);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteClientOrder);
            this.Controls.Add(this.btnUpdateClientOrder);
            this.Controls.Add(this.btnAddClientOrder);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.lstClientOrders);
            this.Controls.Add(this.lblC);
            this.Name = "ClientOrderForm";
            this.Text = "Client Order Maintenance";
            this.Load += new System.EventHandler(this.ClientOrderForm_Load);
            this.pnlAddClientOrder.ResumeLayout(false);
            this.pnlAddClientOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            this.pnlUpClientOrder.ResumeLayout(false);
            this.pnlUpClientOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlAddClientOrder;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveClientOrder;
        private System.Windows.Forms.ComboBox cbxAddClientID;
        private System.Windows.Forms.ComboBox cbxAddLastName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteClientOrder;
        private System.Windows.Forms.Button btnUpdateClientOrder;
        private System.Windows.Forms.Button btnAddClientOrder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.ListBox lstClientOrders;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientOrderDate;
        private System.Windows.Forms.TextBox txtClientOrderDate;
        private System.Windows.Forms.Button btnMOPaid;
        private System.Windows.Forms.Button btnMOShipped;
        private System.Windows.Forms.Label lblAddClientOrderDate;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.DateTimePicker dtpClientOrder;
        private System.Windows.Forms.ComboBox cbxAddFirstName;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private dsBookBrokers dsBookBrokers;
        private System.Windows.Forms.Panel pnlUpClientOrder;
        private System.Windows.Forms.Label lblUpClientOrderDate;
        private System.Windows.Forms.Label lblUpClientID;
        private System.Windows.Forms.TextBox txtUpClientID;
        private System.Windows.Forms.Label lblUpStatus;
        private System.Windows.Forms.TextBox txtUpStatus;
        private System.Windows.Forms.TextBox txtUpFirstName;
        private System.Windows.Forms.TextBox txtUpLastName;
        private System.Windows.Forms.Label lblUpFirstName;
        private System.Windows.Forms.Label lblUpLastName;
        private System.Windows.Forms.Label lblUpClientOrderID;
        private System.Windows.Forms.TextBox txtUpClientOrderID;
        private System.Windows.Forms.DateTimePicker dtpUpClientOrder;
        private System.Windows.Forms.Button btnUpCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblC;
    }
}