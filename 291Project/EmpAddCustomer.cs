using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpAddCustomer
    {

        public SqlDataReader dr = null;
        bool first_valid = false;
        bool last_valid = false;
        bool dob_valid = false;
        bool email_valid = false;
        bool license_valid = false;
        bool gender_valid = false;
        bool line1_valid = false;
        bool line2_valid = false;
        bool postcode_valid = false;
        bool prov_valid = false;
        bool city_valid = false;
        bool phonenum_valid = false;

        String FirstFmtd = String.Empty;
        String LastFmtd = String.Empty;
        String DobFmtd = String.Empty;
        String EmailFmtd = String.Empty;
        String LicenseFmtd = String.Empty;
        String Line1Fmtd = String.Empty;
        String Line2Fmtd = String.Empty;
        String PostFmtd = String.Empty;
        String ProvFmtd = String.Empty;
        String CityFmtd = String.Empty;
        String PhoneNumFmtd = String.Empty;

        public EmpAddCustomer()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {



        }

        private int GetCustomerID(object sender, EventArgs e)
        {
            String cmd = "SELECT MAX(Customer_ID) FROM Customers";
            String StringCustomerID;



            using (SqlDataReader dr = DBridge.run_query(cmd))
            {
                while (dr.Read())
                {
                    StringCustomerID = dr[0].ToString();
                    int CID = Convert.ToInt32(StringCustomerID);
                    return CID;
                }
            }
            return -1;
        }

        private bool AllFieldsValid()
        {
            //CREATE TABLE IF NOT EXISTS Customers (
            //customer_ID INT NOT NULL PRIMARY KEY,
            //first_name VARCHAR(255) NOT NULL,
            //last_name VARCHAR(255) NOT NULL,
            //email VARCHAR(255) NOT NULL,
            //dob DATE NOT NULL,
            //membership_type int FOREIGN KEY REFERENCES MembershipType(Membership_ID)
            //gender VARCHAR(255),
            //driver_license_no VARCHAR(255),
            //phone_number VARCHAR(15) NOT NULL,
            //address_1 VARCHAR(255) NOT NULL,
            //address_2 VARCHAR(255),
            //city VARCHAR(255) NOT NULL,
            //postal_code VARCHAR(10) NOT NULL,
            //province VARCHAR(2) NOT NULL)


            if (first_valid && last_valid && dob_valid && email_valid && license_valid && gender_valid && line1_valid && line2_valid && postcode_valid && prov_valid && city_valid && phonenum_valid)
            {
                return true;
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled\n(Address 2 Optional)", "Failed to Add Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        private void create_Click_1(object sender, EventArgs e)
        {
            // Check fields to make sure they're filled.
            // Submit to Database
            // Close window


            // List of Textboxes:
            // FirstName
            // LastName
            // line1 (address 1)
            // line2 (address 2)
            // postalcode
            // Province
            // City
            // PhoneNum

            // Checking that all necessary fields filled.
            if (!AllFieldsValid()) { return; }
            // 
            int CID = GetCustomerID(sender, e);

            String AddCustomerQuery = $"INSERT INTO Customers (customer_ID, membership_type, first_name, last_name, email, dob, gender, driver_license_no, phone_number, address_1, address_2, city, postal_code, province) VALUES ({CID + 1}, 1, '{FirstFmtd}', '{LastFmtd}', '{EmailFmtd}', '{DOB.Text}', '{Gender.Text}', '{LicenseFmtd}', '{PhoneNumFmtd}', '{Line1Fmtd}', '{Line2Fmtd}', '{CityFmtd}', '{PostFmtd}', '{Province.Text}');";

            DBridge.run_query(AddCustomerQuery);


            //MessageBox.Show(s);
            this.Close();

        }

        private bool PhoneNumValidCheck(String s)
        {
            PhoneNumFmtd = Regex.Replace(s, "[^0-9]", "");
            if (PhoneNumFmtd.Length == 0 || PhoneNumFmtd.Length > 15)
            {
                return false;
            }
            return true;
        }
        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumValidCheck(PhoneNum.Text))
            {
                phonenum_valid = true;
            }
            else phonenum_valid = false;

        }
        private bool FirstValidCheck(String s)
        {
            FirstFmtd = Regex.Replace(s, "[^a-zA-Z -]", "");
            if (FirstFmtd.Length == 0 || FirstFmtd.Length > 250)
            {
                return false;
            }
            return true;
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            if (FirstValidCheck(FirstName.Text))
            {
                first_valid = true;
            }
            else first_valid = false;

        }

        private void last_Click(object sender, EventArgs e)
        {

        }

        private bool Line1ValidCheck(String s)
        {
            Line1Fmtd = Regex.Replace(s, "[^a-zA-Z0-9 -]", "");
            if (Line1Fmtd.Length == 0 || Line1Fmtd.Length > 250)
            {
                return false;
            }
            return true;

        }

        private void line1_TextChanged(object sender, EventArgs e)
        {
            if (Line1ValidCheck(line1.Text))
            {
                line1_valid = true;
            }
            else line1_valid = false;
        }
        private bool Line2ValidCheck(String s)
        {
            Line2Fmtd = Regex.Replace(s, "[^a-zA-Z0-9 -]", "");
            if (Line2Fmtd.Length == 0 || Line2Fmtd.Length > 250)
            {
                return false;
            }
            return true;

        }

        private void line2_TextChanged(object sender, EventArgs e)
        {
            if (Line2ValidCheck(line1.Text))
            {
                line2_valid = true;
            }
            else line2_valid = false;

        }

        private bool PostalValidCheck(String s)
        {
            PostFmtd = Regex.Replace(s, "[^a-zA-Z0-9\\s -]", "");
            if (PostFmtd.Length == 0 || PostFmtd.Length > 7)
            {
                return false;
            }
            return true;
        }

        private bool ProvValidCheck(String s)
        {
            ProvFmtd = Regex.Replace(s, "[^a-zA-Z -]", "");
            if (ProvFmtd.Length == 0 || ProvFmtd.Length > 2)
            {
                return false;
            }
            return true;
        }

        private void postalcode_TextChanged(object sender, EventArgs e)
        {
            if (PostalValidCheck(postalcode.Text))
            {
                postcode_valid = true;
            }
            else postcode_valid = false;
        }
        private bool CityValidCheck(String s)
        {
            CityFmtd = Regex.Replace(s, "[^a-zA-Z -]", "");
            if (CityFmtd.Length == 0 || CityFmtd.Length > 200)
            {
                return false;
            }
            return true;
        }

        private void City_TextChanged(object sender, EventArgs e)
        {
            if (CityValidCheck(City.Text))
            {
                city_valid = true;
            }
            else city_valid = false;

        }

        private void CSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private bool LastValidCheck(String s)
        {
            LastFmtd = Regex.Replace(s, "[^a-zA-Z -]", "");
            if (LastFmtd.Length == 0 || LastFmtd.Length > 250)
            {
                return false;
            }
            return true;
        }
        private void LastName_TextChanged(object sender, EventArgs e)
        {
            if (LastValidCheck(LastName.Text))
            {
                last_valid = true;
            }
            else last_valid = false;

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            dob_valid = true;
            DobFmtd = DOB.Text;
        }

        public bool EmailValidCheck(string emailaddress)
        {
            //https://stackoverflow.com/questions/5342375/regex-email-validation
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                EmailFmtd = m.Address;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void Email_TextChanged(object sender, EventArgs e)
        {

            if (EmailValidCheck(Email.Text))
            {
                email_valid = true;
            }
            else email_valid = false;

        }
        private bool LicenseValidCheck(String s)
        {
            LicenseFmtd = Regex.Replace(s, "[^0-9]", "");
            if (LicenseFmtd.Length == 0 || LicenseFmtd.Length > 30)
            {
                return false;
            }
            return true;
        }

        private void License_TextChanged(object sender, EventArgs e)
        {
            if (LicenseValidCheck(License.Text))
            {
                license_valid = true;
            }
            else license_valid = false;

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Gender.SelectedIndex != -1)
            {
                gender_valid = true;
            }
            else gender_valid = false;
        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Province.SelectedIndex != -1)
            {
                prov_valid = true;
            }
            else prov_valid = false;
        }

        private void ClearAllFields()
        {
            FirstName.Clear();
            LastName.Clear();
            DOB.Refresh();
            Email.Clear();
            License.Clear();
            line1.Clear();
            line2.Clear();
            postalcode.Clear();
            Province.Refresh();
            City.Clear();
            PhoneNum.Clear();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            Hide();
        }
    }
}