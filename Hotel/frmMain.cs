<<<<<<< HEAD
﻿using Hotel.Employee;
using Hotel.EmployeeType;
=======
﻿using Hotel.Customer;
using Hotel.Employee;
using Hotel.EmployeeType;
using Hotel.FamilyRelation;
using Hotel.Identity;
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
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
<<<<<<< HEAD
=======

        private void familyRelationsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListFamilyRelation form = new frmListFamilyRelation();
            form.ShowDialog();
        }

        private void identityToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListIdentity form = new frmListIdentity();
            form.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListCustomers form = new frmListCustomers();
            form.ShowDialog();
        }
>>>>>>> 8499484 (uplading customer  section and all section belong in it)
    }
}
