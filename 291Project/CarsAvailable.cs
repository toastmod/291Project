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
    public partial class CarsAvailable : UserControl
    {
        public CarsAvailable()
        {
            InitializeComponent();
            var reader = DBridge.run_query("SELECT * from Cars");
            dataGridView1.Columns.Add("Car_ID","");
            dataGridView1.Columns.Add("CarType","");
            dataGridView1.Columns.Add("BranchID","");
            dataGridView1.Columns.Add("CarStatusID","");
            for(int i=0; i<12; i++)
            {
                dataGridView1.Rows.Add(reader.Read());
;           }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
