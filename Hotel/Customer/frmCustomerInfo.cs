using System.Windows.Forms;

namespace Hotel.Customer
{
    public partial class frmCustomerInfo : Form
    {
        public frmCustomerInfo(int customerID)
        {
            InitializeComponent();
            _loadDate(customerID);
        }



        private void _loadDate(int id)
        {
            ctrCustomerCard1.loadData(id);
            if (ctrCustomerCard1.customer == null)
            {
                MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

        }
    }


}
