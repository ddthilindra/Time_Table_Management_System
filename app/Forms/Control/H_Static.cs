using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace app.Forms.Control
{
    public partial class H_Static : UserControl
    {
        public H_Static()
        {
            InitializeComponent();
        }

        private void H_Static_Load(object sender, EventArgs e)
        {
            loadlec();
            loadSub();
            loadBld();
            loadRoom();
            loadGrp();
            loadLab();
        }

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);
        private void loadlec()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "select Count(Id) from Lecturer";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblLec.Text = rows_count.ToString();

        }

        private void loadSub()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Subject";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblSub.Text = rows_count.ToString();

        }

        private void loadBld()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Location";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblBld.Text = rows_count.ToString();

        }

        private void loadRoom()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Location";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblRoom.Text = rows_count.ToString();

        }

        private void loadGrp()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from StudentGroups";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblGrp.Text = rows_count.ToString();

        }

        private void loadLab()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Session WHERE tag='Lab'";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblLab.Text = rows_count.ToString();

        }
    }
}
