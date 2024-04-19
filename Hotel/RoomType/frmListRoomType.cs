using HotelBuisness;
using System.Data;
using System.Windows.Forms;

namespace Hotel.RoomType
{
    public partial class frmListRoomType : Form
    {
        DataTable dtRoomType = new DataTable();
        public frmListRoomType()
        {
            InitializeComponent();
        }
        private void _loadData()
        {
            dtRoomType = clsRoomTypeBuisness.getRoomTypes();
            dgvRoomType.DataSource = dtRoomType;

            if (dtRoomType.Rows.Count > 0)
            {
                dgvRoomType.Columns[0].HeaderText = "ID";
                dgvRoomType.Columns[1].HeaderText = "Name";
                dgvRoomType.Columns[1].Width = 300;
                lbRecurdNumber.Text = dgvRoomType.Rows.Count.ToString();

            }


        }


        private void frmListRoomType_Load(object sender, System.EventArgs e)
        {
            _loadData();

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddOrUpdateRoomType form = new frmAddOrUpdateRoomType();
            form.ShowDialog();
            _loadData();

        }

        private void cmsRoomType_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasData = dtRoomType.Rows.Count > 0;
            cmsRoomType.Items[1].Enabled = hasData;
            cmsRoomType.Items[2].Enabled = hasData;
        }

        private void updateRoomTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int roomTypeID = (int)dgvRoomType.CurrentRow.Cells[0].Value;
            frmAddOrUpdateRoomType form = new frmAddOrUpdateRoomType(roomTypeID);
            form.ShowDialog();
            _loadData();
        }

        private void addRoomTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddOrUpdateRoomType form = new frmAddOrUpdateRoomType();
            form.ShowDialog();
            _loadData();
        }
    }
}
