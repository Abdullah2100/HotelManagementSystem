namespace Hotel.RoomType
{
    partial class frmListRoomType
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRecurdNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsRoomType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.cmsRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(675, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 46);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(124, 644);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 13;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(596, 624);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 51);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.AllowUserToAddRows = false;
            this.dgvRoomType.AllowUserToDeleteRows = false;
            this.dgvRoomType.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.ContextMenuStrip = this.cmsRoomType;
            this.dgvRoomType.Location = new System.Drawing.Point(30, 338);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            this.dgvRoomType.RowHeadersWidth = 51;
            this.dgvRoomType.RowTemplate.Height = 24;
            this.dgvRoomType.Size = new System.Drawing.Size(727, 272);
            this.dgvRoomType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(172, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "RoomType System";
            // 
            // cmsRoomType
            // 
            this.cmsRoomType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRoomType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomTypeToolStripMenuItem,
            this.updateRoomTypeToolStripMenuItem,
            this.deleteRoomTypeToolStripMenuItem});
            this.cmsRoomType.Name = "cmsRoomType";
            this.cmsRoomType.Size = new System.Drawing.Size(203, 76);
            this.cmsRoomType.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRoomType_Opening);
            // 
            // addRoomTypeToolStripMenuItem
            // 
            this.addRoomTypeToolStripMenuItem.Name = "addRoomTypeToolStripMenuItem";
            this.addRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addRoomTypeToolStripMenuItem.Text = "Add RoomType";
            this.addRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.addRoomTypeToolStripMenuItem_Click);
            // 
            // updateRoomTypeToolStripMenuItem
            // 
            this.updateRoomTypeToolStripMenuItem.Name = "updateRoomTypeToolStripMenuItem";
            this.updateRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateRoomTypeToolStripMenuItem.Text = "Update RoomType";
            this.updateRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.updateRoomTypeToolStripMenuItem_Click);
            // 
            // deleteRoomTypeToolStripMenuItem
            // 
            this.deleteRoomTypeToolStripMenuItem.Name = "deleteRoomTypeToolStripMenuItem";
            this.deleteRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteRoomTypeToolStripMenuItem.Text = "Delete RoomType";
            // 
            // frmListRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 688);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRecurdNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRoomType);
            this.Controls.Add(this.label1);
            this.Name = "frmListRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListRoomType";
            this.Load += new System.EventHandler(this.frmListRoomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.cmsRoomType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsRoomType;
        private System.Windows.Forms.ToolStripMenuItem addRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoomTypeToolStripMenuItem;
    }
}