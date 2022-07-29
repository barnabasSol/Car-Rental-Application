using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace dbconnectiontest
{

    /*
     * for testing purposes create a database named - connectiontest
     * use it
     * create table named trial and let it have 2 columns named, id (int) and name (varchar) and insert a few data
     * then before running this code change the datasource to your server name
     * this code is just to read from a table
      
     
     */
    class Program
    {
        static string my_connection_string = "Data Source=BARNEY\\SQLEXPRESS;" +
                                             "Initial Catalog=connectiontest;" +
                                             "Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            int id = 7;
            string n = "aster";

             write(id, n);
           // read();
        }

        public static void write(int id, string name)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = my_connection_string;
            string commandText = "exec enter_data "+id+", "+name;
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                }
            }
        }

        public static void read()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = my_connection_string;
            string commandText = "select * from trial";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write(reader[0] + " ");
                            Console.WriteLine(reader[1]);
                        }
                    }
                    connection.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
