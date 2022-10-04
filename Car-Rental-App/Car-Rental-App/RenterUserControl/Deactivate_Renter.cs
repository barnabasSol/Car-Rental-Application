using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_App.Properties;

namespace Car_Rental_App.RenterUserControl
{
    public partial class Deactivate_Renter : UserControl
    {
        bool eye_clicked = true;
        Renter_Form rh;
        public Deactivate_Renter(Renter_Form r)
        {
            InitializeComponent();
            rh = r;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Setting_User_for_Renter_User_Control setting_User_For_Renter_User_Control = new Setting_User_for_Renter_User_Control(rh);
            rh.add_user_control_for_setting(setting_User_For_Renter_User_Control);
        }

        private void backbtn_MouseEnter(object sender, EventArgs e)
        {
            Backlbl.Visible = true;
        }

        private void backbtn_MouseLeave(object sender, EventArgs e)
        {
            Backlbl.Visible = false;
        }

        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            if (p.validate_password_for_renter(Profile.current_userid, password.Text))
            {


                LoginForm loginForm = new LoginForm();
                rh.Hide();
                loginForm.Show();
            }
            else
            {
                errorProvider1.SetError(password, "password incorrect");
            }
        }

        private void eyebtn_Click(object sender, EventArgs e)
        {
            if (eye_clicked)
            {
                password.isPassword = false;
                eyebtn.Image = Resources.visible;
                eye_clicked = false;
            }
            else
            {
                password.isPassword = true;
                eyebtn.Image = Resources.eye;
                eye_clicked = true;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            eyebtn.Visible = true;
            if (password.Text == "enter your password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
              
                password.isPassword = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                eyebtn.Visible = false;
                password.isPassword = false;
                password.Text = "enter your password";
                password.ForeColor = Color.Gray;
            }
            else
            {
                eyebtn.Visible = true;
            }
        }

        private void Deactivate_Renter_Load(object sender, EventArgs e)
        {

        }
    }
}
