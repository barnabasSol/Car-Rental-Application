using System;
using System.Collections.Generic;
using System.ComponentModel;
using Car_Rental_App;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_App.RenterUserControl;

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
        public  void add_user_control(UserControl uc)
        {
           uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);

        }
        public void add_user_control_for_setting(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);

        }
        private void Renter_Form_Load(object sender, EventArgs e)
        {
            Profile p = new Profile();

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

     
     

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

      
      
      

  
     

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Add_Car_User_Control h = new Add_Car_User_Control();
            add_user_control(h);
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Earnings earnings = new Earnings();
            add_user_control(earnings);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            add_user_control(chart);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Setting_User_for_Renter_User_Control s = new Setting_User_for_Renter_User_Control(this);
            add_user_control_for_setting(s);
        }
    }
}
