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
    public partial class AddVehicleUCcs : UserControl
    {
        public AddVehicleUCcs()
        {
            InitializeComponent();
        }

        private void AddVehicleUCcs_Load(object sender, EventArgs e)
        {

        }

        private void lptxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lptxt.Text) || lptxt.Text == "enter license plate")
            {
                lptxt.Text = "";
                lptxt.ForeColor = Color.Black;
            }
        }

        private void lptxt_Leave(object sender, EventArgs e)
        {
            if (lptxt.Text == "")
            {
                lptxt.Text = "enter license plate";
                lptxt.ForeColor = Color.Gray;
            }
        }

        private void cnametxt_Enter(object sender, EventArgs e)
        {
            if (cnametxt.Text == "enter car name")
            {
                cnametxt.Text = "";
                cnametxt.ForeColor = Color.Black;
            }
        }

        private void cnametxt_Leave(object sender, EventArgs e)
        {
            if (cnametxt.Text == "")
            {
                cnametxt.Text = "enter car name";
                cnametxt.ForeColor = Color.Gray;
            }
        }

        private void ctypetxt_Enter(object sender, EventArgs e)
        {
            if (ctypetxt.Text == "enter car type")
            {
                ctypetxt.Text = "";
                ctypetxt.ForeColor = Color.Black;
            }
        }

        private void ctypetxt_Leave(object sender, EventArgs e)
        {
            if (ctypetxt.Text == "")
            {
                ctypetxt.Text = "enter car type";
                ctypetxt.ForeColor = Color.Gray;
            }
        }

        private void cmodeltxt_Enter(object sender, EventArgs e)
        {
            if (cmodeltxt.Text == "enter car model")
            {
                cmodeltxt.Text = "";
                cmodeltxt.ForeColor = Color.Black;
            }
        }

        private void cmodeltxt_Leave(object sender, EventArgs e)
        {
            if (cmodeltxt.Text == "")
            {
                cmodeltxt.Text = "enter car model";
                cmodeltxt.ForeColor = Color.Gray;
            }
        }

        private void ccolortxt_Enter(object sender, EventArgs e)
        {

        }

        private void ccolortxt_Leave(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            lptxt.LineIdleColor = Color.DimGray;
            errorProvider1.SetError(lptxt, null);
            if (string.IsNullOrEmpty(lptxt.Text) || lptxt.Text=="enter license plate")
            {
                lptxt.LineIdleColor = Color.Red;
                errorProvider1.SetError(lptxt, "invalid input here");
            }
        }
    }
}
