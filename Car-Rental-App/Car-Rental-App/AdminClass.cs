using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Car_Rental_App
{
    class AdminClass
    {
        public string task { get; set; }
        public string done_date { get; set; }

        private static List<AdminClass> audit_list = new List<AdminClass>();
        private static List<AdminClass> srch_list = new List<AdminClass>();


        public AdminClass (string task, string done_date)
        {
            this.task = task;
            this.done_date = done_date;
        }
        public AdminClass()
        {

        }


        public void read_audit(string order)
        {
            audit_list.Clear();
            string commandText = order;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Program.my_connection_string;
            if (string.IsNullOrEmpty(commandText))
            {
                commandText = "select task, done_date from audit where admin_id=" + "\'" + Profile.current_userid + "\'";
            }
            else
            {
                 commandText = order;
            }
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader[0].ToString();
                            string done_date = reader[1].ToString();
                            AdminClass a = new AdminClass(task, done_date);
                            audit_list.Add(a);
                        }
                    }
                    connection.Close();
                }
            }
        }
        public List<AdminClass> get_audit()
        {
            return audit_list;
        }


        public void search_item(string item)
        {
            srch_list.Clear();
            string commandText = item;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Program.my_connection_string;
            commandText = "select task, done_date from audit where (admin_id=" + "\'" +
                Profile.current_userid + "\') and (task like " + "\'" + "%" + "\'+" + "\'" + item + "\'" +
                "+\'" + "%" + "\' or done_date like " + "\'" + "%" + "\'+" + "\'" + item + "\'" + "+\'" + "%" + "\')";
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader[0].ToString();
                            string done_date = reader[1].ToString();
                            AdminClass a = new AdminClass(task, done_date);
                            srch_list.Add(a);
                        }
                    }
                    connection.Close();
                }
            }
        }

        public List<AdminClass> get_srch_result()
        {
            return srch_list;
        }
    }
}
