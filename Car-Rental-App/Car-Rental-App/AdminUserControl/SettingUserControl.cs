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
        AdminForm1 settingform;
        public SettingUserControl(AdminForm1 parentform)
        {
            InitializeComponent();
            settingform = parentform;
        }

        public SettingUserControl()
        {

        }





        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            settingform.Close();
        }

        private void logoutbtn_MouseHover(object sender, EventArgs e)
        {
            logoutlbl.Visible = true;
        }

        private void logoutbtn_MouseLeave(object sender, EventArgs e)
        {
            logoutlbl.Visible = false;
        }
        private void resetpswbtn_MouseHover(object sender, EventArgs e)
        {
            resetpswlbl.Visible = true;
        }

        private void resetpswbtn_MouseLeave(object sender, EventArgs e)
        {
            resetpswlbl.Visible = false;
        }

        private void deactivatebtn_MouseHover(object sender, EventArgs e)
        {
            deactivatelbl.Visible = true;
        }

        private void deactivatebtn_MouseLeave(object sender, EventArgs e)
        {
            deactivatelbl.Visible = false;
        }

        private void resetpswbtn_Click(object sender, EventArgs e)
        {
            ResetPswUC rp = new ResetPswUC(settingform);
            settingform.add_user_control(rp);
        }

        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            DeactivateAccountUC d = new DeactivateAccountUC(settingform);
            settingform.add_user_control(d);
        }
    }
}
