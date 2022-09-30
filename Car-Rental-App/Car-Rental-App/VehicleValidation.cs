using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Car_Rental_App
{
    class VehicleValidation
    {
        public bool is_unique_lp (string license_plate_no)
        {
            bool is_unique = true;
            string query = "select license_plate_no from cars";
            using(SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == license_plate_no)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return is_unique;
        }

        public bool vehicle_exists(string license_plate_no)
        {
            string query = "select license_plate_no from cars";
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == license_plate_no)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public int is_unique_for_edit(string license_plate_no)
        {
            int x = 0;
            bool is_unique = true;
            string query = "select license_plate_no from cars";
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == license_plate_no)
                            {
                                ++x;
                            }
                        }
                    }
                }
            }
            return x;
        }


    }
}
