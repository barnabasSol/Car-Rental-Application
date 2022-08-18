using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.reusable_component
{
    public partial class InputField : UserControl
    {
        public InputField()
        {
            InitializeComponent();
        }

        private string _temp_text;

        public string temp_text
        {
            get { return _temp_text; }
            set { _temp_text = value; textbox1.Text = value; }
        }


        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {
                textbox1.Text = _temp_text;
                textbox1.ForeColor = Color.Silver;
            }       
        }
        
        private void textbox1_Enter(object sender, EventArgs e)
        {
            if (textbox1.Text == _temp_text)
            {
                textbox1.Text = "";
                textbox1.ForeColor = Color.Black;
            }
        }
    }
}
