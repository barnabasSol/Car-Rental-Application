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

namespace Car_Rental_App
{
    public partial class EditVehicleForm : Form
    {
        public EditVehicleForm(string lp)
        {
            InitializeComponent();
            temp_lp = lp;
            loadEditVehicleData(lp);
        }
        private readonly string temp_lp;
        VehicleValidation vv = new VehicleValidation();
        int car_capacity;


        private void verifybtn_Click(object sender, EventArgs e)
        {
            if (vstatuslbl.Text == "verified")
            {
                verifyVehicle();
                vstatuslbl.Text = "unverified";
                verifybtn.Image = Properties.Resources.unverified;
            }
            else
            {
                unverifyVehicle();
                vstatuslbl.Text = "verified";
                verifybtn.Image = Properties.Resources.verified;
            }
        }

        private void EditVehicleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loadEditVehicleData(string lp)
        {
            string query = "select license_plate_no, verification, car_name," +
                " car_type, car_capacity, car_model, car_color, car_condition, " +
                "rep_min_req, price_per_hour from cars where license_plate_no=@lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            lp_param.Value = lp;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(lp_param);
                    command.Prepare();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lptxt.Text = reader[0].ToString();
                            if (reader[1].ToString() == "verified")
                            {
                                vstatuslbl.Text = "verified";
                                verifybtn.Image = Properties.Resources.verified;
                            }
                            else
                            {
                                vstatuslbl.Text = "unverified";
                                verifybtn.Image = Properties.Resources.unverified;
                            }
                            cnametxt.Text = reader[2].ToString();
                            cartype_cbox.Text = reader[3].ToString();
                            ccapacity_cbox.Text = reader[4].ToString();
                            cmodeltxt.Text = reader[5].ToString();
                            ccolor_cbox.Text = reader[6].ToString();
                            cconditionlbl.Text = reader[7].ToString();
                            car_condition_slider.Value = int.Parse(reader[7].ToString());
                            repvaluelbl.Text = reader[8].ToString();
                            car_rep_slider.Value = int.Parse(reader[8].ToString());
                            pphtxt.Text = reader[9].ToString();
                        }
                    }
                }
            }
        }

        private void unverifyVehicle()
        {
            string query = "update cars set verification = 'unverified' where license_plate_no = @lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            if (vv.is_unique_lp(lptxt.Text) && !string.IsNullOrEmpty(lptxt.Text))
            {
            lp_param.Value = lptxt.Text;
            }
            else
            {
                lp_param.Value = temp_lp;
            }
            
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

        private void verifyVehicle()
        {
            string query = "update cars set verification = 'verified' where license_plate_no = @lp";
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            if (vv.is_unique_lp(lptxt.Text) && !string.IsNullOrEmpty(lptxt.Text))
            {
                lp_param.Value = lptxt.Text;
            }
            else
            {
                lp_param.Value = temp_lp;
            }
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

        private void saveeditbtn_Click(object sender, EventArgs e)
        {
            bool all_is_good = true;
            if ((!vv.is_unique_lp(lptxt.Text) && lptxt.Text!=temp_lp) || (string.IsNullOrEmpty(lptxt.Text)))
            {
                all_is_good = false;
                errorProvider1.SetError(lptxt, "error here");
            }
            if (string.IsNullOrEmpty(cnametxt.Text))
            {
                all_is_good = false;
                errorProvider1.SetError(cnametxt, "error here");
            }
            if (!is_car_seats(ccapacity_cbox.Text) || string.IsNullOrEmpty(ccapacity_cbox.Text))
            {
                all_is_good = false;
                errorProvider1.SetError(ccapacity_cbox, "either enter a number or pick from list.");
            }
            if (string.IsNullOrEmpty(cmodeltxt.Text))
            {
                all_is_good = false;
                errorProvider1.SetError(cmodeltxt, "error here");
            }
            if (decimal.TryParse(pphtxt.Text, out decimal result) == false)
            {
                all_is_good = false;
                errorProvider1.SetError(pphtxt, "error here");
            }
            if (all_is_good)
            {
                if (int.TryParse(cartype_cbox.Text, out int result1) == true)
                {
                    car_capacity = int.Parse(cartype_cbox.Text);
                }
                else
                {
                    string[] temp = ccapacity_cbox.Text.Split(' ');
                    car_capacity = int.Parse(temp[0]);
                }

                updateVehicle();
                MessageBox.Show("changes successfully made", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private bool is_car_seats(string seats_amnt)
        {
            if (int.TryParse(seats_amnt, out int result) == true)
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

        private void updateVehicle()
        {
            string query = "update cars set license_plate_no=@newlp, verification=@newv, " +
                "car_name=@newcname, car_type=@newctype, car_capacity=@newccapacity," +
                "car_model=@newcmodel, car_color=@newcolor, car_condition=@newcond, " +
                "rep_min_req=@newrep, price_per_hour=@newpph where license_plate_no=@lp";
            SqlParameter newlp_param = new SqlParameter("@newlp", SqlDbType.VarChar, 200);
            SqlParameter lp_param = new SqlParameter("@lp", SqlDbType.VarChar, 200);
            SqlParameter v_param = new SqlParameter("@newv", SqlDbType.VarChar, 200);
            SqlParameter newcname_param = new SqlParameter("@newcname", SqlDbType.VarChar, 200);
            SqlParameter newctype_param = new SqlParameter("@newctype", SqlDbType.VarChar, 100);
            SqlParameter newccapacity_param = new SqlParameter("@newccapacity", SqlDbType.Int, 0);
            SqlParameter newcmodel_param = new SqlParameter("@newcmodel", SqlDbType.VarChar, 200);
            SqlParameter newcolor_param = new SqlParameter("@newcolor", SqlDbType.VarChar, 100);
            SqlParameter newccondition_param = new SqlParameter("@newcond", SqlDbType.Int, 0);
            SqlParameter newrep_param = new SqlParameter("@newrep", SqlDbType.Int, 0);
            SqlParameter pph_param = new SqlParameter("@newpph", SqlDbType.Decimal, 0);

            if (vv.is_unique_lp(lptxt.Text) && !string.IsNullOrEmpty(lptxt.Text))
            {
                newlp_param.Value = lptxt.Text;
            }
            else
            {
                newlp_param.Value = temp_lp;
            }
            v_param.Value = vstatuslbl.Text;
            newcname_param.Value = cnametxt.Text;
            newctype_param.Value = cartype_cbox.Text;
            newccapacity_param.Value = car_capacity;
            newcmodel_param.Value = cmodeltxt.Text;
            newcolor_param.Value = ccolor_cbox.Text;
            newccondition_param.Value = car_condition_slider.Value;
            newrep_param.Value = car_rep_slider.Value;
            pph_param.Value = decimal.Parse(pphtxt.Text);
            lp_param.Value = temp_lp;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.Add(newlp_param);
                    command.Parameters.Add(v_param);
                    command.Parameters.Add(newcname_param);
                    command.Parameters.Add(newctype_param);
                    command.Parameters.Add(newccapacity_param);
                    command.Parameters.Add(newcmodel_param);
                    command.Parameters.Add(newcolor_param);
                    command.Parameters.Add(newccondition_param);
                    command.Parameters.Add(newrep_param);
                    command.Parameters.Add(pph_param);
                    command.Parameters.Add(lp_param);
                    command.Parameters["@newpph"].Precision = 18;
                    command.Parameters["@newpph"].Scale = 2;
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }

        }

        private void car_condition_slider_ValueChanged(object sender, EventArgs e)
        {
            cconditionlbl.Text = car_condition_slider.Value.ToString();
        }

        private void car_rep_slider_ValueChanged(object sender, EventArgs e)
        {
            repvaluelbl.Text = car_rep_slider.Value.ToString();
        }
    }
}
