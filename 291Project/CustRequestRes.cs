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
    public partial class CustRequestRes : UserControl
    {
        public DataTable CustRes_dt = new DataTable();
        public SqlDataReader reader = null;
        public CustRequestRes()
        {
            InitializeComponent();
            reader = DBridge.run_query(CustRequestRes.gen_querystr());
            CustRes_dt.Load(reader);
            ReservationTable.DataSource = CustRes_dt;


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
            return ($"SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, CarStatus.Status, Branches.City, Branches.Province " +
                $"FROM Cars, CarStatus, Branches WHERE Branches.City = 'Edmonton' AND Branches.Branch_ID = Cars.Branch_ID AND " +
                $"Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = 0 OR Cars.Branch_ID = 1 OR Cars.Branch_ID = 2 OR " +
                $"Cars.Branch_ID = 3 OR Cars.Branch_ID = 4 OR Cars.Branch_ID = 5 OR Cars.Branch_ID = 6 OR Cars.Branch_ID = 7 OR " +
                $"Cars.Branch_ID = 8 OR Cars.Branch_ID = 9 OR Cars.Branch_ID = 10");
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
        public void UpdateBranch()
        {
            reader.Close();
            reader = DBridge.run_query($"SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, Branches.City, CarStatus.Status FROM Cars, CarStatus, Branches WHERE Branches.Branch_ID = Cars.Branch_ID AND Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = ${Program.context_branchid}");
            CustRes_dt.Clear();
            CustRes_dt.Load(reader);
            ReservationTable.DataSource = CustRes_dt;
        }

        public void UpdateProvince()
        {
            reader.Close();
            reader = DBridge.run_query($"SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, Branches.City, CarStatus.Status FROM Cars, CarStatus, Branches WHERE Branches.Province = 'BC' AND Branches.Branch_ID = Cars.Branch_ID AND Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = 0 OR Cars.Branch_ID = 1 OR Cars.Branch_ID = 2 OR Cars.Branch_ID = 3 OR Cars.Branch_ID = 4 OR Cars.Branch_ID = 5 OR Cars.Branch_ID = 6 OR Cars.Branch_ID = 7 OR Cars.Branch_ID = 8 OR Cars.Branch_ID = 9 OR Cars.Branch_ID = 10");
            CustRes_dt.Clear();
            CustRes_dt.Load(reader);
            ReservationTable.DataSource = CustRes_dt;
        }

        private void Provinces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void cartypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateResScreen_Click(object sender, EventArgs e)
        {
            UpdateProvince();
            //UpdateBranch();
            
        }
    }
}
