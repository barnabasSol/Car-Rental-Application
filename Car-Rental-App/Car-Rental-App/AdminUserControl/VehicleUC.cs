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
        List<VehicleCard> tempvcardlist = new List<VehicleCard>();

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
            tempvcardlist.Clear();
            vpanel.Controls.Clear();
            flbl.Visible = true;
            filterbycbox.Visible = true;
            searchvtxt.Visible = true;
            srchimg.Visible = true;
            addVehicleCards();
        }

        private void addVehicleCards()
        {
            string query = "exec [vehicle card content] @aid";
            SqlParameter aid_param = new SqlParameter("@aid", SqlDbType.VarChar, 200);
            aid_param.Value = Profile.current_userid;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(aid_param);
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
                            vc.rent_id = reader[9].ToString();
                            if (reader[3].ToString() == "verified")
                            {
                                vc.vstatus = Properties.Resources.verified;
                            }
                            else
                            {
                                vc.vstatus = Properties.Resources.unverified;
                            }
                            vc.r_status = reader[6].ToString();
                            if (reader[4].ToString() == "1")
                                vc.status = Properties.Resources.available;
                            else
                                vc.status = Properties.Resources.unavailable;
                            if (reader[4].ToString() == "1")
                                vc.btnstatus = "Disable";
                            else
                                vc.btnstatus = "Enable";
                            if (reader[6].ToString()=="returned" || reader[6].ToString() == "")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;
                            }
                            else 
                            {
                                vc.freebtn = true;
                                vc.currentcus = reader[5].ToString();
                            }
                            vpanel.Controls.Add(vc);
                            tempvcardlist.Add(vc);
                        }

                    }
                }
            }
        }

        public string get_rent_id(string lp)
        {
            foreach (var item in tempvcardlist)
            {
                if (item.licensep == lp)
                {
                    return item.rent_id;
                }
            }
            return null;
        }

        void filter_vehicles(string attribute, string srchfilter)
        {
            string query = "[search car for admin] @attribute, @filter, @admid";
            SqlParameter attribute_param = new SqlParameter("@attribute", SqlDbType.VarChar, 200);
            SqlParameter filter_param = new SqlParameter("@filter", SqlDbType.VarChar, 100);
            SqlParameter admid_param = new SqlParameter("@admid", SqlDbType.VarChar, 200);
            admid_param.Value = Profile.current_userid;
            attribute_param.Value = attribute;
            filter_param.Value = srchfilter;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(attribute_param);
                    command.Parameters.Add(filter_param);
                    command.Parameters.Add(admid_param);
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
                            }
                            if (reader[4].ToString() == "1")
                            {
                                vc.status = Properties.Resources.available;
                                vc.btnstatus = "Disable";
                            }
                            else
                            {
                                vc.status = Properties.Resources.unavailable;
                                vc.btnstatus = "Enable";
                            }
                            if (reader[8].ToString() == "returned" || reader[5].ToString() == "")
                            {
                                vc.currentcus = "not in use";
                                vc.setcurrentuserimg = Properties.Resources.nulluser;
                            }
                            else
                            {
                                vc.freebtn = true;
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
            vpanel.Controls.Clear();
            filter_vehicles("", filter);
            if (filterbycbox.Text == "unreturned")
            {
                vpanel.Controls.Clear();
                 
            }
        }
        private void search_unreturned(string search_by)
        {
            //var x = from y in tempvcardlist
            //        where y.vstatus_string == "unreturned"
            //        select y;

        }

        private void searchvtxt_OnValueChanged_1(object sender, EventArgs e)
        {
                if (filterbycbox.Text == "unreturned")
                {
                vpanel.Controls.Clear();

                }
                vpanel.Controls.Clear();
                search_vehicle(searchvtxt.Text);
        }

        private void search_vehicle(string attribute)
        {
            foreach (var card in tempvcardlist)
            {
                if (card.licensep.Contains(attribute) || card.car_name.Contains(attribute) ||
                    card.car_type.Contains(attribute) || (card.currentcus.Contains(attribute)
                    && card.freebtn==true))
                {
                    vpanel.Controls.Add(card);
                }
            }
        }

        private void vpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
