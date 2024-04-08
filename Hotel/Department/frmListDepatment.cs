using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;


namespace Hotel.EmployeeType
{
    public partial class frmListDepatment : Form
    {
        DataTable dtEmployeeType = new DataTable();

        private void _loadData()
        {
            dtEmployeeType = clsDepartmentBuisness.getDepartments();
            dgvEmployeeType.DataSource = dtEmployeeType;

            if (dtEmployeeType.Rows.Count > 0)
            {
                dgvEmployeeType.Columns[0].HeaderText = "Department ID";
                dgvEmployeeType.Columns[0].Width = 120;

                dgvEmployeeType.Columns[1].HeaderText = "Name";
                dgvEmployeeType.Columns[1].Width = 230;

                dgvEmployeeType.Columns[2].HeaderText = "Employee Number";
                dgvEmployeeType.Columns[2].Width = 130;

                lbRecurdNumber.Text = dtEmployeeType.Rows.Count.ToString();

            }
        }
        public frmListDepatment()
        {
            InitializeComponent();
        }

        private void frmEmployeeType_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void cmsEmployeeType_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isHasData = dtEmployeeType.Rows.Count > 0;

            cmsEmployeeType.Items[1].Enabled = isHasData;
            cmsEmployeeType.Items[2].Enabled = isHasData;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateDepartment form = new frmAddOrUpdateDepartment();
            form.ShowDialog();
            _loadData();

        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int employeeTypId = (int)dgvEmployeeType.CurrentRow.Cells[0].Value;
            frmAddOrUpdateDepartment form = new frmAddOrUpdateDepartment(employeeTypId);
            form.ShowDialog();
            _loadData();

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateDepartment form = new frmAddOrUpdateDepartment();
            form.ShowDialog();
            _loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This EmployeeType", "Qestion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int employeeTypId = (int)dgvEmployeeType.CurrentRow.Cells[0].Value;

                if (clsDepartmentBuisness.deleteDepartment(employeeTypId))
                {
                    MessageBox.Show("EmployeeType Delete Seccesffuly", "Done", MessageBoxButtons.OK);
                    _loadData();
                }
                else
                {
                    MessageBox.Show("There are Employee Working At This Type EmployeeType", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }

            }
        }
    }
}
