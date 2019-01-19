namespace BookManagement
{
    partial class BookInfoForm
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
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.cbxAddFirstName = new System.Windows.Forms.ComboBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveBookInfo = new System.Windows.Forms.Button();
            this.cbxAddAuthorID = new System.Windows.Forms.ComboBox();
            this.cbxAddLastName = new System.Windows.Forms.ComboBox();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.lstBookInfo = new System.Windows.Forms.ListBox();
            this.pnlUpBookInfo = new System.Windows.Forms.Panel();
            this.lblUpNotes = new System.Windows.Forms.Label();
            this.txtUpNotes = new System.Windows.Forms.TextBox();
            this.lblUpTitle = new System.Windows.Forms.Label();
            this.btnUpCancel = new System.Windows.Forms.Button();
            this.txtUpTitle = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblUpAuthorID = new System.Windows.Forms.Label();
            this.txtUpAuthorID = new System.Windows.Forms.TextBox();
            this.lblUpBookInfoID = new System.Windows.Forms.Label();
            this.txtUpBookInfoID = new System.Windows.Forms.TextBox();
            this.txtUpFirstName = new System.Windows.Forms.TextBox();
            this.txtUpLastName = new System.Windows.Forms.TextBox();
            this.lblUpFirstName = new System.Windows.Forms.Label();
            this.lblUpLastName = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.pnlAddBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            this.pnlUpBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(256, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 115;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(309, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 21);
            this.txtTitle.TabIndex = 114;
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(238, 103);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(65, 12);
            this.lblAuthorID.TabIndex = 113;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(309, 100);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(52, 21);
            this.txtAuthorID.TabIndex = 112;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(27, 283);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 21);
            this.btnPrevious.TabIndex = 111;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(256, 215);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 12);
            this.lblNotes.TabIndex = 110;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNotes.Location = new System.Drawing.Point(309, 212);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(229, 49);
            this.txtNotes.TabIndex = 109;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(309, 176);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 21);
            this.txtFirstName.TabIndex = 107;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(309, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 21);
            this.txtLastName.TabIndex = 108;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(190, 179);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblFirstName.TabIndex = 105;
            this.lblFirstName.Text = "Author First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(196, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(107, 12);
            this.lblLastName.TabIndex = 106;
            this.lblLastName.Text = "Author Last Name:";
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.Controls.Add(this.lblAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.lblAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.txtAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.cbxAddFirstName);
            this.pnlAddBookInfo.Controls.Add(this.lblAddAuthor);
            this.pnlAddBookInfo.Controls.Add(this.btnAddCancel);
            this.pnlAddBookInfo.Controls.Add(this.btnSaveBookInfo);
            this.pnlAddBookInfo.Controls.Add(this.cbxAddAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.cbxAddLastName);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(544, 12);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(371, 265);
            this.pnlAddBookInfo.TabIndex = 103;
            this.pnlAddBookInfo.Visible = false;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Location = new System.Drawing.Point(75, 97);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(41, 12);
            this.lblAddNotes.TabIndex = 119;
            this.lblAddNotes.Text = "Notes:";
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddNotes.Location = new System.Drawing.Point(128, 94);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(229, 49);
            this.txtAddNotes.TabIndex = 118;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(75, 21);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(41, 12);
            this.lblAddTitle.TabIndex = 117;
            this.lblAddTitle.Text = "Title:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(122, 18);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(235, 21);
            this.txtAddTitle.TabIndex = 116;
            // 
            // cbxAddFirstName
            // 
            this.cbxAddFirstName.FormattingEnabled = true;
            this.cbxAddFirstName.Location = new System.Drawing.Point(272, 56);
            this.cbxAddFirstName.Name = "cbxAddFirstName";
            this.cbxAddFirstName.Size = new System.Drawing.Size(85, 20);
            this.cbxAddFirstName.TabIndex = 98;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(69, 59);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(47, 12);
            this.lblAddAuthor.TabIndex = 95;
            this.lblAddAuthor.Text = "Author:";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(245, 155);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(112, 21);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveBookInfo
            // 
            this.btnSaveBookInfo.Location = new System.Drawing.Point(29, 155);
            this.btnSaveBookInfo.Name = "btnSaveBookInfo";
            this.btnSaveBookInfo.Size = new System.Drawing.Size(138, 21);
            this.btnSaveBookInfo.TabIndex = 22;
            this.btnSaveBookInfo.Text = "Save Book Info";
            this.btnSaveBookInfo.UseVisualStyleBackColor = false;
            this.btnSaveBookInfo.Click += new System.EventHandler(this.btnSaveBookInfo_Click);
            // 
            // cbxAddAuthorID
            // 
            this.cbxAddAuthorID.FormattingEnabled = true;
            this.cbxAddAuthorID.Location = new System.Drawing.Point(122, 56);
            this.cbxAddAuthorID.Name = "cbxAddAuthorID";
            this.cbxAddAuthorID.Size = new System.Drawing.Size(53, 20);
            this.cbxAddAuthorID.TabIndex = 12;
            // 
            // cbxAddLastName
            // 
            this.cbxAddLastName.FormattingEnabled = true;
            this.cbxAddLastName.Location = new System.Drawing.Point(181, 56);
            this.cbxAddLastName.Name = "cbxAddLastName";
            this.cbxAddLastName.Size = new System.Drawing.Size(85, 20);
            this.cbxAddLastName.TabIndex = 11;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.dsBookBrokers;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "dsBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(504, 320);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 21);
            this.btnReturn.TabIndex = 98;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(488, 283);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(128, 21);
            this.btnDeleteBookInfo.TabIndex = 99;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = false;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(345, 283);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(128, 21);
            this.btnUpdateBookInfo.TabIndex = 100;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = false;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(200, 283);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(128, 21);
            this.btnAddBookInfo.TabIndex = 101;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = false;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(114, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 21);
            this.btnNext.TabIndex = 102;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(220, 27);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(83, 12);
            this.lblBookInfoID.TabIndex = 104;
            this.lblBookInfoID.Text = "Book Info ID:";
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(309, 24);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(52, 21);
            this.txtBookInfoID.TabIndex = 97;
            this.txtBookInfoID.TextChanged += new System.EventHandler(this.txtBookInfoID_TextChanged);
            // 
            // lstBookInfo
            // 
            this.lstBookInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstBookInfo.FormattingEnabled = true;
            this.lstBookInfo.ItemHeight = 12;
            this.lstBookInfo.Location = new System.Drawing.Point(21, 12);
            this.lstBookInfo.Name = "lstBookInfo";
            this.lstBookInfo.Size = new System.Drawing.Size(166, 208);
            this.lstBookInfo.TabIndex = 96;
            // 
            // pnlUpBookInfo
            // 
            this.pnlUpBookInfo.Controls.Add(this.lblUpNotes);
            this.pnlUpBookInfo.Controls.Add(this.txtUpNotes);
            this.pnlUpBookInfo.Controls.Add(this.lblUpTitle);
            this.pnlUpBookInfo.Controls.Add(this.btnUpCancel);
            this.pnlUpBookInfo.Controls.Add(this.txtUpTitle);
            this.pnlUpBookInfo.Controls.Add(this.btnSaveChanges);
            this.pnlUpBookInfo.Controls.Add(this.lblUpAuthorID);
            this.pnlUpBookInfo.Controls.Add(this.txtUpAuthorID);
            this.pnlUpBookInfo.Controls.Add(this.lblUpBookInfoID);
            this.pnlUpBookInfo.Controls.Add(this.txtUpBookInfoID);
            this.pnlUpBookInfo.Controls.Add(this.txtUpFirstName);
            this.pnlUpBookInfo.Controls.Add(this.txtUpLastName);
            this.pnlUpBookInfo.Controls.Add(this.lblUpFirstName);
            this.pnlUpBookInfo.Controls.Add(this.lblUpLastName);
            this.pnlUpBookInfo.Location = new System.Drawing.Point(921, 12);
            this.pnlUpBookInfo.Name = "pnlUpBookInfo";
            this.pnlUpBookInfo.Size = new System.Drawing.Size(385, 292);
            this.pnlUpBookInfo.TabIndex = 120;
            this.pnlUpBookInfo.Visible = false;
            // 
            // lblUpNotes
            // 
            this.lblUpNotes.AutoSize = true;
            this.lblUpNotes.Location = new System.Drawing.Point(75, 186);
            this.lblUpNotes.Name = "lblUpNotes";
            this.lblUpNotes.Size = new System.Drawing.Size(41, 12);
            this.lblUpNotes.TabIndex = 128;
            this.lblUpNotes.Text = "Notes:";
            // 
            // txtUpNotes
            // 
            this.txtUpNotes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUpNotes.Location = new System.Drawing.Point(128, 183);
            this.txtUpNotes.Multiline = true;
            this.txtUpNotes.Name = "txtUpNotes";
            this.txtUpNotes.Size = new System.Drawing.Size(229, 49);
            this.txtUpNotes.TabIndex = 127;
            // 
            // lblUpTitle
            // 
            this.lblUpTitle.AutoSize = true;
            this.lblUpTitle.Location = new System.Drawing.Point(75, 50);
            this.lblUpTitle.Name = "lblUpTitle";
            this.lblUpTitle.Size = new System.Drawing.Size(41, 12);
            this.lblUpTitle.TabIndex = 126;
            this.lblUpTitle.Text = "Title:";
            // 
            // btnUpCancel
            // 
            this.btnUpCancel.Location = new System.Drawing.Point(197, 251);
            this.btnUpCancel.Name = "btnUpCancel";
            this.btnUpCancel.Size = new System.Drawing.Size(112, 21);
            this.btnUpCancel.TabIndex = 106;
            this.btnUpCancel.Text = "Cancel";
            this.btnUpCancel.UseVisualStyleBackColor = false;
            this.btnUpCancel.Click += new System.EventHandler(this.btnUpCancel_Click);
            // 
            // txtUpTitle
            // 
            this.txtUpTitle.Location = new System.Drawing.Point(128, 47);
            this.txtUpTitle.Name = "txtUpTitle";
            this.txtUpTitle.Size = new System.Drawing.Size(229, 21);
            this.txtUpTitle.TabIndex = 125;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(36, 251);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 21);
            this.btnSaveChanges.TabIndex = 107;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblUpAuthorID
            // 
            this.lblUpAuthorID.AutoSize = true;
            this.lblUpAuthorID.Location = new System.Drawing.Point(57, 88);
            this.lblUpAuthorID.Name = "lblUpAuthorID";
            this.lblUpAuthorID.Size = new System.Drawing.Size(65, 12);
            this.lblUpAuthorID.TabIndex = 124;
            this.lblUpAuthorID.Text = "Author ID:";
            // 
            // txtUpAuthorID
            // 
            this.txtUpAuthorID.Location = new System.Drawing.Point(128, 85);
            this.txtUpAuthorID.Name = "txtUpAuthorID";
            this.txtUpAuthorID.Size = new System.Drawing.Size(52, 21);
            this.txtUpAuthorID.TabIndex = 123;
            // 
            // lblUpBookInfoID
            // 
            this.lblUpBookInfoID.AutoSize = true;
            this.lblUpBookInfoID.Location = new System.Drawing.Point(39, 12);
            this.lblUpBookInfoID.Name = "lblUpBookInfoID";
            this.lblUpBookInfoID.Size = new System.Drawing.Size(83, 12);
            this.lblUpBookInfoID.TabIndex = 122;
            this.lblUpBookInfoID.Text = "Book Info ID:";
            // 
            // txtUpBookInfoID
            // 
            this.txtUpBookInfoID.Location = new System.Drawing.Point(128, 9);
            this.txtUpBookInfoID.Name = "txtUpBookInfoID";
            this.txtUpBookInfoID.Size = new System.Drawing.Size(52, 21);
            this.txtUpBookInfoID.TabIndex = 121;
            // 
            // txtUpFirstName
            // 
            this.txtUpFirstName.Location = new System.Drawing.Point(128, 150);
            this.txtUpFirstName.Name = "txtUpFirstName";
            this.txtUpFirstName.Size = new System.Drawing.Size(133, 21);
            this.txtUpFirstName.TabIndex = 98;
            // 
            // txtUpLastName
            // 
            this.txtUpLastName.Location = new System.Drawing.Point(128, 112);
            this.txtUpLastName.Name = "txtUpLastName";
            this.txtUpLastName.Size = new System.Drawing.Size(133, 21);
            this.txtUpLastName.TabIndex = 99;
            // 
            // lblUpFirstName
            // 
            this.lblUpFirstName.AutoSize = true;
            this.lblUpFirstName.Location = new System.Drawing.Point(9, 153);
            this.lblUpFirstName.Name = "lblUpFirstName";
            this.lblUpFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblUpFirstName.TabIndex = 96;
            this.lblUpFirstName.Text = "Client First Name:";
            // 
            // lblUpLastName
            // 
            this.lblUpLastName.AutoSize = true;
            this.lblUpLastName.Location = new System.Drawing.Point(15, 115);
            this.lblUpLastName.Name = "lblUpLastName";
            this.lblUpLastName.Size = new System.Drawing.Size(107, 12);
            this.lblUpLastName.TabIndex = 97;
            this.lblUpLastName.Text = "Client Last Name:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(334, 106);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(11, 12);
            this.lblA.TabIndex = 121;
            this.lblA.Text = "A";
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1318, 395);
            this.Controls.Add(this.pnlUpBookInfo);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.lstBookInfo);
            this.Controls.Add(this.lblA);
            this.Name = "BookInfoForm";
            this.Text = "Book Info Maintenance";
            this.Load += new System.EventHandler(this.BookInfoForm_Load);
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            this.pnlUpBookInfo.ResumeLayout(false);
            this.pnlUpBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.ComboBox cbxAddFirstName;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveBookInfo;
        private System.Windows.Forms.ComboBox cbxAddAuthorID;
        private System.Windows.Forms.ComboBox cbxAddLastName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.ListBox lstBookInfo;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private dsBookBrokers dsBookBrokers;
        private System.Windows.Forms.Panel pnlUpBookInfo;
        private System.Windows.Forms.Label lblUpNotes;
        private System.Windows.Forms.TextBox txtUpNotes;
        private System.Windows.Forms.Label lblUpTitle;
        private System.Windows.Forms.Button btnUpCancel;
        private System.Windows.Forms.TextBox txtUpTitle;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblUpAuthorID;
        private System.Windows.Forms.TextBox txtUpAuthorID;
        private System.Windows.Forms.Label lblUpBookInfoID;
        private System.Windows.Forms.TextBox txtUpBookInfoID;
        private System.Windows.Forms.TextBox txtUpFirstName;
        private System.Windows.Forms.TextBox txtUpLastName;
        private System.Windows.Forms.Label lblUpFirstName;
        private System.Windows.Forms.Label lblUpLastName;
        private System.Windows.Forms.Label lblA;
    }
}