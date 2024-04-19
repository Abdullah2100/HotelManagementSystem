using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Booking
{
    public partial class frmListBooking : Form
    {

        DataTable dtBooking = new DataTable();
        public frmListBooking()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtBooking = clsBookingBuisness.getBookings();

            if (dtBooking.Rows.Count > 0)
            {
                dgvBooking.DataSource = dtBooking;
            }

        }
        private void frmListBooking_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookingID = (int)dgvBooking.CurrentRow.Cells[0].Value;
            frmAddOrUpdateBooking form = new frmAddOrUpdateBooking(bookingID);
            form.ShowDialog();
        }

        private void cmsBooking_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasData = dtBooking.Rows.Count > 0;
            cmsBooking.Items[0].Enabled = hasData;
            cmsBooking.Items[1].Enabled = hasData;
            cmsBooking.Items[2].Enabled = hasData;
        }
    }
}
