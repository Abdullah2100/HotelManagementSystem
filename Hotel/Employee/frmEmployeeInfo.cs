using System;
using System.Windows.Forms;

namespace Hotel.Employee
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo(int emplloyeeID)
        {
            InitializeComponent();
            _loadData(emplloyeeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _loadData(int id)
        {
            ctrEmployeeCard1.loadData(id);
        }

    }
}
