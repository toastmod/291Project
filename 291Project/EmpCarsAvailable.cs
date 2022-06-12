using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dataGridView2.DataSource = avail_dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
