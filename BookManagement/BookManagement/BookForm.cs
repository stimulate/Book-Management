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
    public partial class BookForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmVendor;
        private CurrencyManager cmClientOrder;
        private CurrencyManager currencyManager;

        public BookForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();            
            pnlAddBook.Left = 194;
            pnlAddBook.Top = 13;
            pnlAddBook.Visible = false;
            pnlUpBook.Left = 194;
            pnlUpBook.Top = 13;
            pnlUpBook.Visible = false;
            this.Width = 700;

        }

        public void BindControls()
        {
            txtBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");            
            txtCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");
            txtBookID.Enabled = false;
            txtTitle.Enabled = false;
            txtCost.Enabled = false;
            txtPrice.Enabled = false;
            txtDatePublished.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtClientOrderID.Enabled = false;
            lstBooks.DataSource = DM.dsBookBrokers;
            lstBooks.DisplayMember = "Book.BookID";
            lstBooks.ValueMember = "Book.BookID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                lblC.Text = "";
                lblD.Text = "";
                lblE.Text = "";
            }
            else
            {
                int aBookID = Convert.ToInt32(txtBookID.Text);                
                currencyManager.Position = DM.BookView.Find(aBookID);
                DataRow drBook = DM.dtBook.Rows[currencyManager.Position];                
                lblC.Text = drBook["VendorID"].ToString();
                lblD.Text = drBook["BookInfoID"].ToString();
                lblE.Text = drBook["ClientOrderID"].ToString();                

                int aVendorID = Convert.ToInt32(lblC.Text);               
                cmVendor.Position = DM.VendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtVendorID.Text = drVendor["VendorID"].ToString();
                txtVendorName.Text = drVendor["VendorName"].ToString();
                int aBookInfoID = Convert.ToInt32(lblD.Text);
                cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }

        private void lblE_TextChanged(object sender, EventArgs e)
        {
            if (lblE.Text == "")
            {
                txtClientOrderID.Text = "";
            }
            else
            {
                int aClientOrderID = Convert.ToInt32(lblE.Text);
                cmClientOrder.Position = DM.ClientOrderView.Find(aClientOrderID);
                DataRow drClientOrder = DM.dtClientOrder.Rows[cmClientOrder.Position];
                txtClientOrderID.Text = drClientOrder["ClientOrderID"].ToString();

            }
        }
        private void LoadBook()
        {
            cboAddBookInfoID.DataSource = DM.dsBookBrokers;
            cboAddBookInfoID.DisplayMember = "BookInfo.BookInfoID";
            cboAddBookInfoID.ValueMember = "BookInfo.BookInfoID";
            cboAddBookTitle.DataSource = DM.dsBookBrokers;
            cboAddBookTitle.DisplayMember = "BookInfo.Title";
            cboAddBookTitle.ValueMember = "BookInfo.Title";
            cboAddVendorID.DataSource = DM.dsBookBrokers;
            cboAddVendorID.DisplayMember = "Vendor.VendorID";
            cboAddVendorID.ValueMember = "Vendor.VendorID";
            cboAddVendorName.DataSource = DM.dsBookBrokers;
            cboAddVendorName.DisplayMember = "Vendor.VendorName";
            cboAddVendorName.ValueMember = "Vendor.VendorName";
        }

       private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lstBooks.Visible = false;
            btnDeleteBook.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddBook.Show();
            LoadBook();            
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];            
            if ( txtClientOrderID.Text == "" )
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookRow.Delete();
                    MessageBox.Show("Book deleted successfully", "Success");
                    DM.UpdateBook();
                }                
            }
            else
            {
                MessageBox.Show("You may only delete books that are not on order", "Error");
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            txtUpBookID.Text = txtBookID.Text;
            txtUpTitle.Text = txtTitle.Text;
            txtUpCost.Text = txtCost.Text;
            txtUpPrice.Text = txtPrice.Text;
            txtUpVendorID.Text = txtVendorID.Text;
            txtUpVendorName.Text = txtVendorName.Text;
            dtpUpDatePublished.Text = txtDatePublished.Text;
            txtUpBookID.Enabled = false;
            txtUpTitle.Enabled = false;
            txtUpVendorID.Enabled = false;
            txtUpVendorName.Enabled = false;
            lstBooks.Visible = false;
            btnDeleteBook.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddBook.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpBook.Show();            
        }       

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstBooks.Visible = true;
            btnDeleteBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddBook.Hide();
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            lstBooks.Visible = true;
            btnDeleteBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddBook.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpBook.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookRow = DM.dtBook.Rows[currencyManager.Position];
            if ((txtUpCost.Text == ""))
            {
                MessageBox.Show("You must enter a cost", "Error");
            }
            else if ((txtClientOrderID.Text != ""))
            {
                MessageBox.Show("Cannot update a book that is on order", "Error");
            }
            else
            {
                updateBookRow["Cost"] = txtUpCost.Text;
                updateBookRow["Price"] = txtUpPrice.Text;
                updateBookRow["DatePublished"] = dtpUpDatePublished.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBook();
                MessageBox.Show("Book updated successfully", "Success");
            }

        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            DataRow newBookRow = DM.dtBook.NewRow();

            if ((txtAddCost.Text == ""))
            {
                MessageBox.Show("You must type in a cost", "Error");
            }
            else
            {
                try
                {
                    newBookRow["BookInfoID"] = cboAddBookInfoID.Text;
                    newBookRow["Cost"] = Convert.ToDouble(txtAddCost.Text);
                    newBookRow["Price"] = Convert.ToDouble(txtAddPrice.Text);
                    newBookRow["DatePublished"] = Convert.ToDateTime(dtpDatePublished.Text);
                    newBookRow["VendorID"] = cboAddVendorID.Text;                    
                    DM.dtBook.Rows.Add(newBookRow);
                    MessageBox.Show("Book added successfully", "Success");
                    DM.UpdateBook();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for Price and Cost", "Error");
                }
            }

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlAddBookInfo_Paint(object sender, PaintEventArgs e)
        {

        }       
              
    }
}
