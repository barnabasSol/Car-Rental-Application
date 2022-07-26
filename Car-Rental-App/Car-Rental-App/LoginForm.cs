﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        Profile p = new Profile();

        private void login_btn_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(login_idtxt, null);
            errorProvider1.SetError(password_txt, null);
            errorProvider2.SetError(login_idtxt, null);

            if (p.is_customer(login_idtxt.Text, password_txt.Text)){
                Profile.current_userid = login_idtxt.Text;
                Customer_form c = new Customer_form();
                this.Hide();
                c.Show();
            }
            else if (p.is_admin(login_idtxt.Text, password_txt.Text))
            {
                Profile.current_userid = login_idtxt.Text;
                AdminForm1 a = new AdminForm1();
                this.Hide();
                a.Show();

            }
            else if (p.is_renter(login_idtxt.Text, password_txt.Text))
            {
                Profile.current_userid = login_idtxt.Text;
                Renter_Form renter_Form = new Renter_Form();

                Hide();
                renter_Form.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(login_idtxt.Text) && string.IsNullOrEmpty(password_txt.Text))
                {
                    errorProvider1.SetError(login_idtxt, "empty field here");
                    errorProvider1.SetError(password_txt, "empty field here");
                }

                else if (string.IsNullOrEmpty(login_idtxt.Text))
                {
                    errorProvider1.SetError(login_idtxt, "empty field here");
                }
                else if (string.IsNullOrEmpty(password_txt.Text))
                {
                    errorProvider1.SetError(password_txt, "empty field here");
                }
                else
                {
                    errorProvider2.SetError(login_idtxt, "user doesn't exist");
                }
            }
        }
        private void create_here_lbl_Click(object sender, EventArgs e)
        {
            Create_Account_Form create_Account_Form = new Create_Account_Form();
            Hide();
            create_Account_Form.Show();
                       
        }

        private void create_here_lbl_MouseLeave(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Regular);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_idtxt.Text = "nathan321";
            password_txt.Text = "0000";
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void create_here_lbl_MouseEnter(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Underline);
        }
    }
}
