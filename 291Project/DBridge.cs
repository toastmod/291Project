using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291Project
{
    public static class DBridge
    {
        public static bool initialized = false;
        public static SqlConnection myConnection;
        public static SqlCommand myCommand;
        public static SqlDataReader myReader;

        public static void init()
        {
            if (!initialized)
            {
                Console.WriteLine("Initializing Database connection.");
                myConnection = new SqlConnection("Server=tcp:291project.database.windows.net,1433;Initial Catalog=291db;Persist Security Info=False;User ID=coolperson;Password=coolcool321@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                myConnection.Open();
                try
                {
                    myCommand = new SqlCommand();
                    myCommand.Connection = myConnection;
                    initialized = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Could not connect to database.");
                    initialized = false;
                }

            }
        }

        public static SqlDataReader run_query(String query)
        {
            DBridge.init();
            myCommand.CommandText = query;

            if (myReader != null)
            {
                myReader.Close();
            }

            myReader = myCommand.ExecuteReader();
            return myReader;
        }

        public static void accept_res(String res_id)
        {
            var i = 0;
            if (int.TryParse(res_id, System.Globalization.NumberStyles.Integer, null, out i))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = $"UPDATE Reservations SET Status = \"ACCEPTED\" WHERE res_id = ${res_id.ToString()} AND Status = \"REQUESTED\"";
            }
            else
            {
                MessageBox.Show("Invalid input","Invalid input");
            }

        }

    }
}
