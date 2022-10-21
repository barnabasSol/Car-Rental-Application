using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Car_Rental_App.RenterUserControl
{
    public partial class Edit_Account_Rentercs : UserControl
    {

        Renter_Form rf;
        public Edit_Account_Rentercs(Renter_Form parentform)
        {
            rf= parentform; 
            InitializeComponent();
        }

        private void LoginId_Txt_Enter(object sender, EventArgs e)
        {
           
        }

    

        private void backbtn_Click(object sender, EventArgs e)
        {
            Setting_User_for_Renter_User_Control setting_User_For_Renter_User_Control = new Setting_User_for_Renter_User_Control(rf);
            rf.add_user_control_for_setting(setting_User_For_Renter_User_Control);
        }

        private void saveeditbtn_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            Regex r = new Regex(@"^[0-9]{3}[0-9]{3}[0-9]{4}$");
            Regex r1 = new Regex(@"^[a-zA-z]{1,100}$");
            Boolean t = true;
            

            
            if (String.IsNullOrEmpty(FirstNameTxt.Texts))
            {
                t=false;
                errorProvider2.SetError(FirstNameTxt, "Enter your old First Name ");

            }
            else { errorProvider2.Clear(); }
            if (String.IsNullOrEmpty(LastNameTxt.Texts))
            {
                t = false;
                errorProvider3.SetError(LastNameTxt, "Enter your old Last Name");

            }
            else { errorProvider3.Clear(); }

            if (String.IsNullOrEmpty(PhoneTxt.Texts))
            {
                t = false;
                errorProvider4.SetError(PhoneTxt, "Enter your old Phone Number");

            }
            else { errorProvider4.Clear(); }

            if (String.IsNullOrEmpty(AddressTxt.Texts))
            {
                t = false;
                errorProvider5.SetError(AddressTxt, "Enter your old Address");

            }
            else { errorProvider5.Clear(); }
            if (!(Male_rb.Checked) && !(Female_rb.Checked))
            {
                t = false;
                errorProvider6.SetError(Male_rb, "Sex is required");
                errorProvider6.SetError(Female_rb, "Sex is required");
            }
            else
            {
                errorProvider6.Clear();
            }


            if (!(r1.IsMatch(FirstNameTxt.Texts)))
            {

                errorProvider7.SetError(FirstNameTxt, "you must enter  letter only ");

                t = false;


            }
            else
            {
                errorProvider7.Clear();

            }

            if (!(r1.IsMatch(LastNameTxt.Texts)))
            {

                errorProvider8.SetError(LastNameTxt, "you must enter  letter only ");

                t = false;


            }
            else
            {
                errorProvider8.Clear();

            }

            if (!(r.IsMatch(PhoneTxt.Texts)))
            {


                errorProvider9.SetError(PhoneTxt, " Example - 0911129870");
                t = false;

            }
            else
            {
                errorProvider9.Clear();

            }


            if (t)
            {
                Renter ry = new Renter();



                string male;
                string female;
               male = Male_rb.Text;
                female = Female_rb.Text;
                
             
                ry.first_name = FirstNameTxt.Texts;
                ry.last_name = LastNameTxt.Texts;
               ry.phone = PhoneTxt.Texts;
                ry.home_adress = AddressTxt.Texts;
                if (Male_rb.Checked)
                {
                   ry.sex = male.Substring(0, 1);
                }
                if (Female_rb.Checked)
                {
                    ry.sex = female.Substring(0, 1);

                }


                ry.Edit_Renter_Account(ry.first_name, ry.last_name, ry.phone, ry.home_adress, ry.sex, Profile.current_userid);





                MessageBox.Show("Updated");

            }
        }


       

       
        private void FirstNameTxt_Enter(object sender, EventArgs e)
        {
            FirstNameTxt.BorderColor = Color.IndianRed;
        }

        private void FirstNameTxt_Leave(object sender, EventArgs e)
        {
            FirstNameTxt.BorderColor = Color.Black;
        }

        private void LastNameTxt_Enter(object sender, EventArgs e)
        {
            LastNameTxt.BorderColor = Color.IndianRed;
        }

        private void LastNameTxt_Leave(object sender, EventArgs e)
        {
            LastNameTxt.BorderColor = Color.Black;
        }

        private void AddressTxt_Enter(object sender, EventArgs e)
        {
            AddressTxt.BorderColor = Color.IndianRed;
        }

        private void AddressTxt_Leave(object sender, EventArgs e)
        {
            AddressTxt.BorderColor = Color.Black;
        }

        private void PhoneTxt_Leave(object sender, EventArgs e)
        {
            PhoneTxt.BorderColor = Color.Black;
        }

        private void PhoneTxt_Enter(object sender, EventArgs e)
        {
            PhoneTxt.BorderColor = Color.IndianRed;
        }

        private void backbtn_MouseEnter(object sender, EventArgs e)
        {
            Backlbl.Visible = true;
        }

        private void backbtn_MouseLeave(object sender, EventArgs e)
        {
            Backlbl.Visible = false;
        }
    }
}
