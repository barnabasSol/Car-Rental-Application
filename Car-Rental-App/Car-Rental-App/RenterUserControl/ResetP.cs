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
    public partial class ResetP : UserControl
    {
        bool eye1_clicked = true;
        bool eye2_clicked = true;
        bool eye3_clicked = true;
        Renter_Form renterForm;
        Renter R = new Renter();
        public ResetP(Renter_Form renterForm)
        {
            InitializeComponent();
            this.renterForm = renterForm;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Setting_User_for_Renter_User_Control setting_User_For_Renter_User_Control = new Setting_User_for_Renter_User_Control(renterForm);
            renterForm.add_user_control_for_setting(setting_User_For_Renter_User_Control);
        }

      
     





        private void backbtn_MouseEnter(object sender, EventArgs e)
        {
            Backlbl.Visible = true;
        }

        private void backbtn_MouseLeave(object sender, EventArgs e)
        {
            Backlbl.Visible = false;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            bool reset = true; 
            if (String.IsNullOrEmpty(oldpswtxt.Texts))
            {
                reset = false;
                errorProvider1.SetError(oldpswtxt, "Empty field here");
            }
            if (String.IsNullOrEmpty(newpswtxt.Texts))
            {
                reset=false;
                errorProvider2.SetError(newpswtxt, "Empty field here");
            }
            if (String.IsNullOrEmpty(cnfrmtxt.Texts)) {

                reset=false;
                errorProvider3.SetError(cnfrmtxt, "Empty field here");

            }
            if(cnfrmtxt.Texts != newpswtxt.Texts)
            {
                reset=false;
                errorProvider4.SetError(cnfrmtxt, "new password doesn't match");
            }
            if (reset)
            {
                MessageBox.Show("You have Successfully changed your password");
                R.reset_Password(Profile.current_userid, newpswtxt.Texts);





            }
        }

        private void oldpswtxt_Enter(object sender, EventArgs e)
        {
            eyebtn.Visible = true;
            if(oldpswtxt.Texts=="enter old password here")
            {
                oldpswtxt.Texts = "";
                oldpswtxt.PasswordChar = true;
                oldpswtxt.BorderColor = Color.IndianRed;

            }
        }

        private void oldpswtxt_Leave(object sender, EventArgs e)
        {
            if (oldpswtxt.Texts == "")
            {
                oldpswtxt.Texts = "enter old password here";
                oldpswtxt.PasswordChar = false;
                oldpswtxt.BorderColor = Color.Black;
            }
            else
            {
                eyebtn.Visible = true;
            }
        }

        private void newpswtxt_Enter(object sender, EventArgs e)
        {
            eyebtn2.Visible = true;
            if(newpswtxt.Texts=="enter new password here")
            {
                newpswtxt.Texts ="";
                newpswtxt.PasswordChar = true;
                newpswtxt.BorderColor = Color.IndianRed;

            }
        }

        private void newpswtxt_Leave(object sender, EventArgs e)
        {
            if (newpswtxt.Texts == "")
            {
                eyebtn2.Visible = false;
                newpswtxt.Texts = "enter new password here";
                newpswtxt.PasswordChar = false;
                newpswtxt.BorderColor = Color.Black;

            }
            else
            {
                eyebtn2.Visible = true;

            }
        }

        private void cnfrmtxt_Enter(object sender, EventArgs e)
        {
            eyebtn3.Visible = true;
            if(cnfrmtxt.Texts=="confirm password")
            {
                cnfrmtxt.Texts = "";
                cnfrmtxt.PasswordChar = true;
                cnfrmtxt.BorderColor = Color.IndianRed;
            }

        }

        private void cnfrmtxt_Leave(object sender, EventArgs e)
        {
            if (cnfrmtxt.Texts == "")
            {
                eyebtn3.Visible= false;
                cnfrmtxt.Texts = "confirm password";
                cnfrmtxt.PasswordChar = false;
                cnfrmtxt.BorderColor = Color.Black;
            }
            else
            {
                eyebtn3.Visible=true;
            }

        }

        private void eyebtn_Click(object sender, EventArgs e)
        {
            if (eye1_clicked)
            {
                oldpswtxt.PasswordChar=false;
                eyebtn.Image = Resources.visible;
                eye1_clicked = false;
            }
            else
            {
                oldpswtxt.PasswordChar = true;
                eyebtn.Image = Resources.eye;
                eye1_clicked = true;
            }
        }

        private void eyebtn2_Click(object sender, EventArgs e)
        {
            if (eye2_clicked)
            {
                newpswtxt.PasswordChar = false;
                eyebtn2.Image = Resources.visible;
                eye2_clicked = false;
            }
            else
            {
                newpswtxt.PasswordChar = true;
                eyebtn2.Image = Resources.eye;
                eye2_clicked = true;
            }

        }

        private void eyebtn3_Click(object sender, EventArgs e)
        {
            if (eye3_clicked)
            {
                cnfrmtxt.PasswordChar = false;
                eyebtn3.Image = Resources.visible;
                eye3_clicked = false;
            }
            else
            {
                cnfrmtxt.PasswordChar = true;
                eyebtn3.Image = Resources.eye;
                eye3_clicked = true;
            }
        }
    }
}
