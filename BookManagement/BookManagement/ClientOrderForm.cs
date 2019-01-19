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
    public partial class ClientOrderForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager cmClient;
        private CurrencyManager currencyManager;

        public ClientOrderForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClientOrder.Left = 174;
            pnlAddClientOrder.Top = 23;
            pnlAddClientOrder.Visible = false;
            pnlUpClientOrder.Left = 174;
            pnlUpClientOrder.Top = 23;
            pnlUpClientOrder.Visible = false;
            this.Width = 700;

        }

        public void BindControls()
        {
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");            
            txtClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");            
            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtClientOrderDate.Enabled = false;
            txtClientOrderID.Enabled = false;
            txtFirstName.Enabled = false;
            txtStatus.Enabled = false;            
            lstClientOrders.DataSource = DM.dsBookBrokers;
            lstClientOrders.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrders.ValueMember = "ClientOrder.ClientOrderID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
        }

        private void txtClientOrderID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientOrderID.Text == "")
            {
                lblC.Text = "";                
            }
            else
            {
                int aClientOrderID = Convert.ToInt32(txtClientOrderID.Text);
                currencyManager.Position = DM.ClientOrderView.Find(aClientOrderID);
                DataRow drClientOrder = DM.dtClientOrder.Rows[currencyManager.Position];
                lblC.Text = drClientOrder["ClientID"].ToString();
                int aClientID = Convert.ToInt32(lblC.Text);
                cmClient.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientID.Text = drClient["ClientID"].ToString();
                txtLastName.Text = drClient["LastName"].ToString();
                txtFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        private void LoadClients()
        {
            cbxAddLastName.DataSource = DM.dsBookBrokers;
            cbxAddLastName.DisplayMember = "Client.LastName";
            cbxAddLastName.ValueMember = "Client.LastName";
            cbxAddFirstName.DataSource = DM.dsBookBrokers;
            cbxAddFirstName.DisplayMember = "Client.FirstName";
            cbxAddFirstName.ValueMember = "Client.FirstName";
            cbxAddClientID.DataSource = DM.dsBookBrokers;
            cbxAddClientID.DisplayMember = "Client.ClientID";
            cbxAddClientID.ValueMember = "Client.ClientID";
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

        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrders.Visible = false;
            btnDeleteClientOrder.Enabled = false;
            btnReturn.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateClientOrder.Enabled = false;           
            btnMOPaid.Enabled = false;
            btnMOShipped.Enabled = false;
            pnlAddClientOrder.Show();
            LoadClients();
        }

        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete a client order that has no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientOrderRow.Delete();                    
                    MessageBox.Show("Client Order deleted successfully", "Success");
                    DM.UpdateClientOrder();
                }
            }
        }

        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrders.Visible = false;
            btnDeleteClientOrder.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnMOPaid.Enabled = false;
            btnMOShipped.Enabled = false;
            pnlUpClientOrder.Show();
            txtUpClientID.Text = txtClientID.Text;
            txtUpClientOrderID.Text = txtClientOrderID.Text;
            txtUpFirstName.Text = txtFirstName.Text;
            txtUpLastName.Text = txtLastName.Text;
            txtUpStatus.Text = txtStatus.Text;
            txtUpStatus.Enabled = false;
            txtUpLastName.Enabled = false;
            txtUpFirstName.Enabled = false;
            txtUpClientOrderID.Enabled = false;
            txtUpClientID.Enabled = false;

        }

        private void lstClientOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstClientOrders.Visible = true;
            btnDeleteClientOrder.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnMOPaid.Enabled = true;
            btnMOShipped.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddClientOrder.Hide();
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            lstClientOrders.Visible = true;
            btnDeleteClientOrder.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnMOPaid.Enabled = true;
            btnMOShipped.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpClientOrder.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            updateClientOrderRow["OrderDate"] = Convert.ToDateTime(dtpUpClientOrder.Text);               
            currencyManager.EndCurrentEdit();
            MessageBox.Show("Client order updated successfully", "Success");
            DM.UpdateClientOrder();                       
            
        }

        private void btnSaveClientOrder_Click(object sender, EventArgs e)
        {
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();
                    newClientOrderRow["OrderDate"] = Convert.ToDateTime(dtpClientOrder.Text);
                    newClientOrderRow["ClientID"] = cbxAddClientID.Text;
                    newClientOrderRow["Status"] = "Current";
                    DM.dtClientOrder.Rows.Add(newClientOrderRow);
                    DM.UpdateClientOrder();
                    MessageBox.Show("Client order added successfully", "Success");
            
                              

        }

        private void btnMOShipped_Click(object sender, EventArgs e)
        {
            if ((txtStatus.Text == "Current"))
            {
                txtStatus.Text = "Shipped";                
                MessageBox.Show("Client Order marked as shipped","Success");
            }
            else
            {
                MessageBox.Show("Only current client orders can be marked as shipped", "Error");
            }
        }

        private void btnMOPaid_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if ((txtStatus.Text == "Shipped"))
            {
                txtStatus.Text = "Paid";
                deleteBookRow.Delete();
                MessageBox.Show("Client Order marked as paid", "Success");
            }
            else
            {
                MessageBox.Show("Only shipped client orders can be marked as paid", "Error");
            }
        }

        private void ClientOrderForm_Load(object sender, EventArgs e)
        {

        }


    }
}
