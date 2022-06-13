using System.Data;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCarsAvailable : UserControl
    {
        public DataTable avail_dt = new DataTable();
        public EmpCarsAvailable()
        {
            InitializeComponent();

            var reader = DBridge.run_query("SELECT * FROM Cars WHERE Cars.Branch_ID = " + Program.context_branchid);
            avail_dt.Load(reader);
            CarSearchDataView.DataSource = avail_dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarSearchDataView_click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
