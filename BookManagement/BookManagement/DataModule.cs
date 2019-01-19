using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class DataModule : Form
    {
        public DataTable dtVendor;
        public DataTable dtClient;
        public DataTable dtBookInfo;
        public DataTable dtBook;
        public DataTable dtAuthor;
        public DataTable dtClientOrder;
        public DataTable dtCountry;
        public DataTable dtBookInStock;
        public DataView VendorView;
        public DataView ClientView;
        public DataView BookInfoView;
        public DataView BookView;
        public DataView AuthorView;
        public DataView ClientOrderView;
        public DataView CountryView;
        public DataView BookInStockView;
        public DataView BookOnOrderView;

        public DataModule()
        {
            InitializeComponent();

            dsBookBrokers.EnforceConstraints = false;

            daVendor.Fill(dsBookBrokers);
            daClient.Fill(dsBookBrokers);
            daBookInfo.Fill(dsBookBrokers);
            daBook.Fill(dsBookBrokers);
            daAuthor.Fill(dsBookBrokers);
            daClientOrder.Fill(dsBookBrokers);
            daCountry.Fill(dsBookBrokers);   
            
            dtVendor = dsBookBrokers.Tables["Vendor"];
            dtClient = dsBookBrokers.Tables["Client"];
            dtBookInfo = dsBookBrokers.Tables["BookInfo"];
            dtBook = dsBookBrokers.Tables["Book"];
            dtAuthor = dsBookBrokers.Tables["Author"];
            dtClientOrder = dsBookBrokers.Tables["ClientOrder"];
            dtCountry = dsBookBrokers.Tables["Country"];
            dtBookInStock = dsBookBrokers.Tables["Book"];

            VendorView = new DataView(dtVendor);
            VendorView.Sort = "VendorID";
            ClientView = new DataView(dtClient);
            ClientView.Sort = "ClientID";
            BookInfoView = new DataView(dtBookInfo);
            BookInfoView.Sort = "BookInfoID";
            BookView = new DataView(dtBook);
            BookView.Sort = "BookID";
            AuthorView = new DataView(dtAuthor);
            AuthorView.Sort = "AuthorID";
            CountryView = new DataView(dtCountry);
            CountryView.Sort = "CountryID";
            ClientOrderView = new DataView(dtClientOrder);
            ClientOrderView.Sort = "ClientOrderID";

            BookInStockView = new DataView(dtBook, "ClientOrderID is NULL", "BookID", DataViewRowState.CurrentRows);
            BookOnOrderView = new DataView(dtBook, "ClientOrderID is NULL", "BookID", DataViewRowState.CurrentRows);

            dsBookBrokers.EnforceConstraints = true;
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("Select @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VendorID"] = newID;
            }
        }

        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }

        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }

        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }

        public void UpdateAuthor()
        {
            daAuthor.Update(dtAuthor);
        }

        public void UpdateCountry()
        {
            daCountry.Update(dtCountry);
        }

        private void ctnBookBrokers_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }

        private void daAuthor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void ctnBookBrokers_InfoMessage_1(object sender, OleDbInfoMessageEventArgs e)
        {

        }
    }
}
