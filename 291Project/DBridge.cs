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
                Console.WriteLine("Initializing Database connection.");
                myConnection = new SqlConnection("Server=tcp:291project.database.windows.net,1433;Initial Catalog=291db;Persist Security Info=False;User ID=coolperson;Password=coolcool321@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                myConnection.Open();
                try
                {
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Could not connect to database.");
                }
            }
        }

        public static SqlDataReader run_query(String query)
        {
            DBridge.init();
            return (new SqlCommand(query)).ExecuteReader();
        }

    }
}
