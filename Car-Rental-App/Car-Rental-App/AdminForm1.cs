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

        private void AdminForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_rental_databaseDataSet1.audit' table. You can move, or remove it, as needed.
            this.auditTableAdapter1.Fill(this.car_rental_databaseDataSet1.audit);
            Profile p = new Profile();
            id_lablel.Text = p.login_id;
            fullnamelbl.Text = p.get_full_name(Profile.current_userid);
            id_lablel.Text = Profile.current_userid;
        }

       
    }
}
