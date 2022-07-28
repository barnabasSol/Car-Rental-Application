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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void create_here_lbl_MouseHover(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Underline);
        }

        private void create_here_lbl_MouseLeave(object sender, EventArgs e)
        {
            create_here_lbl.Font = new Font(create_here_lbl.Font, FontStyle.Regular);
        }
    }
}
