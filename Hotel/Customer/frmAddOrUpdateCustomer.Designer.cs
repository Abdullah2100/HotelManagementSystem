namespace Hotel.Customer
{
    partial class frmAddOrUpdateCustomer
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
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBrithDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFristName = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbAddIdentity = new System.Windows.Forms.PictureBox();
            this.pbAddFamilyRelation = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chcNo = new System.Windows.Forms.CheckBox();
            this.chcYes = new System.Windows.Forms.CheckBox();
            this.cbbIdentity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbFamilyRelation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddIdentity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFamilyRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.txtNationalNo);
            this.gbPersonal.Controls.Add(this.label1);
            this.gbPersonal.Controls.Add(this.label5);
            this.gbPersonal.Controls.Add(this.dtpBrithDay);
            this.gbPersonal.Controls.Add(this.label4);
            this.gbPersonal.Controls.Add(this.txtLastName);
            this.gbPersonal.Controls.Add(this.label3);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Controls.Add(this.txtFristName);
            this.gbPersonal.Location = new System.Drawing.Point(57, 131);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(863, 191);
            this.gbPersonal.TabIndex = 13;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Personal Info";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(163, 151);
            this.txtNationalNo.MaxLength = 15;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(238, 22);
            this.txtNationalNo.TabIndex = 8;
            this.txtNationalNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNo_KeyPress);
            this.txtNationalNo.Leave += new System.EventHandler(this.txtNationalNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(16, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "NationalNo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(40, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "BrithDay :";
            // 
            // dtpBrithDay
            // 
            this.dtpBrithDay.Location = new System.Drawing.Point(161, 113);
            this.dtpBrithDay.Name = "dtpBrithDay";
            this.dtpBrithDay.Size = new System.Drawing.Size(200, 22);
            this.dtpBrithDay.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(544, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(463, 70);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(217, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "FristName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(65, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // txtFristName
            // 
            this.txtFristName.Location = new System.Drawing.Point(159, 70);
            this.txtFristName.MaxLength = 20;
            this.txtFristName.Name = "txtFristName";
            this.txtFristName.Size = new System.Drawing.Size(238, 22);
            this.txtFristName.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(266, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(444, 54);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Add New Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAddIdentity);
            this.groupBox1.Controls.Add(this.pbAddFamilyRelation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chcNo);
            this.groupBox1.Controls.Add(this.chcYes);
            this.groupBox1.Controls.Add(this.cbbIdentity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbFamilyRelation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(57, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // pbAddIdentity
            // 
            this.pbAddIdentity.Image = global::Hotel.Properties.Resources.add;
            this.pbAddIdentity.Location = new System.Drawing.Point(437, 81);
            this.pbAddIdentity.Name = "pbAddIdentity";
            this.pbAddIdentity.Size = new System.Drawing.Size(33, 33);
            this.pbAddIdentity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddIdentity.TabIndex = 17;
            this.pbAddIdentity.TabStop = false;
            this.pbAddIdentity.Click += new System.EventHandler(this.pbAddIdentity_Click);
            // 
            // pbAddFamilyRelation
            // 
            this.pbAddFamilyRelation.Image = global::Hotel.Properties.Resources.add;
            this.pbAddFamilyRelation.Location = new System.Drawing.Point(437, 32);
            this.pbAddFamilyRelation.Name = "pbAddFamilyRelation";
            this.pbAddFamilyRelation.Size = new System.Drawing.Size(33, 33);
            this.pbAddFamilyRelation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddFamilyRelation.TabIndex = 16;
            this.pbAddFamilyRelation.TabStop = false;
            this.pbAddFamilyRelation.Click += new System.EventHandler(this.pbAddFamilyRelation_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.Location = new System.Drawing.Point(533, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Is Block :";
            // 
            // chcNo
            // 
            this.chcNo.AutoSize = true;
            this.chcNo.Location = new System.Drawing.Point(658, 41);
            this.chcNo.Name = "chcNo";
            this.chcNo.Size = new System.Drawing.Size(49, 20);
            this.chcNo.TabIndex = 14;
            this.chcNo.Text = "NO";
            this.chcNo.UseVisualStyleBackColor = true;
            // 
            // chcYes
            // 
            this.chcYes.AutoSize = true;
            this.chcYes.Checked = true;
            this.chcYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcYes.Location = new System.Drawing.Point(723, 41);
            this.chcYes.Name = "chcYes";
            this.chcYes.Size = new System.Drawing.Size(56, 20);
            this.chcYes.TabIndex = 13;
            this.chcYes.Text = "YES";
            this.chcYes.UseVisualStyleBackColor = true;
            // 
            // cbbIdentity
            // 
            this.cbbIdentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIdentity.FormattingEnabled = true;
            this.cbbIdentity.Location = new System.Drawing.Point(201, 85);
            this.cbbIdentity.Name = "cbbIdentity";
            this.cbbIdentity.Size = new System.Drawing.Size(196, 24);
            this.cbbIdentity.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(95, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Identity :";
            // 
            // cbbFamilyRelation
            // 
            this.cbbFamilyRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFamilyRelation.FormattingEnabled = true;
            this.cbbFamilyRelation.Location = new System.Drawing.Point(201, 36);
            this.cbbFamilyRelation.Name = "cbbFamilyRelation";
            this.cbbFamilyRelation.Size = new System.Drawing.Size(196, 24);
            this.cbbFamilyRelation.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(20, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "FamilyRelation :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(546, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 61);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnSave.Location = new System.Drawing.Point(752, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 61);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddOrUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 597);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbPersonal);
            this.Name = "frmAddOrUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdateCustomer";
            this.Load += new System.EventHandler(this.frmAddOrUpdateCustomer_Load);
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddIdentity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFamilyRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBrithDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFristName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbIdentity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbFamilyRelation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chcNo;
        private System.Windows.Forms.CheckBox chcYes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbAddIdentity;
        private System.Windows.Forms.PictureBox pbAddFamilyRelation;
    }
}