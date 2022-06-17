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
        public EmpCustomerManagement()
        {
            InitializeComponent();
            reader = DBridge.run_query(EmpCustomerManagement.GenQueryStr());
            reader = DBridge.run_query(GenQueryStr());
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;
            CustomerDataView.Rows[0].Selected = false;
        }

        private static string GenQueryStr()
        {
            return $"SELECT * FROM Customers";
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
                MessageBox.Show($"{CustomerDataView.SelectedRows[0].ToString()}", "Terminate Membership");

                //DelCustomer()
            }

        }

        private void DelCustomer(object sender, EventArgs e)
        {

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {

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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            reader.Close();
            reader = DBridge.run_query(EmpCustomerManagement.GenQueryStr());
            avail_dt.Clear();
            avail_dt.Load(reader);
            CustomerDataView.DataSource = avail_dt;
            CustomerDataView.CurrentRow.Selected = false;

        }
    }
}
