namespace BookManagement
{
    partial class AddB2COForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddB2COForm));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvBookOrder = new System.Windows.Forms.DataGridView();
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dsBookBrokersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.ctnBookOrder = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daBookOrder = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBookBrokers, "BOOKINFO.Title", true));
            this.txtTitle.Location = new System.Drawing.Point(469, 375);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 21);
            this.txtTitle.TabIndex = 11;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "dsBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(414, 377);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(748, 401);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 29);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(393, 401);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeColumns = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.DataBindings.Add(new System.Windows.Forms.Binding("AllowUserToDeleteRows", this.dsBookBrokers, "BOOK.ClientOrderID", true));
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(570, 198);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(275, 165);
            this.dgvBooks.TabIndex = 4;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_onclick);
            this.dgvBooks.CurrentCellChanged += new System.EventHandler(this.dgvBooks_CurrentCellChange);
            // 
            // dgvBookOrder
            // 
            this.dgvBookOrder.AllowUserToAddRows = false;
            this.dgvBookOrder.AllowUserToDeleteRows = false;
            this.dgvBookOrder.AllowUserToResizeColumns = false;
            this.dgvBookOrder.AllowUserToResizeRows = false;
            this.dgvBookOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBookOrder.Location = new System.Drawing.Point(12, 198);
            this.dgvBookOrder.Name = "dgvBookOrder";
            this.dgvBookOrder.ReadOnly = true;
            this.dgvBookOrder.RowHeadersVisible = false;
            this.dgvBookOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookOrder.Size = new System.Drawing.Size(551, 165);
            this.dgvBookOrder.TabIndex = 93;
            this.dgvBookOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookOrder_onclick);
            this.dgvBookOrder.CurrentCellChanged += new System.EventHandler(this.dgvBookOrder_CurrentCellChange);
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.AllowUserToAddRows = false;
            this.dgvClientOrder.AllowUserToDeleteRows = false;
            this.dgvClientOrder.AllowUserToResizeColumns = false;
            this.dgvClientOrder.AllowUserToResizeRows = false;
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 22);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.ReadOnly = true;
            this.dgvClientOrder.RowHeadersVisible = false;
            this.dgvClientOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientOrder.Size = new System.Drawing.Size(551, 156);
            this.dgvClientOrder.TabIndex = 6;
            this.dgvClientOrder.CurrentCellChanged += new System.EventHandler(this.dgvClientOrder_CurrentCellChange);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBookBrokers, "CLIENT.FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(723, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 21);
            this.txtFirstName.TabIndex = 89;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBookBrokers, "CLIENT.LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(723, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 21);
            this.txtLastName.TabIndex = 90;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(604, 95);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblFirstName.TabIndex = 87;
            this.lblFirstName.Text = "Client First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(610, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(107, 12);
            this.lblLastName.TabIndex = 88;
            this.lblLastName.Text = "Client Last Name:";
            // 
            // dsBookBrokersBindingSource
            // 
            this.dsBookBrokersBindingSource.DataSource = this.dsBookBrokers;
            this.dsBookBrokersBindingSource.Position = 0;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT   BookID, Cost, Price, DatePublished, BookInfoID, VendorID, ClientOrderID\r" +
    "\nFROM      BOOK\r\nORDER BY ClientOrderID";
            this.oleDbSelectCommand2.Connection = this.ctnBookOrder;
            // 
            // ctnBookOrder
            // 
            this.ctnBookOrder.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\temp\\BookBrokers.accdb";
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `BOOK` (`Cost`, `Price`, `DatePublished`, `BookInfoID`, `VendorID`, `" +
    "ClientOrderID`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnBookOrder;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Currency, 0, "Cost"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("DatePublished", System.Data.OleDb.OleDbType.Date, 0, "DatePublished"),
            new System.Data.OleDb.OleDbParameter("BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, "BookInfoID"),
            new System.Data.OleDb.OleDbParameter("VendorID", System.Data.OleDb.OleDbType.Integer, 0, "VendorID"),
            new System.Data.OleDb.OleDbParameter("ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, "ClientOrderID")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnBookOrder;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Currency, 0, "Cost"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("DatePublished", System.Data.OleDb.OleDbType.Date, 0, "DatePublished"),
            new System.Data.OleDb.OleDbParameter("BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, "BookInfoID"),
            new System.Data.OleDb.OleDbParameter("VendorID", System.Data.OleDb.OleDbType.Integer, 0, "VendorID"),
            new System.Data.OleDb.OleDbParameter("ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, "ClientOrderID"),
            new System.Data.OleDb.OleDbParameter("Original_BookID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DatePublished", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DatePublished", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DatePublished", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DatePublished", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnBookOrder;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_BookID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DatePublished", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DatePublished", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DatePublished", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DatePublished", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, null)});
            // 
            // daBookOrder
            // 
            this.daBookOrder.DeleteCommand = this.oleDbDeleteCommand2;
            this.daBookOrder.InsertCommand = this.oleDbInsertCommand2;
            this.daBookOrder.SelectCommand = this.oleDbSelectCommand2;
            this.daBookOrder.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BOOK", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BookID", "BookID"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost"),
                        new System.Data.Common.DataColumnMapping("Price", "Price"),
                        new System.Data.Common.DataColumnMapping("DatePublished", "DatePublished"),
                        new System.Data.Common.DataColumnMapping("BookInfoID", "BookInfoID"),
                        new System.Data.Common.DataColumnMapping("VendorID", "VendorID"),
                        new System.Data.Common.DataColumnMapping("ClientOrderID", "ClientOrderID")})});
            this.daBookOrder.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // AddB2COForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 442);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvBookOrder);
            this.Controls.Add(this.dgvClientOrder);
            this.Name = "AddB2COForm";
            this.Text = "Add Book to a Client Order";
            this.Load += new System.EventHandler(this.AddB2COForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NewMethod()
        {
            this.dgvBookOrder.TabIndex = 5; ;
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvBookOrder;
        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private dsBookBrokers dsBookBrokers;
        private System.Windows.Forms.BindingSource dsBookBrokersBindingSource;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection ctnBookOrder;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daBookOrder;
    }
}