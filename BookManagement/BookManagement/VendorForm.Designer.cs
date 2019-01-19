namespace BookManagement
{
    partial class VendorForm
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
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVendor = new System.Windows.Forms.Panel();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddPBNo = new System.Windows.Forms.Label();
            this.lblAddVendorName = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPBNo = new System.Windows.Forms.TextBox();
            this.txtAddVendorName = new System.Windows.Forms.TextBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.cboAddCountryID = new System.Windows.Forms.ComboBox();
            this.cboAddCountryName = new System.Windows.Forms.ComboBox();
            this.cOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookBrokersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPBNo = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.txtPBNo = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlUpVendor = new System.Windows.Forms.Panel();
            this.lblUpEmail = new System.Windows.Forms.Label();
            this.lblUpCountry = new System.Windows.Forms.Label();
            this.lblUpPBNo = new System.Windows.Forms.Label();
            this.lblUpVendorName = new System.Windows.Forms.Label();
            this.lblUpVendorID = new System.Windows.Forms.Label();
            this.txtUpCountry = new System.Windows.Forms.TextBox();
            this.txtUpEmail = new System.Windows.Forms.TextBox();
            this.txtUpPBNo = new System.Windows.Forms.TextBox();
            this.txtUpVendorName = new System.Windows.Forms.TextBox();
            this.txtUpVendorID = new System.Windows.Forms.TextBox();
            this.btnUpCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlAddVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            this.pnlUpVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVendor
            // 
            this.lstVendor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.ItemHeight = 12;
            this.lstVendor.Location = new System.Drawing.Point(45, 40);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(166, 208);
            this.lstVendor.TabIndex = 0;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(318, 35);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(52, 21);
            this.txtVendorID.TabIndex = 2;
            this.txtVendorID.TextChanged += new System.EventHandler(this.TxtVendorID_TextChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(318, 69);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(195, 21);
            this.txtVendorName.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(45, 276);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 21);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(134, 276);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 21);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(223, 276);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(112, 21);
            this.btnAddVendor.TabIndex = 3;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = false;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.Location = new System.Drawing.Point(349, 276);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(112, 21);
            this.btnUpdateVendor.TabIndex = 3;
            this.btnUpdateVendor.Text = "Update Vendor";
            this.btnUpdateVendor.UseVisualStyleBackColor = false;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Location = new System.Drawing.Point(475, 276);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(112, 21);
            this.btnDeleteVendor.TabIndex = 3;
            this.btnDeleteVendor.Text = "Delete Vendor";
            this.btnDeleteVendor.UseVisualStyleBackColor = false;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(475, 311);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 21);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVendor
            // 
            this.pnlAddVendor.Controls.Add(this.lblAddEmail);
            this.pnlAddVendor.Controls.Add(this.lblAddCountry);
            this.pnlAddVendor.Controls.Add(this.lblAddPBNo);
            this.pnlAddVendor.Controls.Add(this.lblAddVendorName);
            this.pnlAddVendor.Controls.Add(this.txtAddEmail);
            this.pnlAddVendor.Controls.Add(this.txtAddPBNo);
            this.pnlAddVendor.Controls.Add(this.txtAddVendorName);
            this.pnlAddVendor.Controls.Add(this.btnAddCancel);
            this.pnlAddVendor.Controls.Add(this.btnSaveVendor);
            this.pnlAddVendor.Controls.Add(this.cboAddCountryID);
            this.pnlAddVendor.Controls.Add(this.cboAddCountryName);
            this.pnlAddVendor.Location = new System.Drawing.Point(607, 21);
            this.pnlAddVendor.Name = "pnlAddVendor";
            this.pnlAddVendor.Size = new System.Drawing.Size(324, 182);
            this.pnlAddVendor.TabIndex = 4;
            this.pnlAddVendor.Visible = false;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(71, 118);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(41, 12);
            this.lblAddEmail.TabIndex = 32;
            this.lblAddEmail.Text = "Email:";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(60, 84);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(53, 12);
            this.lblAddCountry.TabIndex = 31;
            this.lblAddCountry.Text = "Country:";
            // 
            // lblAddPBNo
            // 
            this.lblAddPBNo.AutoSize = true;
            this.lblAddPBNo.Location = new System.Drawing.Point(14, 49);
            this.lblAddPBNo.Name = "lblAddPBNo";
            this.lblAddPBNo.Size = new System.Drawing.Size(101, 12);
            this.lblAddPBNo.TabIndex = 30;
            this.lblAddPBNo.Text = "Post Box Number:";
            // 
            // lblAddVendorName
            // 
            this.lblAddVendorName.AutoSize = true;
            this.lblAddVendorName.Location = new System.Drawing.Point(31, 14);
            this.lblAddVendorName.Name = "lblAddVendorName";
            this.lblAddVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblAddVendorName.TabIndex = 29;
            this.lblAddVendorName.Text = "Vendor Name:";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(112, 114);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(113, 21);
            this.txtAddEmail.TabIndex = 24;
            // 
            // txtAddPBNo
            // 
            this.txtAddPBNo.Location = new System.Drawing.Point(112, 47);
            this.txtAddPBNo.Name = "txtAddPBNo";
            this.txtAddPBNo.Size = new System.Drawing.Size(90, 21);
            this.txtAddPBNo.TabIndex = 25;
            // 
            // txtAddVendorName
            // 
            this.txtAddVendorName.Location = new System.Drawing.Point(112, 13);
            this.txtAddVendorName.Name = "txtAddVendorName";
            this.txtAddVendorName.Size = new System.Drawing.Size(195, 21);
            this.txtAddVendorName.TabIndex = 26;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(195, 148);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(112, 21);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.Location = new System.Drawing.Point(34, 148);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(112, 21);
            this.btnSaveVendor.TabIndex = 22;
            this.btnSaveVendor.Text = "Save Vendor";
            this.btnSaveVendor.UseVisualStyleBackColor = false;
            this.btnSaveVendor.Click += new System.EventHandler(this.btnSaveVendor_Click);
            // 
            // cboAddCountryID
            // 
            this.cboAddCountryID.FormattingEnabled = true;
            this.cboAddCountryID.Location = new System.Drawing.Point(112, 81);
            this.cboAddCountryID.Name = "cboAddCountryID";
            this.cboAddCountryID.Size = new System.Drawing.Size(45, 20);
            this.cboAddCountryID.TabIndex = 12;
            // 
            // cboAddCountryName
            // 
            this.cboAddCountryName.FormattingEnabled = true;
            this.cboAddCountryName.Location = new System.Drawing.Point(163, 81);
            this.cboAddCountryName.Name = "cboAddCountryName";
            this.cboAddCountryName.Size = new System.Drawing.Size(121, 20);
            this.cboAddCountryName.TabIndex = 11;
            // 
            // cOUNTRYBindingSource
            // 
            this.cOUNTRYBindingSource.DataMember = "COUNTRY";
            this.cOUNTRYBindingSource.DataSource = this.dsBookBrokersBindingSource;
            // 
            // dsBookBrokersBindingSource
            // 
            this.dsBookBrokersBindingSource.DataSource = this.dsBookBrokers;
            this.dsBookBrokersBindingSource.Position = 0;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "dsBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(277, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(266, 140);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(53, 12);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country:";
            // 
            // lblPBNo
            // 
            this.lblPBNo.AutoSize = true;
            this.lblPBNo.Location = new System.Drawing.Point(220, 105);
            this.lblPBNo.Name = "lblPBNo";
            this.lblPBNo.Size = new System.Drawing.Size(101, 12);
            this.lblPBNo.TabIndex = 17;
            this.lblPBNo.Text = "Post Box Number:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(237, 70);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblVendorName.TabIndex = 16;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(254, 35);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblVendorID.TabIndex = 15;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // txtPBNo
            // 
            this.txtPBNo.Location = new System.Drawing.Point(318, 103);
            this.txtPBNo.Name = "txtPBNo";
            this.txtPBNo.Size = new System.Drawing.Size(90, 21);
            this.txtPBNo.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(318, 137);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 21);
            this.txtCountry.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // pnlUpVendor
            // 
            this.pnlUpVendor.Controls.Add(this.lblUpEmail);
            this.pnlUpVendor.Controls.Add(this.lblUpCountry);
            this.pnlUpVendor.Controls.Add(this.lblUpPBNo);
            this.pnlUpVendor.Controls.Add(this.lblUpVendorName);
            this.pnlUpVendor.Controls.Add(this.lblUpVendorID);
            this.pnlUpVendor.Controls.Add(this.txtUpCountry);
            this.pnlUpVendor.Controls.Add(this.txtUpEmail);
            this.pnlUpVendor.Controls.Add(this.txtUpPBNo);
            this.pnlUpVendor.Controls.Add(this.txtUpVendorName);
            this.pnlUpVendor.Controls.Add(this.txtUpVendorID);
            this.pnlUpVendor.Controls.Add(this.btnUpCancel);
            this.pnlUpVendor.Controls.Add(this.btnSaveChanges);
            this.pnlUpVendor.Location = new System.Drawing.Point(607, 209);
            this.pnlUpVendor.Name = "pnlUpVendor";
            this.pnlUpVendor.Size = new System.Drawing.Size(324, 201);
            this.pnlUpVendor.TabIndex = 33;
            this.pnlUpVendor.Visible = false;
            // 
            // lblUpEmail
            // 
            this.lblUpEmail.AutoSize = true;
            this.lblUpEmail.Location = new System.Drawing.Point(73, 153);
            this.lblUpEmail.Name = "lblUpEmail";
            this.lblUpEmail.Size = new System.Drawing.Size(41, 12);
            this.lblUpEmail.TabIndex = 32;
            this.lblUpEmail.Text = "Email:";
            // 
            // lblUpCountry
            // 
            this.lblUpCountry.AutoSize = true;
            this.lblUpCountry.Location = new System.Drawing.Point(62, 119);
            this.lblUpCountry.Name = "lblUpCountry";
            this.lblUpCountry.Size = new System.Drawing.Size(53, 12);
            this.lblUpCountry.TabIndex = 31;
            this.lblUpCountry.Text = "Country:";
            // 
            // lblUpPBNo
            // 
            this.lblUpPBNo.AutoSize = true;
            this.lblUpPBNo.Location = new System.Drawing.Point(16, 84);
            this.lblUpPBNo.Name = "lblUpPBNo";
            this.lblUpPBNo.Size = new System.Drawing.Size(101, 12);
            this.lblUpPBNo.TabIndex = 30;
            this.lblUpPBNo.Text = "Post Box Number:";
            // 
            // lblUpVendorName
            // 
            this.lblUpVendorName.AutoSize = true;
            this.lblUpVendorName.Location = new System.Drawing.Point(33, 49);
            this.lblUpVendorName.Name = "lblUpVendorName";
            this.lblUpVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblUpVendorName.TabIndex = 29;
            this.lblUpVendorName.Text = "Vendor Name:";
            // 
            // lblUpVendorID
            // 
            this.lblUpVendorID.AutoSize = true;
            this.lblUpVendorID.Location = new System.Drawing.Point(50, 14);
            this.lblUpVendorID.Name = "lblUpVendorID";
            this.lblUpVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblUpVendorID.TabIndex = 28;
            this.lblUpVendorID.Text = "Vendor ID:";
            // 
            // txtUpCountry
            // 
            this.txtUpCountry.Location = new System.Drawing.Point(114, 115);
            this.txtUpCountry.Name = "txtUpCountry";
            this.txtUpCountry.Size = new System.Drawing.Size(100, 21);
            this.txtUpCountry.TabIndex = 23;
            // 
            // txtUpEmail
            // 
            this.txtUpEmail.Location = new System.Drawing.Point(114, 150);
            this.txtUpEmail.Name = "txtUpEmail";
            this.txtUpEmail.Size = new System.Drawing.Size(113, 21);
            this.txtUpEmail.TabIndex = 24;
            // 
            // txtUpPBNo
            // 
            this.txtUpPBNo.Location = new System.Drawing.Point(114, 82);
            this.txtUpPBNo.Name = "txtUpPBNo";
            this.txtUpPBNo.Size = new System.Drawing.Size(90, 21);
            this.txtUpPBNo.TabIndex = 25;
            // 
            // txtUpVendorName
            // 
            this.txtUpVendorName.Location = new System.Drawing.Point(114, 48);
            this.txtUpVendorName.Name = "txtUpVendorName";
            this.txtUpVendorName.Size = new System.Drawing.Size(195, 21);
            this.txtUpVendorName.TabIndex = 26;
            // 
            // txtUpVendorID
            // 
            this.txtUpVendorID.Location = new System.Drawing.Point(114, 14);
            this.txtUpVendorID.Name = "txtUpVendorID";
            this.txtUpVendorID.Size = new System.Drawing.Size(52, 21);
            this.txtUpVendorID.TabIndex = 27;
            // 
            // btnUpCancel
            // 
            this.btnUpCancel.Location = new System.Drawing.Point(195, 174);
            this.btnUpCancel.Name = "btnUpCancel";
            this.btnUpCancel.Size = new System.Drawing.Size(112, 21);
            this.btnUpCancel.TabIndex = 22;
            this.btnUpCancel.Text = "Cancel";
            this.btnUpCancel.UseVisualStyleBackColor = false;
            this.btnUpCancel.Click += new System.EventHandler(this.btnUpCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(34, 174);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 21);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(397, 140);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(11, 12);
            this.lblC.TabIndex = 34;
            this.lblC.Text = "C";
            this.lblC.TextChanged += new System.EventHandler(this.lblC_TextChanged);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(977, 411);
            this.Controls.Add(this.pnlAddVendor);
            this.Controls.Add(this.pnlUpVendor);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.lblPBNo);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPBNo);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lstVendor);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblC);
            this.Name = "VendorForm";
            this.Text = "Vendor Maintenance";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            this.pnlAddVendor.ResumeLayout(false);
            this.pnlAddVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            this.pnlUpVendor.ResumeLayout(false);
            this.pnlUpVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendor;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnUpdateVendor;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVendor;
        private System.Windows.Forms.ComboBox cboAddCountryID;
        private System.Windows.Forms.ComboBox cboAddCountryName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPBNo;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.TextBox txtPBNo;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddPBNo;
        private System.Windows.Forms.Label lblAddVendorName;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPBNo;
        private System.Windows.Forms.TextBox txtAddVendorName;
        private System.Windows.Forms.Panel pnlUpVendor;
        private System.Windows.Forms.Label lblUpEmail;
        private System.Windows.Forms.Label lblUpCountry;
        private System.Windows.Forms.Label lblUpPBNo;
        private System.Windows.Forms.Label lblUpVendorName;
        private System.Windows.Forms.Label lblUpVendorID;
        private System.Windows.Forms.TextBox txtUpCountry;
        private System.Windows.Forms.TextBox txtUpEmail;
        private System.Windows.Forms.TextBox txtUpPBNo;
        private System.Windows.Forms.TextBox txtUpVendorName;
        private System.Windows.Forms.TextBox txtUpVendorID;
        private System.Windows.Forms.Button btnUpCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.BindingSource cOUNTRYBindingSource;
        private System.Windows.Forms.BindingSource dsBookBrokersBindingSource;
        private dsBookBrokers dsBookBrokers;
        private System.Windows.Forms.Label lblC;
    }
}
