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
    public partial class RentalQuery : Form
    {

        public RentalQuery()
        {

            // Load branches
            DBridge.run_query("");

            // Load Car types

            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
