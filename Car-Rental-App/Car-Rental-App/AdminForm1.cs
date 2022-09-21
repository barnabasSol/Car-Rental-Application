using Car_Rental_App.AdminUserControl;
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
    public partial class AdminForm1 : Form
    {
        public AdminForm1()
        {
            InitializeComponent();
        }

        public void add_user_control(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
        }

        private void AdminForm1_Load(object sender, EventArgs e)
        {
            Profile p = new Profile();
            fullnamelbl.Text = p.get_full_name(Profile.current_userid);
            idlbl.Text = Profile.current_userid;
            mainpanel.Controls.Add(pictureBox2);
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            vehiclebtn.IdleFillColor = Color.FromArgb(0xF0F0F0);
            vehiclebtn.IdleForecolor = Color.Black;
            vehiclebtn.IdleLineColor = Color.FromArgb(0xF0F0F0);
            customerbtn.IdleFillColor = Color.FromArgb(199, 92, 92);
            customerbtn.IdleForecolor = Color.White;
            customerbtn.IdleLineColor = Color.FromArgb(199, 92, 92);


            CustomerUC c = new CustomerUC();
            add_user_control(c);

        }

        private void vehiclebtn_Click(object sender, EventArgs e)
        {
            customerbtn.IdleFillColor = Color.FromArgb(0xF0F0F0);
            customerbtn.IdleForecolor = Color.Black;
            customerbtn.IdleLineColor = Color.FromArgb(0xF0F0F0);
            vehiclebtn.IdleFillColor = Color.FromArgb(199, 92, 92);
            vehiclebtn.IdleForecolor = Color.White;
            vehiclebtn.IdleLineColor = Color.FromArgb(199, 92, 92);

            VehicleUC v = new VehicleUC(this);
            add_user_control(v);

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            reset_color();
            HomeUserControl h = new HomeUserControl();
            add_user_control(h);
           
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            reset_color();
            SettingUserControl stu = new SettingUserControl(this);
            add_user_control(stu);
        }

        public void reset_color()
        {
            customerbtn.IdleFillColor = Color.FromArgb(0xF0F0F0);
            customerbtn.IdleForecolor = Color.Black;
            customerbtn.IdleLineColor = Color.FromArgb(0xF0F0F0);
            vehiclebtn.IdleFillColor = Color.FromArgb(0xF0F0F0);
            vehiclebtn.IdleForecolor = Color.Black;
            vehiclebtn.IdleLineColor = Color.FromArgb(0xF0F0F0);
        }

        private void little_car_Click(object sender, EventArgs e)
        {

        }
    }
}
