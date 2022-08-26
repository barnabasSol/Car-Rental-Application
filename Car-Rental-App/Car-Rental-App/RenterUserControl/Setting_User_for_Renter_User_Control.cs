using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_App.RenterUserControl;

namespace Car_Rental_App
{
    public partial class Setting_User_for_Renter_User_Control : UserControl
    {
        Renter_Form rf;
        public Setting_User_for_Renter_User_Control(Renter_Form parentform)
        {
            rf = parentform;
            InitializeComponent();

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            rf.Hide();
            lg.Show();
        }

       
        private void deactivatebtn_MouseLeave(object sender, EventArgs e)
        {
            deactivatelbl.Visible = false;
        }

        private void resetpswbtn_MouseEnter(object sender, EventArgs e)
        {
            resetpswlbl.Visible = true;
        }

        private void resetpswbtn_MouseLeave(object sender, EventArgs e)
        {
            resetpswlbl.Visible = false;
        }

        private void deactivatebtn_MouseEnter(object sender, EventArgs e)
        {
          
            deactivatelbl.Visible = true;
        }

        private void logoutbtn_MouseEnter(object sender, EventArgs e)
        {
            logoutlbl.Visible = true;
        }

        private void logoutbtn_MouseLeave(object sender, EventArgs e)
        {
            logoutlbl.Visible = false;
        }

        private void resetpswbtn_Click(object sender, EventArgs e)
        {
            ResetP l = new ResetP(rf);
            
            rf.add_user_control(l);
        }

        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            Deactivate_Renter l = new Deactivate_Renter(rf);
            rf.add_user_control(l);
        }
    }
}
