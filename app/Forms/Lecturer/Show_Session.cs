using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Lecturer;

namespace app.Forms.Lecturer
{
    public partial class Show_Session : UserControl
    {
        ClassSession s = new ClassSession();
        static Show_Session _obj;

        public static Show_Session Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Session();
                }
                return _obj;
            }
        }

        public Show_Session()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown11_onItemSelected(object sender, EventArgs e)
        {

        }

        private void Show_Session_Load(object sender, EventArgs e)
        {
            DataTable dt = s.selectLecturer();
            tblSession.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.DefaultCellStyle.ForeColor = Color.Red;
            btn.DefaultCellStyle.BackColor = Color.Beige;
            btn.UseColumnTextForButtonValue = true;
            tblSession.Columns.Add(btn);

            //Creaing Delete button in gridview
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "";
            btn2.Text = "Delete";
            btn2.DefaultCellStyle.BackColor = SystemColors.WindowFrame;
            btn2.UseColumnTextForButtonValue = true;
            tblSession.Columns.Add(btn2);
        }
    }
}
