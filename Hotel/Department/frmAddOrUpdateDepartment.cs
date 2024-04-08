using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.EmployeeType
{
    public partial class frmAddOrUpdateDepartment : Form
    {
        enum enMode { add, update };
        private enMode _mode { get; set; }

        private int _employeeTypeId = 0;
        private clsDepartmentBuisness _employeeType;
        public frmAddOrUpdateDepartment()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateDepartment(int employeeTypeID)
        {
            InitializeComponent();
            _mode = enMode.update;
            _employeeTypeId = employeeTypeID;

        }
        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
                _employeeType = new clsDepartmentBuisness();
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
            _employeeType = clsDepartmentBuisness.findDepartmentByID(_employeeTypeId);
            if (_employeeType == null)
            {
                MessageBox.Show("EmployeeType Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _employeeType.name;
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
            _employeeType.name = txtName.Text;

            if (_employeeType.save())
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
    }
}
