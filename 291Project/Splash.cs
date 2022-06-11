using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
        }


        private void Splash_Load(object sender, EventArgs e)
        {

        }



        private void LoginHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            String userlogin = textBox1.Text;
            String login_id = userlogin.Trim().ToUpper();
            if (login_id == "")
            {
                MessageBox.Show("Please Enter Valid Credentials", "Failed to Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (login_id[0] == 'C')
            {
                CustomerMainMenu cMain = new CustomerMainMenu();
                cMain.CustomerDisplayName = userlogin;
                cMain.Show();

                this.Visible = false;
            }
            else if (login_id[0] == 'E')
            {
                // Links to employee screen.
                EmployeeMain employee = new EmployeeMain();
                employee.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Credentials", "Failed to Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
