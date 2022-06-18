using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCustomerManagement : UserControl
    {

        public DataTable avail_dt = new();
        public SqlDataReader reader = null;
        public EmpAddCustomer AddCustomer = null;
        bool customer_id_search;
        bool customer_name_search;
        bool terminated_member_view;

        public EmpCustomerManagement()
        {
            InitializeComponent();
            customer_id_search = false;
            customer_name_search = false;
            terminated_member_view = false;
            reader = DBridge.run_query(query: GenQueryStr());
            reader = DBridge.run_query(GenQueryStr());
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;
            CustomerDataView.Rows[0].Selected = false;
        }

        private string GenQueryStr()
        {
            string query = "select c.customer_id, concat(first_name, ' ', last_name) as \"name\", mt.rank as \"membership\", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  from customers c, membershiptype mt WHERE c.membership_type = mt.membership_id";

            // Add customerID and terminated customer filters
            if (!terminated_member_view)
            {
                query += " AND c.membership_type != 0";
            }
            if (customer_id_search)
            {
                query += $" AND c.customer_id = {Program.ExtractLeadingNumbers(CustomerIDFilter.Text)}";
            }
            if (customer_name_search)
            {
                query += $" AND (first_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%' OR last_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%')";
                Program.debug(query);
            }

            return query;
        }

        private void DelCustBtn_Click(object sender, EventArgs e)
        {
            int selectedRowCount =
          CustomerDataView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a customer to terminate.", "Terminate Membership");
            }

            else
            {
                string customerID = GetCustomerID();
                string customerName = GetCustomerName();
                if (CustomerAlreadyTerminated(customerID, customerName))
                {
                    return; // Stop stop they're already dead!!
                }
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
        {
            string membershipstatus = GetCustomerMemberStatus(customerID);
            if (membershipstatus == "0")
            {
                MessageBox.Show($"{customerName}'s membership is already terminated.");
                return true; // Can't terminate whats already terminated!
            }
            return false; // Customer account active
        }

        private static string GetCustomerMemberStatus(string customerID)
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
        {
            int selectedrowindex = CustomerDataView.SelectedCells[0].RowIndex; // Get row index 
            DataGridViewRow selectedRow = CustomerDataView.Rows[selectedrowindex]; // get row
            string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value); // Get Customer ID
            return cellValue;
        }

        private void DelCustomer(string customer_id)
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
            CustomerDataView.CurrentRow.Selected = false;


        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private static bool IdIsValid(String id)
        {
            id = Program.ExtractLeadingNumbers(id);
            if (string.IsNullOrEmpty(id)) { return false; }
            else { return true; }
        }

        private void CusIDFilter_TextChanged(object sender, EventArgs e)
        {
            if (IdIsValid(CustomerIDFilter.Text))
            {
                customer_id_search = true;
            }
            else { customer_id_search = false; }
        }

        private void ShowTermMemBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowTermMemBox.Checked) { terminated_member_view = true; }
            else { terminated_member_view = false; }

        }

        private void CusNameFilter_TextChanged(object sender, EventArgs e)
        {
            if (Program.SanitizeTextInput(CusNameFilter.Text).Length > 0) // if name valid after sanitization
            {
                customer_name_search = true;
            }
            else
            {
                customer_name_search = false;
            }

        }
    }
}
