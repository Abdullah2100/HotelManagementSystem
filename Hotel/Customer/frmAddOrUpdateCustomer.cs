using Hotel.FamilyRelation;
using Hotel.General;
using Hotel.Identity;
using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Customer
{
    public partial class frmAddOrUpdateCustomer : Form
    {
        private enum enMode { add, update };
        private enMode _mode { get; set; }

        private int _customerID { get; set; } = 0;
        private clsCustomerBuisness _customer { set; get; }
        public frmAddOrUpdateCustomer()
        {
            InitializeComponent();
            _mode = enMode.add;

        }

        public frmAddOrUpdateCustomer(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
            _mode = enMode.update;
        }

        private void _loadFamilyRelation()
        {
            cbbFamilyRelation.Items.Clear();
            DataTable dtFamilyRelation = new DataTable();
            dtFamilyRelation = clsFamilyRelationBuisness.getFamilyRelations();
            if (dtFamilyRelation != null)
            {

                foreach (DataRow drFamilyRelation in dtFamilyRelation.Rows)
                {
                    cbbFamilyRelation.Items.Add(drFamilyRelation["name"]);
                }
            }
        }

        private void _loadIdentity()
        {
            cbbIdentity.Items.Clear();
            DataTable dtIdentity = new DataTable();
            dtIdentity = clsIdentitiesBuisness.getIdentities();
            if (dtIdentity != null)
            {
                foreach (DataRow drIdentity in dtIdentity.Rows)
                {
                    cbbIdentity.Items.Add(drIdentity["name"]);
                }
            }
        }
        private void _reaseat()
        {

            _loadFamilyRelation();
            _loadIdentity();

            if (_mode == enMode.add)
            {

                lbTitle.Text = "Add New Employee";
                btnSave.Text = "Save";
                _customer = new clsCustomerBuisness();

            }
            else
            {
                lbTitle.Text = "Update  Employee";
                btnSave.Text = "Update";
            }


            txtFristName.Focus();
            txtFristName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";

            chcYes.Checked = true;

        }

        private void _loadData()
        {
            _customer = clsCustomerBuisness.findCustomerByID(_customerID);
            if (_customer == null)
            {
                MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFristName.Text = _customer.personInfo.firstName;
            txtLastName.Text = _customer.personInfo.lastName;
            txtNationalNo.Text = _customer.personInfo.nationalNo;


            if (_customer.isBlock)
                chcNo.Checked = true;
            else
                chcYes.Checked = true;

            cbbFamilyRelation.SelectedIndex = cbbFamilyRelation.FindString(_customer.familyRelationInfo.name);
            cbbIdentity.SelectedIndex = cbbIdentity.FindString(_customer.identitiesInfo.name);

        }


        private void frmAddOrUpdateCustomer_Load(object sender, EventArgs e)
        {
            _reaseat();
            if (_mode == enMode.update)
                _loadData();
        }

        private void pbAddFamilyRelation_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateFamilyRelation form = new frmAddOrUpdateFamilyRelation();
            form.ShowDialog();
            _loadFamilyRelation();
        }

        private void pbAddIdentity_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateIdentity form = new frmAddOrUpdateIdentity();
            form.ShowDialog();
            _loadIdentity();
        }

        private void btnSave_Click(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(cbbFamilyRelation.Text))
            {
                errorProvider1.SetError(cbbFamilyRelation, "Must add Relation");
                return;
            }

            if (string.IsNullOrEmpty(cbbIdentity.Text))
            {
                errorProvider1.SetError(cbbIdentity, "Must add  Identity");
                return;
            }
            clsPersonBuisness person = new clsPersonBuisness();


            person.firstName = txtFristName.Text;
            person.lastName = txtLastName.Text;
            person.brithDay = dtpBrithDay.Value;
            person.nationalNo = txtNationalNo.Text;
            if (person.save())
            {
                _customer.familyRelationID = clsFamilyRelationBuisness.findFamilyRelationByName(cbbFamilyRelation.Text).id;
                _customer.identityID = clsIdentitiesBuisness.findIdentitieByName(cbbIdentity.Text).id;
                _customer.isBlock = chcNo.Checked ? true : false;
                _customer.addBy = clsEmployee.employee == null ? null : clsEmployee.employee?.id;
                _customer.personID = person.id;
                _customer.belongTo = null;

                if (_customer.save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsPersonBuisness.deletePersonByID(person.id);
                }

            }

        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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
