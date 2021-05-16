using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms.Lecturer
{
    public partial class Show_Lecturer : UserControl
    {
        ClassLecturer c = new ClassLecturer();
        Add_Lecturer form;

        static Show_Lecturer _obj;

        public static Show_Lecturer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Lecturer();
                }
                return _obj;
            }
        }

        public Show_Lecturer()
        {
            InitializeComponent();
            form = new Add_Lecturer();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Lecturer_Load(object sender, EventArgs e)
        {
            DataTable dt = c.selectLecturer();
            lecTbl.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.DefaultCellStyle.BackColor = SystemColors.HotTrack;
            btn.UseColumnTextForButtonValue = true;
            lecTbl.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "";
            btn2.Text = "Delete";
            btn2.DefaultCellStyle.BackColor = SystemColors.WindowFrame;
            btn2.UseColumnTextForButtonValue = true;
            lecTbl.Columns.Add(btn2);
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
                //Add_Lecturer.Instance.Dock = DockStyle.None;
            //Add_Lecturer.Controls.Add(Add_Lecturer.Instance);
                //Add_Lecturer.Instance.Dock = DockStyle.Fill;
                //Add_Lecturer.Instance.BringToFront();
        }

        private void btnAddLecture_Click_1(object sender, EventArgs e)
        {
            //Open add lecturer form to ad new lecturer

            //Add_Lecturer form = new Add_Lecturer();

            form.clear();
            form.addLecInfo();
            form.ShowDialog();
        }

        private void lecTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                //Edit Record
                form.clear();
                form.lecid = lecTbl.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.lecName= lecTbl.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.updateLecInfo();
                form.ShowDialog();

                return;
            }
            if(e.ColumnIndex==1)
            {
                //Delete Record

                if(MessageBox.Show("Are you want to delete Lecturer record", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    c.deleteLecturer(lecTbl.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DataTable dt = c.selectLecturer();
                    lecTbl.DataSource = dt;
                }
                return;
            }
        }
    }
}
