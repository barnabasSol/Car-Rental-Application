using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.AdminUserControl
{
    public partial class SettingUserControl : UserControl
    {
        Form adminform;
        public SettingUserControl(Form parentform)
        {
            InitializeComponent();
            adminform = parentform;
        }

       
        private void SettingUserControl_Load(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            adminform.Hide();
            lg.Show();
        }
    }
}
