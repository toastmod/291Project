using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCustomerManagement : UserControl
    // Accessed through EmpMainMenu
    // Provides a view into the Customer database, allows management and search of users. 
    // Dynamic filters are added by the user, and programatically added to the query used for the dataview.
    {

        public DataTable avail_dt = new();        // Shows data from DB
        public SqlDataReader reader = null;       // Receives data from DB
        public EmpAddCustomer AddCustomer = null; // WF for adding a customer
        bool customer_id_filter;                  // Turns true when ID field is filled and valid 
        bool c_name_filter;                       // Turns true when name field is filled and valid. 
        bool terminated_member_view;              // Turns true when "Show Terminated Customers" checkbox is checked.

        public EmpCustomerManagement()
        {
            InitializeComponent();
            customer_id_filter = false;
            c_name_filter = false;
            terminated_member_view = false;
            reader = DBridge.run_query(query: GenQueryStr()); // Run Base query. All customers sans terminated members.
            reader = DBridge.run_query(GenQueryStr());
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;           // Show results in DataView.
            CustomerDataView.Rows[0].Selected = false;        // Added to prevent autoselection of first row.
        }

        private string GenQueryStr()
        {
            string query = "select c.customer_id, concat(first_name, ' ', last_name) as \"name\", mt.rank as \"membership\", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  from customers c, membershiptype mt WHERE c.membership_type = mt.membership_id";

            // Check filter bools and apply proper text to base query if true.
            if (customer_id_filter)
            {
                query += $" AND c.customer_id = {Program.ExtractLeadingNumbers(CustomerIDFilter.Text)}";
            }
            if (!terminated_member_view)
            {
                query += " AND c.membership_type != 0";
            }
            if (c_name_filter)
            {
                query += $" AND (first_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%' OR last_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%')";
            }

            return query;
        }

        private void DelCustBtn_Click(object sender, EventArgs e)
        // Allows Employee to terminate Customer accounts. 
        // Sets their membership_id to 0, e.g. Terminated
        {
            if (CustomerDataView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // if no customer selected
            {
                MessageBox.Show("Please select a customer to terminate.", "Terminate Membership");
            }
            else
            {
                string customerID = GetCustomerID();
                string customerName = GetCustomerName();
                if (CustomerAlreadyTerminated(customerID, customerName))
                {
                    MessageBox.Show($"{customerName}'s membership is already terminated.");
                    return; // Stop stop they're already dead!!
                }
                // Otherwise show confirmation box
                DialogResult result1 = MessageBox.Show($"Are you sure you would like to deactivate Customer: {customerName}?\n\nWARNING: THERE IS NO WAY TO REVERSE TERMINATION",
                                                       "Confirm Member Termination",
                                                       MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    DelCustomer(customerID); // Assign their membership type to 0
                }
            }

        }

        private static bool CustomerAlreadyTerminated(string customerID, string customerName)
        // Helper function to check Customer Membership Status, returns true if already terminated.
        {
            string membershipstatus = GetCustomerMemberStatus(customerID);
            if (membershipstatus == "0")
            {
                return true; // Can't terminate whats already terminated!
            }
            return false; // Customer account active
        }

        private static string GetCustomerMemberStatus(string customerID)
        // Helper function for CustomerAlready Terminated, checks Customer Status and returns it in String format.
        {
            SqlDataReader reader = DBridge.run_query($"SELECT membership_type FROM Customers WHERE customer_ID = {customerID}");
            string membershipstatus = "null";

            if (reader.Read())
            {
                membershipstatus = (reader[0].ToString());
            }
            return membershipstatus;
        }

        private string GetCustomerID()
        // Takes in selected row and gets the value from Customer_ID field.
        {
            int selectedrowindex = CustomerDataView.SelectedCells[0].RowIndex; // Get row index 
            DataGridViewRow selectedRow = CustomerDataView.Rows[selectedrowindex]; // get row
            string cellValue = Convert.ToString(selectedRow.Cells["Customer_ID"].Value); // Get Customer ID
            return cellValue;
        }

        private string GetCustomerName()
        // Takes in selected row and gets the value from Name field.
        {
            int selectedrowindex = CustomerDataView.SelectedCells[0].RowIndex; // Get row index 
            DataGridViewRow selectedRow = CustomerDataView.Rows[selectedrowindex]; // get row
            string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value); // Get Customer ID
            return cellValue;
        }

        private void DelCustomer(string customer_id)
        // Helper to set selected Customer's membership type to 0, e.g. Terminated.
        {
            DBridge.run_query($"UPDATE Customers SET membership_type = 0 WHERE customer_ID = {customer_id}");
            RefreshView();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        // Brings up Add Customer form to fill out, logs data, submits to database.
        {
            if (AddCustomer == null) // if not created, create new form.
            {
                AddCustomer = new EmpAddCustomer();
            }
            else
            {
                AddCustomer.BringToFront(); // Brings prompt to front if window open and user presses btn again
            }

            try // horrible hacky method to create a new instance if user closed EmpAddCustomer window with 'X'.
            {
                AddCustomer.Show();
            }
            catch
            {
                AddCustomer = new EmpAddCustomer();
                AddCustomer.Show();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void RefreshView()
        {
            reader.Close();
            reader = DBridge.run_query(GenQueryStr());
            avail_dt.Clear();
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;
            if (CustomerDataView.Rows.Count != 0)
            {
                CustomerDataView.CurrentRow.Selected = false;
            }



        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private static bool IdIsValid(String id)
        // Helper for CusIdFilter_TextChanged, checks textbox field for leading integers.
        {
            id = Program.ExtractLeadingNumbers(id);
            if (string.IsNullOrEmpty(id)) { return false; }
            else { return true; }
        }

        private void CusIDFilter_TextChanged(object sender, EventArgs e)
        // Checks validity of textbox, if true: turns customer_id_filter on. Otherwise turns off customer_id_filter.
        {
            if (IdIsValid(CustomerIDFilter.Text))
            {
                customer_id_filter = true;
            }
            else { customer_id_filter = false; }
        }

        private void ShowTermMemBox_CheckedChanged(object sender, EventArgs e)
        // Checks "Show Terminated Customers" box for status, sets filter accordingly.
        {
            if (ShowTermMemBox.Checked) { terminated_member_view = true; }
            else { terminated_member_view = false; }

        }

        private void CusNameFilter_TextChanged(object sender, EventArgs e)
        // Checks validity of textbox, if true: turns c_name_filter  on. Otherwise turns off n_name_filter.
        {
            if (Program.SanitizeTextInput(CusNameFilter.Text).Length > 0) // if name valid after sanitization
            {
                c_name_filter = true; // Turn on the customer name filter
            }
            else
            {
                c_name_filter = false;
            }

        }

        public bool GoBack()
        {
            // if the Add Customer window is open, close it.
            if(AddCustomer != null){
                AddCustomer.Close();
            }

            // hide this UC
            this.Hide();
            this.Enabled = false;

            return true;
        }
    }
}
