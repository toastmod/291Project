using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCarMenu : UserControl
    {

        public EmpCarsAvailable carsavail_uc = null;

        public EmpCarMenu()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpCarMenu_Load(object sender, EventArgs e)
        {

        }

        private void cars_due_btn_Click(object sender, EventArgs e)
        {

        }

        private void cars_avail_btn_Click(object sender, EventArgs e)
        {
            if(Program.context_branchid != null)
            {
                carsavail_uc = new EmpCarsAvailable();
                this.Controls.Add(carsavail_uc);
                carsavail_uc.Show();
                carsavail_uc.BringToFront();
                carsavail_uc.Enabled = true;
                carsavail_uc.Visible = true;
                                
            }
            else
            {
                MessageBox.Show("Please select a Branch.", "Error");
            }
        }

        public void GoBack()
        {
            Program.println("Going back from CarsMenu");
            if(carsavail_uc != null)
            {
                carsavail_uc.GoBack();
                carsavail_uc = null;
            }
            else
            {
                this.Enabled = false;
                this.Hide();
            }
        }
    }

}
