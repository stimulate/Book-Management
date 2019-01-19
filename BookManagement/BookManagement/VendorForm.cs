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
    public partial class VendorForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;
        public VendorForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVendor.Left = 194;
            pnlAddVendor.Top = 33;
            pnlAddVendor.Visible = false;            
            pnlUpVendor.Left = 194;
            pnlUpVendor.Top = 33;
            pnlUpVendor.Visible = false;
            this.Width = 700;
        }
      
        
        public void BindControls()
        {
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtPBNo.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");  
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtPBNo.Enabled = false;
            txtEmail.Enabled = false;
            txtCountry.Enabled = false;
            txtVendorID.Enabled = false;
            lstVendor.DataSource = DM.dsBookBrokers;
            lstVendor.DisplayMember = "Vendor.VendorName";
            lstVendor.ValueMember = "Vendor.VendorName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"]; 
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Country"];
        }

       private void TxtVendorID_TextChanged(object sender, EventArgs e)
       {
            if (txtVendorID.Text == "")
            {
                lblC.Text = "";
            }
            else
            {
                int aVendorID = Convert.ToInt32(txtVendorID.Text);
                currencyManager.Position = DM.VendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[currencyManager.Position];
                lblC.Text = drVendor["CountryID"].ToString();                
            }
        }

        private void lblC_TextChanged(object sender, EventArgs e)
        {
            if (lblC.Text == "")
            {
                txtCountry.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblC.Text);
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountry.Text = drCountry["CountryName"].ToString();
            }
        }

        private void LoadVendors()
        {
            cboAddCountryID.DataSource = DM.dsBookBrokers;
            cboAddCountryID.DisplayMember = "Country.CountryID";
            cboAddCountryID.ValueMember = "Country.CountryID";
            cboAddCountryName.DataSource = DM.dsBookBrokers;
            cboAddCountryName.DisplayMember = "Country.CountryName";
            cboAddCountryName.ValueMember = "Country.CountryName";            
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

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            btnDeleteVendor.Enabled = false;
            btnDeleteVendor.Visible = false;
            btnNext.Enabled = false;
            btnNext.Visible = false;
            btnPrevious.Enabled = false;
            btnPrevious.Visible = false;
            btnUpdateVendor.Enabled = false;
            btnUpdateVendor.Visible  = false;
            btnReturn.Enabled = false;
            btnReturn.Visible = false;
            btnAddVendor.Enabled = false;
            btnAddVendor.Visible = false;
            pnlAddVendor.Show();
            LoadVendors();
        }

        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            DataRow deleteVentorRow = DM.dtVendor.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete vendors that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVentorRow.Delete();
                    DM.UpdateVendor();
                    MessageBox.Show("Vendor deleted successfully", "Success");
                }
            }
        }

        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;            
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;           
            btnAddVendor.Enabled = false;
            txtUpCountry.Text = txtCountry.Text;
            txtUpVendorID.Text = txtVendorID.Text;
            txtUpVendorName.Text = txtVendorName.Text;
            txtUpPBNo.Text = txtPBNo.Text;
            txtUpEmail.Text = txtEmail.Text;
            txtUpVendorID.Enabled = false;
            txtUpCountry.Enabled = false;
            pnlUpVendor.Show(); 
        }

        private void lstVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendor.Enabled = true;
            lstVendor.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnDeleteVendor.Visible = true;
            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnPrevious.Enabled = true;
            btnPrevious.Visible = true;
            btnUpdateVendor.Enabled = true;
            btnUpdateVendor.Visible = true;
            btnAddVendor.Enabled = true;
            btnAddVendor.Visible = true;
            btnReturn.Enabled = true;
            btnReturn.Visible  = true;
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            pnlUpVendor.Hide();
            lstVendor.Enabled = true;
            lstVendor.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnAddVendor.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
                      
            DataRow updateVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            if ((txtUpVendorName.Text == "") || (txtUpPBNo.Text == "") || (txtUpEmail.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                updateVendorRow["VendorName"] = txtUpVendorName.Text;
                updateVendorRow["Email"] = txtUpEmail.Text;
                updateVendorRow["PostBoxNumber"] = Convert.ToInt32(txtUpPBNo.Text);          
            
                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();
                MessageBox.Show("Vendor updated successfully", "Success");
            }
        }

            private void btnSaveVendor_Click(object sender, EventArgs e)
        {
            DataRow newVendorRow = DM.dtVendor.NewRow();

            if ((txtAddVendorName.Text == ""))
            {
                MessageBox.Show("You must type in a Vendor name", "Error");
            }
            else
            {
                try
                {
                    newVendorRow["VendorName"] =(txtAddVendorName.Text).ToString();
                    newVendorRow["Email"] = txtAddEmail.Text;
                    newVendorRow["PostBoxNumber"] = Convert.ToInt32(txtAddPBNo.Text);
                    newVendorRow["CountryID"] = cboAddCountryID.Text;                    
                    DM.dtVendor.Rows.Add(newVendorRow);
                    MessageBox.Show("Vendor added successfully", "Success");
                    DM.UpdateVendor();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for Post Box Number", "Error");
                }
            }

        }

        private void pnlAddVentor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VendorForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
