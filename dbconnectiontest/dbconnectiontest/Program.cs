﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        static string my_connection_string = "Data Source=DESKTOP-CRCECQ7\\SQLEXPRESS;" +
                                             "Initial Catalog=connectiontest;" +
                                             "Integrated Security=SSPI;";
        static void Main(string[] args)
        {

            int id = 1;
            string n = "aster; drop table trial";

             write(id, n);
           // read();
        }

        public static void write(int id, string name)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = my_connection_string;

            string commandText = "exec enter_data @id, @name";
            SqlParameter idparam = new SqlParameter("@id", SqlDbType.Int, 0) ;
            SqlParameter nameparam = new SqlParameter("@name", SqlDbType.VarChar, 50);
            idparam.Value = id;
            nameparam.Value = name;
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(idparam);
                    command.Parameters.Add(nameparam);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }


            string commandText = "SELECT id, name from dbo.trial";

        public static void read()
        {
            int item = 3;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = my_connection_string;
            string commandText = "select * from trial where id=@id";
            SqlParameter idpar = new SqlParameter("@id", SqlDbType.Int, 0);
            idpar.Value = item;

            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(idpar);
                    command.Prepare();
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
