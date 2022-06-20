using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project
{
    public partial class CustViewCurrentRes : UserControl
    {
        public DataTable ViewCurrent_dt = new DataTable();
        public SqlDataReader reader = null;
        bool customer_id;
        public CustViewCurrentRes()
        {

            InitializeComponent();
            customer_id = false;
            //reader = DBridge.run_query("");
            //ViewCurrent_dt.Load(reader);
            //CustViewCurrent_dt.DataSource = ViewCurrent_dt;

        }

        private void CustViewCurrentRes_Load(object sender, EventArgs e)
        {

        }

        private string GenQueryStr()
        {
            string query = "select c.customer_id, concat(first_name, ' ', last_name) as \"Name\", " +
                "concat(r.From_Day, '/', r.From_Month, '/', r.From_Year) as \"Date From\", " +
                "concat(r.To_Day, '/', r.To_Month, '/', r.To_Year) as \"Date To\", r.Branch_ID, cr.Car_ID from " +
                "customers c, membershiptype mt, cars cr, reservations r WHERE cr.Car_ID = r.Car_ID AND r.From_Year < r.To_Year AND " +
                "r.Customer_ID = c.customer_ID";

            // Check filter bools and apply proper text to base query if true.
            if (customer_id)
            {
                query += $" AND c.customer_id = {Program.ExtractLeadingNumbers(cust_id.Text)}";
            }

            return query;
        }

        private static bool IdIsValid(String id)
        // Helper for CusIdFilter_TextChanged, checks textbox field for leading integers.
        {
            id = Program.ExtractLeadingNumbers(id);
            if (string.IsNullOrEmpty(id)) { return false; }
            else { return true; }
        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            if (IdIsValid(cust_id.Text))
            {
                customer_id = true;
            }
            else { customer_id = false; }
        }

        private string GetCustomerID()
        // Takes in selected row and gets the value from Customer_ID field.
        {
            int selectedrowindex = CustViewCurrent_dt.SelectedCells[0].RowIndex; // Get row index 
            DataGridViewRow selectedRow = CustViewCurrent_dt.Rows[selectedrowindex]; // get row
            string cellValue = Convert.ToString(selectedRow.Cells["Customer_ID"].Value); // Get Customer ID
            return cellValue;
        }


        public void RefreshView()
        {
            //reader.Close();
            reader = DBridge.run_query(GenQueryStr());
            ViewCurrent_dt.Clear();
            ViewCurrent_dt.Load(reader);
            CustViewCurrent_dt.DataSource = ViewCurrent_dt;
            if (CustViewCurrent_dt.Rows.Count != 0)
            {
                CustViewCurrent_dt.CurrentRow.Selected = false;
            }



        }

        private void custUpdateCurrent_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
