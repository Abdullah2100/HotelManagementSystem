namespace Hotel.Identity
{
    partial class frmListIdentity
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRecurdNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvIdentity = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsIdentity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addIdentityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIdentityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIdentityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentity)).BeginInit();
            this.cmsIdentity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.identity;
            this.pictureBox1.Location = new System.Drawing.Point(190, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(595, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 46);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(178, 579);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 21;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(515, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 51);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvIdentity
            // 
            this.dgvIdentity.AllowUserToAddRows = false;
            this.dgvIdentity.AllowUserToDeleteRows = false;
            this.dgvIdentity.BackgroundColor = System.Drawing.Color.White;
            this.dgvIdentity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdentity.ContextMenuStrip = this.cmsIdentity;
            this.dgvIdentity.Location = new System.Drawing.Point(84, 372);
            this.dgvIdentity.Name = "dgvIdentity";
            this.dgvIdentity.ReadOnly = true;
            this.dgvIdentity.RowHeadersWidth = 51;
            this.dgvIdentity.RowTemplate.Height = 24;
            this.dgvIdentity.Size = new System.Drawing.Size(592, 175);
            this.dgvIdentity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(195, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Identity System";
            // 
            // cmsIdentity
            // 
            this.cmsIdentity.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIdentity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIdentityToolStripMenuItem,
            this.updateIdentityToolStripMenuItem,
            this.deleteIdentityToolStripMenuItem});
            this.cmsIdentity.Name = "cmsIdentity";
            this.cmsIdentity.Size = new System.Drawing.Size(182, 76);
            this.cmsIdentity.Opening += new System.ComponentModel.CancelEventHandler(this.cmsIdentity_Opening);
            // 
            // addIdentityToolStripMenuItem
            // 
            this.addIdentityToolStripMenuItem.Name = "addIdentityToolStripMenuItem";
            this.addIdentityToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addIdentityToolStripMenuItem.Text = "Add Identity";
            this.addIdentityToolStripMenuItem.Click += new System.EventHandler(this.addIdentityToolStripMenuItem_Click);
            // 
            // updateIdentityToolStripMenuItem
            // 
            this.updateIdentityToolStripMenuItem.Name = "updateIdentityToolStripMenuItem";
            this.updateIdentityToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateIdentityToolStripMenuItem.Text = "Update Identity";
            this.updateIdentityToolStripMenuItem.Click += new System.EventHandler(this.updateIdentityToolStripMenuItem_Click);
            // 
            // deleteIdentityToolStripMenuItem
            // 
            this.deleteIdentityToolStripMenuItem.Name = "deleteIdentityToolStripMenuItem";
            this.deleteIdentityToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteIdentityToolStripMenuItem.Text = "Delete Identity";
            // 
            // frmListIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRecurdNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvIdentity);
            this.Controls.Add(this.label1);
            this.Name = "frmListIdentity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListIdentity";
            this.Load += new System.EventHandler(this.frmListIdentity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentity)).EndInit();
            this.cmsIdentity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvIdentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsIdentity;
        private System.Windows.Forms.ToolStripMenuItem addIdentityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIdentityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteIdentityToolStripMenuItem;
    }
}