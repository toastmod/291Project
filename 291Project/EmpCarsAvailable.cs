using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCarsAvailable : UserControl
    {
        bool province_filter = false;
        bool cartype_filter = false;
        bool rate_filter = false;
        bool status_filter = false;


        public DataTable avail_dt = new DataTable();
        public SqlDataReader reader = null;
        public EmpCarsAvailable()
        {
            InitializeComponent();

            reader = DBridge.run_query(gen_querystr());
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;

            // Fill Province Box
            reader = DBridge.run_query("SELECT DISTINCT(Province) as 'Province' FROM Branches");
            while (reader.Read())
            {
                Provinces.Items.Add(reader["Province"].ToString());
            }


            // Fill Car Types Box
            reader = DBridge.run_query("SELECT DISTINCT(Car_Type) as 'Car Type' FROM Cars");
            while (reader.Read())
            {
                cartypes.Items.Add(reader["Car Type"].ToString());
            }

            // Fill Car Status Box
            reader = DBridge.run_query("SELECT Status FROM carstatus");
            while (reader.Read())
            {
                CarStatus.Items.Add(reader["Status"].ToString());
            }


        }

        private string gen_querystr()
        {
            //AND Cars.Branch_ID = ${Program.context_branchid}
            string query = $"SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, Branches.City, Branches.Province, CarStatus.Status, FORMAT(ct.daily_rate, 'C') as \"Day Rate\", FORMAT(ct.weekly_rate, 'C') as \"Weekly Rate (per day)\", FORMAT(ct.monthly_rate, 'C') as \"Monthly Rate (per day)\" FROM Cars, CarStatus, Branches, CarTypes ct WHERE Branches.Branch_ID = Cars.Branch_ID AND Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Car_Type = ct.CarType";
            if (province_filter)
            {
                query += $" AND Branches.Province LIKE '{Provinces.SelectedItem.ToString()}'";
            }
            if (cartype_filter)
            {
                query += $" AND cars.Car_Type LIKE '{cartypes.SelectedItem.ToString()}'";
            }
            if (Program.context_branchid_used)
            {
                //Program.debug(Program.context_branchid);
                query += $" AND Branches.branch_ID = {Program.ExtractLeadingNumbers(Program.context_branchid)}";
            }
            if (status_filter)
            {
                query += $" AND CarStatus.Status LIKE '{CarStatus.SelectedItem.ToString()}'";
            }
            if (rate_filter)
            {
                query += $" AND ct.monthly_rate <= '{Program.ExtractLeadingNumbers(rates.Text)}'";
            }



            return query;
        }

        private void CarSearchDataView_click(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void GoBack()
        {
            Program.println("Going back from CarsAvailable");
            this.Enabled = false;
            this.Hide();

        }

        public void UpdateBranch()
        {
            reader.Close();
            reader = DBridge.run_query(gen_querystr());
            avail_dt.Clear();
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }

        private void EmpCarsAvailable_Load(object sender, System.EventArgs e)
        {

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


        private void CarStatusDropdown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (CarStatus.SelectedIndex != -1)
            {
                status_filter = true;
                RefreshView();
            }
            else status_filter = false;
        }

        bool ratesValid(String s)
        {
            if (Program.ExtractLeadingNumbers(s).Length > 0)
            {
                return true;
            }
            return false;
        }

        private void rates_TextChanged(object sender, EventArgs e)
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
        public void RefreshView()
        {
            reader = DBridge.run_query(gen_querystr());
            avail_dt.Clear();
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
            try
            {
                if (CarSearchDataView.Rows.Count != 0)
                {
                    CarSearchDataView.CurrentRow.Selected = false;
                }
            }
            catch
            {
                return;
            }

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


    }
}
