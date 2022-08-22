using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_App
{
    class Profile
    {
        public string login_id { get; set; }
        public string first_name { get; set; }
        public string  last_name  { get; set; }
        public string  sex { get; set; }
        public string phone { get; set; }
        public string home_adress { get; set; }
        public string password { get; set; }
        public int profile_type { get; set; }

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

        public bool validate_password_for_renter(string loginid, string oldpsw)
        {
            string command = "Select password from profile where login_id=@loginid";
            
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                SqlCommand cmd=new SqlCommand(command, conn);
                cmd.Parameters.Add(new SqlParameter("@loginid", System.Data.SqlDbType.VarChar, 200)).Value = loginid;
                cmd.Prepare();
                string check = (string)cmd.ExecuteScalar();
                if (check == oldpsw)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public bool validate_password(string loginid, string oldpsw)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            string query = "select password from profile where login_id=@loginid";
            SqlParameter lid_par = new SqlParameter("@loginid", SqlDbType.VarChar, 100);
            lid_par.Value = loginid;
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(lid_par);
                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != oldpsw)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void reset_admin_password(string loginid, string newpsw)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;

            string commandText = "exec [reset_admin_password] @loginid, @newpsw";
            SqlParameter idparam = new SqlParameter("@loginid", SqlDbType.VarChar, 100);
            SqlParameter new_psw_param = new SqlParameter("@newpsw", SqlDbType.VarChar, 100);
            idparam.Value = loginid;
            new_psw_param.Value = newpsw;
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(idparam);
                    command.Parameters.Add(new_psw_param);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


