using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{
    public partial class Add_Car_User_Control : UserControl
    {
        public Add_Car_User_Control()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string current_State = label1.Text;
            int num;
            num=Int16.Parse(current_State);
            if (num == 10)
            {
                num = num;
                label1.Text=num.ToString();
            }
            else if(num >=1)
            {
                num = num + 1;
                label1.Text = num.ToString();
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string current_State = label1.Text;
            int num;
            num = Int16.Parse(current_State);
            if (num == 1)
            {
                num = num;
                label1.Text = num.ToString();

            }
            else if (num > 1)
            {
                num = num - 1;
                label1.Text = num.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   10  🡆  Excellent Condition \n 9-8  🡆  Good Condition \n 7-6  🡆  Average Condition \n 5-4  🡆  Restorable\n 3-1  🡆  Only the parts", bunifuCustomLabel9);
        }
    }
}
