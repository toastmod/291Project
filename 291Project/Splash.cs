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
            // Following code is for logging in, and displaying a welcome message.
            String userlogin = textBox1.Text; // take in the string from the text box
            String login_id = userlogin.Trim().ToUpper();
            if (login_id == "")// Error pop up when string is empty
            {
                MessageBox.Show("Please Enter Valid Credentials", "Failed to Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (login_id[0] == 'C') // redirect to customer menu
            {
                CustomerMainMenu cMain = new CustomerMainMenu(this);
                cMain.CustomerDisplayName = userlogin;
                cMain.Show();
                this.Visible = false;
            }
            else if (login_id[0] == 'E') // redirect to employee menu
            {
                EmployeeMain eMain = new EmployeeMain(this);
                eMain.EmployeeDisplayName = userlogin;
                eMain.Show();
                this.Visible = false;
            }
            else // Error if not beginning w C or E (temp)
            {
                MessageBox.Show("Please Enter Valid Credentials", "Failed to Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
