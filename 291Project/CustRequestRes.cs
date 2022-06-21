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
        bool province_filter = false;
        bool cartype_filter = false;
        bool branch_filter = false;
        bool rate_filter = false;

        /// <summary>
        /// Override for initializing this UC as an employee.
        /// </summary>
        /// <param name="asEmployee"></param>
        public CustRequestRes(bool asEmployee)
        {
            this.asEmployee = asEmployee;
            InitializeComponent();
            if (asEmployee)
            {
                //label1.Text = "Reservation ID to accept";
            }
            else
            {
                //label1.Text = "Car ID to request";
            }

            branch_change = false;
            reader = DBridge.run_query(gen_querystr());
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


        private string gen_querystr()
        {
            String query = "SELECT DISTINCT c.Car_ID as \"ID\", c.Car_Type, b.City, b.Province, FORMAT(ct.daily_rate, 'C') as \"Day Rate\", FORMAT(ct.weekly_rate, 'C') as \"Weekly Rate\", FORMAT(ct.monthly_rate, 'C') as \"Monthly Rate\" FROM Cars c, CarTypes ct, Branches b, CarStatus cs WHERE c.Car_Type = ct.CarType AND b.Branch_ID = c.Branch_ID AND c.CarStatusID = 1";
            if (province_filter)
            {
                query += $" AND b.Province LIKE '{Provinces.SelectedItem.ToString()}'";
            }
            if (branch_filter)
            {
                query += $" AND b.branch_ID = {Program.ExtractLeadingNumbers(Branches.SelectedItem.ToString())}";
            }
            if (cartype_filter)
            {
                query += $" AND c.Car_Type LIKE '{cartypes.SelectedItem.ToString()}'";
            }
            if (rate_filter)
            {
                query += $" AND ct.monthly_rate <= '{Program.ExtractLeadingNumbers(rates.Text)}'";
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
            {
                if (Provinces.SelectedIndex != -1)
                {
                    province_filter = true;
                    RefreshView();
                }
                else province_filter = false;
            }


        }

        private void Branches_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Branches.SelectedIndex != -1)
            {
                branch_filter = true;
                RefreshView();
            }
            else branch_filter = false;

        }

        private void cartypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cartypes.SelectedIndex != -1)
            {
                cartype_filter = true;
                RefreshView();
            }
            else cartype_filter = false;
        }



        private void UpdateResScreen_Click(object sender, EventArgs e)
        {
            //UpdateProvince();
            //UpdateBranch();
        }
        public void RefreshView()
        {
            reader = DBridge.run_query(gen_querystr());
            CustRes_dt.Clear();
            CustRes_dt.Load(reader);
            ResTable.DataSource = CustRes_dt;
            try
            {
                if (ResTable.Rows.Count != 0)
                {
                    ResTable.CurrentRow.Selected = false;
                }
            }
            catch
            {
                return;
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

        private void rates_TextChanged(object sender, EventArgs e)
        {

        }





        private string GetMaxEmployeeID()
        {
            string empID = "null";
            SqlDataReader tempreader = DBridge.run_query("SELECT MAX(Emp_ID) FROM Employees");
            if (tempreader.Read())
            {
                empID = tempreader[0].ToString();
            }
            return empID;
        }



        private void RequestBtn_click(object sender, EventArgs e)
        {
            if (ResTable.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // if no car selected
            {

                MessageBox.Show("Please select a car to reserve.", "Rental Request Invalid");
                string resID = GetCarID();
                string carID = GetResID();

            }
            else
            {

                if (this.asEmployee)
                {
                    // probably cancel the selected ID
                }
                else
                {
                    // Prepare dates
                    var from_day = dateTimePicker1.Value.Day;
                    var from_month = dateTimePicker1.Value.Month;
                    var from_year = dateTimePicker1.Value.Year;

                    var to_day = dateTimePicker2.Value.Day;
                    var to_month = dateTimePicker2.Value.Month;
                    var to_year = dateTimePicker2.Value.Year;


                    var reader = DBridge.run_query($"SELECT TOP 1 E.Emp_ID,C.Branch_ID FROM Employees E, Cars C WHERE C.Car_ID = {GetCarID()} AND C.Branch_ID = E.Branch_ID ORDER BY NEWID()");

                    if (reader.Read())
                    {
                        DBridge.insert_row(
                        "Reservations",
                        $"{int.Parse(GetResID()) + 1},{from_day},{from_month},{from_year},{to_day},{to_month},{to_year},{GetCarID()},{reader["E.Emp_ID"].ToString()},{reader["C.Branch_ID"].ToString()},{Program.context_userid}"
                        );

                    }
                    else
                    {
                        MessageBox.Show("Fatal Error, could not read Employee ID from Car's Branch ID.", "Debug Message");
                    }

                }

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




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        bool ratesValid(String s)
        {
            if (Program.ExtractLeadingNumbers(s).Length > 0)
            {
                return true;
            }
            return false;
        }

        private void rates_TextChanged_1(object sender, EventArgs e)
        {
            if (ratesValid(rates.Text))
            {
                rate_filter = true;
                RefreshView();
            }
            else
            {
                rate_filter = false;

            }
        }
    }
}

