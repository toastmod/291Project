using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _291Project
{
    public partial class EmpCurrentRes : UserControl
    {

        private DataTable dt = new DataTable();
        private SqlDataReader reader = null;
        public EmpCurrentRes()
        {
            InitializeComponent();
            var date = DateTime.Now;
            reader = DBridge.run_query($"WITH ReservationsAfter as (SELECT * FROM (SELECT * FROM(SELECT * FROM Reservations as R WHERE ${date.Year} >= R.From_Year) as R1 WHERE ${date.Month} >= R1.From_Month) as R2 WHERE ${date.Day} >= R2.From_Day) SELECT * FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM ReservationsAfter as RA WHERE ${date.Year} < RA.To_Year) as RA1 WHERE ${date.Month} < RA1.To_Month) as RA2) as RA3 WHERE ${date.Day} < RA3.To_Day");
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void GoBack()
        {
            Program.println("Going back from EmpCurrentRes");
            this.Visible = false;
            this.Hide();
            this.SendToBack();
            this.Enabled = false;
        }
    }
}
