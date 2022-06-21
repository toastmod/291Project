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

        public CustRequestRes createResPanel = null; 
        public EmpReservationMenu()
        {
            InitializeComponent();
        }

        private void emp_create_res_Click(object sender, EventArgs e)
        {
            if(createResPanel == null)
            {
                createResPanel = new CustRequestRes(true);
            }

            createResPanel.Show();
            createResPanel.BringToFront();
            createResPanel.Enabled = true;
            createResPanel.Visible = true;
            
        }

        private void emp_curr_res_Click(object sender, EventArgs e)
        {
            empCurrentRes1.Show();
            empCurrentRes1.BringToFront();
            empCurrentRes1.Enabled = true;
            empCurrentRes1.Visible = true;
        }

        private void emp_past_res_Click(object sender, EventArgs e)
        {

        }

		public bool GoBack() 
		{

            
            if(createResPanel != null)
            {
                // close create res and return here
                if(createResPanel.Enabled)
                {
                    createResPanel.GoBack();
                    this.Enabled = true;
                    this.BringToFront();
                    this.Show();
                    return false;
                }
            }

            // close current res and return here
            if(empCurrentRes1.Enabled)
            {
                empCurrentRes1.GoBack();
                this.Enabled = true;
                this.BringToFront();
                this.Show();
                return false;
            }

            // return home
            Program.println("Going back from EmpReservationMenu");
            this.Hide();
            this.Enabled = false;
            return true;

        }

        private void EmpReservationMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
