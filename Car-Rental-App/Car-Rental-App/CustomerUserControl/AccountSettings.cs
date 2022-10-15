using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.CustomerUserControl
{
    public partial class AccountSettings : UserControl
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace( txtOldP.Text)) {
                MessageBox.Show("Please fill out your old password");
            }else if (txtNewP.Text.Length < 6
                || txtConfirmP.Text.Length < 6)
            {
                MessageBox.Show("Passwords must be longer than 6 characters");
            }else
            {
                if (txtNewP.Text != txtConfirmP.Text)
                {
                    MessageBox.Show("Please confirm your new password");
                }else
                {
                    if (txtOldP.Text == txtNewP.Text)
                    {
                        MessageBox.Show("Old password can not be New password");
                    }else
                    {
                        MessageBox.Show("Password Successfully Changed");
                    }
                }
            }
        }
    }
}
