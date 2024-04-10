using Hotel.Properties;
using HotelBuisness;
using System.Windows.Forms;

namespace Hotel.Employee.Controller
{
    public partial class ctrEmployeeCard : UserControl
    {
        private clsEmployeeBuisness _employee { get; set; }
        public clsEmployeeBuisness employee { get { return _employee; } }

        private int _employeeID { get; set; }

        public int employeeID { get { return _employeeID; } }
        public ctrEmployeeCard()
        {
            InitializeComponent();
        }
        public void loadData(int id)
        {
            _employee = clsEmployeeBuisness.findEmployeeByID(id);
            if (_employee == null)
            {
                _reasetData();
                return;
            }
            _fillData(id);
        }
        private void _fillData(int id)
        {
            _employeeID = id;
            lbEmployeeID.Text = id.ToString();
            lbName.Text = _employee.fullName;
            lbDepartment.Text = _employee.departmentInfo.name;
            lbBrithDay.Text = _employee.personInfo.brithDay.ToString();
            lbAddDate.Text = _employee.personInfo.createdDate.ToString();
            lbAddress.Text = _employee.address;
            lbIsBlock.Text = _employee.isBlock ? "Yes" : "No";
            lbPhone.Text = _employee.phone;
            lbNationalNo.Text = _employee.personInfo.nationalNo.ToString();
            if (!string.IsNullOrEmpty(_employee.image))
                pbPersonalImage.Load(_employee.image);

            lbLiEdite.Enabled = true;
        }
        private void _reasetData()
        {
            lbEmployeeID.Text = "[????]";
            lbName.Text = "[????]";
            lbDepartment.Text = "[????]";
            lbBrithDay.Text = "[????]";
            lbAddDate.Text = "[????]";
            lbAddress.Text = "[????]";
            lbIsBlock.Text = "[????]";
            lbPhone.Text = "[????]";
            lbNationalNo.Text = "[????]";

            pbPersonalImage.Image = Resources.employee1;
            lbLiEdite.Enabled = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrUpdateEmployee form = new frmAddOrUpdateEmployee(_employeeID);
            form.addEmployeeEvent += _onPersonEditeInfo;
            form.ShowDialog();
        }
        private void _onPersonEditeInfo(object sender, int id)
        {
            _fillData(id);
        }
    }
}
