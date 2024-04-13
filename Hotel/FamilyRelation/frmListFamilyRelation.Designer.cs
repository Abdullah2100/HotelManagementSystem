namespace Hotel.FamilyRelation
{
    partial class frmListFamilyRelation
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
            this.lbRecurdNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFamilyRelation = new System.Windows.Forms.DataGridView();
            this.cmsFamilyRelation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFamilyRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFamilyRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyRelation)).BeginInit();
            this.cmsFamilyRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecurdNumber
            // 
            this.lbRecurdNumber.AutoSize = true;
            this.lbRecurdNumber.Location = new System.Drawing.Point(128, 626);
            this.lbRecurdNumber.Name = "lbRecurdNumber";
            this.lbRecurdNumber.Size = new System.Drawing.Size(14, 16);
            this.lbRecurdNumber.TabIndex = 13;
            this.lbRecurdNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recourd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(465, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 51);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvFamilyRelation
            // 
            this.dgvFamilyRelation.AllowUserToAddRows = false;
            this.dgvFamilyRelation.AllowUserToDeleteRows = false;
            this.dgvFamilyRelation.BackgroundColor = System.Drawing.Color.White;
            this.dgvFamilyRelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilyRelation.ContextMenuStrip = this.cmsFamilyRelation;
            this.dgvFamilyRelation.Location = new System.Drawing.Point(34, 405);
            this.dgvFamilyRelation.Name = "dgvFamilyRelation";
            this.dgvFamilyRelation.ReadOnly = true;
            this.dgvFamilyRelation.RowHeadersWidth = 51;
            this.dgvFamilyRelation.RowTemplate.Height = 24;
            this.dgvFamilyRelation.Size = new System.Drawing.Size(592, 189);
            this.dgvFamilyRelation.TabIndex = 9;
            // 
            // cmsFamilyRelation
            // 
            this.cmsFamilyRelation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFamilyRelation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFamilyRelationToolStripMenuItem,
            this.updateFamilyRelationToolStripMenuItem,
            this.deleteFamToolStripMenuItem});
            this.cmsFamilyRelation.Name = "cmsFamilyRelation";
            this.cmsFamilyRelation.Size = new System.Drawing.Size(229, 76);
            this.cmsFamilyRelation.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFamilyRelation_Opening);
            // 
            // addFamilyRelationToolStripMenuItem
            // 
            this.addFamilyRelationToolStripMenuItem.Name = "addFamilyRelationToolStripMenuItem";
            this.addFamilyRelationToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.addFamilyRelationToolStripMenuItem.Text = "Add FamilyRelation";
            this.addFamilyRelationToolStripMenuItem.Click += new System.EventHandler(this.addFamilyRelationToolStripMenuItem_Click);
            // 
            // updateFamilyRelationToolStripMenuItem
            // 
            this.updateFamilyRelationToolStripMenuItem.Name = "updateFamilyRelationToolStripMenuItem";
            this.updateFamilyRelationToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.updateFamilyRelationToolStripMenuItem.Text = "Update FamilyRelation";
            this.updateFamilyRelationToolStripMenuItem.Click += new System.EventHandler(this.updateFamilyRelationToolStripMenuItem_Click);
            // 
            // deleteFamToolStripMenuItem
            // 
            this.deleteFamToolStripMenuItem.Name = "deleteFamToolStripMenuItem";
            this.deleteFamToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.deleteFamToolStripMenuItem.Text = "Delete FamilyRelation";
            this.deleteFamToolStripMenuItem.Click += new System.EventHandler(this.deleteFamToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = " FamilyRelation System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.FamilyRelation;
            this.pictureBox1.Location = new System.Drawing.Point(140, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(545, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 46);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListFamilyRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRecurdNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFamilyRelation);
            this.Controls.Add(this.label1);
            this.Name = "frmListFamilyRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListFamilyRelation";
            this.Load += new System.EventHandler(this.frmListFamilyRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyRelation)).EndInit();
            this.cmsFamilyRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRecurdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFamilyRelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsFamilyRelation;
        private System.Windows.Forms.ToolStripMenuItem addFamilyRelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFamilyRelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFamToolStripMenuItem;
    }
}