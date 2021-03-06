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
            var reader = DBridge.run_query("SELECT CONCAT(Branch_ID, ' - ', City) as 'Branch' FROM Branches");
            while (reader.Read())
            {
                mainMenuBranchDropdown.Items.Add(reader["Branch"].ToString());
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

        private void ManageCars_Btn(object sender, EventArgs e)
        {
            EmpCarMenu.cars_avail_btn_Click(this, e);
            EmpCarMenu.Show();
            EmpCarMenu.BringToFront();
            EmpCarMenu.Visible = true;
            EmpMainMenuBtnPanel.Enabled = false;

            EmpCarMenu.Enabled = true;
            //DBridge.init();
        }

        private void ResMenuBtn(object sender, EventArgs e)
        {
            //HideAllUCs();
            EmpReservationMenu1.Show();
            EmpReservationMenu1.BringToFront();
            EmpReservationMenu1.Enabled = true;
            //EmpMainMenuBtnPanel.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_click(object sender, EventArgs e)
        {
            EmpCarMenu.Hide();
            EmpCarMenu.Enabled = false;
            empCustomerManagement.Hide();
            empCustomerManagement.Enabled = false;
            EmpReservationMenu1.Hide();
            EmpReservationMenu1.Enabled = false;
            EmpMainMenuBtnPanel.Enabled = true;
            mainMenuBranchDropdown.Show();
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
            EmpReservationMenu1.Enabled = false;
        }


        private void MainMenuBranchDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            Program.context_branchid = mainMenuBranchDropdown.SelectedItem.ToString();
            Program.context_branchid = Program.ExtractLeadingNumbers(Program.context_branchid);
            Program.context_branchid_used = true;
            Program.println("BRANCHID WAS SET TO " + Program.context_branchid);
            EmpCarMenu.UpdateBranch();

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            // Each UC has a GoBack function returning a bool
            // true = The UC closed successfully
            // false = UC did not close, another UC was recursively closed.

            var im_here = true;

            if (EmpCarMenu.Enabled)
            {
                im_here = EmpCarMenu.GoBack();
                im_here = EmpCarMenu.GoBack();
                Program.println("EmpCarMenu: " + im_here.ToString());
            }

            if (EmpReservationMenu1.Enabled)
            {
                im_here = EmpReservationMenu1.GoBack();
                Program.println("EmpResMenu: " + im_here.ToString());
            }

            if (empCustomerManagement.Enabled)
            {
                im_here = empCustomerManagement.GoBack();
                Program.println("EmpCustMgmt: " + im_here.ToString());
            }


            // if the user made it back here, enable the menu again.
            if (im_here)
            {
                this.Enabled = true;
                this.BringToFront();
                this.Show();
                this.EmpMainMenuBtnPanel.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // create report button
        }

        private void EmpManageCustomersBtn(object sender, EventArgs e)
        {
            HideAllUCs();
            EmpMainMenuBtnPanel.Enabled = false;
            empCustomerManagement.BringToFront();
            empCustomerManagement.Enabled = true;
            mainMenuBranchDropdown.Hide();
            empCustomerManagement.Show();
        }

        private void HideAllUCs()
        {

            EmpReservationMenu1.Hide();
            EmpReservationMenu1.Enabled = false;
            EmpCarMenu.Hide();
            EmpCarMenu.Enabled = false;
            empCustomerManagement.Hide();
            empCustomerManagement.Enabled = false;
        }

        private void empCustomerManagement1_Load_1(object sender, EventArgs e)
        {
            empCustomerManagement.Hide();
            empCustomerManagement.RefreshView();
        }
    }
}
