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

namespace Car_Rental_App.AdminUserControl
{
    public partial class CustomerCard : UserControl
    {
        public CustomerCard()
        {
            InitializeComponent();
        }

        private Image _gendericon;
        private string _full_name;
        private string _id;
        private string _phone_number;
        private string _address;
        private int _rep_ind;
        private bool _switch_status; 

        public Image gender
        {
            get { return _gendericon; }
            set { _gendericon = value; gendericon.Image = value; }
        }

        public string full_name
        {
            get { return _full_name; }
            set { _full_name = value; nametxt.Text = value; }
        }

        public string id
        {
            get { return _id; }
            set { _id = value; idtxt.Text = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; addresstxt.Text = value; }
        }

        public string phone_number
        {
            get { return _phone_number; }
            set { _phone_number = value; pnumtxt.Text = value; }
        }

        public int rep_indicator
        {
            get { return _rep_ind; }
            set { _rep_ind = value; bunifuSlider1.Value = value; }
        }
        public bool switch_status_m
        {
            get { return _switch_status; }
            set { _switch_status = value; switch_status.Value = value; }
        }

        private void expandbtn_Click(object sender, EventArgs e)
        {
            expandbtn.Visible = false;
            this.Size = new Size(428, 263);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            expandbtn.Visible = true;
            this.Size = new Size(428, 123);
        }
       

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value == 5)
            {
                bunifuSlider1.IndicatorColor = Color.SeaGreen;
            }
            else if (bunifuSlider1.Value < 5 && bunifuSlider1.Value > 2)
            {
                bunifuSlider1.IndicatorColor = Color.Yellow;
            }
            else if (bunifuSlider1.Value > 5)
            {
                bunifuSlider1.IndicatorColor = Color.FromArgb(199, 92, 92);
            }
            else
            {
                bunifuSlider1.IndicatorColor = Color.Red;
            }
            scale.Text = bunifuSlider1.Value.ToString();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuSlider1.Value += 1;
            if (bunifuSlider1.Value == 5)
            {
                bunifuSlider1.IndicatorColor = Color.SeaGreen;
            }
            else if (bunifuSlider1.Value < 5 && bunifuSlider1.Value > 2)
            {
                bunifuSlider1.IndicatorColor = Color.Yellow;
            }
            else if (bunifuSlider1.Value > 5)
            {
                bunifuSlider1.IndicatorColor = Color.FromArgb(199, 92, 92);
            }
            else
            {
                bunifuSlider1.IndicatorColor = Color.Red;
            }
            scale.Text = bunifuSlider1.Value.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuSlider1.Value -= 1;
            if (bunifuSlider1.Value == 5)
            {
                bunifuSlider1.IndicatorColor = Color.SeaGreen;
            }
            else if (bunifuSlider1.Value < 5 && bunifuSlider1.Value > 2)
            {
                bunifuSlider1.IndicatorColor = Color.Yellow;
            }
            else if (bunifuSlider1.Value > 5)
            {
                bunifuSlider1.IndicatorColor = Color.FromArgb(199, 92, 92);
            }
            else
            {
                bunifuSlider1.IndicatorColor = Color.Red;
            }
            scale.Text = bunifuSlider1.Value.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("changes saved","confirmation",MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.my_connection_string;

            string commandText = "exec [update customer change by admin] @loginid, @activity, @rep";
            SqlParameter id_param = new SqlParameter("@loginid", SqlDbType.VarChar, 100);
            SqlParameter rep_par = new SqlParameter("@rep", SqlDbType.Int, 0);
            SqlParameter activ_par = new SqlParameter("@activity", SqlDbType.Int, 0);
            id_param.Value = idtxt.Text;
            rep_par.Value = bunifuSlider1.Value;
            if (switch_status.Value == true)
                activ_par.Value = 1;
            else
            {
                activ_par.Value = 0;
            }
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.Add(id_param);
                    command.Parameters.Add(rep_par);
                    command.Parameters.Add(activ_par);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            expandbtn.Visible = true;
            this.Size = new Size(428, 123);
        }

        private void CustomerCard_Load(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value == 5)
            {
                bunifuSlider1.IndicatorColor = Color.SeaGreen;
            }
            else if (bunifuSlider1.Value < 5 && bunifuSlider1.Value > 2)
            {
                bunifuSlider1.IndicatorColor = Color.Yellow;
            }
            else if (bunifuSlider1.Value > 5)
            {
                bunifuSlider1.IndicatorColor = Color.FromArgb(199, 92, 92);
            }
            else
            {
                bunifuSlider1.IndicatorColor = Color.Red;
            }
            scale.Text = bunifuSlider1.Value.ToString();
        }
    }
}
