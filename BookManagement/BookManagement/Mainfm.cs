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
    public partial class Mainfm : Form
    {
        private DataModule DM;  // the reference to the form that holds the data components
        private VendorForm frmVendor;
        private ClientForm frmClient;
        private BookInfoForm frmBookInfo;
        private BookForm frmBook;
        private ClientOrderForm frmClientOrder;
        private AddB2COForm frmAddB2CO;
        private InvoiceForm frmInvoice;
        private VendorsForm frmVendors;

        public Mainfm()
        {
            InitializeComponent();
        }

        private void Mainfm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            if (frmVendor == null)
            {
                frmVendor = new VendorForm(DM, this);
            }
            frmVendor.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            if (frmVendors == null)
            {
                frmVendors = new VendorsForm(DM, this);
            }
            frmVendors.ShowDialog();
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grpReport_Enter(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }
            frmClient.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

        private void btnAddB2CO_Click(object sender, EventArgs e)
        {
            if (frmAddB2CO == null)
            {
                frmAddB2CO = new AddB2COForm(DM, this);
            }
            frmAddB2CO.ShowDialog();
        }

        private void btnClientOrder_Click(object sender, EventArgs e)
        {
            if (frmClientOrder == null)
            {
                frmClientOrder = new ClientOrderForm(DM, this);
            }
            frmClientOrder.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (frmBook == null)
            {
                frmBook = new BookForm(DM, this);
            }
            frmBook.ShowDialog();
        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            if (frmBookInfo == null)
            {
                frmBookInfo = new BookInfoForm(DM, this);
            }
            frmBookInfo.ShowDialog();
        }
    }
}
