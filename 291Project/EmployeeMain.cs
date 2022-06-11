using System;
using System.Data;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmployeeMain : Form
    {
        public string EmployeeDisplayName { get; set; }
        public DataTable dt = new DataTable();
        public EmployeeMain()
        {
            InitializeComponent();

            //var reader = DBridge.run_query("SELECT * from Cars");
            //dt.Load(reader);
            //dataGridView1.DataSource = dt;

        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            emp_id_box.Text = $"Welcome {EmployeeDisplayName}!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DBridge.init();



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void emp_id_box_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
