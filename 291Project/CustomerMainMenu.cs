using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class CustomerMainMenu : Form
    {
        public Splash splashscreen;

        public string CustomerDisplayName { get; set; }
        public CustomerMainMenu(Splash splashscreen)
        {
            this.splashscreen = splashscreen;
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Home_btn_click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        public void Logout_btn_click(object sender, EventArgs e)
        {
            this.splashscreen.Show();
            this.Close();
        }

        private void Exit_btn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Customer_id_box_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMainMenu_Load_1(object sender, EventArgs e)
        {
            Customer_id_box.Text = $"Welcome {CustomerDisplayName}!";

        }

        private void CustomerReservationMenu1_Load(object sender, EventArgs e)
        {

        }

        private void Req_res_button_Click(object sender, EventArgs e)
        {
        }
    }
}
