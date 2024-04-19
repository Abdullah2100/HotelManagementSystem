using Hotel.Booking;
using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Room
{
    public partial class frmRoomList : Form
    {
        DataTable dtRooms = new DataTable();
        public frmRoomList()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtRooms = clsRoomBuisness.getRooms();
            dgvRoom.DataSource = dtRooms;

            if (dgvRoom.Rows.Count > 0)
            {
                //                Room ID
                //Room Type
                //
                //Bed Number
                //State
                //Add By
                dgvRoom.Columns[0].HeaderText = "ID";
                dgvRoom.Columns[0].Width = 90;

                dgvRoom.Columns[1].HeaderText = "Room Type";
                dgvRoom.Columns[1].Width = 120;

                dgvRoom.Columns[2].HeaderText = "Capacity";
                dgvRoom.Columns[2].Width = 70;

                dgvRoom.Columns[3].HeaderText = "Bed Number";
                dgvRoom.Columns[3].Width = 70;


                dgvRoom.Columns[4].HeaderText = "Daily Price";
                dgvRoom.Columns[4].Width = 120;

                dgvRoom.Columns[5].HeaderText = "State";
                dgvRoom.Columns[5].Width = 90;

                dgvRoom.Columns[6].HeaderText = "Add Date";
                dgvRoom.Columns[6].Width = 120;

                dgvRoom.Columns[7].HeaderText = "Add By";
                dgvRoom.Columns[7].Width = 150;

                lbRecurdNumber.Text = dgvRoom.Rows.Count.ToString();
            }


        }

        private void frmRoomList_Load(object sender, EventArgs e)
        {

            _loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateRoom form = new frmAddOrUpdateRoom();
            form.ShowDialog();
            _loadData();

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateRoom form = new frmAddOrUpdateRoom();
            form.ShowDialog();
            _loadData();

        }

        private void updateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int roomID = (int)dgvRoom.CurrentRow.Cells[0].Value;
            frmAddOrUpdateRoom form = new frmAddOrUpdateRoom(roomID);
            form.ShowDialog();
            _loadData();

        }

        private void cbbGenral_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmsRoom_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasData = dtRooms.Rows.Count > 0;
            bool notBooking = !hasData ? false : (string)dgvRoom.CurrentRow.Cells[5].Value == "None";
            cmsRoom.Items[1].Enabled = (hasData && notBooking);
            cmsRoom.Items[2].Enabled = (hasData && notBooking);
            cmsRoom.Items[3].Enabled = hasData;

            cmsRoom.Items[4].Enabled = (hasData && notBooking);

        }

        private void bookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int roomID = (int)dgvRoom.CurrentRow.Cells[0].Value;
            frmAddOrUpdateBooking form = new frmAddOrUpdateBooking(roomID);
            form.ShowDialog();
            _loadData();
        }
    }
}
