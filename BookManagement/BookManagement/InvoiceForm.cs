using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoiceForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Shipped'";
            string strSort = "ClientOrderID";
            invoicesForPrint = DM.dsBookBrokers.Tables["CLIENTORDER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();           
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int LinesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drClientOrder = invoicesForPrint[amountOfInvoicesPrinted];            

            CurrencyManager cmClient;
            CurrencyManager cmClientOrder;
            CurrencyManager cmBookInfo;
            CurrencyManager cmBook;
            CurrencyManager cmCountry;
            decimal booksalesTotal = 0;

            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            
            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Far;

            StringFormat format2 = new StringFormat();
            format2.Alignment = StringAlignment.Near;
            format2.LineAlignment = StringAlignment.Near;

            //get the client record matching the client ID from the client order record
            int aClientID = Convert.ToInt32(drClientOrder["ClientID"].ToString());
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];

            //get the country record matching the country ID from the client record
            int aCountryID = Convert.ToInt32(drClient["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Client ID: " + drClient["ClientID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drClient["LastName"] + ", " + drClient["FirstName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drClient["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drClient["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drClient["City"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            g.DrawString("Client  Order  ID:  " + drClientOrder["ClientOrderID"] + "          " + "Date:   " + Convert.ToDateTime(drClientOrder["OrderDate"]).ToString("MM / dd / yyyy") + " ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;   
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            LinesSoFarHeading++;

            g.DrawString("Books: ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            LinesSoFarHeading++;

            DataRow[] drBookOrder = drClientOrder.GetChildRows(DM.dtClientOrder.ChildRelations["FK_CLIENTORDER_BOOK"]);

            if (drBookOrder.Length == 0)
            {
                g.DrawString("This book has  no client order", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow BookOrder in drBookOrder)
                {
                    //get the book info matching the bookinfo ID from the book record

                    int abookinfoID = Convert.ToInt32(BookOrder["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(abookinfoID);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];                
                   
                    g.DrawString(BookOrder["BookID"] + "   " + drBookInfo["Title"] , headingFont, brush, new RectangleF(leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format2);
                    g.DrawString(Convert.ToDecimal(BookOrder["Price"]).ToString("$##00.00"), headingFont, brush, new RectangleF(leftMargin + headingLeftMargin, topMargin-60 + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format);
                    LinesSoFarHeading++;
                    booksalesTotal += Convert.ToDecimal(BookOrder["Price"]);                     
                }                
                LinesSoFarHeading++;
                g.DrawString("Gross Due: " + booksalesTotal.ToString("$##00.00"), headingFont, brush, new RectangleF(leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format);
                LinesSoFarHeading++;
                LinesSoFarHeading++;
                LinesSoFarHeading++;
                LinesSoFarHeading++;
            }            
            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }
    }
}
