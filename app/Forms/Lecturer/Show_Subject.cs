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
    public partial class Show_Subject : UserControl
    {
        ClassSubject s = new ClassSubject();

        static Show_Subject _obj;

        public static Show_Subject Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Subject();
                }
                return _obj;
            }
        }

        public Show_Subject()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Subject_Load(object sender, EventArgs e)
        {
            DataTable dt = s.selectLecturer();
            tblSub.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.DefaultCellStyle.ForeColor = Color.Red;
            btn.DefaultCellStyle.BackColor = Color.Beige;
            btn.UseColumnTextForButtonValue = true;
            tblSub.Columns.Add(btn);

            //Creaing Delete button in gridview
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "";
            btn2.Text = "Delete";
            btn2.DefaultCellStyle.BackColor = SystemColors.WindowFrame;
            btn2.UseColumnTextForButtonValue = true;
            tblSub.Columns.Add(btn2);
        }
    }
}
