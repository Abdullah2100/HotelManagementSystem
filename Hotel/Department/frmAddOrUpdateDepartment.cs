using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.EmployeeType
{
    public partial class frmAddOrUpdateDepartment : Form
    {
<<<<<<< HEAD
        enum enMode { add, update };
        private enMode _mode { get; set; }

        private int _employeeTypeId = 0;
        private clsDepartmentBuisness _employeeType;
=======
        public delegate void onDepartmentAdd(object sender, int id);
        public event onDepartmentAdd departmentAddEvent;
        enum enMode { add, update };
        private enMode _mode { get; set; }

        private int _departmentId = 0;
        private clsDepartmentBuisness _department;
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
        public frmAddOrUpdateDepartment()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateDepartment(int employeeTypeID)
        {
            InitializeComponent();
            _mode = enMode.update;
<<<<<<< HEAD
            _employeeTypeId = employeeTypeID;
=======
            _departmentId = employeeTypeID;
>>>>>>> 8499484 (uplading customer  section and all section belong in it)

        }
        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
<<<<<<< HEAD
                _employeeType = new clsDepartmentBuisness();
=======
                _department = new clsDepartmentBuisness();
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
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
<<<<<<< HEAD
            _employeeType = clsDepartmentBuisness.findDepartmentByID(_employeeTypeId);
            if (_employeeType == null)
=======
            _department = clsDepartmentBuisness.findDepartmentByID(_departmentId);
            if (_department == null)
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
            {
                MessageBox.Show("Department Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
<<<<<<< HEAD
            txtName.Text = _employeeType.name;
=======
            txtName.Text = _department.name;
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
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
<<<<<<< HEAD
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
=======
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 2)
            {
                errorProvider1.SetError(txtName, "Write Valide Name");
                return;
            }
            _department.name = txtName.Text;

            if (_department.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departmentAddEvent.Invoke(this, _department.id);
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
<<<<<<< HEAD
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "This Feild is Require");
                e.Cancel = true;
=======

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
            }
        }
    }
}
