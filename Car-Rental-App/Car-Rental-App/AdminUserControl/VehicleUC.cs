﻿using System;
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
    public partial class VehicleUC : UserControl
    {
        AdminForm1 vehicleform;
        public VehicleUC(AdminForm1 parentform)
        {
            vehicleform = parentform;
            InitializeComponent();
        }

        public void add_user_control(UserControl uc)
        {
            vpanel.Controls.Clear();
            vpanel.Controls.Add(uc);
        }

        private void addvehiclebtn_Click(object sender, EventArgs e)
        {
            AddVehicleUCcs av = new AddVehicleUCcs();
            add_user_control(av);
        }
    }
}