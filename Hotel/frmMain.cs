using Hotel.Employee;
using Hotel.EmployeeType;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListEmployee form = new frmListEmployee();
            form.ShowDialog();
        }

        private void employeeTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListDepatment form = new frmListDepatment();
            form.ShowDialog();
        }
    }
}
