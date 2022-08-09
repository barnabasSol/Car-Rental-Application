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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
         
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {

            Regex r = new Regex(@"^[0-9]{3}[0-9]{3}[0-9]{4}$");
            Regex r1 = new Regex(@"^[A-Z]{1}[a-z]{1,100}$");
            if (String.IsNullOrEmpty(login_textbox.Text)&&String.IsNullOrEmpty(First_Name_textBox.Text)&&String.IsNullOrEmpty(Last_Name_textBox.Text)&& String.IsNullOrEmpty(Phone_textBox.Text)&&(Male_rb.Checked == false && Female_rb.Checked==false)&&String.IsNullOrEmpty(Address_textBox.Text)&&String.IsNullOrEmpty(Account_CBox.Text)&&String.IsNullOrEmpty(Password_Textbox.Text)&& String.IsNullOrEmpty(Confirm_TextBox.Text))
            {
                errorProvider1.SetError(login_textbox, "Login Id is required");
                errorProvider1.SetError(First_Name_textBox, "First Name is required");
                errorProvider1.SetError(Last_Name_textBox, "Last Name is required");
                errorProvider1.SetError(Phone_textBox, "Phone Number is required");
                errorProvider1.SetError(Male_rb, "Sex is required");
                errorProvider1.SetError(Female_rb, "Sex is required");
                errorProvider1.SetError(Account_CBox, "Choose your Account type");
                errorProvider1.SetError(Address_textBox, "Address is required");
                errorProvider1.SetError(Password_Textbox, "Password  is required");
                errorProvider1.SetError(Confirm_TextBox, "You need too confrim your password");

                

                
            
            }
            else if (String.IsNullOrEmpty(login_textbox.Text) || String.IsNullOrEmpty(First_Name_textBox.Text) || String.IsNullOrEmpty(Last_Name_textBox.Text) || String.IsNullOrEmpty(Phone_textBox.Text) || (Male_rb.Checked == false && Female_rb.Checked == false) || String.IsNullOrEmpty(Address_textBox.Text) || String.IsNullOrEmpty(Account_CBox.Text) || String.IsNullOrEmpty(Password_Textbox.Text) || String.IsNullOrEmpty(Confirm_TextBox.Text))
            {
              
                MessageBox.Show("Empty field Found","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(r1.IsMatch(First_Name_textBox.Text)) || !(r1.IsMatch(Last_Name_textBox.Text)))
            {
                MessageBox.Show("Please Enter your Name in the correct Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolTip1.SetToolTip(First_Name_textBox, "First Letter must be Capital");
                toolTip1.SetToolTip(Last_Name_textBox, "First Letter must be Capital");
            }
            else if (!(r.IsMatch(Phone_textBox.Text)))
             {
                 MessageBox.Show("Please Enter your correct Phone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 toolTip1.SetToolTip(Phone_textBox, "Example - 0911129870");
             }
          
           





            else
            {
                errorProvider1.Clear();
                MessageBox.Show("You have succefully Created Your Account");
               
            }


           
        }
    }
}
