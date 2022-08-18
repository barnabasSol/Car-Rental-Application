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
    public partial class ResetPswUC : UserControl
    {
        bool eye1_clicked = true;
        bool eye2_clicked = true;
        bool eye3_clicked = true;
        Profile p = new Profile();

        AdminForm1 resetf;
        public ResetPswUC(AdminForm1 parentform)
        {
            resetf = parentform;
            InitializeComponent();
        }

        

        private void backbtn_Click(object sender, EventArgs e)
        {
            SettingUserControl s = new SettingUserControl(resetf);
            resetf.add_user_control(s);
        }

      

        private void oldpswtxt_Enter(object sender, EventArgs e)
        {
            eyebtn.Visible = true;
            if (oldpswtxt.Text == "enter old password here")
            {
                oldpswtxt.Text = "";
                oldpswtxt.ForeColor = Color.Black;
                oldpswtxt.isPassword = true;
            }
        }

        private void oldpswtxt_Leave(object sender, EventArgs e)
        {
            if (oldpswtxt.Text == "") {
                eyebtn.Visible = false;
                oldpswtxt.isPassword = false;
                oldpswtxt.Text = "enter old password here";
                oldpswtxt.ForeColor = Color.Gray;
            }
            else
            {
                eyebtn.Visible = true;
            }
        }


        private void newpswtxt_Enter(object sender, EventArgs e)
        {
            eyebtn2.Visible = true;
            if (newpswtxt.Text == "enter new password here")
            {
                newpswtxt.Text = "";
                newpswtxt.ForeColor = Color.Black;
                newpswtxt.isPassword = true;
            }
        }

        private void newpswtxt_Leave(object sender, EventArgs e)
        {
            if (newpswtxt.Text == "")
            {
                eyebtn2.Visible = false;
                newpswtxt.isPassword = false;
                newpswtxt.Text = "enter new password here";
                newpswtxt.ForeColor = Color.Gray;
            }
            else
            {
                eyebtn2.Visible = true;
            }
        }

        private void cnfrmtxt_Enter(object sender, EventArgs e)
        {
            eyebtn3.Visible = true;
            if (cnfrmtxt.Text == "confirm password")
            {
                cnfrmtxt.Text = "";
                cnfrmtxt.ForeColor = Color.Black;
                cnfrmtxt.isPassword = true;
            }
        }

        private void cnfrmtxt_Leave(object sender, EventArgs e)
        {
            if (cnfrmtxt.Text == "")
            {
                eyebtn3.Visible = false;
                cnfrmtxt.isPassword = false;
                cnfrmtxt.Text = "confirm password";
                cnfrmtxt.ForeColor = Color.Gray;
            }
            else
            {
                eyebtn2.Visible = true;
            }
        }
      
        private void eyebtn_Click(object sender, EventArgs e)
        {
           
            if (eye1_clicked)
            {
                oldpswtxt.isPassword = false;
                eyebtn.Image = Resources.visible;
                eye1_clicked = false;
            }
            else
            {
                oldpswtxt.isPassword = true;
                eyebtn.Image = Resources.eye;
                eye1_clicked = true;
            }
        }

        private void eyebtn2_Click(object sender, EventArgs e)
        {

            if (eye2_clicked)
            {
                newpswtxt.isPassword = false;
                eyebtn2.Image = Resources.visible;
                eye2_clicked = false;
            }
            else
            {
                newpswtxt.isPassword = true;
                eyebtn2.Image = Resources.eye;
                eye2_clicked = true;
            }
        }

        private void eyebtn3_Click(object sender, EventArgs e)
        {
            if (eye3_clicked)
            {
                cnfrmtxt.isPassword = false;
                eyebtn3.Image = Resources.visible;
                eye3_clicked = false;
            }
            else
            {
                cnfrmtxt.isPassword = true;
                eyebtn3.Image = Resources.eye;
                eye3_clicked = true;
            }
        }


        private void cnfrmtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (newpswtxt.Text != cnfrmtxt.Text)
            {
                cnfrmtxt.LineFocusedColor = Color.Red;
            }
            else
            {
                cnfrmtxt.LineFocusedColor = Color.Green;
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (cnfrmtxt.Text!=newpswtxt.Text)
                MessageBox.Show("new password doesn't match");
            else if (!p.validate_reset_password(Profile.current_userid, oldpswtxt.Text))
                errorProvider1.SetError(oldpswtxt, "old password isn't correct");
            else
            {
                p.reset_admin_password(Profile.current_userid, newpswtxt.Text);
                oldpswtxt.Text = "";
                newpswtxt.Text = "";
                cnfrmtxt.Text = "";
                MessageBox.Show("successfuly reset");
            }
        }
    }
}
