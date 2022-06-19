using System.Windows.Forms;
namespace _291Project
{
    partial class EmpAddCustomer : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpAddCustomer));
            this.first = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.SubmitCustomerBtn = new System.Windows.Forms.Button();
            this.line2 = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.License = new System.Windows.Forms.TextBox();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Province = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first.Location = new System.Drawing.Point(55, 9);
            this.first.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(141, 30);
            this.first.TabIndex = 0;
            this.first.Text = "First Name:";
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last.Location = new System.Drawing.Point(55, 39);
            this.last.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(141, 30);
            this.last.TabIndex = 1;
            this.last.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(144, 6);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(148, 23);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(144, 36);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(148, 23);
            this.LastName.TabIndex = 2;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // line1
            // 
            this.line1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line1.Location = new System.Drawing.Point(144, 210);
            this.line1.Margin = new System.Windows.Forms.Padding(2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(148, 23);
            this.line1.TabIndex = 7;
            this.line1.TextChanged += new System.EventHandler(this.line1_TextChanged);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNum.Location = new System.Drawing.Point(144, 350);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(148, 23);
            this.PhoneNum.TabIndex = 12;
            this.PhoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // address_label
            // 
            this.address_label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.Location = new System.Drawing.Point(21, 195);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(113, 30);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "Address:";
            // 
            // SubmitCustomerBtn
            // 
            this.SubmitCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitCustomerBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitCustomerBtn.Location = new System.Drawing.Point(21, 420);
            this.SubmitCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitCustomerBtn.Name = "SubmitCustomerBtn";
            this.SubmitCustomerBtn.Size = new System.Drawing.Size(126, 35);
            this.SubmitCustomerBtn.TabIndex = 13;
            this.SubmitCustomerBtn.Text = "Add Customer";
            this.SubmitCustomerBtn.UseVisualStyleBackColor = false;
            this.SubmitCustomerBtn.Click += new System.EventHandler(this.create_Click_1);
            // 
            // line2
            // 
            this.line2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line2.Location = new System.Drawing.Point(144, 238);
            this.line2.Margin = new System.Windows.Forms.Padding(2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(148, 23);
            this.line2.TabIndex = 8;
            this.line2.TextChanged += new System.EventHandler(this.line2_TextChanged);
            // 
            // postalcode
            // 
            this.postalcode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalcode.Location = new System.Drawing.Point(144, 265);
            this.postalcode.Margin = new System.Windows.Forms.Padding(2);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(148, 23);
            this.postalcode.TabIndex = 10;
            this.postalcode.TextChanged += new System.EventHandler(this.postalcode_TextChanged);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(144, 323);
            this.City.Margin = new System.Windows.Forms.Padding(2);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(148, 23);
            this.City.TabIndex = 11;
            this.City.TextChanged += new System.EventHandler(this.City_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Line 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line 2:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(84, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "DOB:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(144, 65);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(148, 23);
            this.DOB.TabIndex = 3;
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(144, 96);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(148, 23);
            this.Email.TabIndex = 4;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(81, 99);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(141, 30);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email:";
            // 
            // License
            // 
            this.License.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.License.Location = new System.Drawing.Point(144, 126);
            this.License.Margin = new System.Windows.Forms.Padding(2);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(148, 23);
            this.License.TabIndex = 5;
            this.License.TextChanged += new System.EventHandler(this.License_TextChanged);
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LicenseLabel.Location = new System.Drawing.Point(17, 129);
            this.LicenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(141, 30);
            this.LicenseLabel.TabIndex = 23;
            this.LicenseLabel.Text = "Driver\'s License #:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.Location = new System.Drawing.Point(75, 162);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(141, 30);
            this.GenderLabel.TabIndex = 25;
            this.GenderLabel.Text = "Gender:";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gender.Location = new System.Drawing.Point(144, 154);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(148, 26);
            this.Gender.TabIndex = 6;
            this.Gender.Text = " ";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(184, 420);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 35);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Province
            // 
            this.Province.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.FormattingEnabled = true;
            this.Province.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.Province.Location = new System.Drawing.Point(144, 292);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(148, 26);
            this.Province.TabIndex = 27;
            this.Province.Text = " ";
            this.Province.SelectedIndexChanged += new System.EventHandler(this.Province_SelectedIndexChanged);
            // 
            // EmpAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(320, 466);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.License);
            this.Controls.Add(this.LicenseLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.City);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.SubmitCustomerBtn);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCR - Add Customer";
            this.Load += new System.EventHandler(this.CSignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label first;
        private Label last;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox line1;
        private TextBox PhoneNum;
        private Label address_label;
        private Button SubmitCustomerBtn;
        private TextBox line2;
        private TextBox postalcode;
        private TextBox City;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker DOB;
        private TextBox Email;
        private Label EmailLabel;
        private TextBox License;
        private Label LicenseLabel;
        private Label GenderLabel;
        private ComboBox Gender;
        private Button CancelBtn;
        private ComboBox Province;
    }
}