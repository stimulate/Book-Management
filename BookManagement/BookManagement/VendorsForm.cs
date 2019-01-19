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
    public partial class VendorsForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private int amountOfPapersPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;

        public VendorsForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;           
        }

        private void Vendors_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfPapersPrinted = 0;
            string strSort = "VendorID";
            reportForPrint = DM.dsBookBrokers.Tables["VENDOR"].Select("",strSort,DataViewRowState.CurrentRows);
            pagesAmountExpected = reportForPrint.Length;
            prvReport.Show();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int LinesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVendor = reportForPrint[amountOfPapersPrinted];
            CurrencyManager cmVendor;
            CurrencyManager cmAuthor;
            CurrencyManager cmBookInfo;
            CurrencyManager cmBook;
            CurrencyManager cmCountry;           

            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
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
            format.Alignment = StringAlignment.Near;           

            //get the country record matching the country ID from the vendor record
            int aCountryID = Convert.ToInt32(drVendor["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Vendor ID: " + drVendor["VendorID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            g.DrawString(drVendor["VendorName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drVendor["PostBoxNumber"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            g.DrawString(drVendor["Email"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            LinesSoFarHeading++;
            LinesSoFarHeading++;

            g.DrawString("Books: " + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            LinesSoFarHeading++;
            LinesSoFarHeading++;

            DataRow[] drBookVendor = drVendor.GetChildRows(DM.dtVendor.ChildRelations["FK_VENDOR_BOOK"]);

            if (drBookVendor.Length == 0)
            {
                g.DrawString("This vendor has  no book", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow BookVendor in drBookVendor)
                {

                    //get the bookinfo record matching the bookinfo ID from the book record
                    int aBookInfoID = Convert.ToInt32(BookVendor["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                    //get the author record matching the author ID from the bookinfo record
                    int anAuthorID = Convert.ToInt32(drBookInfo["AuthorID"].ToString());
                    cmAuthor.Position = DM.AuthorView.Find(anAuthorID);
                    DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];

                    g.DrawString(BookVendor["BookID"] + "  " + drBookInfo["Title"] + "  " , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height));
                    g.DrawString(Convert.ToDecimal(BookVendor["Cost"]).ToString("$"+"0.00") + "  " , headingFont, brush, new RectangleF(rightMargin-270-headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format);
                    g.DrawString(Convert.ToDecimal(BookVendor["Price"]).ToString("$"+"0.00") + "  " ,headingFont, brush, new RectangleF(rightMargin -200 - headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format);
                    g.DrawString(Convert.ToDateTime(BookVendor["DatePublished"]).ToString("MM/dd/yyyy") + "  " + drAuthor["FirstName"] + "  " + drAuthor["LastName"], headingFont, brush, new RectangleF(rightMargin - 130 - headingLeftMargin, topMargin + (LinesSoFarHeading * textFont.Height), ClientSize.Width, ClientSize.Height), format);
                    LinesSoFarHeading++;
                }                          

                LinesSoFarHeading++;
            }
            amountOfPapersPrinted++;

            if (!(amountOfPapersPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

    }
}
