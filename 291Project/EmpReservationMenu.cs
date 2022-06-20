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
    public partial class EmpReservationMenu : UserControl
    {

        private EmpCurrentRes cur_res_uc = null;
        public EmpReservationMenu()
        {
            InitializeComponent();
        }

        private void emp_create_res_Click(object sender, EventArgs e)
        {

        }

        private void emp_curr_res_Click(object sender, EventArgs e)
        {

            if (cur_res_uc == null)
            {
                cur_res_uc = new EmpCurrentRes();
                this.Controls.Add(cur_res_uc);
            }

            cur_res_uc.Dock = DockStyle.Fill;
            cur_res_uc.Enabled = true;
            cur_res_uc.Visible = true;
            cur_res_uc.Show();
            cur_res_uc.BringToFront();
            this.Enabled = false;



        }

        private void emp_past_res_Click(object sender, EventArgs e)
        {

        }

		public bool GoBack() 
		{

            if(cur_res_uc != null)
            {
                cur_res_uc.GoBack();
                cur_res_uc = null;
                this.Enabled = true;
                return false;
            }
            else
            {
                Program.println("Going back from EmpReservationMenu");
                this.Hide();
                this.Enabled = false;
                return true;
            }
		}

    }
}
