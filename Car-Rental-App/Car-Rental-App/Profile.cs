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

        public Profile()
        {

        }

        public Profile(string login_id, string password)
        {
            this.login_id = login_id;
            this.password = password;
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
                           if (reader[0].ToString()==login_id && reader[1].ToString() == password)
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



    }
}
