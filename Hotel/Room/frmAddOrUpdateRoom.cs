using Hotel.General;
using Hotel.RoomType;
using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Room
{
    public partial class frmAddOrUpdateRoom : Form
    {
        private enum enMode { add, update }
        private enMode _mode { get; set; }
        private int _roomId { get; set; }
        private clsRoomBuisness _room { get; set; }
        public frmAddOrUpdateRoom()
        {
            InitializeComponent();
            _mode = enMode.add;

        }



        public frmAddOrUpdateRoom(int roomID)
        {
            InitializeComponent();
            _roomId = roomID;
            _mode = enMode.update;
        }


        private void _loadRoomType()
        {

            cbbRoomType.Items.Clear();
            DataTable dtRoomType = new DataTable();
            dtRoomType = clsRoomTypeBuisness.getRoomTypes();
            if (dtRoomType.Rows.Count > 0)
                foreach (DataRow dtName in dtRoomType.Rows)
                {
                    cbbRoomType.Items.Add(dtName["name"]);
                }
        }

        private void _reseatData()
        {
            _loadRoomType();
            if (_mode == enMode.update)
            {
                lbTitle.Text = "Update Room Data";
                btnSave.Text = "Update";
            }
            else
            {
                lbTitle.Text = "Add New Room";
                btnSave.Text = "Add";
                _room = new clsRoomBuisness();
            }
            nudBedNumber.Value = 0;
            nudCapacity.Value = 0;
            nudFloorNumber.Value = 0;
            if (cbbRoomType.Items.Count > 0)
            {
                cbbRoomType.SelectedIndex = 0;
            }
            txtPrice.Text = "";
        }


        private void _loadData()
        {

            _room = clsRoomBuisness.getRoomByID(_roomId);
            if (_room == null)
            {
                MessageBox.Show("Room Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            nudBedNumber.Value = _room.bedNumber;
            nudCapacity.Value = _room.capacity;
            nudFloorNumber.Value = _room.floorNumber;

            cbbRoomType.SelectedIndex = cbbRoomType.FindString(_room.roomTypeInfo.name);
            txtPrice.Text = _room.pricePerDay.ToString();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbAddRoomType_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateRoomType form = new frmAddOrUpdateRoomType();
            form.ShowDialog();
            _loadRoomType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudCapacity.Value == 0)
            {
                errorProvider1.SetError(nudCapacity, "This Feild is Require");
                return;
            }

            if (nudBedNumber.Value == 0)
            {
                errorProvider1.SetError(nudBedNumber, "This Feild is Require");
                return;
            }

            if (nudFloorNumber.Value == 0)
            {
                errorProvider1.SetError(nudFloorNumber, "This Feild is Require");
                return;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(txtPrice, "This Feild is Require");
                return;
            }
            if (string.IsNullOrEmpty(cbbRoomType.Text))
            {
                errorProvider1.SetError(cbbRoomType, "This Feild is Require");
                return;
            }

            _room.capacity = (byte)nudFloorNumber.Value;
            _room.bedNumber = (byte)nudBedNumber.Value;
            _room.floorNumber = (byte)nudFloorNumber.Value;
            _room.addBy = clsEmployee.employee == null ? null : clsEmployee.employee?.id;
            _room.pricePerDay = Convert.ToDouble(txtPrice.Text);
            _room.roomTypeID = clsRoomTypeBuisness.findRoomTypeByName(cbbRoomType.Text).id;
            if (_room.save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddOrUpdateRoom_Load(object sender, EventArgs e)
        {
            _reseatData();
            if (_mode == enMode.update)
                _loadData();
        }
    }
}
