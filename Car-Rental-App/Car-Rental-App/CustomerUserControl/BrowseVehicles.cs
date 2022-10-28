using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Car_Rental_App.CustomerUserControl
{

    public partial class BrowseVehicles : UserControl
    {
        public Dictionary<int, Vehicle> vehicles;

        public BrowseVehicles()
        {
            InitializeComponent();
            vehicles = new Dictionary<int, Vehicle>();
        }
        public void reset()
        {
            vehicles.Clear();
            datePicker.MinDate = System.DateTime.Now;
            datePicker.MaxDate = System.DateTime.Now.AddMonths(1);
            datePicker.ResetText();
            searchField.text = "";
            pnlSelected.Controls.Clear();
            pnlSearch.Controls.Clear();
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
                        v.Branch = reader[8].ToString();
                        v.Selected = false;
                        vehicles.Add(++counter, v);
                        Console.WriteLine(v.Branch);
                    }
                }
            }
            //reset searcher
            filterSearch("");
            //fill up branches in combobox
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select branch_address from branch", con);
                var reader = cmd.ExecuteReader();
                cbBranch.Items.Clear();
                while (reader.Read())
                {
                    cbBranch.Items.Add(reader[0].ToString());
                }
            }
            //fill up payment types in combobox
            using (SqlConnection con = new SqlConnection(Program.my_connection_string))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select payment_type from payment", con);
                var reader = cmd.ExecuteReader();
                cbpayment.Items.Clear();
                while (reader.Read())
                {
                    cbpayment.Items.Add(reader[0].ToString());
                }
            }
        }
        private void BrowseVehicles_Load(object sender, EventArgs e)
        {
            reset();
            Console.WriteLine(cbBranch.Items[0]);
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
            if (cbBranch.SelectedItem != null)
            {
                filtered = filtered
                .Where( x =>
                    x.Value.Branch == cbBranch.SelectedItem.ToString()
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
            else
            {
                pnlSearch.Controls.Clear();
                Label l = new Label();
                l.Text = "Choose a branch... ";
                pnlSearch.Controls.Add(l);
            }
        }


        public void selectCar(int index)
        {
            vehicles[index].Selected = true;
            updateSelected();
            filterSearch(searchField.text);
            Console.WriteLine($"Selected {index}");
        }
        public void unselectCar(int index)
        {
            vehicles[index].Selected = false;
            updateSelected();
            filterSearch(searchField.text);
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

        private void searchField_OnTextChange(object sender, EventArgs e)
        {
            var search_term = searchField.text;
            filterSearch(search_term);
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (cbpayment.SelectedItem == null)
            {
                MessageBox.Show("please select a payment type first");
            }
            else
            {
                int total_vehicles = vehicles.Where(x => x.Value.Selected == true).ToList().Count();
                double selected = vehicles.Where(x => x.Value.Selected == true).Aggregate(0.0, (acc, x) => acc + double.Parse(x.Value.Price));
                double payment = ( datePicker.Value - DateTime.Now).TotalHours * selected;
                using (SqlConnection con = new SqlConnection(Program.my_connection_string))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction(IsolationLevel.Serializable);

                    try
                    {
                        // RENTID generation
                        SqlCommand get_rentid = new SqlCommand("select [dbo].[generate rentid] ()",con,trans);
                        String rentid = get_rentid.ExecuteScalar().ToString();
                    
                        // Insertion ;-)
                        SqlCommand cmd_rental = new SqlCommand("insert into rental " +
                            "(rent_id, c_login_id, rental_date, total_vehicles, return_date,  paid_amount, payment_id, branch_loc)" +
                            "values (" +
                            "@rentid," +
                            "@cusid, " +
                            "@rentaldate, " +
                            "@totalvehicles, " +
                            "@returndate, " +
                            "@paidamount," +
                            "@payment," +
                            "@branch) ",con, trans);
                        cmd_rental.Parameters.Add(new SqlParameter("@rentid", SqlDbType.VarChar, 200)).Value = rentid;
                        cmd_rental.Parameters.Add(new SqlParameter("@cusid", SqlDbType.VarChar, 200)).Value = Profile.current_userid;
                        cmd_rental.Parameters.Add(new SqlParameter("@rentaldate", SqlDbType.DateTime)).Value = DateTime.Now;
                        cmd_rental.Parameters.Add(new SqlParameter("@totalvehicles", SqlDbType.Int)).Value = total_vehicles;
                        cmd_rental.Parameters.Add(new SqlParameter("@returndate", SqlDbType.DateTime)).Value = datePicker.Value;
                        cmd_rental.Parameters.Add(new SqlParameter("@paidamount", SqlDbType.Money)).Value = payment;
                        cmd_rental.Parameters.Add(new SqlParameter("@payment", SqlDbType.Int )).Value = cbpayment.SelectedIndex + 1;
                        cmd_rental.Parameters.Add(new SqlParameter("@branch", SqlDbType.NVarChar, 100 )).Value = cbBranch.SelectedItem.ToString();
                        cmd_rental.Prepare();
                        cmd_rental.ExecuteNonQuery();

                        // Buy all the cars
                        foreach (var ve in vehicles.Where(x => x.Value.Selected).Select(x => x.Value.Licence).ToList())
                        {
                            SqlCommand cmd_rent = new SqlCommand("insert into rented_cars(r_id, license_plate_no) values (@rentid, @license)", con, trans);
                            cmd_rent.Parameters.Add(new SqlParameter("@rentid ", SqlDbType.VarChar, 5)).Value = rentid;
                            cmd_rent.Parameters.Add(new SqlParameter("@license", SqlDbType.VarChar, 200)).Value = ve ;
                            cmd_rent.Prepare();
                            cmd_rent.ExecuteNonQuery();
                        }

                        //toggle status
                        foreach (var ve in vehicles.Where(x => x.Value.Selected).Select(x => x.Value.Licence).ToList())
                        {
                            SqlCommand cmd_rent = new SqlCommand("update cars set car_status = 0 where license_plate_no = @license", con, trans);
                            cmd_rent.Parameters.Add(new SqlParameter("@license", SqlDbType.VarChar, 200)).Value = ve;
                            cmd_rent.Prepare();
                            cmd_rent.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch(SqlException ex)
                    {
                        trans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Payment Succesfull");
                        reset();
                    }
                    // TODO:
                    // [x] Generate rent id
                    // [ ] Get payment id
                    // [x] Generate rent id
                    // [x] Create combo box for branch and payment id
                    // [x]=> {insert into rental the batch}
                    // [x]=> loop{ insert into rented cars} -> dont need to inert return status
                }
            }
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var v in vehicles.Values)
            {
                v.Selected = false;
            }
            pnlSelected.Controls.Clear();
            filterSearch(searchField.text);
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
        string branch;
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
        public string Branch { get => branch; set => branch = value; }
    }
}
