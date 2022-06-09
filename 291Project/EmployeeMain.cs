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
    public partial class EmployeeMain : Form
    {
        public DataTable dt = new DataTable();
        public EmployeeMain()
        {
            InitializeComponent();

            var reader = DBridge.run_query("SELECT * from Cars");
            dt.Load(reader);

            dataGridView1.DataSource = dt;

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DBridge.init();



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
