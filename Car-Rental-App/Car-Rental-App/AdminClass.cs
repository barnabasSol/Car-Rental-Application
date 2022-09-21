using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
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
            if (string.IsNullOrEmpty(commandText))
            {
                commandText = "select task, done_date from audit where admin_id=" + "\'" + Profile.current_userid + "\'";
            }
            else
            {
                 commandText = order;
            }
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
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
            string commandText = "[search audit] @item, @admid";
            SqlParameter param_item = new SqlParameter("@item", SqlDbType.VarChar, 1000);
            SqlParameter param_admid = new SqlParameter("@admid", SqlDbType.VarChar, 100);
            param_item.Value = item;
            param_admid.Value = Profile.current_userid;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(param_item);
                    command.Parameters.Add(param_admid);
                    command.Prepare();
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
                }
            }
        }

        public List<AdminClass> get_srch_result()
        {
            return srch_list;
        }
    }
}
