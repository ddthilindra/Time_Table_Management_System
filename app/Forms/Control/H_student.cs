using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Forms.Student;
using System.Configuration;
using System.Data.SqlClient;

namespace app.Forms.Control
{
    public partial class H_student : UserControl
    {
        public H_student()
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
            if (!PnlContainer.Controls.Contains(Manage_Students.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Students.Instance);
                Manage_Students.Instance.Dock = DockStyle.Fill;
                Manage_Students.Instance.BringToFront();
            }
            else
            {
                Manage_Students.Instance.BringToFront();
            }
        }

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);
        private void loadStuM()
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
            lblStM.Text = rows_count.ToString();

        }

        private void gunaShadowPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Student_Groups.Instance))
            {
                Add_Student_Groups.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Student_Groups.Instance);
                Add_Student_Groups.Instance.Dock = DockStyle.Fill;
                Add_Student_Groups.Instance.BringToFront();
            }
            else
            {
                Add_Student_Groups.Instance.BringToFront();
            }
        }

        private void gunaShadowPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Tags.Instance))
            {
                Manage_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Tags.Instance);
                Manage_Tags.Instance.Dock = DockStyle.Fill;
                Manage_Tags.Instance.BringToFront();
            }
            else
            {
                Manage_Tags.Instance.BringToFront();
            }
        }

        private void loadTagM()
        {
            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select Count(Id) from Tag";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblTm.Text = rows_count.ToString();

        }

        private void gunaShadowPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Tags.Instance))
            {
                Add_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Tags.Instance);
                Add_Tags.Instance.Dock = DockStyle.Fill;
                Add_Tags.Instance.BringToFront();
            }
            else
            {
                Add_Tags.Instance.BringToFront();
            }
        }

        private void H_student_Load(object sender, EventArgs e)
        {
            loadStuM();
            loadTagM();
        }

        private void gunaShadowPanel5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Students.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Students.Instance);
                Manage_Students.Instance.Dock = DockStyle.Fill;
                Manage_Students.Instance.BringToFront();
            }
            else
            {
                Manage_Students.Instance.BringToFront();
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Students.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Students.Instance);
                Manage_Students.Instance.Dock = DockStyle.Fill;
                Manage_Students.Instance.BringToFront();
            }
            else
            {
                Manage_Students.Instance.BringToFront();
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Students.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Students.Instance);
                Manage_Students.Instance.Dock = DockStyle.Fill;
                Manage_Students.Instance.BringToFront();
            }
            else
            {
                Manage_Students.Instance.BringToFront();
            }
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Student_Groups.Instance))
            {
                Add_Student_Groups.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Student_Groups.Instance);
                Add_Student_Groups.Instance.Dock = DockStyle.Fill;
                Add_Student_Groups.Instance.BringToFront();
            }
            else
            {
                Add_Student_Groups.Instance.BringToFront();
            }
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Student_Groups.Instance))
            {
                Add_Student_Groups.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Student_Groups.Instance);
                Add_Student_Groups.Instance.Dock = DockStyle.Fill;
                Add_Student_Groups.Instance.BringToFront();
            }
            else
            {
                Add_Student_Groups.Instance.BringToFront();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Student_Groups.Instance))
            {
                Add_Student_Groups.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Student_Groups.Instance);
                Add_Student_Groups.Instance.Dock = DockStyle.Fill;
                Add_Student_Groups.Instance.BringToFront();
            }
            else
            {
                Add_Student_Groups.Instance.BringToFront();
            }
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Tags.Instance))
            {
                Manage_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Tags.Instance);
                Manage_Tags.Instance.Dock = DockStyle.Fill;
                Manage_Tags.Instance.BringToFront();
            }
            else
            {
                Manage_Tags.Instance.BringToFront();
            }
        }

        private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Tags.Instance))
            {
                Manage_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Tags.Instance);
                Manage_Tags.Instance.Dock = DockStyle.Fill;
                Manage_Tags.Instance.BringToFront();
            }
            else
            {
                Manage_Tags.Instance.BringToFront();
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Manage_Tags.Instance))
            {
                Manage_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Manage_Tags.Instance);
                Manage_Tags.Instance.Dock = DockStyle.Fill;
                Manage_Tags.Instance.BringToFront();
            }
            else
            {
                Manage_Tags.Instance.BringToFront();
            }
        }

        private void label18_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Tags.Instance))
            {
                Add_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Tags.Instance);
                Add_Tags.Instance.Dock = DockStyle.Fill;
                Add_Tags.Instance.BringToFront();
            }
            else
            {
                Add_Tags.Instance.BringToFront();
            }
        }

        private void label17_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Tags.Instance))
            {
                Add_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Tags.Instance);
                Add_Tags.Instance.Dock = DockStyle.Fill;
                Add_Tags.Instance.BringToFront();
            }
            else
            {
                Add_Tags.Instance.BringToFront();
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Add_Tags.Instance))
            {
                Add_Tags.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Tags.Instance);
                Add_Tags.Instance.Dock = DockStyle.Fill;
                Add_Tags.Instance.BringToFront();
            }
            else
            {
                Add_Tags.Instance.BringToFront();
            }
        }
    }
}
