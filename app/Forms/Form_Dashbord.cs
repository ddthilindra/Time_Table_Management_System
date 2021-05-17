using app.Forms.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
            //bunifuFormDock1.SubscribeControlsToDragEvents(pnlHeader);
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            indicator.Visible = true;

            indicator.Location = new Point(btnLecture.Location.X + 200, btnLecture.Location.Y - 33);
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

            indicator.Visible = true;

            indicator.Location = new Point(btnStudent.Location.X + 200, btnStudent.Location.Y - 33);
            btnStudent.SendToBack();

            //indicator.Top = btnStudent.Top;
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            H_location loc = new H_location();
            addControl(loc);

            indicator.Visible = true;

            indicator.Location = new Point(btnLocation.Location.X + 200, btnLocation.Location.Y - 33);
            btnLocation.SendToBack();

            //indicator.Top = btnLocation.Top;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            indicator.Visible = true;

            indicator.Location = new Point(btnOther.Location.X + 200, btnOther.Location.Y - 33);
            btnOther.SendToBack();

            //indicator.Top = btnOther.Top;
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            H_timeTable tmtb = new H_timeTable();
            addControl(tmtb);

            indicator.Visible = true;

            indicator.Location = new Point(btnTimeTable.Location.X + 200, btnTimeTable.Location.Y - 33);
            btnTimeTable.SendToBack();

            //indicator.Top = btnTimeTable.Top;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /*private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
        }*/

        /*private void bunifuButton5_Click(object sender, EventArgs e)
        {
            
        }*/

        /*private void bunifuButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            
        }*/
    }
}
