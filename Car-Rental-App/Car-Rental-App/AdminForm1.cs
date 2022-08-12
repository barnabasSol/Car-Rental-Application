using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class AdminForm1 : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public AdminForm1()
        {
            InitializeComponent();
        }

        private void AdminForm1_Load(object sender, EventArgs e)
        {
            Profile p = new Profile();
            id_lablel.Text = p.login_id;
            fullnamelbl.Text = p.get_full_name(Profile.current_userid);
            id_lablel.Text = Profile.current_userid;

            //-------------------------------------------------
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Program.my_connection_string;
            string command_string = "select task, done_date from audit where admin_id=" + "\'" +
                                                Profile.current_userid + "\'";
            sda = new SqlDataAdapter(command_string, con);
            dt = new DataTable();
            sda.Fill(dt);
            auditdataview.DataSource = dt;
            con.Close();

        }

        private void dateascbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Program.my_connection_string;
            string command_string = "select task, done_date from audit where admin_id=" + "\'" +
                                                Profile.current_userid + "\'"+" order by done_date asc";
            sda = new SqlDataAdapter(command_string, con);
            dt = new DataTable();
            sda.Fill(dt);
            auditdataview.DataSource = dt;
            con.Close();
        }

        private void datedescbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Program.my_connection_string;
            string command_string = "select task, done_date from audit where admin_id=" + "\'" +
                                                Profile.current_userid + "\'"+"order by done_date desc";
            sda = new SqlDataAdapter(command_string, con);
            dt = new DataTable();
            sda.Fill(dt);
            auditdataview.DataSource = dt;
            con.Close();
        }
    }
}
