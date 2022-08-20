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
    }
}
