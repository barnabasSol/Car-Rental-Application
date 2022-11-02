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
        private bool _freebtn;
        private Image _vstatus;
        private string _btnstatus;
        private Image _status;
        private Image _currentuserimg;
        private string _curcustomer;
        public string r_status { get; set; }
        public string rent_id { get; set; }


        public VehicleCard()
        {
            InitializeComponent();
        }

        private void VehicleCard_Load(object sender, EventArgs e)
        {
            if (free_btn.Visible == true)
            {
                carstatusbtn.Visible = false;
            }
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
        public bool freebtn
        {
            get { return _freebtn; }
            set { _freebtn = value; free_btn.Visible = value; }
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

        private void update_return_status(string lp)
        {
            string query = "delete from rented_cars where license_plate_no=@lp";
            string query2 = "update rented_cars_log set return_status='returned' where license_plate_no=@lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            SqlParameter lp_param2 = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            lp_param.Value = lp;
            lp_param2.Value = lp;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    SqlCommand command_1 = new SqlCommand(query, connection, transaction);
                    command_1.Parameters.Add(lp_param);
                    command_1.Prepare();
                    command_1.ExecuteNonQuery();

                    SqlCommand command_2 = new SqlCommand(query2, connection, transaction);
                    command_2.Parameters.Add(lp_param2);
                    command_2.Prepare();
                    command_2.ExecuteNonQuery();

                    free_btn.ButtonText = "Freed!";
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show(e.Message);
                }
            }


        }


        private void edit_vehicle_Click(object sender, EventArgs e)
        {
            EditVehicleForm ev = new EditVehicleForm(lplbl.Text);
            ev.Show();
        }

        private void free_btn_Click(object sender, EventArgs e)
        {
            enable_car();
            undofreebtn.Visible = true;
            update_return_status(lplbl.Text);
        }



        private void undofreebtn_Click(object sender, EventArgs e)
        {
            undofreebtn.Visible = false;
            disable_car();
            string query = "insert into rented_cars(r_id, license_plate_no) values(@rid, @lp)";
            string query2 = "update rented_cars_log set return_status='unreturned' where license_plate_no=@lp";
            SqlParameter rid_param = new SqlParameter("@rid", SqlDbType.VarChar, 100);
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            SqlParameter lp_param2 = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            rid_param.Value = rent_id;
            lp_param.Value = lplbl.Text;
            lp_param2.Value = lplbl.Text;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    SqlCommand command_1 = new SqlCommand(query, connection, transaction);
                    command_1.Parameters.Add(lp_param);
                    command_1.Parameters.Add(rid_param);
                    command_1.Prepare();
                    command_1.ExecuteNonQuery();

                    SqlCommand command_2 = new SqlCommand(query2, connection, transaction);
                    command_2.Parameters.Add(lp_param2);
                    command_2.Prepare();
                    command_2.ExecuteNonQuery();

                    free_btn.ButtonText = "Free Vehicle";
                    transaction.Commit();
                }
                catch (Exception e1)
                {
                    transaction.Rollback();
                    MessageBox.Show(e1.Message);
                }
            }
        }
    }
}