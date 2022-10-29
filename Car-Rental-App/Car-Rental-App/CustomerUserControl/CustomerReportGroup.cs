using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private String  rentid;

        public String  Rentid
        {
            get { return rentid; }
            set { rentid = value; }
        }

  

        private void btnRate_Click_1(object sender, EventArgs e)
        {
            Decimal rating = bunifuRating1.Value;
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("exec [rate rent] @id, @rating", con);
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 200)).Value = Rentid;
                cmd.Parameters.Add(new SqlParameter("@rating", SqlDbType.Decimal, 18)).Value = rating;
                cmd.Parameters["@rating"].Precision = 18;
                cmd.Parameters["@rating"].Offset = 2;

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanks for your feedback");
            }
        }
    }
}
