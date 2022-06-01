using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen1A
{
    public partial class Form2a : System.Windows.Forms.Form
    {
        public string msg;
        public Form2 f2;
        public Form2a(string a, Form2 b)
        {
            InitializeComponent();
            msg = a;
            displayedmessage.Text = msg;
            f2 = b;
        }

        private void displayedmessage_Click(object sender, EventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Close();

        }
    }
}
