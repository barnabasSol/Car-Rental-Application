using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_App
{
    class Profile
    {
        public string login_id { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }

        public static string current_userid;

        public Profile()
        {

        }

        public Profile(string login_id, string password)
        {
            this.login_id = login_id;
            this.password = password;
        }

        public bool valdation(string login_id)
        {
            bool valdation1 = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string commandText = "select login_id from profile ";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == login_id)
                            {
                                valdation1 = true;
                                break;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return valdation1;
        }
        public bool is_customer(string login_id, string password)
        {
            bool isCustomer = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string commandText = "select login_id, password from profile where profile_type_id=2";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == login_id && reader[1].ToString() == password)
                            {
                                isCustomer = true;
                                break;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return isCustomer;
        }

        public bool is_admin(string login_id, string password)
        {
            bool isAdmin = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string commandText = "select login_id, password from profile where profile_type_id=1";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == login_id && reader[1].ToString() == password)
                            {
                                isAdmin = true;
                                break;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return isAdmin;
        }


        public bool is_renter(string login_id, string password)
        {
            bool isRenter = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string commandText = "select login_id, password from profile where profile_type_id=3";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == login_id && reader[1].ToString() == password)
                            {
                                isRenter = true;
                                break;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return isRenter;
        }

        public string get_full_name(string login_id)
        {
            string full_name = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string commandText = "select first_name, last_name from profile where login_id=" + "\'"+login_id+"\'";
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            full_name = reader[0].ToString() + " " + reader[1].ToString();
                        }
                    }

                    connection.Close();
                }
                return full_name;
            }
        }
    }
}


