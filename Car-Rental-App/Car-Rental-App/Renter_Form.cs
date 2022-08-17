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
    public partial class Renter_Form : Form
    {
        public Renter_Form()
        {
            InitializeComponent();
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
                
        }

        private void Renter_Form_Load(object sender, EventArgs e)
        {
            Profile p = new Profile();
            logoutbtn.Hide();
            
            fullnamelbl.Text=p.get_full_name(Profile.current_userid);
            idlbl.Text = Profile.current_userid;

        }

        private void fullnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
        
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

     
        private void settingbtn_Click_1(object sender, EventArgs e)
        {
            logoutbtn.Show();
        }

        private void settingbtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
