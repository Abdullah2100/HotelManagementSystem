using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.Customer.Controller
{

    public partial class ctrCustomerCardFilter : UserControl
    {
        public event Action<int> onCustomerSearch;

        public event Action<int> onAddNewCustomer;

        protected virtual void searchCusomter(int id)
        {
            Action<int> customerSearch = onCustomerSearch;
            if (customerSearch != null)
            {
                customerSearch(id);
            }
        }

        protected virtual void addNewcusomter(int id)
        {
            Action<int> addNewCustomer = onAddNewCustomer;
            if (addNewCustomer != null)
            {
                addNewCustomer(id);
            }
        }

        private clsCustomerBuisness _customer = new clsCustomerBuisness();
        private bool _filterSate { get; set; } = true;

        public bool changeFilterState
        {
            set
            {
                _filterSate = value;
                gbFilter.Enabled = _filterSate;
            }
            get
            {
                return _filterSate;
            }
        }

        public int customerID { get { return ctrCustomerCard2.customerID; } }
        public clsCustomerBuisness customer { get { return ctrCustomerCard2.customer; } }

        public void searchFoucse()
        {
            txtSearch.Focus();
        }

        public ctrCustomerCardFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _customer = clsCustomerBuisness.findCustomerByID(Convert.ToInt32(txtSearch.Text));
            if (_customer != null)
            {

                ctrCustomerCard2.loadData(_customer.id);
                if (customer == null)
                {
                    MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searchFoucse();
                    return;
                }

                searchCusomter(customerID);
                return;
            }
            searchFoucse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateCustomer form = new frmAddOrUpdateCustomer();
            form.OnAddEvent += _addNewCustomer;
            form.ShowDialog();


        }

        private void _addNewCustomer(object sender, int id)
        {
            if (id < 0)
            {
                MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrCustomerCard2.loadData(id);
            txtSearch.Text = ctrCustomerCard2.customer.personInfo.nationalNo;
            addNewcusomter(ctrCustomerCard2.customer.id);
        }

        private void CustomerCardFilter_Load(object sender, EventArgs e)
        {
            searchFoucse();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void loadData(int customerID)
        {
            ctrCustomerCard2.loadData(customerID);
        }
    }
}
