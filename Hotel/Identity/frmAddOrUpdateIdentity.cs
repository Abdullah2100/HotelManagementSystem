using HotelBuisness;
using System.Windows.Forms;

namespace Hotel.Identity
{
    public partial class frmAddOrUpdateIdentity : Form
    {
        public delegate void onIdentityAdd(object sender, int id);
        public event onIdentityAdd addIdentityEvent;
        enum enMode { add, update };
        private enMode _mode { get; set; }

        private clsIdentitiesBuisness _identity { get; set; }
        private int _identityID = 0;

        public frmAddOrUpdateIdentity()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateIdentity(int identityID)
        {
            InitializeComponent();
            _identityID = identityID;
            _mode = enMode.update;
        }


        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
                _identity = new clsIdentitiesBuisness();
                lbTitle.Text = "Add New Identity";
                btnSave.Text = "Add";
            }
            else
            {
                lbTitle.Text = "Update Identity";
                btnSave.Text = "Update";
            }
            txtName.Text = "";
        }

        private void _loadDate()
        {
            _identity = clsIdentitiesBuisness.findIdentitieByID(_identityID);
            if (_identity == null)
            {
                MessageBox.Show("Department Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _identity.name;
        }

        private void frmAddOrUpdateIdentity_Load(object sender, System.EventArgs e)
        {

            _reseatData();
            if (_mode == enMode.update)
                _loadDate();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 2)
            {
                errorProvider1.SetError(txtName, "Write Valide Name");
                return;
            }


            _identity.name = txtName.Text;

            if (_identity.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                addIdentityEvent?.Invoke(this, _identity.id);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
