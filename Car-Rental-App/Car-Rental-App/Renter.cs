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



            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {

                var stm = "insert into profile ( login_id,first_name , last_name,sex,phone_number, home_address, password, profile_type_id,activity ) values(@login_id,@first_name , @last_name,@sex,@phone_number, @home_address, @password, @profile_type_id,@activity)";
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(stm, conn,tran);
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
                    tran.Commit();
                }
                catch(SqlException p)
                {
                    tran.Rollback();
                    Console.WriteLine("Transaction Rollback");


                }
                finally
                {
                    conn.Close();
                }
            }
            

        }
        public void insert_By_Sp()
        {
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                
          
                SqlTransaction transaction= conn.BeginTransaction(IsolationLevel.Serializable);
          
                try
                {
                    Console.WriteLine(transaction.IsolationLevel);
                    SqlCommand cmd = new SqlCommand("Insert_Profile", conn,transaction);
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
                    transaction.Commit();

                
                }
                catch(SqlException ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Rollback");

                }
                finally
                {
                    conn.Close();
                }

            }
        

        }

        public void reset_Password(string id, string new_password)
        {
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("reset_renter_password", conn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@login_id ", SqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@new_password", SqlDbType.VarChar).Value = new_password;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(SqlException p)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Rollback");

                }
                finally
                {
                    conn.Close();
                }
            }
           
        }

        public void addcar(string license_plate_no,string car_name,string car_type,int car_capacity,string car_model, string car_color, int car_condition, string car_branch ,double price,string current_loginid )
        {
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string)) {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {

                    SqlCommand cmd = new SqlCommand("insert_car", conn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@license_plate_no", SqlDbType.VarChar).Value = license_plate_no;
                    cmd.Parameters.AddWithValue("@car_name", SqlDbType.VarChar).Value = car_name;
                    cmd.Parameters.AddWithValue("@car_type", SqlDbType.VarChar).Value = car_type;
                    cmd.Parameters.AddWithValue("@car_capacity", SqlDbType.Int).Value = car_capacity;
                    cmd.Parameters.AddWithValue("@car_model", SqlDbType.VarChar).Value = car_model;
                    cmd.Parameters.AddWithValue("@car_color", SqlDbType.VarChar).Value = car_color;
                    cmd.Parameters.AddWithValue("@car_condition", SqlDbType.Int).Value = car_condition;
                    cmd.Parameters.AddWithValue("@car_branch", SqlDbType.NVarChar).Value = car_branch;
                    cmd.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
                    cmd.Parameters.AddWithValue("@login_id", SqlDbType.VarChar).Value = current_loginid;
                    cmd.Parameters.AddWithValue("@rep_min_req", SqlDbType.VarChar).Value = 5;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(SqlException e)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Rollback");
                }
                finally
                {
                    conn.Close();
                }
            }
                
            }

        public void Edit_Renter_Account(string FirstName,string LastName,string Phone,string Address,string sex,string currentuserid)
        {
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try { 
                SqlCommand cmd = new SqlCommand("Edit_renter_Account", conn,tran);
               
                
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@First_Name", SqlDbType.VarChar).Value = FirstName;
                    cmd.Parameters.AddWithValue("@Last_Name", SqlDbType.VarChar).Value = LastName;
                    cmd.Parameters.AddWithValue("@phone", SqlDbType.VarChar).Value = Phone;
                    cmd.Parameters.AddWithValue("@homeaddress", SqlDbType.VarChar).Value = Address;
                    cmd.Parameters.AddWithValue("@sex", SqlDbType.VarChar).Value = sex;
                    cmd.Parameters.AddWithValue("@currentuserid ", SqlDbType.VarChar).Value = currentuserid;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                }
                catch(SqlException p)
                {
                    tran.Rollback();
                    Console.WriteLine("Transaction Rollback");
                }
                finally
                {
                    conn.Close();
                }
            }
           

        }
        public void Deactivate_Renter_Account(string currentuserid)
        {

            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("deactivate_renter_account", conn, tran);
               
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@renterid", SqlDbType.VarChar).Value = currentuserid;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                }catch(SqlException p)
                {
                    tran.Rollback();
                    Console.WriteLine("Transaction Rollback");
                }
                finally
                {
                    conn.Close();
                }
            }
            

        }


    }
}
