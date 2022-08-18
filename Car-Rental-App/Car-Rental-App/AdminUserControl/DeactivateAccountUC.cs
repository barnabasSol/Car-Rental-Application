using Car_Rental_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.AdminUserControl
{
    public partial class DeactivateAccountUC : UserControl
    {
        AdminForm1 deacf;
        bool eye_clicked = true;
        public DeactivateAccountUC(AdminForm1 parentform)
        {
            deacf = parentform;
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            SettingUserControl s = new SettingUserControl(deacf);
            deacf.add_user_control(s);
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

     

        private void password_Enter_1(object sender, EventArgs e)
        {
            eyebtn.Visible = true;
            if (password.Text == "enter your password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.isPassword = true;
            }
        }

        private void password_Leave_1(object sender, EventArgs e)
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

        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            if(p.validate_password(Profile.current_userid, password.Text))
            {
                LoginForm l = new LoginForm();
                MessageBox.Show("account successfuly deactivated");
                deacf.Hide();
                l.Show();
            }

        }
    }
}
