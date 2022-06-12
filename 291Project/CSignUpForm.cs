using System;
namespace _291Project
{
    public partial class CSignUpForm
    {
        public CSignUpForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {



        }

        private void create_Click_1(object sender, EventArgs e)
        {
            string s = "                                        Success!!\n" +
               "                                  Account Created\n" +
               "First Name: " + FirstName.Text + "\nLast Name: " + LastName.Text;
            s = s + "\nAddress: " + "\n" + line1.Text + "\n" + line2.Text + "\n" + postalcode.Text +
                "\n" + Province.Text + "\n" + City.Text + "\nPhone Number: " + PhoneNum.Text;
            //MessageBox.Show(s);
            this.Visible = false;

        }

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_Click(object sender, EventArgs e)
        {

        }

        private void line1_TextChanged(object sender, EventArgs e)
        {

        }

        private void line2_TextChanged(object sender, EventArgs e)
        {

        }

        private void postalcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Province_TextChanged(object sender, EventArgs e)
        {

        }

        private void City_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}