using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project {
    public partial class Form2a : System.Windows.Forms.Form
    {
        public string msg;
        public CSignUpForm f2;
        public Form2a(string signup_msg, CSignUpForm b)
        {
            InitializeComponent();
            msg = signup_msg;
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
