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
    public partial class AddVehicleUCcs : UserControl
    {
        private string temp_lp;
        public AddVehicleUCcs()
        {
            InitializeComponent();
        }
        VehicleValidation vv = new VehicleValidation();

        private void AddVehicleUCcs_Load(object sender, EventArgs e)
        {

        }

        private void lptxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lptxt.Text) || lptxt.Text == "enter license plate")
            {
                lptxt.Text = "";
                lptxt.ForeColor = Color.Black;
            }
        }

        private void lptxt_Leave(object sender, EventArgs e)
        {
            if (lptxt.Text == "")
            {
                lptxt.Text = "enter license plate";
                lptxt.ForeColor = Color.Gray;
            }
        }

        private void cnametxt_Enter(object sender, EventArgs e)
        {
            if (cnametxt.Text == "enter car name")
            {
                cnametxt.Text = "";
                cnametxt.ForeColor = Color.Black;
            }
        }

        private void cnametxt_Leave(object sender, EventArgs e)
        {
            if (cnametxt.Text == "")
            {
                cnametxt.Text = "enter car name";
                cnametxt.ForeColor = Color.Gray;
            }
        }

       

        private void cmodeltxt_Enter(object sender, EventArgs e)
        {
            if (cmodeltxt.Text == "enter car model")
            {
                cmodeltxt.Text = "";
                cmodeltxt.ForeColor = Color.Black;
            }
        }

        private void cmodeltxt_Leave(object sender, EventArgs e)
        {
            if (cmodeltxt.Text == "")
            {
                cmodeltxt.Text = "enter car model";
                cmodeltxt.ForeColor = Color.Gray;
            }
        }

     

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool all_safe = true;
            errorProvider1.SetError(lptxt, null);
            errorProvider1.SetError(cnametxt, null);
            errorProvider1.SetError(cartype_cbox, null);
            errorProvider1.SetError(ccapacity_cbox, null);
            errorProvider1.SetError(cmodeltxt, null);
            errorProvider1.SetError(ccolor_cbox, null);
            errorProvider1.SetError(pphtxt, null);
            lptxt.LineIdleColor = Color.DimGray;
            errorProvider1.SetError(lptxt, null);
            if (string.IsNullOrEmpty(lptxt.Text) || lptxt.Text=="enter license plate" || !vv.is_unique_lp(lptxt.Text))
            {
                lptxt.LineIdleColor = Color.Red;
                errorProvider1.SetError(lptxt, "error input here");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(cnametxt.Text) || cnametxt.Text == "enter car name")
            {
                cnametxt.LineIdleColor = Color.Red;
                errorProvider1.SetError(cnametxt, "error input here");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(cartype_cbox.Text) || !is_car_type(cartype_cbox.Text))
            {
                errorProvider1.SetError(cartype_cbox, "error here");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(ccapacity_cbox.Text) || !is_car_seats(ccapacity_cbox.Text))
            {
                errorProvider1.SetError(ccapacity_cbox, "enter number only or choose from list");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(cmodeltxt.Text) || cmodeltxt.Text == "enter car model")
            {
                errorProvider1.SetError(cmodeltxt, "enter car model");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(ccolor_cbox.Text) || !is_car_color(ccolor_cbox.Text))
            {
                errorProvider1.SetError(ccolor_cbox, "error here");
                all_safe = false;
            }
            if (string.IsNullOrEmpty(pphtxt.Text) || Decimal.TryParse(pphtxt.Text, out Decimal result)==false)
            {
                errorProvider1.SetError(pphtxt, "error here");
                all_safe = false;
            }
            if (all_safe)
            {
                undobtn.Visible = true;
                temp_lp = lptxt.Text;
                int car_capacity;
                if (int.TryParse(cartype_cbox.Text, out int result1) == true)
                {
                    car_capacity = int.Parse(cartype_cbox.Text);
                }
                else
                {
                      string[] temp = ccapacity_cbox.Text.Split(' ');
                      car_capacity = int.Parse(temp[0]);
                }
                addVehicle(lptxt.Text, cnametxt.Text, cartype_cbox.Text, car_capacity,
                    cmodeltxt.Text, ccolor_cbox.Text, car_condition_slider.Value, car_rep_slider.Value,
                    decimal.Parse(pphtxt.Text), Profile.current_userid);
                MessageBox.Show("successfully added", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_content();
            }
        }

        void undo(string license_plate_no)
        {

            string query = "[undo added vehicle] @lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            lp_param.Value = license_plate_no;
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

        private void undobtn_Click(object sender, EventArgs e)
        {

            undo(temp_lp);
        }

        void clear_content()
        {
            lptxt.Text = "";
            cnametxt.Text = "";
            cartype_cbox.Text = "";
            ccapacity_cbox.Text = "";
            cmodeltxt.Text = "";
            ccolor_cbox.Text = "";
            car_condition_slider.Value = 0;
            car_rep_slider.Value = 0;
            pphtxt.Text = "";
        }

        public void addVehicle (string lp, string cname, string ctype, int ccapacity, string cmodel, string ccolor, int ccondition, int rep, Decimal pph, string adminid)
        {
            string query = "[insert cars by admin] @lp, @cname, @ctype, @ccapacity, @cmodel, @ccolor, @ccondition, @rep, @pph, @admid";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            SqlParameter cname_param = new SqlParameter("@cname", SqlDbType.VarChar, 100);
            SqlParameter ctype_param = new SqlParameter("@ctype", SqlDbType.VarChar, 100);
            SqlParameter ccapacity_param = new SqlParameter("@ccapacity", SqlDbType.Int, 0);
            SqlParameter cmodel_param = new SqlParameter("@cmodel", SqlDbType.VarChar, 100);
            SqlParameter ccolor_param = new SqlParameter("@ccolor", SqlDbType.VarChar, 100);
            SqlParameter ccondition_param = new SqlParameter("@ccondition", SqlDbType.Int, 100);
            SqlParameter rep_param = new SqlParameter("@rep", SqlDbType.Int, 100);
            SqlParameter pph_param = new SqlParameter("@pph", SqlDbType.Decimal, 18);
            SqlParameter admid_param = new SqlParameter("@admid", SqlDbType.VarChar, 100);

            lp_param.Value = lp;
            cname_param.Value = cname;
            ctype_param.Value = ctype;
            ccapacity_param.Value = ccapacity;
            cmodel_param.Value = cmodel;
            ccolor_param.Value = ccolor;
            ccondition_param.Value = ccondition;
            rep_param.Value = rep;
            pph_param.Value = pph;
            admid_param.Value = adminid;

            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                        connection.Open();
                        command.Parameters.Add(lp_param);
                        command.Parameters.Add(cname_param);
                        command.Parameters.Add(ctype_param);
                        command.Parameters.Add(ccapacity_param);
                        command.Parameters.Add(cmodel_param);
                        command.Parameters.Add(ccolor_param);
                        command.Parameters.Add(ccondition_param);
                        command.Parameters.Add(rep_param);
                        command.Parameters.Add(pph_param);
                        command.Parameters["@pph"].Precision = 18;
                        command.Parameters["@pph"].Scale = 2;
                        command.Parameters.Add(admid_param);
                        command.Prepare();
                        command.ExecuteNonQuery();
                }
            }
        }

        public bool is_car_type(string ct)
        {
            bool isNotCtype = false;
            foreach (string item in cartype_cbox.Items)
            {
                if (item == ct)
                {
                    return true;
                }
            }
            return isNotCtype;
        }

        private bool is_car_color (string ccolor)
        {
            bool isColor = true;
            foreach (string item in ccolor_cbox.Items)
            {
                if (item == ccolor)
                {
                    return true;
                }
            }
            return isColor;
        }

        private bool is_car_seats(string seats_amnt)
        {
            if (int.TryParse(seats_amnt,out int result) == true)
            {
                return true;
            }
            foreach (string item in ccapacity_cbox.Items)
            {
                if (item == seats_amnt)
                {
                    return true;
                }
            }
            return false;
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void car_condition_slider_ValueChanged(object sender, EventArgs e)
        {
            ccondition_valuelbl.Text = car_condition_slider.Value.ToString();
        }

        private void car_Rep_slider_ValueChanged(object sender, EventArgs e)
        {
            repvaluelbl.Text = car_rep_slider.Value.ToString();
        }

        private void car_condition_slider_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("on a scale of 1 to 10, 1 being in bad condition, 5 being functional, 10 being perfectly fine", car_condition_slider);
        }

        private void pphtxt_Leave(object sender, EventArgs e)
        {
            if (pphtxt.Text == "")
            {
                pphtxt.Text = "price per hour";
                pphtxt.ForeColor = Color.Gray;
            }
        }


        private void pphtxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pphtxt.Text) || pphtxt.Text == "price per hour")
            {
                pphtxt.Text = "";
                pphtxt.ForeColor = Color.Black;
            }
        }

    }
}
