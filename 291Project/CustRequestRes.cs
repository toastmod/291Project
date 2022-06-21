﻿
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{

    public partial class CustRequestRes : UserControl

    {
        bool branch_change;
        public DataTable CustRes_dt = new DataTable();
        public SqlDataReader reader = null;
        public bool asEmployee = false;

        /// <summary>
        /// Override for initializing this UC as an employee.
        /// </summary>
        /// <param name="asEmployee"></param>
        public CustRequestRes(bool asEmployee)
        {
            this.asEmployee = asEmployee;
            InitializeComponent();
            branch_change = false;
            reader = DBridge.run_query(CustRequestRes.gen_querystr());
            CustRes_dt.Load(reader);
            ResTable.DataSource = CustRes_dt;


            reader = DBridge.run_query("SELECT CONCAT(Branch_ID, ' - ', City) as 'Branch' FROM Branches");
            while (reader.Read())
            {
                Branches.Items.Add(reader["Branch"].ToString());
            }

            reader = DBridge.run_query("SELECT DISTINCT(Province) as 'Province' FROM Branches");
            while (reader.Read())
            {
                Provinces.Items.Add(reader["Province"].ToString());
            }

            reader = DBridge.run_query("SELECT DISTINCT(Car_Type) as 'Car Type' FROM Cars");
            while (reader.Read())
            {
                cartypes.Items.Add(reader["Car Type"].ToString());
            }

        }


        private static string gen_querystr()
        {
            String query = "SELECT DISTINCT c.Car_ID as \"ID\", c.Car_Type, b.City, b.Province, FORMAT(ct.daily_rate, 'C') as \"Day Rate\", FORMAT(ct.weekly_rate, 'C') as \"Weekly Rate\", FORMAT(ct.monthly_rate, 'C') as \"Monthly Rate\" FROM Cars c, CarTypes ct, Branches b, CarStatus cs WHERE c.Car_Type = ct.CarType AND b.Branch_ID = c.Branch_ID AND c.CarStatusID = 1";
            return query;

        }

        private string GenQueryStr()
        {
            string query = "select DISTINCT c.customer_id as \"ID\", concat(first_name, ' ', last_name) as \"Name\", " +
                "concat(r.From_Day, '/', r.From_Month, '/', r.From_Year) as \"Date From\", " +
                "concat(r.To_Day, '/', r.To_Month, '/', r.To_Year) as \"Date To\", r.Branch_ID as \"Branch ID\", cr.Car_ID as \"Car ID\" from " +
                "customers c, membershiptype mt, cars cr, reservations r WHERE cr.Car_ID = r.Car_ID AND r.From_Year < r.To_Year AND " +
                "r.Customer_ID = c.customer_ID";

            // Check filter bools and apply proper text to base query if true.
            if (branch_change)
            {
                query += $" AND c.customer_id = {Program.ExtractLeadingNumbers(Branches.Text)}";
            }

            return query;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CustRequestRes_Load(object sender, EventArgs e)
        {

        }


        private static bool IdIsValid(String id)
        // Helper for CusIdFilter_TextChanged, checks textbox field for leading integers.
        {
            id = Program.ExtractLeadingNumbers(id);
            if (string.IsNullOrEmpty(id)) { return false; }
            else { return true; }
        }

        private void Provinces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Branches_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshView();

        }

        private void cartypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void UpdateResScreen_Click(object sender, EventArgs e)
        {
            //UpdateProvince();
            //UpdateBranch();
        }
        public void RefreshView()
        {
            reader = DBridge.run_query(GenQueryStr());
            CustRes_dt.Clear();
            CustRes_dt.Load(reader);
            ResTable.DataSource = CustRes_dt;
            if (ResTable.Rows.Count != 0)
            {
                ResTable.CurrentRow.Selected = false;
            }

        }
        private string GetResID()
        {
            string resID = "null";
            SqlDataReader tempreader = DBridge.run_query("SELECT MAX(Res_ID) FROM Reservations");
            if (tempreader.Read())
            {
                resID = tempreader[0].ToString(); // 
            }
            MessageBox.Show($"Selected Value: {resID}.", "Rental Request Debug");
            return resID;
        }

        private string GetCarID()
        // Takes in selected row and gets the value from Customer_ID field.
        {
            int selectedrowindex = ResTable.SelectedCells[0].RowIndex; // Get row index 
            DataGridViewRow selectedRow = ResTable.Rows[selectedrowindex]; // get row
            string carID = Convert.ToString(selectedRow.Cells["Car_ID"].Value); // Get Customer ID
            MessageBox.Show($"Selected Value: {carID}.", "Rental Request Debug");
            return carID;
        }


        private void ReservationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void ResTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestBtn_Click_1(object sender, EventArgs e)
        {
            if (ResTable.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // if no car selected
            {
                MessageBox.Show("Please select a car to reserve.", "Rental Request Invalid");
            }
            else
            {
                string resID = GetCarID();
                string carID = GetResID();
                //if (CustomerAlreadyTerminated(customerID, customerName))
                //{
                //MessageBox.Show($"{customerName}'s membership is already terminated.");
                //return; // Stop stop they're already dead!!
                //}
                // Otherwise show confirmation box
                //DialogResult result1 = MessageBox.Show($"Are you sure you would like to deactivate Customer: {customerName}?\n\nWARNING: THERE IS NO WAY TO REVERSE TERMINATION",
                //"Confirm Member Termination",
                //MessageBoxButtons.YesNo);
                //if (result1 == DialogResult.Yes)
                //{
                //DelCustomer(customerID); // Assign their membership type to 0
                //}


            }

        }

        private void RequestBtn_click(object sender, EventArgs e)
        {
            if (ResTable.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // if no car selected
            {
                // probably cancel the selected ID
                if (this.asEmployee)
                {
                    // Submit request as an employee?
                    var from_day = dateTimePicker1.Value.Day;
                    var from_month = dateTimePicker1.Value.Month;
                    var from_year = dateTimePicker1.Value.Year;

                    var to_day = dateTimePicker2.Value.Day;
                    var to_month = dateTimePicker2.Value.Month;
                    var to_year = dateTimePicker2.Value.Year;

                    // Submit request as a customer? not sure what the difference might but...
                    //DBridge.insert_row(
                    //    "Reservations",
                    //    $"{int.Parse(GetResID())+1},{from_day},{from_month},{from_year},{to_day},{to_month},{to_year},{GetCarID()}"
                    //);

                }
                else
                {
                    // Submit request as a customer? not sure what the difference might but...
                }

            }
            else
            {
                MessageBox.Show("Please select a car to reserve.", "Rental Request Invalid");
                string resID = GetCarID();
                string carID = GetResID();
            }

            //if (CustomerAlreadyTerminated(customerID, customerName))
            //{
            //MessageBox.Show($"{customerName}'s membership is already terminated.");
            //return; // Stop stop they're already dead!!
            //}
            // Otherwise show confirmation box
            //DialogResult result1 = MessageBox.Show($"Are you sure you would like to deactivate Customer: {customerName}?\n\nWARNING: THERE IS NO WAY TO REVERSE TERMINATION",
            //"Confirm Member Termination",
            //MessageBoxButtons.YesNo);
            //if (result1 == DialogResult.Yes)
            //{
            //DelCustomer(customerID); // Assign their membership type to 0
            //}


        }



        public void GoBack()
        {
            this.Hide();
            this.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

