using Car_Rental_App.AdminUserControl;
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

namespace Car_Rental_App
{
    public partial class BranchStats : Form
    {
        private List<StatsCard> stats_card_list = new List<StatsCard>();
        public BranchStats()
        {
            InitializeComponent();
        }

        private void load_stats_card()
        {
            string query = "[get branch stats]";
            using (SqlConnection connection = new SqlConnection(Program.my_connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StatsCard sc = new StatsCard();
                            sc.braddress = reader[0].ToString();
                            sc.vcount = reader[1].ToString();
                            sc.br_rating = reader[2].ToString();
                            sc.available_vehicle_count = reader[3].ToString();
                            bstatspanel.Controls.Add(sc);
                            stats_card_list.Add(sc);
                        }
                    }
                }
            }
        }


        private void BranchStats_Load(object sender, EventArgs e)
        {
            load_stats_card();
        }


        private void branchsrchtxt_OnValueChanged_1(object sender, EventArgs e)
        {
            foreach (var card in stats_card_list)
            {
                if (card.braddress.Contains(branchsrchtxt.Text))
                {
                    bstatspanel.Controls.Clear();
                    bstatspanel.Controls.Add(card);
                }
                if (branchsrchtxt.Text == "")
                {
                    load_stats_card();
                    break;
                }
            }
        }
    }
}
