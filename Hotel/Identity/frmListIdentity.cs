using HotelBuisness;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Identity
{
    public partial class frmListIdentity : Form
    {
        DataTable dtIdentity = new DataTable();
        public frmListIdentity()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtIdentity = clsIdentitiesBuisness.getIdentities();
            dgvIdentity.DataSource = dtIdentity;

            if (dgvIdentity.Rows.Count > 0)
            {


                lbRecurdNumber.Text = dtIdentity.Rows.Count.ToString();
            }
        }

        private void cmsIdentity_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasData = dtIdentity.Rows.Count > 0;
            cmsIdentity.Items[1].Enabled = hasData;
            cmsIdentity.Items[2].Enabled = hasData;
        }

        private void frmListIdentity_Load(object sender, System.EventArgs e)
        {
            _loadData();
        }

        private void addIdentityToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddOrUpdateIdentity form = new frmAddOrUpdateIdentity();
            form.ShowDialog();
            _loadData();
        }

        private void updateIdentityToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            int identityID = (int)dgvIdentity.CurrentRow.Cells[0].Value;
            frmAddOrUpdateIdentity form = new frmAddOrUpdateIdentity(identityID);
            form.ShowDialog();
            _loadData();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddOrUpdateIdentity form = new frmAddOrUpdateIdentity();
            form.ShowDialog();
            _loadData();
        }
    }

}
