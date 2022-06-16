using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpAddCustomer
    {

        public SqlDataReader dr = null;
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

        private bool FieldsValid()
        {
            // this code is awful and half completed. I'll come back to this.
            if (FirstName.Text.Length == 0 || LastName.Text.Length == 0 || line1.Text.Length == 0 || postalcode.Text.Length == 0 || City.Text.Length == 0 || Province.Text.Length == 0 || PhoneNum.Text.Length == 0)
            {
                MessageBox.Show("All Fields Must Be Filled\n(Address 2 Optional)", "Failed to Add Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (PhoneNum.Text.Length > 15)
            {
                MessageBox.Show("Phone Number Too Long (Max 15 Chars)", "Failed to Add Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (FirstName.Text.Length > 255)
            {
                MessageBox.Show("First Name Too Long (Max 255 Chars)", "Failed to Add Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (LastName.Text.Length > 255)
            {
                MessageBox.Show("Last Name Too Long (Max 255 Chars)", "Failed to Add Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;

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
            if (!FieldsValid()) { return; }
            // 
            int CID = GetCustomerID(sender, e);
            if (line2.Text.Length == 0)
            {
                line2.Text = "NULL"; //! Temporary. This doesn't work.
            };

            String AddCustomerQuery = $"INSERT INTO Customers (customer_ID, membership_type, first_name, last_name, email, dob, gender, driver_license_no, phone_number, address_1, address_2, city, postal_code, province) VALUES ({CID + 1}, 0, '{FirstName.Text}', '{LastName.Text}', '{Email.Text}', '{DOB.Text}', '{Gender.Text}', '{License.Text}', '{PhoneNum.Text}', '{line1.Text}', '{line2.Text}', '{City.Text}', '{postalcode.Text}', '{Province.Text}');";

            MessageBox.Show($"{AddCustomerQuery}", "Failed to Add Customer",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            ;
            DBridge.run_query(AddCustomerQuery);


            //MessageBox.Show(s);
            this.Close();

        }

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_Click(object sender, EventArgs e)
        {

        }

        private void line1_TextChanged(object sender, EventArgs e)
        {

        }

        private void line2_TextChanged(object sender, EventArgs e)
        {

        }

        private void postalcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Province_TextChanged(object sender, EventArgs e)
        {

        }

        private void City_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}