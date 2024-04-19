using HotelBuisness;
using System;
using System.Windows.Forms;
namespace Hotel.Booking
{
    public partial class frmAddOrUpdateBooking : Form
    {
        enum enMode { add, join, update };
        private enMode _mode { get; set; }
        private int? _roomID { get; set; }
        private int _bookingID { get; set; }
        private clsBookingBuisness _booking { get; set; } = new clsBookingBuisness();


        private double _firstPayment { get; set; }
        private double _totalPayment { get; set; }
        public frmAddOrUpdateBooking(int roomID)
        {
            InitializeComponent();
            _roomID = roomID;
            _mode = enMode.add;
        }

        public frmAddOrUpdateBooking(int roomID, int bookingID)
        {
            InitializeComponent();
            _roomID = roomID;
            _mode = enMode.update;
        }

        public frmAddOrUpdateBooking(int bookingID, bool join)
        {
            InitializeComponent();
            _mode = enMode.join;
        }

        private void _calCulateTotalAndFirstPayment()
        {
            _totalPayment = clsRoomBuisness.getRoomByID(_roomID ?? _booking.roomID).pricePerDay * ((dtpOutDate.Value - dtpAddDAte.Value).Days);
            _firstPayment = _totalPayment * 0.4;
            txtTotalPayment.Text = _totalPayment.ToString();
            txtFirstPayment.Text = (_totalPayment * 0.5).ToString();
        }
        private void _reseateData()
        {

            switch (_mode)
            {
                case enMode.add:
                    {
                        btnSave.Text = "Add";
                        lbFormHeader.Text = "Add New Booking";
                        _booking = new clsBookingBuisness();
                    }
                    break;
                case enMode.join:
                    {
                        btnSave.Text = "Join";
                        lbFormHeader.Text = "Join Customer To Booking";
                    }
                    break;

                case enMode.update:
                    {
                        btnSave.Text = "Update";
                        lbFormHeader.Text = "Update Customer To Booking";
                    }
                    break;

            }


            ctrCustomerCardFilter6.searchFoucse();
            dtpOutDate.MinDate = DateTime.Now.AddDays(1);
            dtpOutDate.MaxDate.AddDays(360);
            dtpOutDate.Value.AddDays(1);
            if (_roomID != null)
            {
                _calCulateTotalAndFirstPayment();
            }

            btnSave.Enabled = false;

        }

        private void _loadData()
        {
            _booking = clsBookingBuisness.findBookingByID(_roomID ?? _booking.roomID);
            if (_booking == null)
            {
                MessageBox.Show("Booking Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;
            }
            if (_mode == enMode.update)
            {


                ctrCustomerCardFilter6.loadData(_booking.customerId);
                ctrCustomerCardFilter6.changeFilterState = false;
                btnSave.Enabled = true;
            }

            dtpAddDAte.Value = _booking.addDate;
            if (_booking.outDate != null)
                dtpOutDate.Value = _booking.outDate;
            txtFirstPayment.Text = _booking.firstPayment.ToString();
            txtTotalPayment.Text = _booking.totalPrice.ToString();
        }


        private void customerCardFilter6_onAddNewCustomer(int obj)
        {
            if (clsCustomerBuisness.isCustomerBlock(obj))
            {
                if (clsBookingBuisness.isCustomerBookingRoom(obj, _roomID ?? _booking.roomID))
                {
                    MessageBox.Show("Customer Already has Valid Booking On This Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Customer Is Not Allow To Make Booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _booking.customerId = obj;
        }

        private void customerCardFilter6_onCustomerSearch(int obj)
        {
            if (clsCustomerBuisness.isCustomerExistByID(obj))
            {
                if (!clsCustomerBuisness.isCustomerBlock(obj))
                {
                    if (clsBookingBuisness.isCustomerBookingRoom(obj, _roomID ?? _booking.roomID))
                    {
                        MessageBox.Show("Customer Already has Valid Booking On This Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnSave.Enabled = false;
                        return;
                    }
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Customer Is Not Allow To Make Booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _booking.customerId = obj;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

            _booking.roomID = _roomID ?? _booking.roomID;
            _booking.addDate = dtpAddDAte.Value;
            _booking.outDate = dtpOutDate.Value;
            _booking.firstPayment = (decimal)_firstPayment;
            _booking.totalPrice = (decimal)_totalPayment;
            _booking.reminderPayment = (decimal)(_totalPayment - _firstPayment);
            _booking.isAvailable = _booking.id == 0 ? true : _booking.isAvailable;
            if (_booking.save())
            {

            }


        }

        private void dtpOutDate_ValueChanged(object sender, EventArgs e)
        {
            _calCulateTotalAndFirstPayment();
        }

        private void frmAddOrUpdateBooking_Load(object sender, EventArgs e)
        {
            _reseateData();
            if (_mode != enMode.add)
                _loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
