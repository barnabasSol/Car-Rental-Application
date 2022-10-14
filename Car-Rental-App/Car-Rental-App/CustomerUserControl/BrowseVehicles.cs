using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace Car_Rental_App.CustomerUserControl
{

    public partial class BrowseVehicles : UserControl
    {
        public BrowseVehicles()
        {
            InitializeComponent();
        }
        public static Dictionary<int, Vehicle> vehicles = new Dictionary<int, Vehicle>();
        private void BrowseVehicles_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                string query = "select * from [get available vehicles] ('" + Profile.current_userid + "')";
                con.Open();
                using (SqlCommand com = new SqlCommand(query, con))
                {

                    var reader = com.ExecuteReader();
                    var counter = 0;
                    while (reader.Read())
                    {
                        Vehicle v = new Vehicle();
                        v.Licence = reader[0].ToString();
                        v.Name = reader[1].ToString();
                        v.Type = reader[2].ToString();
                        v.Capacity = reader[3].ToString();
                        v.Model = reader[4].ToString();
                        v.Color = reader[5].ToString();
                        v.Condition = reader[6].ToString();
                        v.Price = reader[7].ToString();
                        v.Selected = false;
                        vehicles.Add(++counter, v);
                    }
                }
            }
            filterSearch("");

        }

        private void filterSearch(String search_term)
        {
            var filtered = vehicles
                .Where(x =>
                    (x.Value.Name.Contains(search_term)
                    || x.Value.Model.Contains(search_term)
                    || x.Value.Type.Contains(search_term))
                    && !x.Value.Selected
                );
            pnlSearch.Controls.Clear();
            foreach (var v in filtered)
            {
                VehicleCard vc = new VehicleCard(this);
                vc.name1 = v.Value.Name;
                vc.type = v.Value.Type;
                vc.model = v.Value.Model;
                vc.condition = v.Value.Condition;
                vc.price = v.Value.Price;
                vc.color = v.Value.Color;
                vc.capacity = v.Value.Capacity;
                vc.IsSelected = false;
                vc.Index = v.Key;
                pnlSearch.Controls.Add(vc);
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            var search_term = bunifuMaterialTextbox1.Text;
            filterSearch(search_term);
        }

        public void selectCar(int index)
        {
            vehicles[index].Selected = true;
            updateSelected();
            filterSearch(bunifuMaterialTextbox1.Text);
            Console.WriteLine($"Selected {index}");
        }
        public void unselectCar(int index)
        {
            vehicles[index].Selected = false;
            updateSelected();
            filterSearch(bunifuMaterialTextbox1.Text);
        }
        private void updateSelected ()
        {
            pnlSelected.Controls.Clear();
            var selectedCars = vehicles
                .Where(x => x.Value.Selected)
                ;

            foreach (var v in selectedCars)
            {
                VehicleCard vc = new VehicleCard(this);
                vc.name1 = v.Value.Name;
                vc.type = v.Value.Type;
                vc.model = v.Value.Model;
                vc.condition = v.Value.Condition;
                vc.price = v.Value.Price;
                vc.color = v.Value.Color;
                vc.capacity = v.Value.Capacity;
                vc.IsSelected = true;
                vc.Index = v.Key;
                pnlSelected.Controls.Add(vc);
            }
        }

       
    }
    public class Vehicle
    {
        string name;
        string model;
        string type;
        string condition;
        string price;
        string color;
        string licence;
        string capacity;
        bool selected;
        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Type { get => type; set => type = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Licence { get => licence; set => licence = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public bool Selected { get => selected; set => selected = value; }
    }
}
