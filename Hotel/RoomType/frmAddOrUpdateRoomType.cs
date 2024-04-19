using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.RoomType
{
    public partial class frmAddOrUpdateRoomType : Form
    {
        enum enMode { add, update };
        private enMode _mode { get; set; }



        private int _roomTypID = 0;
        private clsRoomTypeBuisness _roomType;
        public frmAddOrUpdateRoomType()
        {
            InitializeComponent();
            _mode = enMode.add;

        }

        public frmAddOrUpdateRoomType(int roomTypeID)
        {
            InitializeComponent();
            _roomTypID = roomTypeID;
            _mode = enMode.update;
        }
        private void _reseatData()
        {
            if (_mode == enMode.add)
            {
                _roomType = new clsRoomTypeBuisness();
                lbTitle.Text = "Add New RoomType";
                btnSave.Text = "Add";
            }
            else
            {
                lbTitle.Text = "Update RoomType";
                btnSave.Text = "Update";
            }
            txtName.Text = "";
        }

        private void _loadDate()
        {

            _roomType = clsRoomTypeBuisness.findRoomTypeByID(_roomTypID);
            if (_roomType == null)
            {
                MessageBox.Show("Department Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtName.Text = _roomType.name;
        }

        private void frmAddOrUpdateRoomType_Load(object sender, EventArgs e)
        {
            _reseatData();
            if (_mode == enMode.update)
                _loadDate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("You Must Fill All Require Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _roomType.name = txtName.Text;

            if (_roomType.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (clsRoomTypeBuisness.isRoomTypeExistByName(txtName.Text))
            {
                MessageBox.Show("This Name is Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }
    }
}
