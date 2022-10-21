using Car_Rental_App.CustomerUserControl;
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
    public partial class Customer_form : Form
    {
        public Customer_form()
        {
            InitializeComponent();
        }
        public void add_user_control(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(uc);
        }

        private void Customer_form_Load(object sender, EventArgs e)
        {
            Profile p = new Profile();
            fullnamelbl.Text = p.get_full_name(Profile.current_userid);
            idlbl.Text = Profile.current_userid;
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            add_user_control(new BrowseVehicles());
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            add_user_control(new AccountSettings(this));
        }
    }
}
