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

            //var reader = DBridge.run_query("SELECT Car_ID, Car_Type, Branch_ID, CarStatus.Status from Cars, CarStatus where CarStatus.CarStatusID = Cars.CarStatusID");
            //dt.Load(reader);

            //dataGridView1.DataSource = dt;

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {

        }

        // BACK BUTTON 
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

        private void customerLogin2_Load(object sender, EventArgs e)
        {

        }

        private void carsAvailable1_Load(object sender, EventArgs e)
        {

        }

        // HOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void background1_Load(object sender, EventArgs e)
        {
            background1.Enabled = false;
            carsAvailable1.Enabled = false;
            employeeMenu1.Enabled = true;
            employeeMenu1.Visible = true;
        }

        // BACK BUTTON 
        private void button4_Click(object sender, EventArgs e)
        {
            background1.Enabled = false;
            
            employeeMenu1.Enabled = false;
            employeeMenu1.Visible = false;

            carsAvailable1.Enabled = true;
            carsAvailable1.Visible = true;
        }

        // EXIT BUTTON 
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
