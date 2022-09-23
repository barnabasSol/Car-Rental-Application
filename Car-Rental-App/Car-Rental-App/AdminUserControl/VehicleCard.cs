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
    public partial class VehicleCard : UserControl
    {
        private string _license_plate;
        private string _car_name;
        private string _car_type;
        private Image _vstatus;
        private string _btnstatus;
        private Image _status;

        public VehicleCard()
        {
            InitializeComponent();
        }

        private void VehicleCard_Load(object sender, EventArgs e)
        {
        

        }

        public string licensep
        {
            get { return _license_plate; }
            set { _license_plate = value; lplbl.Text = value; }
        }
        public string car_name
        {
            get { return _car_name; }
            set { _car_name = value; cnamelbl.Text = value; }
        }
        public string car_type
        {
            get { return _car_type; }
            set { _car_type = value; ctypelbl.Text = value; }
        }
        public Image vstatus
        {
            get { return _vstatus; }
            set { _vstatus = value; vstatusimg.Image = value; }
        }
        public Image status
        {
            get { return _status; }
            set { _status = value; statusimg.Image = value; }
        }
        public string btnstatus
        {
            get { return _btnstatus; }
            set { _btnstatus = value; disablebtn.Text = value; }
        }

    }
}
