using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCarsAvailable : UserControl
    {
        public DataTable avail_dt = new DataTable();
        public SqlDataReader reader = null;
        public EmpCarsAvailable()
        {
            InitializeComponent();

            reader = DBridge.run_query(EmpCarsAvailable.gen_querystr());
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }

        private static string gen_querystr()
        {
            return $"SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, Branches.City, CarStatus.Status FROM Cars, CarStatus, Branches WHERE Branches.Branch_ID = Cars.Branch_ID AND Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Branch_ID = ${Program.context_branchid}";
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
            reader = DBridge.run_query(EmpCarsAvailable.gen_querystr());
            avail_dt.Clear();
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }

        private void EmpCarsAvailable_Load(object sender, System.EventArgs e)
        {

        }
    }
}
