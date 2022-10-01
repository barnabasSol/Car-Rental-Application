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

            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                string commandText="select * from Earnings(" + "\'" + Profile.current_userid + "\')";
                SqlDataAdapter sd = new SqlDataAdapter(commandText, conn);
                DataSet ds = new DataSet();
                sd.Fill(ds,"Earnings(" + "\'" + Profile.current_userid + "\')");
                dataGridView1.DataSource = ds.Tables["Earnings(" + "\'" + Profile.current_userid + "\')"];



               


            }

            using (SqlConnection conn = new SqlConnection(Program.my_connection_string))
            {
                conn.Open();
                string command = "select dbo.Total_Earings(" + "\'" + Profile.current_userid + "\')";

                SqlCommand cmd =  new SqlCommand(command, conn);
                Decimal total_Amount=(Decimal)cmd.ExecuteScalar();
                Total_Amount_number.Text = total_Amount.ToString();
                conn.Close();

            }

                
        }
    }
}
