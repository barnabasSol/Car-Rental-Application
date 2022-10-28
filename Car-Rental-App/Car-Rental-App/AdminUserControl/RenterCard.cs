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

namespace Car_Rental_App.AdminUserControl
{
    public partial class RenterCard : UserControl
    {
        private Image _gendericon;
        private string _full_name;
        private string _id;
        private string _phone_number;
        private string _address;
        private bool _switch_status;
        public RenterCard()
        {
            InitializeComponent();
        }

        public Image gender
        {
            get { return _gendericon; }
            set { _gendericon = value; rgendericon.Image = value; }
        }

        public string full_name
        {
            get { return _full_name; }
            set { _full_name = value; rnametxt.Text = value; }
        }

        public string id
        {
            get { return _id; }
            set { _id = value; ridtxt.Text = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; raddresstxt.Text = value; }
        }

        public string phone_number
        {
            get { return _phone_number; }
            set { _phone_number = value; rpnumtxt.Text = value; }
        }

        public bool switch_status_m
        {
            get { return _switch_status; }
            set { _switch_status = value; rswitch_status.Value = value; }
        }



        private void load_renter_card()
        {

        }

        private void RenterCard_Load(object sender, EventArgs e)
        {

        }

        private void reditbtn_Click(object sender, EventArgs e)
        {
            EditUserClientForm euf = new EditUserClientForm(id);
            euf.Show();
        }

        private void rswitch_status_Click(object sender, EventArgs e)
        {

            string disable_query = "[disable renter] @rid";
            string enable_query = "update profile set activity=1 where login_id = @rid";
            SqlParameter rid_param = new SqlParameter("@rid", SqlDbType.VarChar, 200);
            rid_param.Value = ridtxt.Text;
            if (rswitch_status.Value == false)
            {
                using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(disable_query, connection))
                    {
                        command.Parameters.Add(rid_param);
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else 
            {
                using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(enable_query, connection))
                    {
                        command.Parameters.Add(rid_param);
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}

