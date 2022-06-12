using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCarMenu : UserControl
    {
        
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
                var carsavail_uc = new EmpCarsAvailable();
                this.Controls.Add(carsavail_uc);
                carsavail_uc.Dock = DockStyle.Fill;
                carsavail_uc.Visible = true;
                carsavail_uc.Enabled = true;
                carsavail_uc.Show();
                carsavail_uc.BringToFront();
            }
        }
    }
}
