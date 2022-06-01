namespace screen1A
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
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
            Form2a f2a = new Form2a(s, this);
            f2a.Show();
            this.Visible = false;

        }
    }
    }