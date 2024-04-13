using HotelBuisness;
using System.Windows.Forms;

namespace Hotel.FamilyRelation
{
    public partial class frmAddOrUpdateFamilyRelation : Form
    {
        public delegate void onFamilyRelationAdd(object sender, int id);
        public event onFamilyRelationAdd familyRelationAddEvent;
        enum enMode { add, update };
        private enMode _mode { get; set; }

        private clsFamilyRelationBuisness _familyRelation { get; set; }
        private int _familyRelationId = 0;
        public frmAddOrUpdateFamilyRelation()
        {
            InitializeComponent();
            _mode = enMode.add;
        }

        public frmAddOrUpdateFamilyRelation(int familyRelationID)
        {
            InitializeComponent();
            _mode = enMode.update;
            _familyRelationId = familyRelationID;
        }

        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
                _familyRelation = new clsFamilyRelationBuisness();
                lbTitle.Text = "Add New FamilyRelation";
                btnSave.Text = "Add";
            }
            else
            {
                lbTitle.Text = "Update FamilyRelation";
                btnSave.Text = "Update";
            }
            txtName.Text = "";
        }

        private void _loadDate()
        {
            _familyRelation = clsFamilyRelationBuisness.findFamilyRelationByID(_familyRelationId);
            if (_familyRelation == null)
            {
                MessageBox.Show("FamilyRelation Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _familyRelation.name;
        }




        private void frmAddOrUpdateFamilyRelation_Load(object sender, System.EventArgs e)
        {
            _reseatData();
            if (_mode == enMode.update)
                _loadDate();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 2)
            {
                errorProvider1.SetError(txtName, "Write Valide Name");
                return;
            }

            _familyRelation.name = txtName.Text;

            if (_familyRelation.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familyRelationAddEvent?.Invoke(this, _familyRelation.id);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
