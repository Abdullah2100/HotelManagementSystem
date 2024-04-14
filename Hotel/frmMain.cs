using Hotel.Customer;
using Hotel.Employee;
using Hotel.EmployeeType;
using Hotel.FamilyRelation;
using Hotel.Identity;
using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEmployee form = new frmListEmployee();
            form.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDepatment form = new frmListDepatment();
            form.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCustomers form = new frmListCustomers();
            form.ShowDialog();
        }

        private void familyRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListFamilyRelation form = new frmListFamilyRelation();
            form.ShowDialog();
        }

        private void identityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListIdentity form = new frmListIdentity();
            form.ShowDialog();
        }
    }
}
