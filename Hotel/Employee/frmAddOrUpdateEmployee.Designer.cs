namespace Hotel.Employee
{
    partial class frmAddOrUpdateEmployee
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbLinRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lbLinImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chcNo = new System.Windows.Forms.CheckBox();
            this.chcYes = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbbDepartments = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonal.SuspendLayout();
            this.gbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(243, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(448, 54);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Add New Employee";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(570, 757);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 61);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnSave.Location = new System.Drawing.Point(776, 757);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.gbPersonal.Location = new System.Drawing.Point(76, 91);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(863, 204);
            this.gbPersonal.TabIndex = 12;
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
            this.txtNationalNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
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
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.label6);
            this.gbEmployee.Controls.Add(this.txtAddress);
            this.gbEmployee.Controls.Add(this.lbLinRemoveImage);
            this.gbEmployee.Controls.Add(this.lbLinImage);
            this.gbEmployee.Controls.Add(this.pbImage);
            this.gbEmployee.Controls.Add(this.label9);
            this.gbEmployee.Controls.Add(this.label8);
            this.gbEmployee.Controls.Add(this.chcNo);
            this.gbEmployee.Controls.Add(this.chcYes);
            this.gbEmployee.Controls.Add(this.txtPhone);
            this.gbEmployee.Controls.Add(this.cbbDepartments);
            this.gbEmployee.Controls.Add(this.label7);
            this.gbEmployee.Controls.Add(this.lbPassword);
            this.gbEmployee.Controls.Add(this.txtPassword);
            this.gbEmployee.Controls.Add(this.l);
            this.gbEmployee.Controls.Add(this.txtUserName);
            this.gbEmployee.Location = new System.Drawing.Point(76, 313);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(863, 426);
            this.gbEmployee.TabIndex = 13;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Employee Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(53, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(169, 311);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(642, 91);
            this.txtAddress.TabIndex = 15;
            // 
            // lbLinRemoveImage
            // 
            this.lbLinRemoveImage.AutoSize = true;
            this.lbLinRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbLinRemoveImage.Location = new System.Drawing.Point(628, 263);
            this.lbLinRemoveImage.Name = "lbLinRemoveImage";
            this.lbLinRemoveImage.Size = new System.Drawing.Size(161, 26);
            this.lbLinRemoveImage.TabIndex = 14;
            this.lbLinRemoveImage.TabStop = true;
            this.lbLinRemoveImage.Text = "Remove Image";
            this.lbLinRemoveImage.Visible = false;
            this.lbLinRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinRemoveImage_LinkClicked);
            // 
            // lbLinImage
            // 
            this.lbLinImage.AutoSize = true;
            this.lbLinImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbLinImage.Location = new System.Drawing.Point(655, 18);
            this.lbLinImage.Name = "lbLinImage";
            this.lbLinImage.Size = new System.Drawing.Size(112, 26);
            this.lbLinImage.TabIndex = 11;
            this.lbLinImage.TabStop = true;
            this.lbLinImage.Text = "Set Image";
            this.lbLinImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Hotel.Properties.Resources.personHolder;
            this.pbImage.Location = new System.Drawing.Point(605, 53);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(206, 193);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.Location = new System.Drawing.Point(56, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Is Block :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label8.Location = new System.Drawing.Point(67, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone :";
            // 
            // chcNo
            // 
            this.chcNo.AutoSize = true;
            this.chcNo.Location = new System.Drawing.Point(181, 226);
            this.chcNo.Name = "chcNo";
            this.chcNo.Size = new System.Drawing.Size(49, 20);
            this.chcNo.TabIndex = 10;
            this.chcNo.Text = "NO";
            this.chcNo.UseVisualStyleBackColor = true;
            // 
            // chcYes
            // 
            this.chcYes.AutoSize = true;
            this.chcYes.Checked = true;
            this.chcYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcYes.Location = new System.Drawing.Point(246, 226);
            this.chcYes.Name = "chcYes";
            this.chcYes.Size = new System.Drawing.Size(56, 20);
            this.chcYes.TabIndex = 9;
            this.chcYes.Text = "YES";
            this.chcYes.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(176, 171);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 22);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // cbbDepartments
            // 
            this.cbbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartments.FormattingEnabled = true;
            this.cbbDepartments.Location = new System.Drawing.Point(176, 124);
            this.cbbDepartments.Name = "cbbDepartments";
            this.cbbDepartments.Size = new System.Drawing.Size(228, 24);
            this.cbbDepartments.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.Location = new System.Drawing.Point(16, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Department :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbPassword.Location = new System.Drawing.Point(34, 83);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(120, 26);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 87);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(228, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.l.Location = new System.Drawing.Point(25, 43);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(129, 26);
            this.l.TabIndex = 1;
            this.l.Text = "UserName :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(176, 48);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(228, 22);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddOrUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 836);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmAddOrUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdateEmployee";
            this.Load += new System.EventHandler(this.frmAddOrUpdateEmployee_Load);
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFristName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBrithDay;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cbbDepartments;
        private System.Windows.Forms.LinkLabel lbLinImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chcNo;
        private System.Windows.Forms.CheckBox chcYes;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLinRemoveImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
    }
}