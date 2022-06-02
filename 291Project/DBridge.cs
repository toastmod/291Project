using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public static class DBridge
    {
        public static bool initialized;
        public static SqlConnection myConnection;
        public static SqlCommand myCommand;
        public static SqlDataReader myReader;

        public static void init()
        {
            if(!initialized)
            {
                myConnection = new SqlConnection("Server = DESKTOP-BDONDJ3; Database = lab3_thursday; Trusted_Connection = yes");
                myConnection.Open();
                try
                {
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Cound not connect to database.");
                }
            }
        }

        public static SqlDataReader run_query(String query)
        {

            return (new SqlCommand(query)).ExecuteReader();
        }

    }
}
