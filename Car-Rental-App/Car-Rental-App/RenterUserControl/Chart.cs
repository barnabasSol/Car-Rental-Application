using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_App.RenterUserControl
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            fillchart();
        }
        private void fillchart()
        {
           
            SqlConnection conn = new SqlConnection(Program.my_connection_string);
            DataSet ds = new DataSet();
            conn.Open();
            string command = "select year(rental_date) as year,paid_amount from  Earnings("+"\'"+Profile.current_userid+"\')";
            SqlDataAdapter sd = new SqlDataAdapter(command, conn);

            sd.Fill(ds, "Earnings");
            chart1.DataSource = ds;
            chart1.Series["Earnings"].XValueMember = "year";
            chart1.Series["Earnings"].YValueMembers = "paid_amount";

            conn.Close();


        }

        

    }
}
