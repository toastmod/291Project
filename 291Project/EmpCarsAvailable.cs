using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _291Project
{
    public partial class EmpCarsAvailable : UserControl
    {
        public DataTable avail_dt = new DataTable();
        public SqlDataReader reader = null;
        public EmpCarsAvailable()
        {
            InitializeComponent();

            reader = DBridge.run_query("SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, CarStatus.Status FROM Cars, CarStatus WHERE Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = " + Program.context_branchid);
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            reader = DBridge.run_query("SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, CarStatus.Status FROM Cars, CarStatus WHERE Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = " + Program.context_branchid);
            avail_dt.Clear();
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }
    }
}
