using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using UserControl = System.Windows.Forms.UserControl;

namespace Car_Rental_App.CustomerUserControl
{
    public partial class HomeUserControl : UserControl
    {

        public HomeUserControl()
        {
            InitializeComponent();
        
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select " +
                    "* " +
                    "from [get rented cars] ('" + Profile.current_userid + "')", con);
                var reader = cmd.ExecuteReader();

                String current_id = null;
                string current_branch = null;
                DateTime current_timeLeft = DateTime.Now;

                int total_cars = 0;

                while (reader.Read())
                {
                    string carname = reader[0].ToString();
                    string liplate = reader[1].ToString();
                    DateTime returndate = (DateTime)reader[2];
                    String branch = reader[3].ToString();
                    String rentId = reader[4].ToString();
                    var new_cusr = new CustomerReportCard();
                    new_cusr.License = liplate;
                    new_cusr.CName = carname;
                    current_timeLeft = returndate;
                    current_branch = branch;
                    if ( current_id != rentId)
                    {
                        var breaker = new CustomerReportGroup();
                        breaker.Branch = current_branch;
                        breaker.timeLeft = current_timeLeft;
                        breaker.Rentid = rentId;
                        pnlHomeList.Controls.Add(breaker); 
                        current_id = rentId;
                    }

                    pnlHomeList.Controls.Add(new_cusr);
                    total_cars += 1;
    
                }
                reader.Close();
                SqlCommand cmdrep = new SqlCommand("select reputation from customer where login_id = '" + Profile.current_userid + "'", con);
                String rep = cmdrep.ExecuteScalar().ToString();
                lblRep.Text = rep;

                lblPending.Text = total_cars.ToString();
                // Todo
                // [x] add the grouping and listing for these vehicles
                // [x] add rating system
                // [x] show reputation
                // [x] show pending cars

            }
        }
    }

}
