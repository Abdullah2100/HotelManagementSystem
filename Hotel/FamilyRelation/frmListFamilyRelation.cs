using HotelBuisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel.FamilyRelation
{
    public partial class frmListFamilyRelation : Form
    {
        DataTable dtFamilyRelation = new DataTable();
        public frmListFamilyRelation()
        {
            InitializeComponent();
        }

        private void _loadData()
        {
            dtFamilyRelation = clsFamilyRelationBuisness.getFamilyRelations();
            dgvFamilyRelation.DataSource = dtFamilyRelation;
            if (dgvFamilyRelation.Rows.Count > 0)
            {
                dgvFamilyRelation.Columns[0].HeaderText = "ID";
                dgvFamilyRelation.Columns[0].Width = 90;

                dgvFamilyRelation.Columns[1].HeaderText = "Name";
                dgvFamilyRelation.Columns[1].Width = 150;

                lbRecurdNumber.Text = dtFamilyRelation.Rows.Count.ToString();
            }

        }
        private void frmListFamilyRelation_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void cmsFamilyRelation_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasData = dtFamilyRelation.Rows.Count > 0;
            cmsFamilyRelation.Items[1].Enabled = hasData;
            cmsFamilyRelation.Items[2].Enabled = hasData;
        }

        private void addFamilyRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateFamilyRelation form = new frmAddOrUpdateFamilyRelation();
            form.ShowDialog();
            _loadData();
        }

        private void updateFamilyRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int familyRelationID = (int)dgvFamilyRelation.CurrentRow.Cells[0].Value;
            frmAddOrUpdateFamilyRelation form = new frmAddOrUpdateFamilyRelation(familyRelationID);
            form.ShowDialog();
            _loadData();
        }

        private void deleteFamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This FamoilyRelation", "Qestion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int familyRelationID = (int)dgvFamilyRelation.CurrentRow.Cells[0].Value;

                if (clsFamilyRelationBuisness.deleteFamilyRelation(familyRelationID))
                {
                    MessageBox.Show("FamoilyRelation Delete Seccesffuly", "Done", MessageBoxButtons.OK);
                    _loadData();
                }
                else
                {
                    MessageBox.Show("There are Employee Working At This FamoilyRelation", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateFamilyRelation form = new frmAddOrUpdateFamilyRelation();
            form.ShowDialog();
            _loadData();
        }


    }
}
