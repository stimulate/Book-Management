namespace BookManagement
{
    partial class BookForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.cboAddBookTitle = new System.Windows.Forms.ComboBox();
            this.lblAddVendor = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddBookInfo = new System.Windows.Forms.Label();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.cboAddBookInfoID = new System.Windows.Forms.ComboBox();
            this.lblAddDatePublished = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.cboAddVendorID = new System.Windows.Forms.ComboBox();
            this.cboAddVendorName = new System.Windows.Forms.ComboBox();
            this.bOOKINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.pnlUpBook = new System.Windows.Forms.Panel();
            this.dtpUpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.lblUpVendorName = new System.Windows.Forms.Label();
            this.lblUpVendorID = new System.Windows.Forms.Label();
            this.txtUpVendorName = new System.Windows.Forms.TextBox();
            this.txtUpVendorID = new System.Windows.Forms.TextBox();
            this.lblUpTitle = new System.Windows.Forms.Label();
            this.txtUpTitle = new System.Windows.Forms.TextBox();
            this.lblUpCost = new System.Windows.Forms.Label();
            this.txtUpCost = new System.Windows.Forms.TextBox();
            this.txtUpPrice = new System.Windows.Forms.TextBox();
            this.lblUpDatePublished = new System.Windows.Forms.Label();
            this.lblUpPrice = new System.Windows.Forms.Label();
            this.lblUpBookID = new System.Windows.Forms.Label();
            this.txtUpBookID = new System.Windows.Forms.TextBox();
            this.btnUpCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cLIENTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.pnlAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            this.pnlUpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(255, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 134;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(302, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 21);
            this.txtTitle.TabIndex = 133;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(261, 91);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 12);
            this.lblCost.TabIndex = 132;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(302, 88);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(71, 21);
            this.txtCost.TabIndex = 131;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(5, 329);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 21);
            this.btnPrevious.TabIndex = 130;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Location = new System.Drawing.Point(302, 162);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(133, 21);
            this.txtDatePublished.TabIndex = 126;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(302, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(71, 21);
            this.txtPrice.TabIndex = 127;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(201, 165);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(95, 12);
            this.lblDatePublished.TabIndex = 124;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(255, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 125;
            this.lblPrice.Text = "Price:";
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.Controls.Add(this.dtpDatePublished);
            this.pnlAddBook.Controls.Add(this.cboAddBookTitle);
            this.pnlAddBook.Controls.Add(this.lblAddVendor);
            this.pnlAddBook.Controls.Add(this.lblAddCost);
            this.pnlAddBook.Controls.Add(this.lblAddBookInfo);
            this.pnlAddBook.Controls.Add(this.txtAddCost);
            this.pnlAddBook.Controls.Add(this.txtAddPrice);
            this.pnlAddBook.Controls.Add(this.cboAddBookInfoID);
            this.pnlAddBook.Controls.Add(this.lblAddDatePublished);
            this.pnlAddBook.Controls.Add(this.lblAddPrice);
            this.pnlAddBook.Controls.Add(this.btnAddCancel);
            this.pnlAddBook.Controls.Add(this.btnSaveBook);
            this.pnlAddBook.Controls.Add(this.cboAddVendorID);
            this.pnlAddBook.Controls.Add(this.cboAddVendorName);
            this.pnlAddBook.Location = new System.Drawing.Point(480, 78);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(335, 308);
            this.pnlAddBook.TabIndex = 122;
            this.pnlAddBook.Visible = false;
            this.pnlAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddBookInfo_Paint);
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Location = new System.Drawing.Point(102, 101);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(200, 21);
            this.dtpDatePublished.TabIndex = 149;
            // 
            // cboAddBookTitle
            // 
            this.cboAddBookTitle.FormattingEnabled = true;
            this.cboAddBookTitle.Location = new System.Drawing.Point(161, 3);
            this.cboAddBookTitle.Name = "cboAddBookTitle";
            this.cboAddBookTitle.Size = new System.Drawing.Size(143, 20);
            this.cboAddBookTitle.TabIndex = 148;
            // 
            // lblAddVendor
            // 
            this.lblAddVendor.AutoSize = true;
            this.lblAddVendor.Location = new System.Drawing.Point(49, 137);
            this.lblAddVendor.Name = "lblAddVendor";
            this.lblAddVendor.Size = new System.Drawing.Size(47, 12);
            this.lblAddVendor.TabIndex = 147;
            this.lblAddVendor.Text = "Vendor:";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(61, 40);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(35, 12);
            this.lblAddCost.TabIndex = 146;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddBookInfo
            // 
            this.lblAddBookInfo.AutoSize = true;
            this.lblAddBookInfo.Location = new System.Drawing.Point(31, 6);
            this.lblAddBookInfo.Name = "lblAddBookInfo";
            this.lblAddBookInfo.Size = new System.Drawing.Size(65, 12);
            this.lblAddBookInfo.TabIndex = 117;
            this.lblAddBookInfo.Text = "Book Info:";
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(102, 35);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(71, 21);
            this.txtAddCost.TabIndex = 145;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(102, 68);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(71, 21);
            this.txtAddPrice.TabIndex = 144;
            // 
            // cboAddBookInfoID
            // 
            this.cboAddBookInfoID.FormattingEnabled = true;
            this.cboAddBookInfoID.Location = new System.Drawing.Point(102, 3);
            this.cboAddBookInfoID.Name = "cboAddBookInfoID";
            this.cboAddBookInfoID.Size = new System.Drawing.Size(53, 20);
            this.cboAddBookInfoID.TabIndex = 98;
            // 
            // lblAddDatePublished
            // 
            this.lblAddDatePublished.AutoSize = true;
            this.lblAddDatePublished.Location = new System.Drawing.Point(1, 108);
            this.lblAddDatePublished.Name = "lblAddDatePublished";
            this.lblAddDatePublished.Size = new System.Drawing.Size(95, 12);
            this.lblAddDatePublished.TabIndex = 141;
            this.lblAddDatePublished.Text = "Date Published:";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(55, 74);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(41, 12);
            this.lblAddPrice.TabIndex = 142;
            this.lblAddPrice.Text = "Price:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(192, 176);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(112, 21);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(18, 176);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(138, 21);
            this.btnSaveBook.TabIndex = 22;
            this.btnSaveBook.Text = "Save Book";
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // cboAddVendorID
            // 
            this.cboAddVendorID.FormattingEnabled = true;
            this.cboAddVendorID.Location = new System.Drawing.Point(102, 134);
            this.cboAddVendorID.Name = "cboAddVendorID";
            this.cboAddVendorID.Size = new System.Drawing.Size(53, 20);
            this.cboAddVendorID.TabIndex = 12;
            // 
            // cboAddVendorName
            // 
            this.cboAddVendorName.FormattingEnabled = true;
            this.cboAddVendorName.Location = new System.Drawing.Point(161, 134);
            this.cboAddVendorName.Name = "cboAddVendorName";
            this.cboAddVendorName.Size = new System.Drawing.Size(112, 20);
            this.cboAddVendorName.TabIndex = 11;
            // 
            // bOOKINFOBindingSource
            // 
            this.bOOKINFOBindingSource.DataMember = "BOOKINFO";
            this.bOOKINFOBindingSource.DataSource = this.dsBookBrokers;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "dsBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.dsBookBrokers;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(411, 329);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(88, 21);
            this.btnDeleteBook.TabIndex = 118;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(303, 329);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(88, 21);
            this.btnUpdateBook.TabIndex = 119;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(195, 329);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(88, 21);
            this.btnAddBook.TabIndex = 120;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(100, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 21);
            this.btnNext.TabIndex = 121;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(243, 17);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(53, 12);
            this.lblBookID.TabIndex = 123;
            this.lblBookID.Text = "Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(302, 14);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(52, 21);
            this.txtBookID.TabIndex = 117;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 12;
            this.lstBooks.Location = new System.Drawing.Point(12, 14);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(177, 280);
            this.lstBooks.TabIndex = 116;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(219, 239);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblVendorName.TabIndex = 138;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(231, 202);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblVendorID.TabIndex = 137;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(302, 236);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(160, 21);
            this.txtVendorName.TabIndex = 135;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(303, 199);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(52, 21);
            this.txtVendorID.TabIndex = 136;
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(195, 276);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(101, 12);
            this.lblClientOrderID.TabIndex = 140;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBookBrokers, "CLIENTORDER.ClientOrderID", true));
            this.txtClientOrderID.Location = new System.Drawing.Point(302, 273);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(52, 21);
            this.txtClientOrderID.TabIndex = 139;
            // 
            // pnlUpBook
            // 
            this.pnlUpBook.Controls.Add(this.dtpUpDatePublished);
            this.pnlUpBook.Controls.Add(this.lblUpVendorName);
            this.pnlUpBook.Controls.Add(this.lblUpVendorID);
            this.pnlUpBook.Controls.Add(this.txtUpVendorName);
            this.pnlUpBook.Controls.Add(this.txtUpVendorID);
            this.pnlUpBook.Controls.Add(this.lblUpTitle);
            this.pnlUpBook.Controls.Add(this.txtUpTitle);
            this.pnlUpBook.Controls.Add(this.lblUpCost);
            this.pnlUpBook.Controls.Add(this.txtUpCost);
            this.pnlUpBook.Controls.Add(this.txtUpPrice);
            this.pnlUpBook.Controls.Add(this.lblUpDatePublished);
            this.pnlUpBook.Controls.Add(this.lblUpPrice);
            this.pnlUpBook.Controls.Add(this.lblUpBookID);
            this.pnlUpBook.Controls.Add(this.txtUpBookID);
            this.pnlUpBook.Controls.Add(this.btnUpCancel);
            this.pnlUpBook.Controls.Add(this.btnSaveChanges);
            this.pnlUpBook.Location = new System.Drawing.Point(788, 12);
            this.pnlUpBook.Name = "pnlUpBook";
            this.pnlUpBook.Size = new System.Drawing.Size(341, 338);
            this.pnlUpBook.TabIndex = 141;
            this.pnlUpBook.Visible = false;
            // 
            // dtpUpDatePublished
            // 
            this.dtpUpDatePublished.Location = new System.Drawing.Point(104, 150);
            this.dtpUpDatePublished.Name = "dtpUpDatePublished";
            this.dtpUpDatePublished.Size = new System.Drawing.Size(200, 21);
            this.dtpUpDatePublished.TabIndex = 153;
            // 
            // lblUpVendorName
            // 
            this.lblUpVendorName.AutoSize = true;
            this.lblUpVendorName.Location = new System.Drawing.Point(21, 227);
            this.lblUpVendorName.Name = "lblUpVendorName";
            this.lblUpVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblUpVendorName.TabIndex = 152;
            this.lblUpVendorName.Text = "Vendor Name:";
            // 
            // lblUpVendorID
            // 
            this.lblUpVendorID.AutoSize = true;
            this.lblUpVendorID.Location = new System.Drawing.Point(33, 190);
            this.lblUpVendorID.Name = "lblUpVendorID";
            this.lblUpVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblUpVendorID.TabIndex = 151;
            this.lblUpVendorID.Text = "Vendor ID:";
            // 
            // txtUpVendorName
            // 
            this.txtUpVendorName.Location = new System.Drawing.Point(104, 224);
            this.txtUpVendorName.Name = "txtUpVendorName";
            this.txtUpVendorName.Size = new System.Drawing.Size(160, 21);
            this.txtUpVendorName.TabIndex = 149;
            // 
            // txtUpVendorID
            // 
            this.txtUpVendorID.Location = new System.Drawing.Point(104, 187);
            this.txtUpVendorID.Name = "txtUpVendorID";
            this.txtUpVendorID.Size = new System.Drawing.Size(52, 21);
            this.txtUpVendorID.TabIndex = 150;
            // 
            // lblUpTitle
            // 
            this.lblUpTitle.AutoSize = true;
            this.lblUpTitle.Location = new System.Drawing.Point(57, 42);
            this.lblUpTitle.Name = "lblUpTitle";
            this.lblUpTitle.Size = new System.Drawing.Size(41, 12);
            this.lblUpTitle.TabIndex = 148;
            this.lblUpTitle.Text = "Title:";
            // 
            // txtUpTitle
            // 
            this.txtUpTitle.Location = new System.Drawing.Point(104, 39);
            this.txtUpTitle.Name = "txtUpTitle";
            this.txtUpTitle.Size = new System.Drawing.Size(229, 21);
            this.txtUpTitle.TabIndex = 147;
            // 
            // lblUpCost
            // 
            this.lblUpCost.AutoSize = true;
            this.lblUpCost.Location = new System.Drawing.Point(63, 79);
            this.lblUpCost.Name = "lblUpCost";
            this.lblUpCost.Size = new System.Drawing.Size(35, 12);
            this.lblUpCost.TabIndex = 146;
            this.lblUpCost.Text = "Cost:";
            // 
            // txtUpCost
            // 
            this.txtUpCost.Location = new System.Drawing.Point(104, 76);
            this.txtUpCost.Name = "txtUpCost";
            this.txtUpCost.Size = new System.Drawing.Size(71, 21);
            this.txtUpCost.TabIndex = 145;
            // 
            // txtUpPrice
            // 
            this.txtUpPrice.Location = new System.Drawing.Point(104, 113);
            this.txtUpPrice.Name = "txtUpPrice";
            this.txtUpPrice.Size = new System.Drawing.Size(71, 21);
            this.txtUpPrice.TabIndex = 144;
            // 
            // lblUpDatePublished
            // 
            this.lblUpDatePublished.AutoSize = true;
            this.lblUpDatePublished.Location = new System.Drawing.Point(3, 153);
            this.lblUpDatePublished.Name = "lblUpDatePublished";
            this.lblUpDatePublished.Size = new System.Drawing.Size(95, 12);
            this.lblUpDatePublished.TabIndex = 141;
            this.lblUpDatePublished.Text = "Date Published:";
            // 
            // lblUpPrice
            // 
            this.lblUpPrice.AutoSize = true;
            this.lblUpPrice.Location = new System.Drawing.Point(57, 116);
            this.lblUpPrice.Name = "lblUpPrice";
            this.lblUpPrice.Size = new System.Drawing.Size(41, 12);
            this.lblUpPrice.TabIndex = 142;
            this.lblUpPrice.Text = "Price:";
            // 
            // lblUpBookID
            // 
            this.lblUpBookID.AutoSize = true;
            this.lblUpBookID.Location = new System.Drawing.Point(45, 5);
            this.lblUpBookID.Name = "lblUpBookID";
            this.lblUpBookID.Size = new System.Drawing.Size(53, 12);
            this.lblUpBookID.TabIndex = 140;
            this.lblUpBookID.Text = "Book ID:";
            // 
            // txtUpBookID
            // 
            this.txtUpBookID.Location = new System.Drawing.Point(104, 2);
            this.txtUpBookID.Name = "txtUpBookID";
            this.txtUpBookID.Size = new System.Drawing.Size(52, 21);
            this.txtUpBookID.TabIndex = 139;
            // 
            // btnUpCancel
            // 
            this.btnUpCancel.Location = new System.Drawing.Point(166, 264);
            this.btnUpCancel.Name = "btnUpCancel";
            this.btnUpCancel.Size = new System.Drawing.Size(112, 21);
            this.btnUpCancel.TabIndex = 106;
            this.btnUpCancel.Text = "Cancel";
            this.btnUpCancel.UseVisualStyleBackColor = false;
            this.btnUpCancel.Click += new System.EventHandler(this.btnUpCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(5, 264);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 21);
            this.btnSaveChanges.TabIndex = 107;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cLIENTORDERBindingSource
            // 
            this.cLIENTORDERBindingSource.DataMember = "CLIENTORDER";
            this.cLIENTORDERBindingSource.DataSource = this.dsBookBrokers;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(411, 365);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 21);
            this.btnReturn.TabIndex = 142;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(313, 17);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(11, 12);
            this.lblC.TabIndex = 143;
            this.lblC.Text = "C";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(313, 202);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(11, 12);
            this.lblD.TabIndex = 144;
            this.lblD.Text = "D";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(313, 239);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(11, 12);
            this.lblE.TabIndex = 145;
            this.lblE.Text = "E";
            this.lblE.TextChanged += new System.EventHandler(this.lblE_TextChanged);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1131, 417);
            this.Controls.Add(this.pnlUpBook);
            this.Controls.Add(this.pnlAddBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDatePublished);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblC);
            this.Name = "BookForm";
            this.Text = "Book Maintenance";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            this.pnlUpBook.ResumeLayout(false);
            this.pnlUpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtDatePublished;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Label lblAddBookInfo;
        private System.Windows.Forms.ComboBox cboAddBookInfoID;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.ComboBox cboAddVendorID;
        private System.Windows.Forms.ComboBox cboAddVendorName;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Label lblAddVendor;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Label lblAddDatePublished;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.ComboBox cboAddBookTitle;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.BindingSource bOOKINFOBindingSource;
        private dsBookBrokers dsBookBrokers;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private System.Windows.Forms.Panel pnlUpBook;
        private System.Windows.Forms.DateTimePicker dtpUpDatePublished;
        private System.Windows.Forms.Label lblUpVendorName;
        private System.Windows.Forms.Label lblUpVendorID;
        private System.Windows.Forms.TextBox txtUpVendorName;
        private System.Windows.Forms.TextBox txtUpVendorID;
        private System.Windows.Forms.Label lblUpTitle;
        private System.Windows.Forms.TextBox txtUpTitle;
        private System.Windows.Forms.Label lblUpCost;
        private System.Windows.Forms.TextBox txtUpCost;
        private System.Windows.Forms.TextBox txtUpPrice;
        private System.Windows.Forms.Label lblUpDatePublished;
        private System.Windows.Forms.Label lblUpPrice;
        private System.Windows.Forms.Label lblUpBookID;
        private System.Windows.Forms.TextBox txtUpBookID;
        private System.Windows.Forms.Button btnUpCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.BindingSource cLIENTORDERBindingSource;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblE;
    }
}