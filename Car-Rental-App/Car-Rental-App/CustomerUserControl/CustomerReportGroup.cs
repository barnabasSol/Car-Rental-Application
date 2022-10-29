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
    public partial class CustomerReportGroup : UserControl
    {
        public CustomerReportGroup()
        {
            InitializeComponent();
        }

        private String branch;

        public String Branch
        {
            get { return branch; }
            set { branch = value; lblBranch.Text = value; }
        }

        private DateTime time;

        public DateTime timeLeft
        {
            get { return time; }
            set { time = value; lblTimeLeft.Text = ((int)((value - DateTime.Now).TotalDays)) + " days and " + ((int)((value - DateTime.Now).TotalHours) % 24) + " hours left"; }
        }

    }
}
