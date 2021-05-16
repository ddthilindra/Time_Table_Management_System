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

        private void btnLecture_Click(object sender, EventArgs e)
        {
            //indicator.Visible = true;
            indicator.Top = btnLecture.Top;

            H_lecture lec = new H_lecture();
            addControl(lec);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            H_student std = new H_student();
            addControl(std);

            //indicator.Visible = true;
            indicator.Top = btnStudent.Top;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            H_location loc = new H_location();
            addControl(loc);

            //indicator.Visible = true;
            indicator.Top = btnLocation.Top;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            H_timeTable tmtb = new H_timeTable();
            addControl(tmtb);

            //indicator.Visible = true;
            indicator.Top = btnTimeTable.Top;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
           //indicator.Visible = true;
            indicator.Top = btnOther.Top;
        }
    }
}
