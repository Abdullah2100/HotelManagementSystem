using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.EmployeeType
{
    public partial class frmAddOrUpdateDepartment : Form
    {
        //public delegate void onDepartmentAdd(object sender, int id);
        //public event onDepartmentAdd departmentAddEvent;
        enum enMode { add, update };
        private enMode _mode { get; set; }



        private int _departmentId = 0;
        private clsDepartmentBuisness _department;
        public frmAddOrUpdateDepartment()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateDepartment(int employeeTypeID)
        {
            InitializeComponent();
            _mode = enMode.update;
            _departmentId = employeeTypeID;

        }
        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
                _department = new clsDepartmentBuisness();
                lbTitle.Text = "Add New Department";
                btnSave.Text = "Add";
            }
            else
            {
                lbTitle.Text = "Update Department";
                btnSave.Text = "Update";
            }
            txtName.Text = "";
        }

        private void _loadDate()
        {

            _department = clsDepartmentBuisness.findDepartmentByID(_departmentId);
            if (_department == null)
            {
                MessageBox.Show("Department Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _department.name;
        }


        private void frmAddOrUpdateEmployeeType_Load(object sender, EventArgs e)
        {
            _reseatData();
            if (_mode == enMode.update)
                _loadDate();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("You Must Fill All Require Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _department.name = txtName.Text;

            if (_department.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "This Feild is Require");
                e.Cancel = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
