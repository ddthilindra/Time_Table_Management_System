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
using app.Forms.Session;

namespace app.Forms.Control
{
    public partial class H_Session : UserControl
    {
        public H_Session()
        {
            InitializeComponent();
        }

        static H_Session _obj;

        public static H_Session Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new H_Session();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }


        private void bunifuShadowPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bunifuShadowPanel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void tab2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gunaShadowPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(ManageSessionRoom.Instance))
            {
                ManageSessionRoom.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(ManageSessionRoom.Instance);
                ManageSessionRoom.Instance.Dock = DockStyle.Fill;
                ManageSessionRoom.Instance.BringToFront();
            }
            else
            {
                ManageSessionRoom.Instance.BringToFront();
            }
        }

        private void gunaShadowPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(SessionandNATAllocations.Instance))
            {
                SessionandNATAllocations.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(SessionandNATAllocations.Instance);
                SessionandNATAllocations.Instance.Dock = DockStyle.Fill;
                SessionandNATAllocations.Instance.BringToFront();
            }
            else
            {
                SessionandNATAllocations.Instance.BringToFront();
            }
        }

        private void gunaShadowPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Session.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Session.Instance);
                Show_Session.Instance.Dock = DockStyle.Fill;
                Show_Session.Instance.BringToFront();
            }
            else
            {
                Show_Session.Instance.BringToFront();
            }
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(SessionandNATAllocations.Instance))
            {
                SessionandNATAllocations.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(SessionandNATAllocations.Instance);
                SessionandNATAllocations.Instance.Dock = DockStyle.Fill;
                SessionandNATAllocations.Instance.BringToFront();
            }
            else
            {
                SessionandNATAllocations.Instance.BringToFront();
            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(SessionandNATAllocations.Instance))
            {
                SessionandNATAllocations.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(SessionandNATAllocations.Instance);
                SessionandNATAllocations.Instance.Dock = DockStyle.Fill;
                SessionandNATAllocations.Instance.BringToFront();
            }
            else
            {
                SessionandNATAllocations.Instance.BringToFront();
            }
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Session.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Session.Instance);
                Show_Session.Instance.Dock = DockStyle.Fill;
                Show_Session.Instance.BringToFront();
            }
            else
            {
                Show_Session.Instance.BringToFront();
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Session.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Session.Instance);
                Show_Session.Instance.Dock = DockStyle.Fill;
                Show_Session.Instance.BringToFront();
            }
            else
            {
                Show_Session.Instance.BringToFront();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(Show_Session.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Show_Session.Instance);
                Show_Session.Instance.Dock = DockStyle.Fill;
                Show_Session.Instance.BringToFront();
            }
            else
            {
                Show_Session.Instance.BringToFront();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(SessionandNATAllocations.Instance))
            {
                SessionandNATAllocations.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(SessionandNATAllocations.Instance);
                SessionandNATAllocations.Instance.Dock = DockStyle.Fill;
                SessionandNATAllocations.Instance.BringToFront();
            }
            else
            {
                SessionandNATAllocations.Instance.BringToFront();
            }
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(ManageSessionRoom.Instance))
            {
                ManageSessionRoom.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(ManageSessionRoom.Instance);
                ManageSessionRoom.Instance.Dock = DockStyle.Fill;
                ManageSessionRoom.Instance.BringToFront();
            }
            else
            {
                ManageSessionRoom.Instance.BringToFront();
            }
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(ManageSessionRoom.Instance))
            {
                ManageSessionRoom.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(ManageSessionRoom.Instance);
                ManageSessionRoom.Instance.Dock = DockStyle.Fill;
                ManageSessionRoom.Instance.BringToFront();
            }
            else
            {
                ManageSessionRoom.Instance.BringToFront();
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PnlContainer.Controls.Contains(ManageSessionRoom.Instance))
            {
                ManageSessionRoom.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(ManageSessionRoom.Instance);
                ManageSessionRoom.Instance.Dock = DockStyle.Fill;
                ManageSessionRoom.Instance.BringToFront();
            }
            else
            {
                ManageSessionRoom.Instance.BringToFront();
            }
        }
    }
}
