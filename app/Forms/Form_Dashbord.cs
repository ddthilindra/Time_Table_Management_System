using app.Forms.Control;
using app.Forms.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Form_Dashbord : Form
    {
        public Form_Dashbord()
        {
            //make a header dragable

            
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
                
        private void addControl(UserControl uc)
        {
            home_User1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            home_User1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void moveImageBox (object sender)
        {
            
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {           
            btnLecture.OnDisabledState.FillColor = Color.Gray;
            btnLecture.OnIdleState.FillColor = Color.Gray;
            btnLecture.onHoverState.FillColor = Color.Gray;

            //indicator.Visible = true;

            //indicator.Location = new Point(btnLecture.Location.X + 200, btnLecture.Location.Y - 33);
            btnLecture.SendToBack();            

            //btnLecture.IdleFillColor.
            //indicator.Top = btnLecture.Top;

            H_lecture lec = new H_lecture();
            addControl(lec);
        }        

        private void indicator_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            
            H_student std = new H_student();
            addControl(std);

            //indicator.Visible = true;

            //indicator.Location = new Point(btnStudent.Location.X + 200, btnStudent.Location.Y - 33);
            btnStudent.SendToBack();

            //indicator.Top = btnStudent.Top;
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            AddLocation loc = new AddLocation();
            addControl(loc);

            //indicator.Visible = true;

            //indicator.Location = new Point(btnLocation.Location.X + 200, btnLocation.Location.Y - 33);
            btnLocation.SendToBack();

            //indicator.Top = btnLocation.Top;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            H_GenerateTimeT genT = new H_GenerateTimeT();
            addControl(genT);
            //indicator.Visible = true;

            //indicator.Location = new Point(btnOther.Location.X + 200, btnOther.Location.Y - 33);
            btnOther.SendToBack();

            //indicator.Top = btnOther.Top;
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            H_timeTable tmtb = new H_timeTable();
            addControl(tmtb);

            //indicator.Visible = true;

            //indicator.Location = new Point(btnTimeTable.Location.X + 200, btnTimeTable.Location.Y - 33);
            btnTimeTable.SendToBack();

            //indicator.Top = btnTimeTable.Top;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnLecture_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        private void Form_Dashbord_Load(object sender, EventArgs e)
        {
            bunifuFormDock1.SubscribeControlToDragEvents(pnlHeader);

            SqlConnection con = new SqlConnection(myconstr);
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            H_Session genT = new H_Session();
            addControl(genT);
            
            btnSession.SendToBack();
        }
    }
}
