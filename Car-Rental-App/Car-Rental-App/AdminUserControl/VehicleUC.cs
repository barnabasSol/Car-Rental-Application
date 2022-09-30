using System;
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
    public partial class VehicleUC : UserControl
    {
        private string filter = "";
        AdminForm1 vehicleform;
        public VehicleUC(AdminForm1 parentform)
        {
            vehicleform = parentform;
            InitializeComponent();
        }

        public void add_user_control(UserControl uc)
        {
            vpanel.Controls.Clear();
            vpanel.Controls.Add(uc);
        }

        private void addvehiclebtn_Click(object sender, EventArgs e)
        {
            flbl.Visible = false;
            searchvtxt.Visible = false;
            filterbycbox.Visible = false;
            srchimg.Visible = false;
            AddVehicleUCcs av = new AddVehicleUCcs();
            add_user_control(av);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            vpanel.Controls.Clear();
            flbl.Visible = true;
            filterbycbox.Visible = true;
            searchvtxt.Visible = true;
            srchimg.Visible = true;
            addVehicleCards();
        }

        private void addVehicleCards()
        {
            string query = "[vehicle card content]";
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VehicleCard vc = new VehicleCard
                            {
                                licensep = reader[0].ToString(),
                                car_name = reader[1].ToString(),
                                car_type = reader[2].ToString()
                            };
                            if (reader[3].ToString() == "verified")
                            {
                                vc.vstatus = Properties.Resources.verified;
                            }
                            else
                            {
                                vc.vstatus = Properties.Resources.unverified;
                                vc.deletebtn = true;
                            }

                            if (reader[4].ToString() == "1")
                                vc.status = Properties.Resources.available;
                            else
                                vc.status = Properties.Resources.unavailable;
                            if (reader[4].ToString() == "1")
                                vc.btnstatus = "Disable";
                            else
                                vc.btnstatus = "Enable";
                            if (reader[5].ToString() == "")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;
                            }
                            else if (reader[5].ToString() != "" && reader[4].ToString()=="1")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;
                                
                            }
                            else
                            {
                                vc.currentcus = reader[5].ToString();
                                vc.setcurrentuserimg = Properties.Resources.user;
                            }
                            vpanel.Controls.Add(vc);
                        }
                    }
                }
            }
        }

        private void searchv_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        void search_vehicle(string attribute, string srchfilter)
        {
            string query = "[search car for admin] @attribute, @filter";
            SqlParameter attribute_param = new SqlParameter("@attribute", SqlDbType.VarChar, 200);
            SqlParameter filter_param = new SqlParameter("@filter", SqlDbType.VarChar, 100);
            filter_param.Value = srchfilter;
            attribute_param.Value = attribute;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(attribute_param);
                    command.Parameters.Add(filter_param);
                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VehicleCard vc = new VehicleCard
                            {
                                licensep = reader[0].ToString(),
                                car_name = reader[1].ToString(),
                                car_type = reader[2].ToString()
                            };
                            if (reader[3].ToString() == "verified")
                            {
                                vc.vstatus = Properties.Resources.verified;
                            }
                            else
                            {
                                vc.vstatus = Properties.Resources.unverified;
                                vc.deletebtn = true;
                            }

                            if (reader[4].ToString() == "1")
                                vc.status = Properties.Resources.available;
                            else
                                vc.status = Properties.Resources.unavailable;
                            if (reader[4].ToString() == "1")
                                vc.btnstatus = "Disable";
                            else
                                vc.btnstatus = "Enable";
                            if (reader[5].ToString() == "")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;
                            }
                            else if (reader[5].ToString() != "" && reader[4].ToString() == "1")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;

                            }
                            else
                            {
                                vc.currentcus = reader[5].ToString();
                                vc.setcurrentuserimg = Properties.Resources.user;
                            }
                            vpanel.Controls.Add(vc);
                        }
                    }
                    
                }
            }

        }

   

        private void filterbycbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = filterbycbox.Text;
            if (filter == "")
            {
                filter = "none";
            }
        }

        private void searchvtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (filter == "")
            {
                filter = "none";
            }
            vpanel.Controls.Clear();
            search_vehicle(searchvtxt.Text, filter);
        }
    }
}
