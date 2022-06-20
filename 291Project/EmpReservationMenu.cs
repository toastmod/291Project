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

            //if (empCurrentRes1 == null)
            //{
            //    cur_res_uc = new EmpCurrentRes();
            //    this.Controls.Add(cur_res_uc);
            //}

            empCurrentRes1.Show();
            empCurrentRes1.BringToFront();
            empCurrentRes1.Enabled = true;
            empCurrentRes1.Visible = true;
            //empCurrentRes1.Dock = DockStyle.Fill;
            //this.Enabled = false;

        }

        private void emp_past_res_Click(object sender, EventArgs e)
        {

        }

		public bool GoBack() 
		{

            if(!empCurrentRes1.Enabled)
            {
                empCurrentRes1.GoBack();
                this.Enabled = true;
                this.BringToFront();
                this.Show();
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

        private void EmpReservationMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
