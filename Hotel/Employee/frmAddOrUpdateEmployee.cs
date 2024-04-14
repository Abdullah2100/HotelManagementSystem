using Hotel.General;
using Hotel.Properties;
using HotelBuisness;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Hotel.Employee
{
    public partial class frmAddOrUpdateEmployee : Form
    {
        public delegate void onAddEmployee(object e, int id);
        public event onAddEmployee addEmployeeEvent;

        private enum enMode { add, update };
        private enMode _mode { get; set; }

        private int _employeeID { get; set; } = 0;
        private clsEmployeeBuisness _employee { set; get; }
        public frmAddOrUpdateEmployee()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateEmployee(int employeeID)
        {
            InitializeComponent();
            _mode = enMode.update;
            _employeeID = employeeID;
        }

        private bool _handleSaveImage()
        {
            if (pbImage.ImageLocation != _employee.image)
            {
                if (string.IsNullOrEmpty(_employee.image))
                {
                    try
                    {
                        File.Delete(_employee.image);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error is : " + ex.Message);
                    }
                }

                if (pbImage.ImageLocation != null)
                {

                    string image = pbImage.ImageLocation.ToString();

                    if (clsUtil.saveImageToLocal(ref image))
                    {
                        _employee.image = image;
                        return true;
                    }
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void lbLinImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "all image * |*.png;*.jpg;*.jepg;";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Load(openFileDialog1.FileName);
                lbLinRemoveImage.Visible = true;
            }
        }

        private void _loadDepartmentList()
        {
            DataTable dtDepartment = new DataTable();
            dtDepartment = clsDepartmentBuisness.getDepartments();
            if (dtDepartment.Rows.Count > 0)
            {

                foreach (DataRow drName in dtDepartment.Rows)
                {
                    cbbDepartments.Items.Add(drName["name"]);
                }
            }
        }


        private void _reaseat()
        {


            _loadDepartmentList();

            if (_mode == enMode.add)
            {

                lbTitle.Text = "Add New Employee";
                btnSave.Text = "Save";
                _employee = new clsEmployeeBuisness();
            }
            else
            {
                lbTitle.Text = "Update  Employee";
                btnSave.Text = "Update";
            }


            txtFristName.Focus();
            txtFristName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtNationalNo.Text = "";

            chcYes.Checked = true;

            dtpBrithDay.MinDate = DateTime.Now.AddYears(-clsEmployee.maxYear);
            dtpBrithDay.MaxDate = DateTime.Now.AddYears(-clsEmployee.minYear);
            dtpBrithDay.Value = dtpBrithDay.MaxDate;
        }

        private void _loadData()
        {
            _employee = clsEmployeeBuisness.findEmployeeByID(_employeeID);
            if (_employee == null)
            {
                MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFristName.Text = _employee.personInfo.firstName;
            txtLastName.Text = _employee.personInfo.lastName;
            txtUserName.Text = _employee.userName;
            txtNationalNo.Text = _employee.personInfo.nationalNo;
            txtPhone.Text = _employee.phone;
            txtAddress.Text = _employee.address;

            txtPassword.Enabled = false;
            if (!string.IsNullOrEmpty(_employee.image))
                pbImage.Load(_employee.image);
            else
                pbImage.Image = Resources.personHolder;

            cbbDepartments.SelectedIndex = cbbDepartments.FindString(_employee.departmentInfo.name);

            if (_employee.isBlock)
                chcNo.Checked = true;
            else
                chcYes.Checked = true;

        }

        private void frmAddOrUpdateEmployee_Load(object sender, System.EventArgs e)
        {

            _reaseat();
            if (_mode == enMode.update)
                _loadData();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFristName.Text) || txtFristName.Text.Length < 2)
            {
                errorProvider1.SetError(txtFristName, "This Feild is Must be More Than 2 charatecher");
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text.Length < 2)
            {
                errorProvider1.SetError(txtLastName, "This Feild is Must be More Than 2 charatecher");
                return;
            }

            if (string.IsNullOrEmpty(txtNationalNo.Text) || txtNationalNo.Text.Length < 2)
            {
                errorProvider1.SetError(txtNationalNo, "This Feild is Must be More Than 2 charatecher");
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text) || txtUserName.Text.Length < 2)
            {
                errorProvider1.SetError(txtUserName, "This Feild is Must be More Than 2 charatecher");
                return;
            }

            if (string.IsNullOrEmpty(lbPassword.Text) || lbPassword.Text.Length < 2)
            {
                errorProvider1.SetError(lbPassword, "This Feild is Must be More Than 2 charatecher");
                return;
            }

            if (string.IsNullOrEmpty(cbbDepartments.Text))
            {
                errorProvider1.SetError(cbbDepartments, "You Must sellect Department");
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text.Length < 9)
            {
                errorProvider1.SetError(txtPhone, "Write Valid Phone Number");
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text) || txtAddress.Text.Length < 2)
            {
                errorProvider1.SetError(txtAddress, "Write Valid Phone Number");
                return;
            }

            if (!_handleSaveImage())
            {
                MessageBox.Show("Select Valid Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPersonBuisness person = new clsPersonBuisness();


            person.firstName = txtFristName.Text;
            person.lastName = txtLastName.Text;
            person.brithDay = dtpBrithDay.Value;
            person.nationalNo = txtNationalNo.Text;
            if (person.save())
            {
                _employee.userName = txtUserName.Text;
                _employee.password = clsUtil.decodePassword(lbPassword.Text);
                _employee.departmentID = clsDepartmentBuisness.findDepartmentByName(cbbDepartments.Text).id;
                _employee.phone = txtPhone.Text;
                _employee.isBlock = chcNo.Checked ? true : false;
                _employee.personID = person.id;
                _employee.address = txtAddress.Text;

                if (_employee.save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addEmployeeEvent.Invoke(this, _employee.id);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsPersonBuisness.deletePersonByID(person.id);
                }

            }


        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (clsEmployeeBuisness.isEmployeeExistByUserName(txtUserName.Text))
            {

                MessageBox.Show("UserName is Already Used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (clsEmployeeBuisness.isEmployeeExistByPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone  is Already Used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
        }

        private void lbLinRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = null;
            lbLinRemoveImage.Visible = false;
        }




        private void txtNationalNo_Leave(object sender, EventArgs e)
        {

            if (clsPersonBuisness.isPersonExistByNationalNo(txtNationalNo.Text))
            {
                MessageBox.Show("Naitonal no is Allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnSave.Enabled = false;
            }
        }

    }
}
