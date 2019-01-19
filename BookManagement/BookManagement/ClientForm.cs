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
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;

        public ClientForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClient.Left = 194;
            pnlAddClient.Top = 23;
            pnlAddClient.Visible = false;
            pnlUpClient.Left = 194;
            pnlUpClient.Top = 23;
            pnlUpClient.Visible = false;
            this.Width = 700;
        }

        public void BindControls()
        {
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");            
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            txtCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");
            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtCountry.Enabled = false;
            txtFirstName.Enabled = false;
            txtSuburb.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtCreditStatus.Enabled = false;
            txtCity.Enabled = false;
            lstClients.DataSource = DM.dsBookBrokers;
            lstClients.DisplayMember = "Client.LastName";
            lstClients.ValueMember = "Client.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Country"];
        }

        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text == "")
            {
                lblC.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(txtClientID.Text);
                currencyManager.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[currencyManager.Position];
                lblC.Text = drClient["CountryID"].ToString();               

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

        private void LoadClient()
        {
            cbxAddCountryID.DataSource = DM.dsBookBrokers;
            cbxAddCountryID.DisplayMember = "Country.CountryID";
            cbxAddCountryID.ValueMember = "Country.CountryID";
            cbxAddCountryName.DataSource = DM.dsBookBrokers;
            cbxAddCountryName.DisplayMember = "Country.CountryName";
            cbxAddCountryName.ValueMember = "Country.CountryName";
            cbxUpCountryID.DataSource = DM.dsBookBrokers;
            cbxUpCountryID.DisplayMember = "Country.CountryID";
            cbxUpCountryID.ValueMember = "Country.CountryID";
            cbxUpCountryName.DataSource = DM.dsBookBrokers;
            cbxUpCountryName.DisplayMember = "Country.CountryName";
            cbxUpCountryName.ValueMember = "Country.CountryName";

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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClients.Visible = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateClient.Enabled = false;           
            pnlAddClient.Show();
            LoadClient();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] ClientOrderRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete clients who have no client orders", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                    MessageBox.Show("Client deleted successfully", "Success");
                }
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lstClients.Visible = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;           
            btnAddClient.Enabled = false;
            pnlUpClient.Show();
            txtUpCity.Text = txtCity.Text;
            txtUpEmail.Text = txtEmail.Text;
            txtUpFirstName.Text = txtFirstName.Text;
            txtUpLastName.Text = txtLastName.Text;
            txtUpStreetAddress.Text = txtStreetAddress.Text;
            txtUpSuburb.Text = txtSuburb.Text;
            cbxUpCountryName.Text = txtCountry.Text;
            cbxUpCreditStatus.Text = txtCreditStatus.Text;
            LoadClient();
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            lstClients.Enabled = true;
            lstClients.Visible = true;
            btnDeleteClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnAddClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            pnlUpClient.Hide();
            lstClients.Enabled = true;
            lstClients.Visible = true;
            btnDeleteClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnReturn.Enabled = true;
            btnAddClient.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientRow = DM.dtClient.Rows[currencyManager.Position];
            if ((txtUpLastName.Text == "") || (txtUpFirstName.Text == "") || (txtUpEmail.Text == "") || (txtUpStreetAddress.Text == "")
                || (txtUpSuburb.Text == "") || (txtUpCity.Text == "") || (cbxUpCountryID.Text == "") || (cbxUpCreditStatus.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                updateClientRow["LastName"] = txtUpLastName.Text;
                updateClientRow["Email"] = txtUpEmail.Text;
                updateClientRow["CountryID"] = Convert.ToInt32(cbxUpCountryID.Text);
                updateClientRow["FirstName"] = txtUpFirstName.Text;
                updateClientRow["StreetAddress"] = txtUpStreetAddress.Text;
                updateClientRow["Suburb"] = txtUpSuburb.Text;
                updateClientRow["City"] = txtUpCity.Text;
                updateClientRow["CreditStatus"] = cbxUpCreditStatus.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateClient();
                MessageBox.Show("Client updated successfully", "Success");
            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            DataRow newClientRow = DM.dtClient.NewRow();

            if ((txtUpLastName.Text == "") || (txtUpFirstName.Text == "") || (txtUpEmail.Text == "") || (txtUpStreetAddress.Text == "")
                 || (txtUpSuburb.Text == "") || (txtUpCity.Text == "") || (cbxUpCountryID.Text == "") || (cbxUpCreditStatus.Text == ""))
            {
                MessageBox.Show("Your inputting data is invalid", "Error");
            }
            else
            {
                try
                {
                    newClientRow["LastName"] = txtAddLastName.Text;
                    newClientRow["Email"] = txtAddEmail.Text;
                    newClientRow["FirstName"] = txtAddFirstName.Text;
                    newClientRow["StreetAddress"] = txtAddStreetAddress.Text;
                    newClientRow["Suburb"] = txtAddSuburb.Text;
                    newClientRow["City"] = txtAddCity.Text;
                    newClientRow["CreditStatus"] = cbxAddCreditStatus.Text;
                    newClientRow["CountryID"] = Convert.ToInt32(cbxAddCountryID.Text);
                    DM.dtClient.Rows.Add(newClientRow);
                    MessageBox.Show("Client added successfully", "Success");
                    DM.UpdateClient();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for CountryID", "Error");
                }
            }

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlAddClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpClient_Paint(object sender, PaintEventArgs e)
        {

        }       
        
    }
}
