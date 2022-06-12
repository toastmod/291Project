﻿using System;
using System.Windows.Forms;

namespace _291Project
{
    public partial class CustomerMainMenu : Form
    {
        public Splash splashscreen;

        public string CustomerDisplayName { get; set; }
        public CustomerMainMenu(Splash splashscreen)
        {
            this.splashscreen = splashscreen;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            this.splashscreen.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void customer_id_box_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMainMenu_Load_1(object sender, EventArgs e)
        {
            customer_id_box.Text = $"Welcome {CustomerDisplayName}!";

        }

        private void customerReservationMenu1_Load(object sender, EventArgs e)
        {

        }

        private void req_res_button_Click(object sender, EventArgs e)
        {
        }
    }
}
