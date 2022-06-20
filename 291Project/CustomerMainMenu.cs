using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class CustomerMainMenu : Form
    {
        public LoginSplash splashscreen;

        public string CustomerDisplayName { get; set; }
        public CustomerMainMenu(LoginSplash splashscreen)
        {

            this.splashscreen = splashscreen;
            InitializeComponent();

            custRequestRes1.Hide();
            custViewCurrentRes1.Hide();
            custViewPastRes1.Hide();

            custRequestRes1.SendToBack();
            custViewCurrentRes1.SendToBack();
            custViewPastRes1.SendToBack();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Home_btn_click(object sender, EventArgs e)
        {
            custViewPastRes1.Hide();
            custViewCurrentRes1.Hide();
            custRequestRes1.Hide();
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

		private void req_res_button_Click_1(object sender, EventArgs e)
		{
			custRequestRes1.BringToFront();
			custRequestRes1.Show();
		}

		private void view_curr_res_button_Click(object sender, EventArgs e)
		{
			custViewCurrentRes1.BringToFront();
			custViewCurrentRes1.Show();
		}

		private void past_res_button_Click(object sender, EventArgs e)
		{
			custViewPastRes1.BringToFront();
			custViewPastRes1.Show();
		}

		private void custViewPastRes1_Load(object sender, EventArgs e)
		{

		}

		private void Back_btn_Click(object sender, EventArgs e)
		{

		}

		private void custViewPastRes1_Load_1(object sender, EventArgs e)
		{

		}
    }
}
