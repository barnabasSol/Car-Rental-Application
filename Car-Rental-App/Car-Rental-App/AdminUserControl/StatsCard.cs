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
    public partial class StatsCard : UserControl
    {
        public StatsCard()
        {
            InitializeComponent();
        }

        private string _braddress;
        private string _vehicle_count;
        private string _avvcount;
        private string _rating;

        public string braddress
        {
           get { return _braddress; }
           set { _braddress = value; braddlbl.Text = value; }
        }
        public string vcount
        {
            get { return _vehicle_count; }
            set { _vehicle_count = value; totalvlbl.Text = value; }
        }
        public string available_vehicle_count
        {
            get { return _avvcount; }
            set { _avvcount = value; avvcountlbl.Text = value; }
        }
        public string br_rating
        {
            get { return _rating; }
            set { _rating = value; ratinglbl.Text = value; }
        }

    }
}
