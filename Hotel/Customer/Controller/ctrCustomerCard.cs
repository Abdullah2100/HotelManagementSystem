using HotelBuisness;
using System;
using System.Windows.Forms;

namespace Hotel.Customer.Controller
{
    public partial class ctrCustomerCard : UserControl
    {
        private int _customerID { get; set; }

        private clsCustomerBuisness _customer { get; set; }

        public int customerID { get { return _customerID; } }

        public clsCustomerBuisness customer { get { return _customer; } }


        public ctrCustomerCard()
        {
            InitializeComponent();
        }

        private void _reseateData()
        {
            lbAge.Text = "[????]";
            lbName.Text = "[????]";
            lbIsBlock.Text = "[????]";
            lbRelationShip.Text = "[????]";
            lbIdentity.Text = "[????]";
            lbNationalityNo.Text = "[????]";

        }

        public void loadData(int customerID)
        {
            _customer = clsCustomerBuisness.findCustomerByID(customerID);
            if (_customer == null)
            {
                _reseateData();
                return;
            }
            _customerID = _customer.id;
            lbAge.Text = (DateTime.Now.Year - _customer.personInfo.brithDay.Year).ToString();
            lbName.Text = _customer.personInfo.fullName;
            lbIsBlock.Text = _customer.isBlock ? "Yes" : "No";
            lbRelationShip.Text = _customer.familyRelationInfo.name;
            lbIdentity.Text = _customer.identitiesInfo.name;
            lbNationalityNo.Text = _customer.personInfo.nationalNo;
        }

    }
}
