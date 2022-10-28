using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Car_Rental_App
{
    public partial class Add_Car_User_Control : UserControl
    {
        Renter renter= new Renter();
        public Add_Car_User_Control()
        {
            InitializeComponent();
        }

       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   10  🡆  Excellent Condition \n 9-8  🡆  Good Condition \n 7-6  🡆  Average Condition \n 5-4  🡆  Restorable\n 3-1  🡆  Only the parts", bunifuCustomLabel9);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Boolean t = true;

            Regex r = new Regex(@"^[0-9]{1,100}$");
            if (String.IsNullOrEmpty(LicensePlateno_textbox.Text))
            {

                t = false;
                errorProvider1.SetError(LicensePlateno_textbox, "License Plate is required");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (String.IsNullOrEmpty(CarName_txtbox.Text))
            {

                t = false;
                errorProvider2.SetError(CarName_txtbox, "Car Name is required");
            }
            else
            {
                errorProvider2.Clear();
            }




            if (String.IsNullOrEmpty(CarType_txtbox.Text))
            {

                t = false;
                errorProvider3.SetError(CarType_txtbox, "Car Type is required");
            }
            else
            {
                errorProvider3.Clear();
            }









            if (String.IsNullOrEmpty(CarCapacity_txtbox.Text))
            {

                t = false;
                errorProvider4.SetError(CarCapacity_txtbox, "Car Capacity is required");
            }
            else
            {
                errorProvider4.Clear();
            }



            if (String.IsNullOrEmpty(CarModel_txtbox.Text))
            {

                t = false;
                errorProvider5.SetError(CarModel_txtbox, "Car Model is required");
            }
            else
            {
                errorProvider5.Clear();
            }

            if (String.IsNullOrEmpty(CarColor_txtbox.Text))
            {

                t = false;
                errorProvider6.SetError(CarColor_txtbox, "Car Color is required");
            }
            else
            {
                errorProvider6.Clear();
            }


            if (String.IsNullOrEmpty(CarBranch_txtbox.Text))
            {

                t = false;
                errorProvider7.SetError(CarBranch_txtbox, "Car Branch is required");
            }
            else
            {
                errorProvider7.Clear();
            }




            if (String.IsNullOrEmpty(Price_txtbox.Text))
            {

                t = false;
                errorProvider8.SetError(Price_txtbox, "Car Price is required");
            }
            else
            {
                errorProvider8.Clear();
            }



            if (!(r.IsMatch(CarCapacity_txtbox.Text)))
            {


                errorProvider9.SetError(CarCapacity_txtbox, " Please enter number only");
                t = false;

            }
            else
            {
                errorProvider9.Clear();

            }

            if (!(r.IsMatch(Price_txtbox.Text)))
            {


                errorProvider10.SetError(Price_txtbox, " Please enter number only");
                t = false;

            }
            else
            {
                errorProvider10.Clear();

            }


            if (t)
            {
                


                renter.addcar(LicensePlateno_textbox.Text, CarName_txtbox.Text, CarType_txtbox.Text, Int16.Parse(CarCapacity_txtbox.Text), CarModel_txtbox.Text, CarColor_txtbox.Text, Int16.Parse(numericUpDown1.Value.ToString()),CarBranch_txtbox.Text.ToString(),double.Parse(Price_txtbox.Text),Profile.current_userid);
                MessageBox.Show("You successfully added a new car");



            }





        }

       
    }
}
