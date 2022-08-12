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

namespace Car_Rental_App
{
    public partial class Create_Account_Form : Form
    {
        public Create_Account_Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {

            Profile p = new Profile();


            Regex r = new Regex(@"^[0-9]{3}[0-9]{3}[0-9]{4}$");
            Regex r1 = new Regex(@"^[A-Z]{1}[a-z]{1,100}$");
            Boolean t = true;

            if (String.IsNullOrEmpty(login_textbox.Text))
            {
                t = false;
                errorProvider1.SetError(login_textbox, "Login Id is required");


            }

            else
            {
                errorProvider1.Clear();
            }

            if (p.valdation(login_textbox.Text))
            {

                t = false;
                errorProvider14.SetError(login_textbox, " Login Id  already extits in the database");

            }
            else
            {
                errorProvider14.Clear();
            }

            if (!(r1.IsMatch(First_Name_textBox.Text)))
            {

                errorProvider2.SetError(First_Name_textBox, "First Letter must be Capital ");

                t = false;


            }
            else
            {
                errorProvider2.Clear();

            }

            if (!(r1.IsMatch(Last_Name_textBox.Text)))
            {
                errorProvider12.SetError(Last_Name_textBox, "First Letter must be Capital ");
                t = false;

            }
            else
            {
                errorProvider12.Clear();

            }
            if (!(r.IsMatch(Phone_textBox.Text)))
            {


                errorProvider3.SetError(Phone_textBox, " Example - 0911129870");
                t = false;

            }
            else
            {
                errorProvider3.Clear();

            }

            if (String.IsNullOrEmpty(First_Name_textBox.Text))
            {
                t = false;
                errorProvider11.SetError(First_Name_textBox, "First Name is required");
            }
            else
            {
                errorProvider11.Clear();
            }
            if (String.IsNullOrEmpty(Last_Name_textBox.Text))
            {
                t = false;
                errorProvider10.SetError(Last_Name_textBox, "Last Name is required");
            }
            else
            {
                errorProvider10.Clear();
            }
            if (String.IsNullOrEmpty(Phone_textBox.Text))
            {
                t = false;
                errorProvider4.SetError(Phone_textBox, "Phone Number is required");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (!(Male_rb.Checked) && !(Female_rb.Checked))
            {
                t = false;
                errorProvider5.SetError(Male_rb, "Sex is required");
                errorProvider5.SetError(Female_rb, "Sex is required");
            }
            else
            {
                errorProvider5.Clear();
            }
            if (String.IsNullOrEmpty(Account_CBox.Text))
            {
                t = false;
                errorProvider6.SetError(Account_CBox, "Choose your Account type");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (String.IsNullOrEmpty(Address_textBox.Text))
            {
                t = false;
                errorProvider7.SetError(Address_textBox, "Address is required");
            }
            else
            {
                errorProvider7.Clear();
            }
            if (String.IsNullOrEmpty(Password_Textbox.Text))
            {
                t = false;
                errorProvider8.SetError(Password_Textbox, "Password  is required");
            }
            else
            {
                errorProvider8.Clear();
            }
            if (String.IsNullOrEmpty(Confirm_TextBox.Text))
            {
                t = false;
                errorProvider9.SetError(Confirm_TextBox, "You need too confrim your password");

            }
            else
            {
                errorProvider9.Clear();
            }

            if (Password_Textbox.Text != Confirm_TextBox.Text)
            {
                t = false;
                errorProvider13.SetError(Confirm_TextBox, "Your Password Doesnt Not Match with your confrimation ");
                errorProvider13.SetError(Password_Textbox, "Your Password Doesnt Not Match with your confrimation ");
            }
            else
            {
                errorProvider13.Clear();
            }

            if (t)
            {

                MessageBox.Show("You have succefully Created Your Account");

            }

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Hide();
            login.Show();
        }
    }
}
