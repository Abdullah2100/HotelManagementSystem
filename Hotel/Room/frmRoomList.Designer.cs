namespace Hotel.Room
{
    partial class frmRoomList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbbState = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbbGenral = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.lbRecurdNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.cmsRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.cmsRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbState
            // 
            this.cbbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbbState.Location = new System.Drawing.Point(279, 440);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(133, 24);
            this.cbbState.TabIndex = 28;
            this.cbbState.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(279, 440);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 22);
            this.txtFilter.TabIndex = 27;
            // 
            // cbbGenral
            // 
            this.cbbGenral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenral.FormattingEnabled = true;
            this.cbbGenral.Items.AddRange(new object[] {
            "none",
            "Room ID",
            "Room Type",
            "Capacity",
            "Bed Number",
            "State",
            "Add By"});
            this.cbbGenral.Location = new System.Drawing.Point(95, 440);
            this.cbbGenral.Name = "cbbGenral";
            this.cbbGenral.Size = new System.Drawing.Size(165, 24);
            this.cbbGenral.TabIndex = 26;
            this.cbbGenral.SelectedIndexChanged += new System.EventHandler(this.cbbGenral_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(28, 443);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(61, 16);
            this.lbFilter.TabIndex = 25;
            this.lbFilter.Text = "Filter By :";
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(125, 788);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 24;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 788);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 788);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(1195, 771);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 51);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.ContextMenuStrip = this.cmsRoom;
            this.dgvRoom.Location = new System.Drawing.Point(31, 482);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(1302, 272);
            this.dgvRoom.TabIndex = 20;
            // 
            // cmsRoom
            // 
            this.cmsRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.updateRoomToolStripMenuItem,
            this.deleteRoomToolStripMenuItem,
            this.bookingRoomToolStripMenuItem});
            this.cmsRoom.Name = "cmsRoom";
            this.cmsRoom.Size = new System.Drawing.Size(178, 100);
            this.cmsRoom.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRoom_Opening);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.dToolStripMenuItem.Text = "Add Room";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // updateRoomToolStripMenuItem
            // 
            this.updateRoomToolStripMenuItem.Name = "updateRoomToolStripMenuItem";
            this.updateRoomToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.updateRoomToolStripMenuItem.Text = "Update Room";
            this.updateRoomToolStripMenuItem.Click += new System.EventHandler(this.updateRoomToolStripMenuItem_Click);
            // 
            // deleteRoomToolStripMenuItem
            // 
            this.deleteRoomToolStripMenuItem.Name = "deleteRoomToolStripMenuItem";
            this.deleteRoomToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.deleteRoomToolStripMenuItem.Text = "Delete Room";
            // 
            // bookingRoomToolStripMenuItem
            // 
            this.bookingRoomToolStripMenuItem.Name = "bookingRoomToolStripMenuItem";
            this.bookingRoomToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.bookingRoomToolStripMenuItem.Text = "Booking Room";
            this.bookingRoomToolStripMenuItem.Click += new System.EventHandler(this.bookingRoomToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(522, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Room System";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(1241, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 46);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.RoomIcon;
            this.pictureBox1.Location = new System.Drawing.Point(364, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 830);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbState);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbbGenral);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.lbRecurdNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.label1);
            this.Name = "frmRoomList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoomList";
            this.Load += new System.EventHandler(this.frmRoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.cmsRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbbGenral;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRoom;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingRoomToolStripMenuItem;
    }
}