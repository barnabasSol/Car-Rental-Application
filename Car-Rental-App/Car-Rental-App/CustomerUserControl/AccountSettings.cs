using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.CustomerUserControl
{
    public partial class AccountSettings : UserControl
    {
        Customer_form s_usercontrol;
        public AccountSettings(Customer_form parent)
        {
            InitializeComponent();
            s_usercontrol = parent;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("[change password]", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@cusid",SqlDbType.VarChar, 200)).Value=Profile.current_userid;
                    cmd.Parameters.Add(new SqlParameter("@oldp", SqlDbType.VarChar, 100)).Value = txtOldP.Text;
                    cmd.Parameters.Add(new SqlParameter("@newp", SqlDbType.VarChar, 100)).Value = txtNewP.Text;
                    cmd.Parameters.Add(new SqlParameter("@conp", SqlDbType.VarChar, 100)).Value = txtConfirmP.Text;
                    cmd.Parameters.Add(new SqlParameter("@out", SqlDbType.VarChar, 100)).Direction = ParameterDirection.Output;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    var result = cmd.Parameters["@out"].Value.ToString();
                    MessageBox.Show(result);
                } 
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            s_usercontrol.Close();
            lg.Show();
        }
    }
}
