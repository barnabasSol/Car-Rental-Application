using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Car_Rental_App
{
    internal class Renter   : Profile
    {


        public void insert()
        {



            SqlConnection conn = new SqlConnection(Program.my_connection_string);

            var stm = "insert into profile ( login_id,first_name , last_name,sex,phone_number, home_address, password, profile_type_id,activity ) values(@login_id,@first_name , @last_name,@sex,@phone_number, @home_address, @password, @profile_type_id,@activity)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(stm, conn);
            cmd.Parameters.Add(new SqlParameter("@login_id", System.Data.SqlDbType.VarChar, 200)).Value = login_id;
            cmd.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 100)).Value = first_name;
            cmd.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 100)).Value = last_name;
            cmd.Parameters.Add(new SqlParameter("@sex", System.Data.SqlDbType.VarChar, 2)).Value = sex;
            cmd.Parameters.Add(new SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 100)).Value = phone;
            cmd.Parameters.Add(new SqlParameter("@home_address", System.Data.SqlDbType.VarChar, 100)).Value = home_adress;
            cmd.Parameters.Add(new SqlParameter("@password", System.Data.SqlDbType.VarChar, 100)).Value = password;
            cmd.Parameters.Add(new SqlParameter("@profile_type_id", System.Data.SqlDbType.Int)).Value = profile_type;
            cmd.Parameters.Add(new SqlParameter("@activity", System.Data.SqlDbType.Int)).Value = 1;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void insert_By_Sp()
        {
            SqlConnection conn = new SqlConnection(Program.my_connection_string);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert_Profile", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@login_id", SqlDbType.VarChar).Value = login_id;
            cmd.Parameters.AddWithValue("@first_name", SqlDbType.VarChar).Value = first_name;
            cmd.Parameters.AddWithValue("@last_name", SqlDbType.VarChar).Value = last_name;
            cmd.Parameters.AddWithValue("@sex", SqlDbType.VarChar).Value = sex;
            cmd.Parameters.AddWithValue("@phone_number", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.AddWithValue("@home_address", SqlDbType.VarChar).Value = home_adress;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.AddWithValue("@profile_type_id", SqlDbType.Int).Value = profile_type;
            cmd.Parameters.AddWithValue("@Activity", SqlDbType.Int).Value = 1;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void reset_Password(string id, string new_password)
        {
            SqlConnection conn = new SqlConnection(Program.my_connection_string);
            conn.Open();
            SqlCommand cmd = new SqlCommand("reset_renter_password", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login_id ",SqlDbType.VarChar).Value = id;
            cmd.Parameters.AddWithValue("@new_password", SqlDbType.VarChar).Value = new_password;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
