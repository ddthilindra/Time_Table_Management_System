using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Forms.WorkingD;
using System.Configuration;
using System.Data.SqlClient;

namespace app.Forms.Control
{
    public partial class H_timeTable : UserControl
    {
        public H_timeTable()
        {
            InitializeComponent();
        }
        public Panel PnlContainer
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        
        private void gunaShadowPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormManageWorkingDays.Instance))
            {
                FormManageWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormManageWorkingDays.Instance);
                FormManageWorkingDays.Instance.Dock = DockStyle.Fill;
                FormManageWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormManageWorkingDays.Instance.BringToFront();
            }
        }
        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);
        private void loadWdays()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Work";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblWd.Text = rows_count.ToString();

        }

        private void gunaShadowPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormAddWorkingDays.Instance))
            {
                FormAddWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormAddWorkingDays.Instance);
                FormAddWorkingDays.Instance.Dock = DockStyle.Fill;
                FormAddWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormAddWorkingDays.Instance.BringToFront();
            }
        }

        private void H_timeTable_Load(object sender, EventArgs e)
        {
            loadWdays();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormManageWorkingDays.Instance))
            {
                FormManageWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormManageWorkingDays.Instance);
                FormManageWorkingDays.Instance.Dock = DockStyle.Fill;
                FormManageWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormManageWorkingDays.Instance.BringToFront();
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormManageWorkingDays.Instance))
            {
                FormManageWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormManageWorkingDays.Instance);
                FormManageWorkingDays.Instance.Dock = DockStyle.Fill;
                FormManageWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormManageWorkingDays.Instance.BringToFront();
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormManageWorkingDays.Instance))
            {
                FormManageWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormManageWorkingDays.Instance);
                FormManageWorkingDays.Instance.Dock = DockStyle.Fill;
                FormManageWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormManageWorkingDays.Instance.BringToFront();
            }
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormAddWorkingDays.Instance))
            {
                FormAddWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormAddWorkingDays.Instance);
                FormAddWorkingDays.Instance.Dock = DockStyle.Fill;
                FormAddWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormAddWorkingDays.Instance.BringToFront();
            }
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormAddWorkingDays.Instance))
            {
                FormAddWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormAddWorkingDays.Instance);
                FormAddWorkingDays.Instance.Dock = DockStyle.Fill;
                FormAddWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormAddWorkingDays.Instance.BringToFront();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(FormAddWorkingDays.Instance))
            {
                FormAddWorkingDays.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(FormAddWorkingDays.Instance);
                FormAddWorkingDays.Instance.Dock = DockStyle.Fill;
                FormAddWorkingDays.Instance.BringToFront();
            }
            else
            {
                FormAddWorkingDays.Instance.BringToFront();
            }
        }
    }
}
