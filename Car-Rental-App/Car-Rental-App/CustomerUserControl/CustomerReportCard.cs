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
    public partial class CustomerReportCard : UserControl
    {
        public CustomerReportCard()
        {
            InitializeComponent();
        }
        private String license;

        public String License
        {
            get { return license; }
            set { license = value; lbllicense.Text = value; }
        }

        private String cName;

        public String CName
        {
            get { return cName; }
            set { cName = value;lblname.Text = value; }
        }
        


    }
}
