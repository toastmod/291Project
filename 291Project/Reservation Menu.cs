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
    public partial class ReservationMenu : Form
    {
        public ReservationMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeMenu employee = new EmployeeMenu();
            employee.Show();
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void ReservationMenu_Load(object sender, EventArgs e)
        {
            createRes1.SendToBack();
            createReservation1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createReservation1.BringToFront();
        }
    }
}
