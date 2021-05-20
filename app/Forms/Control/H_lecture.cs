using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Forms.Lecturer;
using System.Configuration;
using System.Data.SqlClient;

namespace app.Forms.Control
{
    public partial class H_lecture : UserControl
    {
        static H_lecture _obj;

        public static H_lecture Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new H_lecture();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public H_lecture()
        {
            InitializeComponent();
        }

        private void H_lecture_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            loadlec();
            loadSub();
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            
            //Add_Lecturer.Instance.Dock = DockStyle.None;
            PnlContainer.Controls.Clear();
            H_lecture.Instance.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(H_lecture.Instance);
            H_lecture.Instance.BringToFront();
            btnBack.Visible = false;
            //This will display the UCHome back*/

            /*panelContainer.Controls["Add_Lecturer"].BringToFront();
            btnBack.Visible = false;
            //This will display the UCHome back*/
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void gunaShadowPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //btnBack.Visible = true;


            if (!PnlContainer.Controls.Contains(Show_Lecturer.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Lecturer.Instance);
                Show_Lecturer.Instance.Dock = DockStyle.Fill;
                Show_Lecturer.Instance.BringToFront();
            }
            else
            {
                Show_Lecturer.Instance.BringToFront();
            }
        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {            
            
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

        private void gunaShadowPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Subject.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Subject.Instance);
                Show_Subject.Instance.Dock = DockStyle.Fill;
                Show_Subject.Instance.BringToFront();
            }
            else
            {
                Show_Subject.Instance.BringToFront();
            }
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

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Lecturer.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Lecturer.Instance);
                Show_Lecturer.Instance.Dock = DockStyle.Fill;
                Show_Lecturer.Instance.BringToFront();
            }
            else
            {
                Show_Lecturer.Instance.BringToFront();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Lecturer.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Lecturer.Instance);
                Show_Lecturer.Instance.Dock = DockStyle.Fill;
                Show_Lecturer.Instance.BringToFront();
            }
            else
            {
                Show_Lecturer.Instance.BringToFront();
            }
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Subject.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Subject.Instance);
                Show_Subject.Instance.Dock = DockStyle.Fill;
                Show_Subject.Instance.BringToFront();
            }
            else
            {
                Show_Subject.Instance.BringToFront();
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Subject.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Subject.Instance);
                Show_Subject.Instance.Dock = DockStyle.Fill;
                Show_Subject.Instance.BringToFront();
            }
            else
            {
                Show_Subject.Instance.BringToFront();
            }
        }
    }
}
