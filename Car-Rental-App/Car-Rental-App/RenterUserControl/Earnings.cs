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
    public partial class Earnings : UserControl
    {
        public Earnings()
        {
            InitializeComponent();
        }

        private void Earnings_Load(object sender, EventArgs e)
        {

            EarningsDataGrid1.DefaultCellStyle.SelectionBackColor = EarningsDataGrid1.DefaultCellStyle.BackColor;

            EarningsDataGrid1.DefaultCellStyle.SelectionForeColor = EarningsDataGrid1.DefaultCellStyle.ForeColor;


            string commandText = "select * from Earnings(" + "\'" + Profile.current_userid + "\')";

             using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {

                conn.Open();
                SqlCommand cmd =new SqlCommand(commandText, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int r = 0;
                while (reader.Read())
                {
                    EarningsDataGrid1.Rows.Add(1);
                    EarningsDataGrid1[0,r].Value = reader["license_plate_no"].ToString();
                    EarningsDataGrid1[1,r].Value = reader["car_name"].ToString();
                    EarningsDataGrid1[2,r].Value = reader["car_branch"].ToString();
                    EarningsDataGrid1[3,r].Value = reader["firstname"].ToString();
                    EarningsDataGrid1[4,r].Value = reader["rental_date"].ToString();
                    EarningsDataGrid1[5,r].Value = reader["total_vehicles"].ToString();
                    EarningsDataGrid1[6,r].Value = reader["return_date"].ToString();
                    EarningsDataGrid1[7,r].Value = reader["paid_amount"].ToString();
                    
                    r++;
                }
            }

            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                string command = "select dbo.Total_Earings(" + "\'" + Profile.current_userid + "\')";

                SqlCommand cmd = new SqlCommand(command, conn);
                Decimal total_Amount = (Decimal)cmd.ExecuteScalar();
                Total_Amount_number.Text = total_Amount.ToString();
                conn.Close();

            }


        }
    }
}
