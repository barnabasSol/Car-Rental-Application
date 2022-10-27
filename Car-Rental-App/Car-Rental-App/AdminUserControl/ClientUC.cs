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
    public partial class ClientUC : UserControl
    {
        string the_table = "";
        string selected_filter = "";

        public ClientUC()
        {
            InitializeComponent();
        }


        public void search_user_client(string attribute)
        {
            string commandText;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;
            search_user_client_panel.Controls.Clear();
            if (comboBox1.Text == "Customer")
            {
                commandText = "[search customer] @attribute";
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
                                if (reader[5].ToString() == "0")
                                    cc.switch_status_m = false;
                                else
                                {
                                    cc.switch_status_m = true;
                                }
                                cc.rep_indicator = int.Parse(reader[6].ToString());
                                search_user_client_panel.Controls.Add(cc);
                            }
                        }
                    }
                }

            }
            else
            {
                SqlParameter attribute_param = new SqlParameter("@attribute", SqlDbType.VarChar, 100);
                commandText = "[search renter] @attribute";
                attribute_param.Value = searchclienttxt.Text;

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
                                RenterCard rc = new RenterCard();
                                rc.id = reader[0].ToString();
                                rc.full_name = reader[1].ToString();
                                if (reader[2].ToString() == "M")
                                {
                                    rc.gender = Resources.male3;
                                }
                                else
                                {
                                    rc.gender = Resources.female1;
                                }
                                rc.phone_number = reader[3].ToString();
                                rc.address = reader[4].ToString();
                                if (reader[5].ToString() == "0")
                                    rc.switch_status_m = false;
                                else
                                {
                                    rc.switch_status_m = true;
                                }
                                search_user_client_panel.Controls.Add(rc);
                            }
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
            search_user_client(searchclienttxt.Text);
            slow.Stop();
        }

        private void searchcustomer_Enter(object sender, EventArgs e)
        {
            search_user_client(searchclienttxt.Text);
        }
 


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_filter = comboBox1.Text;
            if (selected_filter == "renter") { 
            search_user_client_panel.Controls.Clear();
            string query = "[get_renter_for_admin]";
            using (SqlConnection connection = new SqlConnection())
            {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            RenterCard rc = new RenterCard();
                            rc.id = reader[0].ToString();
                            rc.full_name = reader[1].ToString();
                            if (reader[2].ToString() == "M")
                            {
                                rc.gender = Resources.male3;
                            }
                            else
                            {
                                rc.gender = Resources.female1;
                            }
                            rc.phone_number = reader[3].ToString();
                            rc.address = reader[4].ToString();
                            if (reader[5].ToString() == "0")
                                rc.switch_status_m = false;
                            else
                            {
                                rc.switch_status_m = true;
                            }
                            search_user_client_panel.Controls.Add(rc);
                        }
                    }
            }
        }
            else
            {
                search_user_client(searchclienttxt.Text);
            }

        }

        private void ClientUC_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "customer";
        }
    }
    }

