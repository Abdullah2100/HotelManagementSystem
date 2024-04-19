namespace Hotel.Booking
{
    partial class frmListBooking
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsBooking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complateBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsBooking.SuspendLayout();
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
            this.cbbState.Location = new System.Drawing.Point(283, 345);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(133, 24);
            this.cbbState.TabIndex = 41;
            this.cbbState.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(283, 345);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 22);
            this.txtFilter.TabIndex = 40;
            // 
            // cbbGenral
            // 
            this.cbbGenral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenral.FormattingEnabled = true;
            this.cbbGenral.Items.AddRange(new object[] {
            "none",
            "ID",
            "Person ID",
            "FullName",
            "Follow To",
            "Following Customer ID",
            "Relation Ship",
            "Identity Type",
            "Is Block",
            "Created By"});
            this.cbbGenral.Location = new System.Drawing.Point(99, 345);
            this.cbbGenral.Name = "cbbGenral";
            this.cbbGenral.Size = new System.Drawing.Size(165, 24);
            this.cbbGenral.TabIndex = 39;
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(32, 348);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(61, 16);
            this.lbFilter.TabIndex = 38;
            this.lbFilter.Text = "Filter By :";
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(129, 693);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 36;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(1199, 676);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 51);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.ContextMenuStrip = this.cmsBooking;
            this.dgvBooking.Location = new System.Drawing.Point(35, 387);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(1302, 272);
            this.dgvBooking.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(479, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 54);
            this.label1.TabIndex = 31;
            this.label1.Text = "Booking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.customer;
            this.pictureBox1.Location = new System.Drawing.Point(451, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(1245, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 46);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmsBooking
            // 
            this.cmsBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddToolStripMenuItem,
            this.complateBookingToolStripMenuItem,
            this.addServicesToolStripMenuItem});
            this.cmsBooking.Name = "cmsBooking";
            this.cmsBooking.Size = new System.Drawing.Size(203, 76);
            this.cmsBooking.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBooking_Opening);
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ddToolStripMenuItem.Text = "Join Bookig";
            this.ddToolStripMenuItem.Click += new System.EventHandler(this.ddToolStripMenuItem_Click);
            // 
            // complateBookingToolStripMenuItem
            // 
            this.complateBookingToolStripMenuItem.Name = "complateBookingToolStripMenuItem";
            this.complateBookingToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.complateBookingToolStripMenuItem.Text = "Complate Booking";
            // 
            // addServicesToolStripMenuItem
            // 
            this.addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            this.addServicesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addServicesToolStripMenuItem.Text = "Add Services";
            // 
            // frmListBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbState);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbbGenral);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRecurdNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.label1);
            this.Name = "frmListBooking";
            this.Text = "frmListBooking";
            this.Load += new System.EventHandler(this.frmListBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsBooking.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbbGenral;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsBooking;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServicesToolStripMenuItem;
    }
}