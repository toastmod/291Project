using System;
using System.Data;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmployeeMain : Form
    {
        public string EmployeeDisplayName { get; set; }
        public DataTable branch_dt = new DataTable();
        public EmployeeMain()
        {
            InitializeComponent();

            //var reader = DBridge.run_query("SELECT * from Cars");
            //dt.Load(reader);
            //dataGridView1.DataSource = dt;


            var reader = DBridge.run_query("SELECT Branch_ID from Branches");
            branch_dt.Load(reader);
            mainMenuBranchDropdown.DataSource = branch_dt;

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            emp_id_box.Text = $"Welcome {EmployeeDisplayName}!";
        }

        // BACK BUTTON 
        private void button3_Click(object sender, EventArgs e)
        {
            //DBridge.init();
            empCarMenu2.BringToFront();
            empCarMenu2.Show();
            empCarMenu2.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            empReservationMenu1.BringToFront();
            empReservationMenu1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            empCarMenu2.Hide();
            empReservationMenu1.Hide();


        }

        private void emp_id_box_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void empCarMenu2_Load(object sender, EventArgs e)
        {
            empCarMenu2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void empReservationMenu1_Load(object sender, EventArgs e)
        {
            empReservationMenu1.Hide();

        }

        private void mainMenuBranchDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
