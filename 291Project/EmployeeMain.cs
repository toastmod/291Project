using System;
using System.Data;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmployeeMain : Form
    {
        public Splash LoginScreen;
        public string EmployeeDisplayName { get; set; }
        public DataTable dt = new DataTable();
        public EmployeeMain(Splash splashscreen)
        {
            this.LoginScreen = splashscreen;
            InitializeComponent();

            var reader = DBridge.run_query("SELECT Branch_ID from Branches");
            while(reader.Read())
            {
                mainMenuBranchDropdown.Items.Add(reader["Branch_ID"]);
            }

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            Emp_id_box.Text = $"Welcome {EmployeeDisplayName}!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DBridge.init();
            EmpCarMenu.BringToFront();
            EmpCarMenu.Show();
            EmpCarMenu.Enabled = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmpReservationMenu1.BringToFront();
            EmpReservationMenu1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResMenuBtn_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            EmpCarMenu.Hide();
            EmpReservationMenu1.Hide();

        }

        private void Emp_id_box_Click(object sender, EventArgs e)
        {

        }


        private void EmpCarMenu_Load(object sender, EventArgs e)
        {
            EmpCarMenu.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.LoginScreen.Show();
            this.Close();

        }

        private void empReservationMenu1_Load(object sender, EventArgs e)
        {
            EmpReservationMenu1.Hide();

        }

        private void mainMenuBranchDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.context_branchid = mainMenuBranchDropdown.SelectedItem.ToString();
            Console.WriteLine("BRANCHID WAS SET TO " + Program.context_branchid);
        }
    }
}
