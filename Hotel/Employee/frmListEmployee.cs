using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Employee
{
    public partial class frmListEmployee : Form
    {
        DataTable dtEmployees = new DataTable();
        public frmListEmployee()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtEmployees = clsEmployeeBuisness.getEmployees();
            dgvEmployee.DataSource = dtEmployees;
            if (dtEmployees.Rows.Count > 0)
            {
                dgvEmployee.Columns[0].HeaderText = "Employee ID";
                dgvEmployee.Columns[0].Width = 90;

                dgvEmployee.Columns[1].HeaderText = "Person ID";
                dgvEmployee.Columns[1].Width = 80;

                dgvEmployee.Columns[2].HeaderText = "Department";
                dgvEmployee.Columns[2].Width = 80;

                dgvEmployee.Columns[3].HeaderText = "UserName";
                dgvEmployee.Columns[3].Width = 200;

                dgvEmployee.Columns[4].HeaderText = "FullName";
                dgvEmployee.Columns[4].Width = 200;

                dgvEmployee.Columns[5].HeaderText = "Age";
                dgvEmployee.Columns[5].Width = 80;

                dgvEmployee.Columns[6].HeaderText = "CreatedDate";
                dgvEmployee.Columns[6].Width = 120;

                dgvEmployee.Columns[7].HeaderText = "Is Block";
                dgvEmployee.Columns[7].Width = 60;



                lbRecurdNumber.Text = dtEmployees.Rows.Count.ToString();
            }
        }
        private void frmListEmployee_Load(object sender, EventArgs e)
        {
            _loadData();
            cbbGenral.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbGenral_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee form = new frmAddOrUpdateEmployee();
            form.ShowDialog();
            _loadData();


        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int employeeID = (int)dgvEmployee.CurrentRow.Cells[0].Value;
            frmAddOrUpdateEmployee form = new frmAddOrUpdateEmployee(employeeID);
            form.ShowDialog();
            _loadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee form = new frmAddOrUpdateEmployee();
            form.ShowDialog();
            _loadData();
        }

        private void cmsEmployee_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            bool hasData = dtEmployees.Rows.Count > 0;
            int employeeID = !hasData ? 0 : (int)dgvEmployee.CurrentRow.Cells[0].Value;

            bool isActivate = !hasData ? false : clsEmployeeBuisness.isEmployeeBlock(employeeID);
            cmsEmployee.Items[1].Enabled = hasData;
            cmsEmployee.Items[2].Enabled = hasData;
            cmsEmployee.Items[3].Enabled = hasData;

            cmsEmployee.Items[4].Enabled = (hasData && !isActivate);
            cmsEmployee.Items[5].Enabled = (hasData && isActivate);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnName = "";

            switch (cbbGenral.Text)
            {
                //Age
                //CreatedDate
                //Is Block
                case "Employee ID":
                    {
                        columnName = "employeeID";
                    }
                    break;
                case "Person ID":
                    {
                        columnName = "personID";
                    }
                    break;
                case "Department":
                    {
                        columnName = "department";
                    }
                    break;
                case "UserName":
                    {
                        columnName = "userName";
                    }
                    break;
                case "FullName":
                    {
                        columnName = "fullName";
                    }
                    break;
                case "Age":
                    {
                        columnName = "Age";
                    }
                    break;
                case "CreatedDate":
                    {
                        columnName = "createdDate";
                    }
                    break;
                case "Is Block":
                    {
                        columnName = "sBlock";
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
                dtEmployees.DefaultView.RowFilter = "";
                return;
            }
            if (columnName == "employeeID" || columnName == "personID" || columnName == "Age")
                dtEmployees.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilter.Text);
            else
                dtEmployees.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", columnName, txtFilter.Text);



        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Deleting This Employee", "?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int employeeID = (int)dgvEmployee.CurrentRow.Cells[1].Value;
                if (clsEmployeeBuisness.deleteEmployee(employeeID))
                {
                    MessageBox.Show("Employee Delete Seccesful", "Done", MessageBoxButtons.OK);
                    _loadData();
                }
                else
                {
                    MessageBox.Show("Could Not Delete Employee", "Error", MessageBoxButtons.OK);

                }
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtFilter.Text == "employeeID" || txtFilter.Text == "personID" || txtFilter.Text == "Age")
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void cbbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = "isBlock", rowValue = "";

            switch (cbbState.Text)
            {
                case "Yes": { rowValue = "1"; } break;
                case "No": { rowValue = "0"; } break;
                default: { rowValue = ""; } break;
            }
            if (string.IsNullOrEmpty(rowValue))
                dtEmployees.DefaultView.RowFilter = "";
            else
                dtEmployees.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, rowValue);



        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int employeeID = (int)dgvEmployee.CurrentRow.Cells[0].Value;
            frmEmployeeInfo form = new frmEmployeeInfo(employeeID);
            form.ShowDialog();

        }

        private void blockEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int employeeID = (int)dgvEmployee.CurrentRow.Cells[0].Value;

            clsEmployeeBuisness.deActivateEmployee(employeeID);
            _loadData();
        }

        private void unBlockEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int employeeID = (int)dgvEmployee.CurrentRow.Cells[0].Value;

            clsEmployeeBuisness.activateEmployee(employeeID);
            _loadData();
        }


    }
}
