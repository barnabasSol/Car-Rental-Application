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
    public partial class VehicleCard : UserControl
    {
        private string _license_plate;
        private string _car_name;
        private string _car_type;
        private bool _deletebtn;
        private Image _vstatus;
        private string _btnstatus;
        private Image _status;
        private Image _currentuserimg;
        private string _curcustomer;

        public VehicleCard()
        {
            InitializeComponent();
        }

        private void VehicleCard_Load(object sender, EventArgs e)
        {
            if (carstatusbtn.ButtonText == "Disable")
            {
                carstatusbtn.ActiveFillColor = Color.Red;
            }
            else
            {
                carstatusbtn.ActiveFillColor = Color.Green;
            }
        }

      

        public string licensep
        {
            get { return _license_plate; }
            set { _license_plate = value; lplbl.Text = value; }
        }
        public string car_name
        {
            get { return _car_name; }
            set { _car_name = value; cnamelbl.Text = value; }
        }
        public string car_type
        {
            get { return _car_type; }
            set { _car_type = value; ctypelbl.Text = value; }
        }
        public bool deletebtn
        {
            get { return _deletebtn; }
            set { _deletebtn = value; delete_btn.Visible = value; }
        }
        public Image vstatus
        {
            get { return _vstatus; }
            set { _vstatus = value; vstatusimg.Image = value; }
        }
        public Image status
        {
            get { return _status; }
            set { _status = value; statusimg.Image = value; }
        }
        public Image setcurrentuserimg
        {
            get { return _currentuserimg; }
            set { _currentuserimg = value; currentuserimg.Image = value; }
        }
        public string btnstatus
        {
            get { return _btnstatus; }
            set { _btnstatus = value; carstatusbtn.ButtonText = value; }
        }
        public string currentcus
        {
            get { return _curcustomer; }
            set { _curcustomer = value; toolTip1.SetToolTip(currentuserimg, value); }
        }


        private void disablebtn_Click(object sender, EventArgs e)
        {
            if (carstatusbtn.ButtonText == "Disable")
            {
                disable_car();
                carstatusbtn.ActiveFillColor = Color.Green;
                carstatusbtn.ButtonText = "Enable";
            }
            else
            {
                enable_car();
                carstatusbtn.ActiveFillColor = Color.Red;
                carstatusbtn.ButtonText = "Disable";
            }
        }

        private void disable_car()
        {
            string query = "[disable car] @lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            lp_param.Value = lplbl.Text;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(lp_param);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void enable_car()
        {
            string query = "[enable car] @lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            lp_param.Value = lplbl.Text;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(lp_param);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "[delete car] @lp";
            SqlParameter lp_param = new SqlParameter("lp", SqlDbType.VarChar, 200);
            lp_param.Value = lplbl.Text;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(lp_param);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            Controls.Remove(this);
        }

        private void edit_vehicle_Click(object sender, EventArgs e)
        {
            EditVehicleForm ev = new EditVehicleForm(lplbl.Text);
            ev.Show();
        }
    }
}
