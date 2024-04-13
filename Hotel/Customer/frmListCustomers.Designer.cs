namespace Hotel.Customer
{
    partial class frmListCustomers
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.cmsCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBlockCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.cmsCustomer.SuspendLayout();
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
            this.cbbState.Location = new System.Drawing.Point(286, 372);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(133, 24);
            this.cbbState.TabIndex = 29;
            this.cbbState.Visible = false;
            this.cbbState.SelectedIndexChanged += new System.EventHandler(this.cbbState_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(286, 372);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(247, 22);
            this.txtFilter.TabIndex = 28;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
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
            this.cbbGenral.Location = new System.Drawing.Point(102, 372);
            this.cbbGenral.Name = "cbbGenral";
            this.cbbGenral.Size = new System.Drawing.Size(165, 24);
            this.cbbGenral.TabIndex = 27;
            this.cbbGenral.SelectedIndexChanged += new System.EventHandler(this.cbbGenral_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(35, 375);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(61, 16);
            this.lbFilter.TabIndex = 26;
            this.lbFilter.Text = "Filter By :";
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(132, 720);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 24;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(1202, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 51);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.ContextMenuStrip = this.cmsCustomer;
            this.dgvCustomer.Location = new System.Drawing.Point(38, 414);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1302, 272);
            this.dgvCustomer.TabIndex = 20;
            // 
            // cmsCustomer
            // 
            this.cmsCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.blockCustomerToolStripMenuItem,
            this.unBlockCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.cmsCustomer.Name = "cmsCustomer";
            this.cmsCustomer.Size = new System.Drawing.Size(211, 152);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // blockCustomerToolStripMenuItem
            // 
            this.blockCustomerToolStripMenuItem.Name = "blockCustomerToolStripMenuItem";
            this.blockCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.blockCustomerToolStripMenuItem.Text = "Block Customer";
            // 
            // unBlockCustomerToolStripMenuItem
            // 
            this.unBlockCustomerToolStripMenuItem.Name = "unBlockCustomerToolStripMenuItem";
            this.unBlockCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.unBlockCustomerToolStripMenuItem.Text = "UnBlock Customer";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(482, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.customer;
            this.pictureBox1.Location = new System.Drawing.Point(454, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(1248, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 46);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 769);
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
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListCustomers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.cmsCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbbGenral;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsCustomer;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBlockCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
    }
}