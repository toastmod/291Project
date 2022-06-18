using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCustomerManagement : UserControl
    {

        public DataTable avail_dt = new DataTable();
        public SqlDataReader reader = null;
        public EmpAddCustomer AddCustomer = null;
        public EmpCusManagementFilter FilterForm = null;
        public bool filters_on;

        public EmpCustomerManagement()
        {
            InitializeComponent();
            filters_on = false;
            reader = DBridge.run_query(query: GenQueryStr());
            reader = DBridge.run_query(GenQueryStr());
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;
            CustomerDataView.Rows[0].Selected = false;
        }

        private string GenQueryStr()
        {
            if (!filters_on)
            {
                return "select c.customer_id, concat(first_name, ' ', last_name) as \"name\", mt.rank as \"membership\", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  from customers c, membershiptype mt where c.membership_type = mt.membership_id";
            }
            else return FilteredQuery();
        }

        private string FilteredQuery()
        {
            string baseQuery = "select c.customer_id, concat(first_name, ' ', last_name) as \"name\", mt.rank as \"membership\", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  from customers c, membershiptype mt WHERE c.membership_type = mt.membership_id";

            // Check and process text boxes from FilterForm
            if (filters_on)
            {

            }

            return baseQuery;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private bool CustomerAlreadyTerminated(string customerID, string customerName)
        {
            string membershipstatus = GetCustomerMemberStatus(customerID);


            if (membershipstatus == "0")
            {
                MessageBox.Show($"{customerName}'s membership is already terminated.");
                return true; // Can't terminate whats already terminated!
            }
            return false; // Customer account active
        }

        private string GetCustomerMemberStatus(string customerID)
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

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (FilterForm == null)
            {
                FilterForm = new EmpCusManagementFilter(this);
                FilterForm.Show();
            }
            else
            {
                FilterForm.BringToFront(); // Brings prompt to front if window open and user presses btn again
            }

            try // horrible hacky method to create a new instance if user closed window with 'X'.
            {
                FilterForm.Show();
            }
            catch
            {
                FilterForm = new EmpCusManagementFilter(this);
                FilterForm.Parent = this;
                FilterForm.Show();
            }

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        // Brings up Add Customer form to fill out, logs data, submits to database.
        {
            if (AddCustomer == null)
            {
                AddCustomer = new EmpAddCustomer();
            }
            else
            {
                AddCustomer.BringToFront(); // Brings prompt to front if window open and user presses btn again
            }

            try // horrible hacky method to create a new instance if user closed window with 'X'.
            {
                AddCustomer.Show();
            }
            catch
            {
                AddCustomer = new EmpAddCustomer();
                AddCustomer.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
