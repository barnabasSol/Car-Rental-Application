using System;
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
                //the customer form goes here
                MessageBox.Show("customer here");
            }
            else if (p.is_admin(login_idtxt.Text, password_txt.Text))
            {
                //the admin form goes here
                MessageBox.Show("admin here");
            }
            else if (p.is_renter(login_idtxt.Text, password_txt.Text))
            {
                //the renter form goes here
                MessageBox.Show("renter here");
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
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            Hide();
            
        }

        private void create_here_lbl_MouseHover(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Underline);
        }

        private void create_here_lbl_MouseLeave(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Regular);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
