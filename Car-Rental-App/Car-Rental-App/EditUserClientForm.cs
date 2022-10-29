using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class EditUserClientForm : Form
    {
        string this_login_id = "";
        public EditUserClientForm(string id)
        {
            this_login_id=id;
            InitializeComponent();
        }
         void fill_content()
        {
            string query = "select first_name, last_name, home_address, phone_number, sex from profile where login_id=@id";
            SqlParameter id_param = new SqlParameter("@id", SqlDbType.VarChar, 100);
            id_param.Value = this_login_id;
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                      command.Parameters.Add(id_param);
                      command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FirstNameTxt.Texts = reader[0].ToString();
                            LastNameTxt.Texts = reader[1].ToString();
                            AddressTxt.Texts = reader[2].ToString();
                            PhoneTxt.Texts = reader[3].ToString();
                            if (reader[4].ToString() == "M")
                            {
                                Male_rb.Checked = true;
                            }
                            else
                            {
                                Female_rb.Checked = true;
                            }
                        }
                    }
                }
            }

        }

        private void EditUserClientForm_Load(object sender, EventArgs e)
        {
            fill_content();
        }
        // Edit_renter_Account @First_Name varchar(100),@Last_Name varchar(100),@phone varchar(100),
        // @homeaddress varchar(100),@sex varchar(3),@currentuserid varchar(200)
        private void saveeditsbtn_Click(object sender, EventArgs e)
        {
            bool all_clean = true;
            string regex = "^[a-zA-Z]+$";

            bool f_all_letters = Regex.IsMatch(FirstNameTxt.Texts, regex);
            bool l_all_letters = Regex.IsMatch(LastNameTxt.Texts, regex);

            if (FirstNameTxt.Texts == "" || !f_all_letters)
            {
                all_clean = false;
                errorProvider1.SetError(FirstNameTxt, "error here");
            }
            if (LastNameTxt.Texts == "" || !l_all_letters)
            {
                all_clean = false;
                errorProvider1.SetError(LastNameTxt, "error here");
            }
            if (!int.TryParse(PhoneTxt.Texts, out int r) || PhoneTxt.Texts == "")
            {
                all_clean = false;
                errorProvider1.SetError(PhoneTxt, "error here");
            }
            if (AddressTxt.Texts == "")
            {
                all_clean = false;
                errorProvider1.SetError(AddressTxt, "error here");
            }
            if (all_clean)
            {
                Renter rr = new Renter();
                string sex = "";
                if (Male_rb.Checked == true)
                {
                    sex = "M";
                }
                else
                {
                    sex = "F";
                }
                string query = "update profile set first_name=@fname, last_name=@lname, phone_number=@pnum, home_address=@address, sex=@s where login_id=@id";
                SqlParameter fname_param = new SqlParameter("@fname", SqlDbType.VarChar, 100);
                SqlParameter lname_param = new SqlParameter("@lname", SqlDbType.VarChar, 100);
                SqlParameter phone_param = new SqlParameter("@pnum", SqlDbType.VarChar, 100);
                SqlParameter address_param = new SqlParameter("@address", SqlDbType.VarChar, 100);
                SqlParameter sex_param = new SqlParameter("@s", SqlDbType.VarChar, 100);
                SqlParameter id_param = new SqlParameter("@id", SqlDbType.VarChar, 100);
                fname_param.Value = FirstNameTxt.Texts;
                lname_param.Value = LastNameTxt.Texts;
                phone_param.Value = PhoneTxt.Texts;
                address_param.Value = AddressTxt.Texts;
                sex_param.Value = sex;
                id_param.Value = this_login_id;
                using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(fname_param);
                        command.Parameters.Add(lname_param);
                        command.Parameters.Add(phone_param);
                        command.Parameters.Add(address_param);
                        command.Parameters.Add(sex_param);
                        command.Parameters.Add(id_param);
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Changes Successfully Made!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
