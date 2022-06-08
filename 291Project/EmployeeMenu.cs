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
    public partial class EmployeeMenu : Form
    {
        public Splash splash;
        bool sidebarExpand;

        public EmployeeMenu()
        {
            InitializeComponent();
            sidebarTimer.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            sidebarExpand = !sidebarExpand;
            sidebarTimer.Interval = (int)(1000.0f / 80.0f);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            // Set the Minimum and maximum size of sidebar Panel
            if (sidebarExpand)
            {

                if(sidebar.Width > 0)
                {
                    sidebar.Width -= 5;
                }
                //sidebarExpand = false;

                // if sidebar is expand, minimize
                //if (sidebar.Width == sidebar.MinimumSize.Width)
                //{
                //   sidebarTimer.Stop();
                //}
            }
            else
            {
                if (sidebar.Width <= sidebar.MaximumSize.Width)
                {
                    sidebar.Width += 5;
                }
                //sidebarExpand = true;
            }
            //else {
            //    sidebar.Width += 10;
            //    if(sidebar.Width == sidebar.MaximumSize.Width)
            //    {
            //        sidebarExpand = true;
            //        sidebarTimer.Stop();
            //    }
            }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {

        }
    }
    
}
