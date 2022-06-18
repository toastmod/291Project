namespace _291Project
{
    partial class EmpCusManagementFilter
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
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.License = new System.Windows.Forms.TextBox();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.FilterSubmitBtn = new System.Windows.Forms.Button();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.MembershipTypeLabel = new System.Windows.Forms.Label();
            this.membershipType = new System.Windows.Forms.ComboBox();
            this.FilterHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gender.Location = new System.Drawing.Point(136, 253);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(148, 25);
            this.Gender.TabIndex = 7;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // GenderLabel
            // 
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.Location = new System.Drawing.Point(67, 253);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(141, 30);
            this.GenderLabel.TabIndex = 51;
            this.GenderLabel.Text = "Gender:";
            // 
            // License
            // 
            this.License.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.License.Location = new System.Drawing.Point(136, 223);
            this.License.Margin = new System.Windows.Forms.Padding(2);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(148, 25);
            this.License.TabIndex = 7;
            this.License.TextChanged += new System.EventHandler(this.License_TextChanged);
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LicenseLabel.Location = new System.Drawing.Point(9, 223);
            this.LicenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(141, 30);
            this.LicenseLabel.TabIndex = 50;
            this.LicenseLabel.Text = "Driver\'s License #:";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(136, 194);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(148, 25);
            this.Email.TabIndex = 6;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(73, 194);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(141, 30);
            this.EmailLabel.TabIndex = 49;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // DOB
            // 
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(136, 166);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(148, 23);
            this.DOB.TabIndex = 5;
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 48;
            this.label7.Text = "DOB:";
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(136, 337);
            this.City.Margin = new System.Windows.Forms.Padding(2);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(148, 23);
            this.City.TabIndex = 10;
            this.City.TextChanged += new System.EventHandler(this.City_TextChanged);
            // 
            // Province
            // 
            this.Province.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.Location = new System.Drawing.Point(136, 310);
            this.Province.Margin = new System.Windows.Forms.Padding(2);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(148, 23);
            this.Province.TabIndex = 9;
            this.Province.TextChanged += new System.EventHandler(this.Province_TextChanged);
            // 
            // postalcode
            // 
            this.postalcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalcode.Location = new System.Drawing.Point(136, 283);
            this.postalcode.Margin = new System.Windows.Forms.Padding(2);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(148, 23);
            this.postalcode.TabIndex = 8;
            this.postalcode.TextChanged += new System.EventHandler(this.postalcode_TextChanged);
            // 
            // FilterSubmitBtn
            // 
            this.FilterSubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.FilterSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterSubmitBtn.Location = new System.Drawing.Point(67, 416);
            this.FilterSubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FilterSubmitBtn.Name = "FilterSubmitBtn";
            this.FilterSubmitBtn.Size = new System.Drawing.Size(172, 35);
            this.FilterSubmitBtn.TabIndex = 43;
            this.FilterSubmitBtn.Text = "Submit Filters...";
            this.FilterSubmitBtn.UseVisualStyleBackColor = false;
            this.FilterSubmitBtn.Click += new System.EventHandler(this.SubmitFilterBtn);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNum.Location = new System.Drawing.Point(136, 364);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(148, 23);
            this.PhoneNum.TabIndex = 11;
            this.PhoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(136, 136);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(148, 25);
            this.LastName.TabIndex = 4;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(136, 107);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(148, 25);
            this.FirstName.TabIndex = 3;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last.Location = new System.Drawing.Point(47, 136);
            this.last.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(141, 30);
            this.last.TabIndex = 27;
            this.last.Text = "Last Name:";
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first.Location = new System.Drawing.Point(47, 106);
            this.first.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(141, 30);
            this.first.TabIndex = 26;
            this.first.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Postal Code:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 47;
            this.label5.Text = "City:";
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerID.Location = new System.Drawing.Point(136, 78);
            this.customerID.Margin = new System.Windows.Forms.Padding(2);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(148, 25);
            this.customerID.TabIndex = 2;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerIdLabel.Location = new System.Drawing.Point(47, 77);
            this.customerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(141, 30);
            this.customerIdLabel.TabIndex = 52;
            this.customerIdLabel.Text = "CustomerID:";
            // 
            // MembershipTypeLabel
            // 
            this.MembershipTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MembershipTypeLabel.Location = new System.Drawing.Point(13, 48);
            this.MembershipTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MembershipTypeLabel.Name = "MembershipTypeLabel";
            this.MembershipTypeLabel.Size = new System.Drawing.Size(141, 30);
            this.MembershipTypeLabel.TabIndex = 54;
            this.MembershipTypeLabel.Text = "Membership Type:";
            // 
            // membershipType
            // 
            this.membershipType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membershipType.FormattingEnabled = true;
            this.membershipType.Items.AddRange(new object[] {
            "Member",
            "Gold Member",
            "Terminated"});
            this.membershipType.Location = new System.Drawing.Point(136, 48);
            this.membershipType.Name = "membershipType";
            this.membershipType.Size = new System.Drawing.Size(148, 25);
            this.membershipType.TabIndex = 0;
            this.membershipType.SelectedIndexChanged += new System.EventHandler(this.membershipType_SelectedIndexChanged);
            // 
            // FilterHeaderLabel
            // 
            this.FilterHeaderLabel.AutoSize = true;
            this.FilterHeaderLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FilterHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.FilterHeaderLabel.Location = new System.Drawing.Point(13, 9);
            this.FilterHeaderLabel.Name = "FilterHeaderLabel";
            this.FilterHeaderLabel.Size = new System.Drawing.Size(283, 24);
            this.FilterHeaderLabel.TabIndex = 57;
            this.FilterHeaderLabel.Text = "Only Filled Fields Will Be Used";
            this.FilterHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmpCusManagementFilter
            // 
            this.AcceptButton = this.FilterSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(205)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(308, 462);
            this.Controls.Add(this.FilterHeaderLabel);
            this.Controls.Add(this.membershipType);
            this.Controls.Add(this.MembershipTypeLabel);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.License);
            this.Controls.Add(this.LicenseLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.FilterSubmitBtn);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "EmpCusManagementFilter";
            this.Text = "Customer Filter Options";
            this.Load += new System.EventHandler(this.EmpCusManagementFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox License;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Province;
        private System.Windows.Forms.TextBox postalcode;
        private System.Windows.Forms.Button FilterSubmitBtn;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label MembershipTypeLabel;
        private System.Windows.Forms.ComboBox membershipType;
        private System.Windows.Forms.Label FilterHeaderLabel;
    }
}