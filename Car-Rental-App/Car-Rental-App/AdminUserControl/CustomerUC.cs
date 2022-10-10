using System;
using Car_Rental_App.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.AdminUserControl
{
    public partial class CustomerUC : UserControl
    {

        public CustomerUC()
        {
            InitializeComponent();
        }

    
        public void search_customer(string attribute)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            customer_search_panel.Controls.Clear();

            string commandText = "[search customer] @attribute";
            SqlParameter attribute_param = new SqlParameter("@attribute", SqlDbType.VarChar, 100);
            attribute_param.Value = attribute;
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(attribute_param);
                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerCard cc = new CustomerCard();
                            cc.id = reader[0].ToString();
                            cc.full_name = reader[1].ToString();
                            if (reader[2].ToString() == "M")
                            {
                                cc.gender = Resources.male3;
                            }
                            else
                            {
                                cc.gender = Resources.female1;
                            }
                            cc.phone_number = reader[3].ToString();
                            cc.address = reader[4].ToString();
                            if (reader[5].ToString()=="0")
                                   cc.switch_status_m = false;
                            else
                            { 
                                cc.switch_status_m = true;
                            }
                            cc.rep_indicator = int.Parse(reader[6].ToString());
                            customer_search_panel.Controls.Add(cc);
                        }
                    }
                }
            }
        }

        private void searchcustomer_OnValueChanged_1(object sender, EventArgs e)
        {
            slow.Start();
        }

        private void slow_Tick(object sender, EventArgs e)
        {
            search_customer(searchcustomer.Text);
            slow.Stop();
        }

        private void searchcustomer_Enter(object sender, EventArgs e)
        {
            search_customer(searchcustomer.Text);
        }
    }
}
