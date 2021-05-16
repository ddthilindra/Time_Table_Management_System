using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;

            /*if (!H_lecture.Instance.PnlContainer.Controls.ContainsKey("Addlec"))
            {
                H_lecture un = new H_lecture();
                un.Dock = DockStyle.Fill;
                H_lecture.Instance.PnlContainer.Controls.Add(un);
            }
            H_lecture.Instance.PnlContainer.Controls["Addlec"].BringToFront();
            H_lecture.Instance.BackButton.Visible = true;*/

            if (!PnlContainer.Controls.Contains(Add_Lecturer.Instance))
            {
                H_lecture.Instance.Dock = DockStyle.None;
                PnlContainer.Controls.Add(Add_Lecturer.Instance);
                Add_Lecturer.Instance.Dock = DockStyle.Fill;
                Add_Lecturer.Instance.BringToFront();
            }
            else
            {
                Add_Lecturer.Instance.BringToFront();
            }
            
        }

        /*btnAddLecture.Visible = false;
            label1.Visible = false;
            btnBack.Visible = true;
            
            Add_Lecturer addlec = new Add_Lecturer();
            addlec.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(addlec);
            //This will display add lecturer when form loads*/

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Add_Lecturer.Instance.Dock = DockStyle.None;
            PnlContainer.Controls.Add(H_lecture.Instance);
            H_lecture.Instance.Dock = DockStyle.Fill;
            H_lecture.Instance.BringToFront();
            btnBack.Visible = false;
            //This will display the UCHome back
        }
    }
}
