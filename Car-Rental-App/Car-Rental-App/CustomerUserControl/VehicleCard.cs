using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.CustomerUserControl
{
    public partial class VehicleCard : UserControl
    {
        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public BrowseVehicles parent;
        public VehicleCard(BrowseVehicles f)
        {
            InitializeComponent();
            parent = f;
        }
        private bool is_selected;

        public bool IsSelected
        {
            get { return is_selected; }
            set { is_selected = value; button1.ButtonText = value? "-" : "+"; }
        }

        private string _name;

        public string name1
        {
            get { return _name; }
            set { _name = value; lblname.Text = value; }
        }
        private string _model;

        public string model
        {
            get { return _model; }
            set { _model = value; lblmodel.Text = value; }
        }
        private string _type;

        public string type
        {
            get { return _type; }
            set { _type = value; lbltype.Text = value; }
        }
        private string _condition;

        public string condition
        {
            get { return _condition; }
            set { _condition = value; lblcondition.Text = value; }
        }

        private string _price;

        public string price
        {
            get { return _price; }
            set { _price = value; lblprice.Text = value; }
        }

        private string _color;

        public string color
        {
            get { return _color; }
            set { _color = value; pnlColor.BackColor = Color.FromName(value); }
        }
        private string _capacity;

        public string capacity
        {
            get { return _capacity; }
            set { _capacity = value; lblcapacity.Text = value;  }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!is_selected)
            {
                parent.selectCar(Index);
            }
            else
            {
                parent.unselectCar(Index);
            }
        }
    }
}
