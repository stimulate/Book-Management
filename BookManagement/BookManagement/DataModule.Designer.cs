namespace BookManagement
{
    partial class DataModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnBookBrokers = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daAuthor = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daBook = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daBookInfo = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daClient = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daClientOrder = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daCountry = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daVendor = new System.Data.OleDb.OleDbDataAdapter();
            this.dsBookBrokers = new BookManagement.dsBookBrokers();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        AuthorID, LastName, FirstName\r\nFROM            AUTHOR\r\nORDER BY Aut" +
    "horID";
            this.oleDbSelectCommand1.Connection = this.ctnBookBrokers;
            // 
            // ctnBookBrokers
            // 
            this.ctnBookBrokers.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\E\\BookManagement\\BookBrokers.acc" +
    "db";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `AUTHOR` (`LastName`, `FirstName`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `AUTHOR` SET `LastName` = ?, `FirstName` = ? WHERE ((`AuthorID` = ?) AND (" +
    "(? = 1 AND `LastName` IS NULL) OR (`LastName` = ?)) AND ((? = 1 AND `FirstName` " +
    "IS NULL) OR (`FirstName` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("Original_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `AUTHOR` WHERE ((`AuthorID` = ?) AND ((? = 1 AND `LastName` IS NULL) " +
    "OR (`LastName` = ?)) AND ((? = 1 AND `FirstName` IS NULL) OR (`FirstName` = ?)))" +
    "";
            this.oleDbDeleteCommand1.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null)});
            // 
            // daAuthor
            // 
            this.daAuthor.DeleteCommand = this.oleDbDeleteCommand1;
            this.daAuthor.InsertCommand = this.oleDbInsertCommand1;
            this.daAuthor.SelectCommand = this.oleDbSelectCommand1;
            this.daAuthor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AUTHOR", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AuthorID", "AuthorID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName")})});
            this.daAuthor.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        BookID, Cost, Price, DatePublished, BookInfoID, VendorID, ClientOrd" +
    "erID\r\nFROM            BOOK\r\nORDER BY BookID";
            this.oleDbSelectCommand2.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `BOOK` (`Cost`, `Price`, `DatePublished`, `BookInfoID`, `VendorID`, `" +
    "ClientOrderID`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnBookBrokers;
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
            this.oleDbUpdateCommand2.Connection = this.ctnBookBrokers;
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
            this.oleDbDeleteCommand2.Connection = this.ctnBookBrokers;
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
            // daBook
            // 
            this.daBook.DeleteCommand = this.oleDbDeleteCommand2;
            this.daBook.InsertCommand = this.oleDbInsertCommand2;
            this.daBook.SelectCommand = this.oleDbSelectCommand2;
            this.daBook.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BOOK", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BookID", "BookID"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost"),
                        new System.Data.Common.DataColumnMapping("Price", "Price"),
                        new System.Data.Common.DataColumnMapping("DatePublished", "DatePublished"),
                        new System.Data.Common.DataColumnMapping("BookInfoID", "BookInfoID"),
                        new System.Data.Common.DataColumnMapping("VendorID", "VendorID"),
                        new System.Data.Common.DataColumnMapping("ClientOrderID", "ClientOrderID")})});
            this.daBook.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        BookInfoID, Title, AuthorID, Notes\r\nFROM            BOOKINFO\r\nORDER" +
    " BY BookInfoID";
            this.oleDbSelectCommand3.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `BOOKINFO` (`Title`, `AuthorID`, `Notes`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title"),
            new System.Data.OleDb.OleDbParameter("AuthorID", System.Data.OleDb.OleDbType.Integer, 0, "AuthorID"),
            new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title"),
            new System.Data.OleDb.OleDbParameter("AuthorID", System.Data.OleDb.OleDbType.Integer, 0, "AuthorID"),
            new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"),
            new System.Data.OleDb.OleDbParameter("Original_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Notes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Notes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notes", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_BookInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookInfoID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AuthorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AuthorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Notes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Notes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Notes", System.Data.DataRowVersion.Original, null)});
            // 
            // daBookInfo
            // 
            this.daBookInfo.DeleteCommand = this.oleDbDeleteCommand3;
            this.daBookInfo.InsertCommand = this.oleDbInsertCommand3;
            this.daBookInfo.SelectCommand = this.oleDbSelectCommand3;
            this.daBookInfo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BOOKINFO", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BookInfoID", "BookInfoID"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("AuthorID", "AuthorID"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes")})});
            this.daBookInfo.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        ClientID, LastName, FirstName, StreetAddress, Suburb, City, Country" +
    "ID, Email, CreditStatus\r\nFROM            CLIENT\r\nORDER BY ClientID";
            this.oleDbSelectCommand4.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `CLIENT` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City`," +
    " `CountryID`, `Email`, `CreditStatus`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("CountryID", System.Data.OleDb.OleDbType.Integer, 0, "CountryID"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "CreditStatus")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("CountryID", System.Data.OleDb.OleDbType.Integer, 0, "CountryID"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "CreditStatus"),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CreditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CreditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // daClient
            // 
            this.daClient.DeleteCommand = this.oleDbDeleteCommand4;
            this.daClient.InsertCommand = this.oleDbInsertCommand4;
            this.daClient.SelectCommand = this.oleDbSelectCommand4;
            this.daClient.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CLIENT", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ClientID", "ClientID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("CountryID", "CountryID"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("CreditStatus", "CreditStatus")})});
            this.daClient.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        ClientOrderID, OrderDate, ClientID, Status\r\nFROM            CLIENTO" +
    "RDER\r\nORDER BY ClientOrderID";
            this.oleDbSelectCommand5.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `CLIENTORDER` (`OrderDate`, `ClientID`, `Status`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.Date, 0, "OrderDate"),
            new System.Data.OleDb.OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer, 0, "ClientID"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.Date, 0, "OrderDate"),
            new System.Data.OleDb.OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer, 0, "ClientID"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Original_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_OrderDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ClientOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_OrderDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
            // 
            // daClientOrder
            // 
            this.daClientOrder.DeleteCommand = this.oleDbDeleteCommand5;
            this.daClientOrder.InsertCommand = this.oleDbInsertCommand5;
            this.daClientOrder.SelectCommand = this.oleDbSelectCommand5;
            this.daClientOrder.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CLIENTORDER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ClientOrderID", "ClientOrderID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("ClientID", "ClientID"),
                        new System.Data.Common.DataColumnMapping("Status", "Status")})});
            this.daClientOrder.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT        CountryID, CountryName\r\nFROM            COUNTRY\r\nORDER BY CountryID" +
    "";
            this.oleDbSelectCommand6.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `COUNTRY` (`CountryName`) VALUES (?)";
            this.oleDbInsertCommand6.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CountryName", System.Data.OleDb.OleDbType.VarWChar, 0, "CountryName")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = "UPDATE `COUNTRY` SET `CountryName` = ? WHERE ((`CountryID` = ?) AND ((? = 1 AND `" +
    "CountryName` IS NULL) OR (`CountryName` = ?)))";
            this.oleDbUpdateCommand6.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CountryName", System.Data.OleDb.OleDbType.VarWChar, 0, "CountryName"),
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryName", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = "DELETE FROM `COUNTRY` WHERE ((`CountryID` = ?) AND ((? = 1 AND `CountryName` IS N" +
    "ULL) OR (`CountryName` = ?)))";
            this.oleDbDeleteCommand6.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryName", System.Data.DataRowVersion.Original, null)});
            // 
            // daCountry
            // 
            this.daCountry.DeleteCommand = this.oleDbDeleteCommand6;
            this.daCountry.InsertCommand = this.oleDbInsertCommand6;
            this.daCountry.SelectCommand = this.oleDbSelectCommand6;
            this.daCountry.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "COUNTRY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CountryID", "CountryID"),
                        new System.Data.Common.DataColumnMapping("CountryName", "CountryName")})});
            this.daCountry.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT        VendorID, VendorName, PostBoxNumber, CountryID, Email\r\nFROM        " +
    "    VENDOR\r\nORDER BY VendorID";
            this.oleDbSelectCommand7.Connection = this.ctnBookBrokers;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `VENDOR` (`VendorName`, `PostBoxNumber`, `CountryID`, `Email`) VALUES" +
    " (?, ?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.ctnBookBrokers;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VendorName", System.Data.OleDb.OleDbType.VarWChar, 0, "VendorName"),
            new System.Data.OleDb.OleDbParameter("PostBoxNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PostBoxNumber"),
            new System.Data.OleDb.OleDbParameter("CountryID", System.Data.OleDb.OleDbType.Integer, 0, "CountryID"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.ctnBookBrokers;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VendorName", System.Data.OleDb.OleDbType.VarWChar, 0, "VendorName"),
            new System.Data.OleDb.OleDbParameter("PostBoxNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PostBoxNumber"),
            new System.Data.OleDb.OleDbParameter("CountryID", System.Data.OleDb.OleDbType.Integer, 0, "CountryID"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("Original_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VendorName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VendorName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VendorName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PostBoxNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostBoxNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PostBoxNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostBoxNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.ctnBookBrokers;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_VendorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_VendorName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VendorName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_VendorName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VendorName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PostBoxNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostBoxNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PostBoxNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostBoxNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CountryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CountryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // daVendor
            // 
            this.daVendor.DeleteCommand = this.oleDbDeleteCommand7;
            this.daVendor.InsertCommand = this.oleDbInsertCommand7;
            this.daVendor.SelectCommand = this.oleDbSelectCommand7;
            this.daVendor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VENDOR", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VendorID", "VendorID"),
                        new System.Data.Common.DataColumnMapping("VendorName", "VendorName"),
                        new System.Data.Common.DataColumnMapping("PostBoxNumber", "PostBoxNumber"),
                        new System.Data.Common.DataColumnMapping("CountryID", "CountryID"),
                        new System.Data.Common.DataColumnMapping("Email", "Email")})});
            this.daVendor.UpdateCommand = this.oleDbUpdateCommand7;
            // 
            // dsBookBrokers
            // 
            this.dsBookBrokers.DataSetName = "DSBookBrokers";
            this.dsBookBrokers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Name = "DataModule";
            this.Text = "DataModule";
            this.Load += new System.EventHandler(this.DataModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBookBrokers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnBookBrokers;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daAuthor;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daBook;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daBookInfo;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daClient;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daClientOrder;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daCountry;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daVendor;
        public dsBookBrokers dsBookBrokers;
    }
}