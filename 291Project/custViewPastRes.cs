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
    public partial class custViewPastRes : UserControl
    {
        public custViewPastRes()
        {   
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CustViewPastFilters() == false)
            {
                CustViewPastFilters filters = new();
                filters.Show();
            }
            
      
                


        }

        private bool CustViewPastFilters()
        {
            throw new NotImplementedException();
        }
    }
}
