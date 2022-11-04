using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_App.RenterUserControl
{
    public partial class My_Car : UserControl
    {
        public My_Car()
        {
            InitializeComponent();
        }

        private void My_Car_Load(object sender, EventArgs e)
        {

            string command = "select license_plate_no,car_name,car_branch,car_type,verification,car_color,car_condition,price_per_hour,car_status from cars where login_id=" + "\'" + Profile.current_userid + "\'";
            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                int r = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1[0, r].Value = reader["license_plate_no"].ToString();
                    dataGridView1[1, r].Value = reader["car_name"].ToString();
                    dataGridView1[2, r].Value = reader["car_branch"].ToString();
                    dataGridView1[3, r].Value = reader["car_type"].ToString();
                    dataGridView1[4, r].Value = reader["verification"].ToString();
                    dataGridView1[5, r].Value = reader["car_color"].ToString();
                    dataGridView1[6, r].Value = reader["car_condition"].ToString();
                    dataGridView1[7, r].Value = reader["price_per_hour"].ToString();
                    dataGridView1[8, r].Value = reader["car_status"].ToString();

                    r++;
                }


            }
        }

    }
}

