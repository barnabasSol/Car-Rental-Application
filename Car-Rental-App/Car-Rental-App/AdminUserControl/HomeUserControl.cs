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

namespace Car_Rental_App.AdminUserControl
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            AdminClass a = new AdminClass();
            a.read_audit(null);
            auditdatagridview.DataSource = null;
            auditdatagridview.DataSource = a.get_audit();
            auditdatagridview.Columns[0].HeaderText = "Done Task";
            auditdatagridview.Columns[1].HeaderText = "Done Date";
        }

        private void filterlatestlbl_Click(object sender, EventArgs e)
        {
            AdminClass c = new AdminClass();
            string query = "select task, done_date from audit where admin_id=" + "\'" + Profile.current_userid + "\'"+" order by done_date desc";
            c.read_audit(query);
            auditdatagridview.DataSource = null;
            auditdatagridview.DataSource = c.get_audit();
            auditdatagridview.Columns[0].HeaderText = "Done Task";
            auditdatagridview.Columns[1].HeaderText = "Done Date";
        }

        private void filteroldestlbl_Click(object sender, EventArgs e)
        {
            AdminClass b = new AdminClass();
            string query = "select task, done_date from audit where admin_id=" + "\'" + Profile.current_userid + "\'" + " order by done_date asc";
            b.read_audit(query);
            auditdatagridview.DataSource = null;
            auditdatagridview.DataSource = b.get_audit();
            auditdatagridview.Columns[0].HeaderText = "Done Task";
            auditdatagridview.Columns[1].HeaderText = "Done Date";
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            AdminClass a = new AdminClass();
            a.search_item(searchtxt.Text);
            auditdatagridview.DataSource = null;
            auditdatagridview.DataSource = a.get_srch_result();
            auditdatagridview.Columns[0].HeaderText = "Done Task";
            auditdatagridview.Columns[1].HeaderText = "Done Date";
        }

        private void auditdatagridview_SelectionChanged(object sender, EventArgs e)
        {
            this.auditdatagridview.ClearSelection();
        }
    }
}
