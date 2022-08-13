using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
