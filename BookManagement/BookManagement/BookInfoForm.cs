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
    public partial class BookInfoForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager cmAuthor;
        private CurrencyManager currencyManager;

        public BookInfoForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBookInfo.Left = 194;
            pnlAddBookInfo.Top = 23;
            pnlAddBookInfo.Visible = false;
            pnlUpBookInfo.Left = 194;
            pnlUpBookInfo.Top = 23;
            pnlUpBookInfo.Visible = false;
            this.Width = 700;

        }

        public void BindControls()
        {
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");            
            txtTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");           
            txtNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");
            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtLastName.Enabled = false;
            txtAuthorID.Enabled = false;
            txtNotes.Enabled = false;
            txtFirstName.Enabled = false;            
            lstBookInfo.DataSource = DM.dsBookBrokers;
            lstBookInfo.DisplayMember = "BookInfo.Title";
            lstBookInfo.ValueMember = "BookInfo.Title";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
        }

        private void txtBookInfoID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookInfoID.Text == "")
            {
                lblA.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(txtBookInfoID.Text);
                currencyManager.Position = DM.BookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[currencyManager.Position];
                lblA.Text = drBookInfo["AuthorID"].ToString();
                int anAuthorID = Convert.ToInt32(lblA.Text);
                cmAuthor.Position = DM.AuthorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtAuthorID.Text = drAuthor["AuthorID"].ToString();
                txtLastName.Text = drAuthor["LastName"].ToString();
                txtFirstName.Text = drAuthor["FirstName"].ToString();
            }
        }

        private void LoadAuthor()
        {
            cbxAddAuthorID.DataSource = DM.dsBookBrokers;
            cbxAddAuthorID.DisplayMember = "Author.AuthorID";
            cbxAddAuthorID.ValueMember = "Author.AuthorID";
            cbxAddLastName.DataSource = DM.dsBookBrokers;
            cbxAddLastName.DisplayMember = "Author.LastName";
            cbxAddLastName.ValueMember = "Author.LastName";
            cbxAddFirstName.DataSource = DM.dsBookBrokers;
            cbxAddFirstName.DisplayMember = "Author.FirstName";
            cbxAddFirstName.ValueMember = "Author.FirstName";
            cbxAddAuthorID.DataSource = DM.dsBookBrokers;
            cbxAddAuthorID.DisplayMember = "Author.AuthorID";
            cbxAddAuthorID.ValueMember = "Author.AuthorID";
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

        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = false;
            btnDeleteBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnReturn.Enabled = false;            
            pnlAddBookInfo.Show();
            LoadAuthor();
        }

        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {
            DataRow deleteBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete book info records that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookInfoRow.Delete();
                    MessageBox.Show("Book Info deleted successfully", "Success");
                    DM.UpdateBookInfo();
                }
            }
        }

        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            txtUpAuthorID.Text = txtAuthorID.Text;
            txtUpBookInfoID.Text = txtBookInfoID.Text;
            txtUpAuthorID.Enabled = false;
            txtUpBookInfoID.Enabled = false;
            txtUpFirstName.Enabled = false;
            txtUpLastName.Enabled = false;
            txtUpNotes.Text = txtNotes.Text;
            txtUpTitle.Text = txtTitle.Text;
            lstBookInfo.Visible = false;
            btnDeleteBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpBookInfo.Show();
        }

        private void lstBookInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = true;
            btnDeleteBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddBookInfo.Hide();
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            lstBookInfo.Visible = true;
            btnDeleteBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpBookInfo.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            lblUpBookInfoID.Text = null;
            lblUpAuthorID.Text = null;
            lblUpLastName.Text = null;            
            lblUpFirstName.Text = null;
            DataRow updateBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            if ((txtUpTitle.Text == ""))
            {
                MessageBox.Show("You must enter a title", "Error");
            }
            else
            {
                updateBookInfoRow["Title"] = txtUpTitle.Text;
                updateBookInfoRow["Notes"] = txtUpNotes.Text;                    
                currencyManager.EndCurrentEdit();
                DM.UpdateBookInfo();
                MessageBox.Show("Book Info updated successfully", "Success");
            }

        }

        private void btnSaveBookInfo_Click(object sender, EventArgs e)
        {
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();

            if ((txtAddTitle.Text == ""))
            {
                MessageBox.Show("You must type in a title", "Error");
            }
            else
            {
                try
                {
                    newBookInfoRow["Title"] = txtAddTitle.Text;                    
                    newBookInfoRow["Notes"] = txtAddNotes.Text;
                    newBookInfoRow["AuthorID"] = cbxAddAuthorID.Text;                    
                    DM.dtBookInfo.Rows.Add(newBookInfoRow);
                    MessageBox.Show("Book Info added successfully", "Success");
                    DM.UpdateBookInfo();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for AuthorID", "Error");
                }
            }

        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {

        }       
    }
}
