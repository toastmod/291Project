using System;
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
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ReservationMenu_Load(object sender, EventArgs e)
        {
            createRes1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
