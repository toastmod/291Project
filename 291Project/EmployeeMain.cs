using System;
using System.Data;
using System.Windows.Forms;

//! damn this page is a mess. gotta do some clean up.

// Goal, page loads, all UC's are disabled and hidden until clicked on.

namespace _291Project
{
    public partial class EmployeeMain : Form
    {
        public LoginSplash LoginScreen;
        public string EmployeeDisplayName { get; set; }
        public DataTable dt = new DataTable();
        public EmployeeMain(LoginSplash splashscreen)
        {
            this.LoginScreen = splashscreen;
            InitializeComponent();
            HideAllUCs();

            // load branch IDs into drop down
            var reader = DBridge.run_query("SELECT Branch_ID from Branches");
            while (reader.Read())
            {
                mainMenuBranchDropdown.Items.Add(reader["Branch_ID"].ToString());
            }

            // if a branch ID is already loaded in the context, set it to that ID item.
            if (Program.context_branchid != null)
            {
                mainMenuBranchDropdown.SelectedIndex = mainMenuBranchDropdown.FindStringExact(Program.context_branchid);
            }

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            Emp_id_box.Text = $"Welcome {EmployeeDisplayName}!";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DBridge.init();
            EmpCarMenu.Show();
            EmpCarMenu.BringToFront();
            EmpCarMenu.Enabled = true;
            EmpCarMenu.Visible = true;
        }

        private void ResMenuBtn(object sender, EventArgs e)
        {
            HideAllUCs();
            EmpReservationMenu1.Enabled = true;
            EmpReservationMenu1.BringToFront();
            EmpReservationMenu1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_click(object sender, EventArgs e)
        {
            EmpCarMenu.Hide();
            EmpCarMenu.Enabled = false;
            EmpCustomerManagement.Hide();
            EmpCustomerManagement.Enabled = false;
            EmpReservationMenu1.Hide();
            EmpReservationMenu1.Enabled = false;
            EmpMainMenuBtnPanel.Enabled = true;
            BringToFront();


        }

        private void Emp_id_box_Click(object sender, EventArgs e)
        {

        }


        private void EmpCarMenu_Load(object sender, EventArgs e)
        {
            EmpCarMenu.Hide();
            EmpCarMenu.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginScreen.Show();
            Close();

        }

        private void EmpReservationMenu1_Load(object sender, EventArgs e)
        {
            EmpReservationMenu1.Hide();

        }

        private void MainMenuBranchDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.context_branchid = mainMenuBranchDropdown.SelectedItem.ToString();
            Program.println("BRANCHID WAS SET TO " + Program.context_branchid);
            EmpCarMenu.UpdateBranch();

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            EmpCarMenu.GoBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void EmpManageCustomersBtn(object sender, EventArgs e)
        {
            HideAllUCs();
            EmpMainMenuBtnPanel.Enabled = false; // Bug where buttons are active and can be selected even when visible.
            EmpCustomerManagement.BringToFront();
            EmpCustomerManagement.Enabled = true; // Bug where buttons are active and can be selected even when visible.
            EmpCustomerManagement.Show();
        }

        private void empCustomerManagement1_Load(object sender, EventArgs e)
        {
            EmpCustomerManagement.Hide();
        }
        private void HideAllUCs()
        {

            EmpReservationMenu1.Hide();
            EmpReservationMenu1.Enabled = false;
            EmpCarMenu.Hide();
            EmpCarMenu.Enabled = false;
            EmpCustomerManagement.Hide();
            EmpCustomerManagement.Enabled = false;
        }
    }
}
