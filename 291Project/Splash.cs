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
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }


        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Temporary, just testing flow. 
            // This should link to a "Customer Login" Screen
            
            CustomerMainMenu cMain = new CustomerMainMenu();
            cMain.Show();
            this.Visible = false;
           
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            // Links to employee screen.
            EmployeeMain employee =  new EmployeeMain();
            employee.Show();
            this.Visible = false;
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

            String login_id = textBox1.Text;
            login_id = login_id.Trim().ToUpper();
            if (login_id == "C")
            {
                CustomerMainMenu cMain = new CustomerMainMenu();
                cMain.Show();
                this.Visible = false;
            }
            else if (login_id == "E")
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
