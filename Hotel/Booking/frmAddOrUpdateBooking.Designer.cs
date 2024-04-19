namespace Hotel.Booking
{
    partial class frmAddOrUpdateBooking
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
            this.lbFormHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAddDAte = new System.Windows.Forms.DateTimePicker();
            this.ctrCustomerCardFilter6 = new Hotel.Customer.Controller.ctrCustomerCardFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFormHeader
            // 
            this.lbFormHeader.AutoSize = true;
            this.lbFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormHeader.ForeColor = System.Drawing.Color.Red;
            this.lbFormHeader.Location = new System.Drawing.Point(277, 40);
            this.lbFormHeader.Name = "lbFormHeader";
            this.lbFormHeader.Size = new System.Drawing.Size(408, 54);
            this.lbFormHeader.TabIndex = 32;
            this.lbFormHeader.Text = "Add New Booking";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnClose.Location = new System.Drawing.Point(567, 695);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 61);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnSave.Location = new System.Drawing.Point(765, 695);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 61);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalPayment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFirstPayment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpOutDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpAddDAte);
            this.groupBox1.Location = new System.Drawing.Point(25, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 176);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(450, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Payment :";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Enabled = false;
            this.txtTotalPayment.Location = new System.Drawing.Point(634, 51);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(200, 22);
            this.txtTotalPayment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(33, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Payment :";
            // 
            // txtFirstPayment
            // 
            this.txtFirstPayment.Enabled = false;
            this.txtFirstPayment.Location = new System.Drawing.Point(205, 125);
            this.txtFirstPayment.Name = "txtFirstPayment";
            this.txtFirstPayment.Size = new System.Drawing.Size(200, 22);
            this.txtFirstPayment.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(81, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Out Date :";
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(205, 85);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(200, 22);
            this.dtpOutDate.TabIndex = 2;
            this.dtpOutDate.ValueChanged += new System.EventHandler(this.dtpOutDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(77, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Date :";
            // 
            // dtpAddDAte
            // 
            this.dtpAddDAte.Enabled = false;
            this.dtpAddDAte.Location = new System.Drawing.Point(205, 49);
            this.dtpAddDAte.Name = "dtpAddDAte";
            this.dtpAddDAte.Size = new System.Drawing.Size(200, 22);
            this.dtpAddDAte.TabIndex = 0;
            // 
            // ctrCustomerCardFilter6
            // 
            this.ctrCustomerCardFilter6.changeFilterState = true;
            this.ctrCustomerCardFilter6.Location = new System.Drawing.Point(12, 97);
            this.ctrCustomerCardFilter6.Name = "ctrCustomerCardFilter6";
            this.ctrCustomerCardFilter6.Size = new System.Drawing.Size(938, 401);
            this.ctrCustomerCardFilter6.TabIndex = 0;
            this.ctrCustomerCardFilter6.onCustomerSearch += new System.Action<int>(this.customerCardFilter6_onCustomerSearch);
            this.ctrCustomerCardFilter6.onAddNewCustomer += new System.Action<int>(this.customerCardFilter6_onAddNewCustomer);
            // 
            // frmAddOrUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 773);
            this.Controls.Add(this.ctrCustomerCardFilter6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFormHeader);
            this.Name = "frmAddOrUpdateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdateBooking";
            this.Load += new System.EventHandler(this.frmAddOrUpdateBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormHeader;
        private Customer.Controller.ctrCustomerCardFilter customerCardFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAddDAte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private Customer.Controller.ctrCustomerCardFilter customerCardFilter2;
        private Customer.Controller.ctrCustomerCardFilter customerCardFilter3;
        private Customer.Controller.ctrCustomerCardFilter customerCardFilter4;
        private Customer.Controller.ctrCustomerCardFilter customerCardFilter5;
        private Customer.Controller.ctrCustomerCardFilter ctrCustomerCardFilter6;
    }
}