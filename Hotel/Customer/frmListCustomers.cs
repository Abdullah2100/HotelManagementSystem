using HotelBuisness;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Customer
{
    public partial class frmListCustomers : Form
    {
        DataTable dtCusotmer = new DataTable();
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtCusotmer = clsCustomerBuisness.getCustomers();

            dgvCustomer.DataSource = dtCusotmer;
            if (dtCusotmer != null)
            {
                dgvCustomer.Columns[0].HeaderText = "ID";
                dgvCustomer.Columns[0].Width = 120;

                dgvCustomer.Columns[1].HeaderText = "Person ID";
                dgvCustomer.Columns[1].Width = 90;

                dgvCustomer.Columns[2].HeaderText = "FullName";
                dgvCustomer.Columns[2].Width = 150;

                dgvCustomer.Columns[3].HeaderText = "Follow To";
                dgvCustomer.Columns[3].Width = 150;

                dgvCustomer.Columns[4].HeaderText = "Following Customer ID";
                dgvCustomer.Columns[4].Width = 150;

                dgvCustomer.Columns[5].HeaderText = "Relation Ship";
                dgvCustomer.Columns[5].Width = 120;

                dgvCustomer.Columns[6].HeaderText = "Identity Type";
                dgvCustomer.Columns[6].Width = 90;

                dgvCustomer.Columns[7].HeaderText = "Is Block";
                dgvCustomer.Columns[7].Width = 70;

                ////dgvCustomer.Columns[8].HeaderText = "Add Date";
                ////dgvCustomer.Columns[8].Width = 120;

                ////dgvCustomer.Columns[9].HeaderText = "Created By";
                ////dgvCustomer.Columns[9].Width = 120;



                lbRecurdNumber.Text = dtCusotmer.Rows.Count.ToString();
            }
            cbbGenral.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddOrUpdateCustomer form = new frmAddOrUpdateCustomer();
            form.ShowDialog();
            _loadData();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            frmAddOrUpdateCustomer form = new frmAddOrUpdateCustomer();
            form.ShowDialog();
            _loadData();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int customerID = (int)dgvCustomer.CurrentRow.Cells[0].Value;
            frmAddOrUpdateCustomer form = new frmAddOrUpdateCustomer(customerID);
            form.ShowDialog();
            _loadData();
        }

        private void frmListCustomers_Load(object sender, System.EventArgs e)
        {
            _loadData();
        }

        private void cbbGenral_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFilter.Text = "";
            if (cbbGenral.SelectedIndex == 0)
            {
                txtFilter.Enabled = false;
                cbbState.Visible = false;
            }
            else
            {
                txtFilter.Visible = (cbbGenral.SelectedIndex != 8);
                txtFilter.Enabled = (cbbGenral.SelectedIndex != 8);
                cbbState.Visible = (cbbGenral.SelectedIndex == 8);
            }
        }

        private void txtFilter_TextChanged(object sender, System.EventArgs e)
        {
            string columnName = "";
            ////Following Customer ID
            ////Relation Ship
            ////Identity Type
            ////Is Block
            ////Created By

            switch (cbbGenral.Text)
            {
                case "ID":
                    {
                        columnName = "customerID";
                    }
                    break;
                case "Person ID":
                    {
                        columnName = "personID";
                    }
                    break;
                case "FullName":
                    {
                        columnName = "fullName";
                    }
                    break;
                case "Follow To":
                    {
                        columnName = "belongToName";
                    }
                    break;
                case "Following Customer ID":
                    {
                        columnName = "belongID";
                    }
                    break;
                case "Relation Ship":
                    {
                        columnName = "relationShip";
                    }
                    break;
                case "Identity Type":
                    {
                        columnName = "kindOfIdentity";
                    }
                    break;
                case "Is Block":
                    {
                        columnName = "isBlock";
                    }
                    break;
                case "Created By":
                    {
                        columnName = "createdBy";
                    }
                    break;

                default:
                    {
                        columnName = "none";
                    }
                    break;
            }

            if (columnName == "none" || string.IsNullOrEmpty(txtFilter.Text))
            {
                dtCusotmer.DefaultView.RowFilter = "";
                return;
            }
            if (columnName == "customerID" || columnName == "personID" || columnName == "createdBy" || columnName == "belongID")
                dtCusotmer.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilter.Text);
            else
                dtCusotmer.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", columnName, txtFilter.Text);



        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFilter.Text == "ID" || txtFilter.Text == "Person ID" || txtFilter.Text == "Following Customer ID" || txtFilter.Text == "Created By")
            {

                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbbState_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string columnName = "isBlock", rowValue = "";

            switch (cbbState.Text)
            {
                case "Yes": { rowValue = "1"; } break;
                case "No": { rowValue = "0"; } break;
                default: { rowValue = ""; } break;
            }
            if (string.IsNullOrEmpty(rowValue))
                dtCusotmer.DefaultView.RowFilter = "";
            else
                dtCusotmer.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, rowValue);

        }

        private void showInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int customerID = (int)dgvCustomer.CurrentRow.Cells[0].Value;

            frmCustomerInfo form = new frmCustomerInfo(customerID);
            form.ShowDialog();
        }
    }
}
