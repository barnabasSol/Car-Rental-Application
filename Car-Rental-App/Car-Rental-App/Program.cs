using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App
{
    static class Program
    {
        /// The main entry point for the application.

       public static string my_connection_string = "Data Source=DESKTOP-CRCECQ7;" +
                                                    "Initial Catalog=car_rental_database;" +
                                                    "Integrated Security=true;";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
