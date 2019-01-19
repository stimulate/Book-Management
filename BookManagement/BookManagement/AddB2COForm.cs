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
    public partial class AddB2COForm : Form
    {
        private DataModule DM;
        private Mainfm frmMenu;
        private CurrencyManager cmClientOrder;
            
               
        public AddB2COForm(DataModule dm, Mainfm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];                       
                     
            BindControls();           

        }

        public void BindControls()
        {
            dgvClientOrder.DataSource = DM.dsBookBrokers;
            dgvClientOrder.DataMember = "ClientOrder";
                    
            DM.BookInStockView.RowFilter = "ClientOrderID is NULL";
            dgvBooks.DataSource = DM.BookInStockView;            
            dgvBooks.Columns["DatePublished"].HeaderText = "Date";
            
            dgvBooks.Columns["ClientOrderID"].Visible = false;

            dgvBookOrder.DataSource = DM.dsBookBrokers;
            dgvBookOrder.DataMember = "ClientOrder.FK_CLIENTORDER_BOOK";
            dgvBookOrder.Columns["DatePublished"].HeaderText = "Date";
        }

        private void AddB2COForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvClientOrder_CurrentCellChange(object sender, EventArgs e)
        {
            if (cmClientOrder.Position < 0)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";                
                return;
            }

            DataRow rowCur = DM.dtClientOrder.Rows[cmClientOrder.Position];
            DataRow[] rowRs = DM.dtClient.Select("ClientID = " + rowCur["ClientID"], "ClientID");
            if (rowRs.Length > 0)
            {
                txtFirstName.Text = rowRs[0]["FirstName"].ToString();
                txtLastName.Text = rowRs[0]["LastName"].ToString();                
            }
                        
            DM.BookOnOrderView.RowFilter = "ClientOrderID = " + rowCur["ClientOrderID"];
                        
            dgvBookOrder.ClearSelection();

            if (rowCur["Status"].ToString().ToLower() != "current")
            {
                dgvBooks.ClearSelection();
            }
                      
            btnRemove.Enabled = false;
            btnAdd.Enabled = true;

            if (dgvBookOrder.CurrentCell == null || dgvBookOrder.SelectedRows.Count < 1)
            {
                btnRemove.Enabled = false;
            }

            if (dgvBooks.CurrentCell == null || dgvBooks.SelectedRows.Count < 1)
            {
                btnAdd.Enabled = false;
            }
        }

        private DataRow dgvCurrentRow(DataGridView dgv)
        {
            
            if (dgv.CurrentCell == null || dgv.SelectedRows.Count < 1)
            {
                return null;
            }
          
            DataGridViewRow dgvRow = dgv.CurrentCell.OwningRow;
            return (dgvRow.DataBoundItem as DataRowView).Row;
        }

        private void dgvBooks_CurrentCellChange(object sender, EventArgs e)
        {
            DataRow rowCur = dgvCurrentRow(dgvBooks);
            
            if (rowCur == null)
            {
                return;
            }
            
            dgvBookOrder.ClearSelection();

            DataRow[] rowRs = DM.dtBookInfo.Select("BookInfoID = " + rowCur["BookInfoID"], "BookInfoID");
            if (rowRs.Length > 0)
            {
                txtTitle.Text = rowRs[0]["Title"].ToString();
            }
                        
            btnRemove.Enabled = false;
            btnAdd.Enabled = true;

            if (dgvBookOrder.CurrentCell == null || dgvBookOrder.SelectedRows.Count < 1)
            {
                btnRemove.Enabled = false;
            }

            if (dgvBooks.CurrentCell == null || dgvBooks.SelectedRows.Count < 1)
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow targetRow = DM.dtClientOrder.Rows[cmClientOrder.Position];
            if (targetRow["Status"].ToString().ToLower() != "current")
            {
                MessageBox.Show("Books can only be added to current orders", "Error");
                return;
            }

            DataRow rowCur = dgvCurrentRow(dgvBooks);
            
            if (rowCur == null)
            {
                return;
            }

            if (rowCur["ClientOrderID"].ToString().Length > 0)
            {
                MessageBox.Show("Book(idle) has a ClientOrderID: " + rowCur["ClientOrderID"].ToString(), "Error");
                return;
            }

            rowCur["ClientOrderID"] = targetRow["ClientOrderID"];

            DM.UpdateBook();

            if (dgvBookOrder.CurrentCell == null || dgvBookOrder.SelectedRows.Count < 1)
            {
                btnRemove.Enabled = false;
            }

            if (dgvBooks.CurrentCell == null || dgvBooks.SelectedRows.Count < 1)
            {
                btnAdd.Enabled = false;
            }

            MessageBox.Show("Book added successfully", "Success");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataRow targetRow = DM.dtClientOrder.Rows[cmClientOrder.Position];
            if (targetRow["Status"].ToString().ToLower() != "current")
            {
                MessageBox.Show("Books can only be removed from current orders", "Error");
                return;
            }

            DataRow rowCur = dgvCurrentRow(dgvBookOrder);

            if (rowCur == null)
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this book from client order?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                rowCur["ClientOrderID"] = DBNull.Value;
                DM.UpdateBook();

                if (dgvBookOrder.CurrentCell == null || dgvBookOrder.SelectedRows.Count < 1)
                {
                    btnRemove.Enabled = false;
                }

                if (dgvBooks.CurrentCell == null || dgvBooks.SelectedRows.Count < 1)
                {
                    btnAdd.Enabled = false;
                }

                MessageBox.Show("Book removed successfully", "Success");
            }
        }

        private void dgvBooks_onclick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBooks_CurrentCellChange(sender, e);
        }

        private void dgvBookOrder_CurrentCellChange(object sender, EventArgs e)
        {
            DataRow rowCur = dgvCurrentRow(dgvBookOrder);
            
            if (rowCur == null)
            {
                return;
            }

            dgvBooks.ClearSelection();

            DataRow[] rowRs = DM.dtBookInfo.Select("BookInfoID = " + rowCur["BookInfoID"], "BookInfoID");
            if (rowRs.Length == 0)
            {
                txtTitle.Text = "";
            }
            else
            {
                txtTitle.Text = rowRs[0]["Title"].ToString();
            }

            btnRemove.Enabled = true;
            btnAdd.Enabled = false;

            if (dgvBookOrder.CurrentCell == null)
            {
                btnRemove.Enabled = false;
            }

            if (dgvBooks.CurrentCell == null)
            {
                btnAdd.Enabled = false;
            }
        }

        private void dgvBookOrder_onclick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBookOrder_CurrentCellChange(sender, e);
        }
    }
}
