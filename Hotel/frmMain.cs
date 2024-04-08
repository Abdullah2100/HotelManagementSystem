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

        }

        private void employeeTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmEmployeeType form = new frmEmployeeType();
            form.ShowDialog();
        }
    }
}
